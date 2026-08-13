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
                    Period w_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                    CqlDateTime y_ = context.Operators.Start(x_);
                    v_ = u_ & (!((bool?)(y_ is null)));
                }
                return k_ & v_;
            }
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period z_ = @this?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.End(aa_);
            return ab_;
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
                    Period w_ = TheEncounter?.Period;
                    CqlInterval<CqlDateTime> x_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, w_);
                    CqlDateTime y_ = context.Operators.Start(x_);
                    v_ = u_ & (!((bool?)(y_ is null)));
                }
                return k_ & v_;
            }
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);

        object e_(Encounter @this) {
            Period z_ = @this?.Period;
            CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, z_);
            CqlDateTime ab_ = context.Operators.End(aa_);
            return ab_;
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
                                    Period ed_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ed_);
                                    CqlDateTime ef_ = context.Operators.Start(ee_);
                                    ec_ = eb_ & (!((bool?)(ef_ is null)));
                                }
                                return dr_ & ec_;
                            }
                        }

                        IEnumerable<Encounter> cr_ = context.Operators.Where<Encounter>(cp_, cq_);

                        object cs_(Encounter @this) {
                            Period eg_ = @this?.Period;
                            CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eg_);
                            CqlDateTime ei_ = context.Operators.End(eh_);
                            return ei_;
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
                            Code<Encounter.EncounterStatus> ej_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? ek_ = ej_?.Value;
                            Code<Encounter.EncounterStatus> el_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ek_);
                            bool? em_ = context.Operators.Equal(el_, "finished");
                            // CQL 'and' (240:6-241:83): right operand skipped when left is false
                            if (em_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period en_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> eo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, en_);
                                CqlDateTime ep_ = context.Operators.End(eo_);
                                Period eq_ = Visit?.Period;
                                CqlInterval<CqlDateTime> er_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eq_);
                                CqlDateTime es_ = context.Operators.Start(er_);
                                CqlQuantity et_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime eu_ = context.Operators.Subtract(es_, et_);
                                CqlInterval<CqlDateTime> ev_ = context.Operators.Interval(eu_, es_, true, true);
                                bool? ew_ = context.Operators.In<CqlDateTime>(ep_, ev_, (string)default);
                                bool? ex_;
                                // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                if (ew_ is false)
                                {
                                    ex_ = false;
                                }
                                else
                                {
                                    Period ey_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> ez_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ey_);
                                    CqlDateTime fa_ = context.Operators.Start(ez_);
                                    ex_ = ew_ & (!((bool?)(fa_ is null)));
                                }
                                return em_ & ex_;
                            }
                        }

                        IEnumerable<Encounter> de_ = context.Operators.Where<Encounter>(cp_, dd_);

                        object df_(Encounter @this) {
                            Period fb_ = @this?.Period;
                            CqlInterval<CqlDateTime> fc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fb_);
                            CqlDateTime fd_ = context.Operators.End(fc_);
                            return fd_;
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
                            CqlValueSet fe_ = this.Observation_Services(context);
                            IEnumerable<Encounter> ff_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fe_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? fg_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> fr_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? fs_ = fr_?.Value;
                                Code<Encounter.EncounterStatus> ft_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fs_);
                                bool? fu_ = context.Operators.Equal(ft_, "finished");
                                // CQL 'and' (240:6-241:83): right operand skipped when left is false
                                if (fu_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period fv_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> fw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fv_);
                                    CqlDateTime fx_ = context.Operators.End(fw_);
                                    Period fy_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> fz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fy_);
                                    CqlDateTime ga_ = context.Operators.Start(fz_);
                                    CqlQuantity gb_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime gc_ = context.Operators.Subtract(ga_, gb_);
                                    CqlInterval<CqlDateTime> gd_ = context.Operators.Interval(gc_, ga_, true, true);
                                    bool? ge_ = context.Operators.In<CqlDateTime>(fx_, gd_, (string)default);
                                    bool? gf_;
                                    // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                    if (ge_ is false)
                                    {
                                        gf_ = false;
                                    }
                                    else
                                    {
                                        Period gg_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> gh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gg_);
                                        CqlDateTime gi_ = context.Operators.Start(gh_);
                                        gf_ = ge_ & (!((bool?)(gi_ is null)));
                                    }
                                    return fu_ & gf_;
                                }
                            }

                            IEnumerable<Encounter> fh_ = context.Operators.Where<Encounter>(ff_, fg_);

                            object fi_(Encounter @this) {
                                Period gj_ = @this?.Period;
                                CqlInterval<CqlDateTime> gk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gj_);
                                CqlDateTime gl_ = context.Operators.End(gk_);
                                return gl_;
                            }

                            IEnumerable<Encounter> fj_ = context.Operators.SortBy<Encounter>(fh_, fi_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter fk_ = context.Operators.Last<Encounter>(fj_);
                            Period fl_ = fk_?.Period;
                            CqlInterval<CqlDateTime> fm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fl_);
                            CqlDateTime fn_ = context.Operators.Start(fm_);
                            Period fo_ = Visit?.Period;
                            CqlInterval<CqlDateTime> fp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fo_);
                            CqlDateTime fq_ = context.Operators.Start(fp_);
                            dn_ = dm_ & (!((bool?)((fn_ ?? fq_) is null)));
                        }
                        return ck_ & dn_;
                    }
                }

                IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);

                object au_(Encounter @this) {
                    Period gm_ = @this?.Period;
                    CqlInterval<CqlDateTime> gn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gm_);
                    CqlDateTime go_ = context.Operators.End(gn_);
                    return go_;
                }

                IEnumerable<Encounter> av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter aw_ = context.Operators.Last<Encounter>(av_);
                Period ax_ = aw_?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlValueSet ba_ = this.Observation_Services(context);
                IEnumerable<Encounter> bb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bc_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> gp_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gq_ = gp_?.Value;
                    Code<Encounter.EncounterStatus> gr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gq_);
                    bool? gs_ = context.Operators.Equal(gr_, "finished");
                    // CQL 'and' (240:6-241:83): right operand skipped when left is false
                    if (gs_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period gt_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gt_);
                        CqlDateTime gv_ = context.Operators.End(gu_);
                        Period gw_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gw_);
                        CqlDateTime gy_ = context.Operators.Start(gx_);
                        CqlQuantity gz_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ha_ = context.Operators.Subtract(gy_, gz_);
                        CqlInterval<CqlDateTime> hb_ = context.Operators.Interval(ha_, gy_, true, true);
                        bool? hc_ = context.Operators.In<CqlDateTime>(gv_, hb_, (string)default);
                        bool? hd_;
                        // CQL 'and' (241:15-241:83): right operand skipped when left is false
                        if (hc_ is false)
                        {
                            hd_ = false;
                        }
                        else
                        {
                            Period he_ = Visit?.Period;
                            CqlInterval<CqlDateTime> hf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, he_);
                            CqlDateTime hg_ = context.Operators.Start(hf_);
                            hd_ = hc_ & (!((bool?)(hg_ is null)));
                        }
                        return gs_ & hd_;
                    }
                }

                IEnumerable<Encounter> bd_ = context.Operators.Where<Encounter>(bb_, bc_);

                object be_(Encounter @this) {
                    Period hh_ = @this?.Period;
                    CqlInterval<CqlDateTime> hi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hh_);
                    CqlDateTime hj_ = context.Operators.End(hi_);
                    return hj_;
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
                    Code<Encounter.EncounterStatus> hk_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hl_ = hk_?.Value;
                    Code<Encounter.EncounterStatus> hm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hl_);
                    bool? hn_ = context.Operators.Equal(hm_, "finished");
                    // CQL 'and' (246:6-247:71): right operand skipped when left is false
                    if (hn_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period ho_ = LastED?.Period;
                        CqlInterval<CqlDateTime> hp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ho_);
                        CqlDateTime hq_ = context.Operators.End(hp_);
                        CqlValueSet hr_ = this.Observation_Services(context);
                        IEnumerable<Encounter> hs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? ht_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> ir_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? is_ = ir_?.Value;
                            Code<Encounter.EncounterStatus> it_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(is_);
                            bool? iu_ = context.Operators.Equal(it_, "finished");
                            // CQL 'and' (240:6-241:83): right operand skipped when left is false
                            if (iu_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period iv_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> iw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iv_);
                                CqlDateTime ix_ = context.Operators.End(iw_);
                                Period iy_ = Visit?.Period;
                                CqlInterval<CqlDateTime> iz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iy_);
                                CqlDateTime ja_ = context.Operators.Start(iz_);
                                CqlQuantity jb_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime jc_ = context.Operators.Subtract(ja_, jb_);
                                CqlInterval<CqlDateTime> jd_ = context.Operators.Interval(jc_, ja_, true, true);
                                bool? je_ = context.Operators.In<CqlDateTime>(ix_, jd_, (string)default);
                                bool? jf_;
                                // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                if (je_ is false)
                                {
                                    jf_ = false;
                                }
                                else
                                {
                                    Period jg_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> jh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jg_);
                                    CqlDateTime ji_ = context.Operators.Start(jh_);
                                    jf_ = je_ & (!((bool?)(ji_ is null)));
                                }
                                return iu_ & jf_;
                            }
                        }

                        IEnumerable<Encounter> hu_ = context.Operators.Where<Encounter>(hs_, ht_);

                        object hv_(Encounter @this) {
                            Period jj_ = @this?.Period;
                            CqlInterval<CqlDateTime> jk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jj_);
                            CqlDateTime jl_ = context.Operators.End(jk_);
                            return jl_;
                        }

                        IEnumerable<Encounter> hw_ = context.Operators.SortBy<Encounter>(hu_, hv_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter hx_ = context.Operators.Last<Encounter>(hw_);
                        Period hy_ = hx_?.Period;
                        CqlInterval<CqlDateTime> hz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hy_);
                        CqlDateTime ia_ = context.Operators.Start(hz_);
                        Period ib_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ic_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ib_);
                        CqlDateTime id_ = context.Operators.Start(ic_);
                        CqlQuantity ie_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime if_ = context.Operators.Subtract(ia_ ?? id_, ie_);

                        bool? ig_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> jm_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? jn_ = jm_?.Value;
                            Code<Encounter.EncounterStatus> jo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jn_);
                            bool? jp_ = context.Operators.Equal(jo_, "finished");
                            // CQL 'and' (240:6-241:83): right operand skipped when left is false
                            if (jp_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period jq_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> jr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jq_);
                                CqlDateTime js_ = context.Operators.End(jr_);
                                Period jt_ = Visit?.Period;
                                CqlInterval<CqlDateTime> ju_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jt_);
                                CqlDateTime jv_ = context.Operators.Start(ju_);
                                CqlQuantity jw_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime jx_ = context.Operators.Subtract(jv_, jw_);
                                CqlInterval<CqlDateTime> jy_ = context.Operators.Interval(jx_, jv_, true, true);
                                bool? jz_ = context.Operators.In<CqlDateTime>(js_, jy_, (string)default);
                                bool? ka_;
                                // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                if (jz_ is false)
                                {
                                    ka_ = false;
                                }
                                else
                                {
                                    Period kb_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> kc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kb_);
                                    CqlDateTime kd_ = context.Operators.Start(kc_);
                                    ka_ = jz_ & (!((bool?)(kd_ is null)));
                                }
                                return jp_ & ka_;
                            }
                        }

                        IEnumerable<Encounter> ih_ = context.Operators.Where<Encounter>(hs_, ig_);

                        object ii_(Encounter @this) {
                            Period ke_ = @this?.Period;
                            CqlInterval<CqlDateTime> kf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ke_);
                            CqlDateTime kg_ = context.Operators.End(kf_);
                            return kg_;
                        }

                        IEnumerable<Encounter> ij_ = context.Operators.SortBy<Encounter>(ih_, ii_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter ik_ = context.Operators.Last<Encounter>(ij_);
                        Period il_ = ik_?.Period;
                        CqlInterval<CqlDateTime> im_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, il_);
                        CqlDateTime in_ = context.Operators.Start(im_);
                        CqlInterval<CqlDateTime> io_ = context.Operators.Interval(if_, in_ ?? id_, true, true);
                        bool? ip_ = context.Operators.In<CqlDateTime>(hq_, io_, (string)default);
                        bool? iq_;
                        // CQL 'and' (247:15-247:71): right operand skipped when left is false
                        if (ip_ is false)
                        {
                            iq_ = false;
                        }
                        else
                        {
                            CqlValueSet kh_ = this.Observation_Services(context);
                            IEnumerable<Encounter> ki_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? kj_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> ku_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? kv_ = ku_?.Value;
                                Code<Encounter.EncounterStatus> kw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kv_);
                                bool? kx_ = context.Operators.Equal(kw_, "finished");
                                // CQL 'and' (240:6-241:83): right operand skipped when left is false
                                if (kx_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period ky_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> kz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ky_);
                                    CqlDateTime la_ = context.Operators.End(kz_);
                                    Period lb_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> lc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lb_);
                                    CqlDateTime ld_ = context.Operators.Start(lc_);
                                    CqlQuantity le_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime lf_ = context.Operators.Subtract(ld_, le_);
                                    CqlInterval<CqlDateTime> lg_ = context.Operators.Interval(lf_, ld_, true, true);
                                    bool? lh_ = context.Operators.In<CqlDateTime>(la_, lg_, (string)default);
                                    bool? li_;
                                    // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                    if (lh_ is false)
                                    {
                                        li_ = false;
                                    }
                                    else
                                    {
                                        Period lj_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> lk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lj_);
                                        CqlDateTime ll_ = context.Operators.Start(lk_);
                                        li_ = lh_ & (!((bool?)(ll_ is null)));
                                    }
                                    return kx_ & li_;
                                }
                            }

                            IEnumerable<Encounter> kk_ = context.Operators.Where<Encounter>(ki_, kj_);

                            object kl_(Encounter @this) {
                                Period lm_ = @this?.Period;
                                CqlInterval<CqlDateTime> ln_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lm_);
                                CqlDateTime lo_ = context.Operators.End(ln_);
                                return lo_;
                            }

                            IEnumerable<Encounter> km_ = context.Operators.SortBy<Encounter>(kk_, kl_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter kn_ = context.Operators.Last<Encounter>(km_);
                            Period ko_ = kn_?.Period;
                            CqlInterval<CqlDateTime> kp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ko_);
                            CqlDateTime kq_ = context.Operators.Start(kp_);
                            Period kr_ = Visit?.Period;
                            CqlInterval<CqlDateTime> ks_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kr_);
                            CqlDateTime kt_ = context.Operators.Start(ks_);
                            iq_ = ip_ & (!((bool?)((kq_ ?? kt_) is null)));
                        }
                        return hn_ & iq_;
                    }
                }

                IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(ar_, bp_);

                object br_(Encounter @this) {
                    Period lp_ = @this?.Period;
                    CqlInterval<CqlDateTime> lq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lp_);
                    CqlDateTime lr_ = context.Operators.End(lq_);
                    return lr_;
                }

                IEnumerable<Encounter> bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bt_ = context.Operators.Last<Encounter>(bs_);
                Period bu_ = bt_?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);

                bool? bx_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> ls_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? lt_ = ls_?.Value;
                    Code<Encounter.EncounterStatus> lu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lt_);
                    bool? lv_ = context.Operators.Equal(lu_, "finished");
                    // CQL 'and' (240:6-241:83): right operand skipped when left is false
                    if (lv_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period lw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> lx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lw_);
                        CqlDateTime ly_ = context.Operators.End(lx_);
                        Period lz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ma_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lz_);
                        CqlDateTime mb_ = context.Operators.Start(ma_);
                        CqlQuantity mc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime md_ = context.Operators.Subtract(mb_, mc_);
                        CqlInterval<CqlDateTime> me_ = context.Operators.Interval(md_, mb_, true, true);
                        bool? mf_ = context.Operators.In<CqlDateTime>(ly_, me_, (string)default);
                        bool? mg_;
                        // CQL 'and' (241:15-241:83): right operand skipped when left is false
                        if (mf_ is false)
                        {
                            mg_ = false;
                        }
                        else
                        {
                            Period mh_ = Visit?.Period;
                            CqlInterval<CqlDateTime> mi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mh_);
                            CqlDateTime mj_ = context.Operators.Start(mi_);
                            mg_ = mf_ & (!((bool?)(mj_ is null)));
                        }
                        return lv_ & mg_;
                    }
                }

                IEnumerable<Encounter> by_ = context.Operators.Where<Encounter>(bb_, bx_);

                object bz_(Encounter @this) {
                    Period mk_ = @this?.Period;
                    CqlInterval<CqlDateTime> ml_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mk_);
                    CqlDateTime mm_ = context.Operators.End(ml_);
                    return mm_;
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
                    CqlValueSet mn_ = this.Emergency_Department_Visit(context);
                    IEnumerable<Encounter> mo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? mp_(Encounter LastED) {
                        Code<Encounter.EncounterStatus> nk_ = LastED?.StatusElement;
                        Encounter.EncounterStatus? nl_ = nk_?.Value;
                        Code<Encounter.EncounterStatus> nm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nl_);
                        bool? nn_ = context.Operators.Equal(nm_, "finished");
                        // CQL 'and' (246:6-247:71): right operand skipped when left is false
                        if (nn_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period no_ = LastED?.Period;
                            CqlInterval<CqlDateTime> np_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, no_);
                            CqlDateTime nq_ = context.Operators.End(np_);
                            CqlValueSet nr_ = this.Observation_Services(context);
                            IEnumerable<Encounter> ns_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? nt_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> or_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? os_ = or_?.Value;
                                Code<Encounter.EncounterStatus> ot_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(os_);
                                bool? ou_ = context.Operators.Equal(ot_, "finished");
                                // CQL 'and' (240:6-241:83): right operand skipped when left is false
                                if (ou_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period ov_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> ow_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ov_);
                                    CqlDateTime ox_ = context.Operators.End(ow_);
                                    Period oy_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> oz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oy_);
                                    CqlDateTime pa_ = context.Operators.Start(oz_);
                                    CqlQuantity pb_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime pc_ = context.Operators.Subtract(pa_, pb_);
                                    CqlInterval<CqlDateTime> pd_ = context.Operators.Interval(pc_, pa_, true, true);
                                    bool? pe_ = context.Operators.In<CqlDateTime>(ox_, pd_, (string)default);
                                    bool? pf_;
                                    // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                    if (pe_ is false)
                                    {
                                        pf_ = false;
                                    }
                                    else
                                    {
                                        Period pg_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> ph_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pg_);
                                        CqlDateTime pi_ = context.Operators.Start(ph_);
                                        pf_ = pe_ & (!((bool?)(pi_ is null)));
                                    }
                                    return ou_ & pf_;
                                }
                            }

                            IEnumerable<Encounter> nu_ = context.Operators.Where<Encounter>(ns_, nt_);

                            object nv_(Encounter @this) {
                                Period pj_ = @this?.Period;
                                CqlInterval<CqlDateTime> pk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pj_);
                                CqlDateTime pl_ = context.Operators.End(pk_);
                                return pl_;
                            }

                            IEnumerable<Encounter> nw_ = context.Operators.SortBy<Encounter>(nu_, nv_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter nx_ = context.Operators.Last<Encounter>(nw_);
                            Period ny_ = nx_?.Period;
                            CqlInterval<CqlDateTime> nz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ny_);
                            CqlDateTime oa_ = context.Operators.Start(nz_);
                            Period ob_ = Visit?.Period;
                            CqlInterval<CqlDateTime> oc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ob_);
                            CqlDateTime od_ = context.Operators.Start(oc_);
                            CqlQuantity oe_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime of_ = context.Operators.Subtract(oa_ ?? od_, oe_);

                            bool? og_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> pm_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? pn_ = pm_?.Value;
                                Code<Encounter.EncounterStatus> po_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pn_);
                                bool? pp_ = context.Operators.Equal(po_, "finished");
                                // CQL 'and' (240:6-241:83): right operand skipped when left is false
                                if (pp_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period pq_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> pr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pq_);
                                    CqlDateTime ps_ = context.Operators.End(pr_);
                                    Period pt_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> pu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pt_);
                                    CqlDateTime pv_ = context.Operators.Start(pu_);
                                    CqlQuantity pw_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime px_ = context.Operators.Subtract(pv_, pw_);
                                    CqlInterval<CqlDateTime> py_ = context.Operators.Interval(px_, pv_, true, true);
                                    bool? pz_ = context.Operators.In<CqlDateTime>(ps_, py_, (string)default);
                                    bool? qa_;
                                    // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                    if (pz_ is false)
                                    {
                                        qa_ = false;
                                    }
                                    else
                                    {
                                        Period qb_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> qc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qb_);
                                        CqlDateTime qd_ = context.Operators.Start(qc_);
                                        qa_ = pz_ & (!((bool?)(qd_ is null)));
                                    }
                                    return pp_ & qa_;
                                }
                            }

                            IEnumerable<Encounter> oh_ = context.Operators.Where<Encounter>(ns_, og_);

                            object oi_(Encounter @this) {
                                Period qe_ = @this?.Period;
                                CqlInterval<CqlDateTime> qf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qe_);
                                CqlDateTime qg_ = context.Operators.End(qf_);
                                return qg_;
                            }

                            IEnumerable<Encounter> oj_ = context.Operators.SortBy<Encounter>(oh_, oi_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter ok_ = context.Operators.Last<Encounter>(oj_);
                            Period ol_ = ok_?.Period;
                            CqlInterval<CqlDateTime> om_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ol_);
                            CqlDateTime on_ = context.Operators.Start(om_);
                            CqlInterval<CqlDateTime> oo_ = context.Operators.Interval(of_, on_ ?? od_, true, true);
                            bool? op_ = context.Operators.In<CqlDateTime>(nq_, oo_, (string)default);
                            bool? oq_;
                            // CQL 'and' (247:15-247:71): right operand skipped when left is false
                            if (op_ is false)
                            {
                                oq_ = false;
                            }
                            else
                            {
                                CqlValueSet qh_ = this.Observation_Services(context);
                                IEnumerable<Encounter> qi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                                bool? qj_(Encounter LastObs) {
                                    Code<Encounter.EncounterStatus> qu_ = LastObs?.StatusElement;
                                    Encounter.EncounterStatus? qv_ = qu_?.Value;
                                    Code<Encounter.EncounterStatus> qw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qv_);
                                    bool? qx_ = context.Operators.Equal(qw_, "finished");
                                    // CQL 'and' (240:6-241:83): right operand skipped when left is false
                                    if (qx_ is false)
                                    {
                                        return false;
                                    }
                                    else
                                    {
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
                                        bool? ri_;
                                        // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                        if (rh_ is false)
                                        {
                                            ri_ = false;
                                        }
                                        else
                                        {
                                            Period rj_ = Visit?.Period;
                                            CqlInterval<CqlDateTime> rk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rj_);
                                            CqlDateTime rl_ = context.Operators.Start(rk_);
                                            ri_ = rh_ & (!((bool?)(rl_ is null)));
                                        }
                                        return qx_ & ri_;
                                    }
                                }

                                IEnumerable<Encounter> qk_ = context.Operators.Where<Encounter>(qi_, qj_);

                                object ql_(Encounter @this) {
                                    Period rm_ = @this?.Period;
                                    CqlInterval<CqlDateTime> rn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rm_);
                                    CqlDateTime ro_ = context.Operators.End(rn_);
                                    return ro_;
                                }

                                IEnumerable<Encounter> qm_ = context.Operators.SortBy<Encounter>(qk_, ql_, System.ComponentModel.ListSortDirection.Ascending);
                                Encounter qn_ = context.Operators.Last<Encounter>(qm_);
                                Period qo_ = qn_?.Period;
                                CqlInterval<CqlDateTime> qp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qo_);
                                CqlDateTime qq_ = context.Operators.Start(qp_);
                                Period qr_ = Visit?.Period;
                                CqlInterval<CqlDateTime> qs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qr_);
                                CqlDateTime qt_ = context.Operators.Start(qs_);
                                oq_ = op_ & (!((bool?)((qq_ ?? qt_) is null)));
                            }
                            return nn_ & oq_;
                        }
                    }

                    IEnumerable<Encounter> mq_ = context.Operators.Where<Encounter>(mo_, mp_);

                    object mr_(Encounter @this) {
                        Period rp_ = @this?.Period;
                        CqlInterval<CqlDateTime> rq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rp_);
                        CqlDateTime rr_ = context.Operators.End(rq_);
                        return rr_;
                    }

                    IEnumerable<Encounter> ms_ = context.Operators.SortBy<Encounter>(mq_, mr_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter mt_ = context.Operators.Last<Encounter>(ms_);
                    Period mu_ = mt_?.Period;
                    CqlInterval<CqlDateTime> mv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mu_);
                    CqlDateTime mw_ = context.Operators.Start(mv_);
                    CqlValueSet mx_ = this.Observation_Services(context);
                    IEnumerable<Encounter> my_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? mz_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> rs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? rt_ = rs_?.Value;
                        Code<Encounter.EncounterStatus> ru_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rt_);
                        bool? rv_ = context.Operators.Equal(ru_, "finished");
                        // CQL 'and' (240:6-241:83): right operand skipped when left is false
                        if (rv_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period rw_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> rx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rw_);
                            CqlDateTime ry_ = context.Operators.End(rx_);
                            Period rz_ = Visit?.Period;
                            CqlInterval<CqlDateTime> sa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rz_);
                            CqlDateTime sb_ = context.Operators.Start(sa_);
                            CqlQuantity sc_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime sd_ = context.Operators.Subtract(sb_, sc_);
                            CqlInterval<CqlDateTime> se_ = context.Operators.Interval(sd_, sb_, true, true);
                            bool? sf_ = context.Operators.In<CqlDateTime>(ry_, se_, (string)default);
                            bool? sg_;
                            // CQL 'and' (241:15-241:83): right operand skipped when left is false
                            if (sf_ is false)
                            {
                                sg_ = false;
                            }
                            else
                            {
                                Period sh_ = Visit?.Period;
                                CqlInterval<CqlDateTime> si_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sh_);
                                CqlDateTime sj_ = context.Operators.Start(si_);
                                sg_ = sf_ & (!((bool?)(sj_ is null)));
                            }
                            return rv_ & sg_;
                        }
                    }

                    IEnumerable<Encounter> na_ = context.Operators.Where<Encounter>(my_, mz_);

                    object nb_(Encounter @this) {
                        Period sk_ = @this?.Period;
                        CqlInterval<CqlDateTime> sl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sk_);
                        CqlDateTime sm_ = context.Operators.End(sl_);
                        return sm_;
                    }

                    IEnumerable<Encounter> nc_ = context.Operators.SortBy<Encounter>(na_, nb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nd_ = context.Operators.Last<Encounter>(nc_);
                    Period ne_ = nd_?.Period;
                    CqlInterval<CqlDateTime> nf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ne_);
                    CqlDateTime ng_ = context.Operators.Start(nf_);
                    Period nh_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ni_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nh_);
                    CqlDateTime nj_ = context.Operators.Start(ni_);
                    return cg_ & (!((bool?)((mw_ ?? ng_ ?? nj_) is null)));
                }
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period sn_ = @this?.Period;
                CqlInterval<CqlDateTime> so_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sn_);
                CqlDateTime sp_ = context.Operators.End(so_);
                return sp_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastED) {
                Code<Encounter.EncounterStatus> sq_ = LastED?.StatusElement;
                Encounter.EncounterStatus? sr_ = sq_?.Value;
                Code<Encounter.EncounterStatus> ss_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sr_);
                bool? st_ = context.Operators.Equal(ss_, "finished");
                // CQL 'and' (246:6-247:71): right operand skipped when left is false
                if (st_ is false)
                {
                    return false;
                }
                else
                {
                    Period su_ = LastED?.Period;
                    CqlInterval<CqlDateTime> sv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, su_);
                    CqlDateTime sw_ = context.Operators.End(sv_);
                    CqlValueSet sx_ = this.Observation_Services(context);
                    IEnumerable<Encounter> sy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, sx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? sz_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> tx_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ty_ = tx_?.Value;
                        Code<Encounter.EncounterStatus> tz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ty_);
                        bool? ua_ = context.Operators.Equal(tz_, "finished");
                        // CQL 'and' (240:6-241:83): right operand skipped when left is false
                        if (ua_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period ub_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> uc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ub_);
                            CqlDateTime ud_ = context.Operators.End(uc_);
                            Period ue_ = Visit?.Period;
                            CqlInterval<CqlDateTime> uf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ue_);
                            CqlDateTime ug_ = context.Operators.Start(uf_);
                            CqlQuantity uh_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime ui_ = context.Operators.Subtract(ug_, uh_);
                            CqlInterval<CqlDateTime> uj_ = context.Operators.Interval(ui_, ug_, true, true);
                            bool? uk_ = context.Operators.In<CqlDateTime>(ud_, uj_, (string)default);
                            bool? ul_;
                            // CQL 'and' (241:15-241:83): right operand skipped when left is false
                            if (uk_ is false)
                            {
                                ul_ = false;
                            }
                            else
                            {
                                Period um_ = Visit?.Period;
                                CqlInterval<CqlDateTime> un_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, um_);
                                CqlDateTime uo_ = context.Operators.Start(un_);
                                ul_ = uk_ & (!((bool?)(uo_ is null)));
                            }
                            return ua_ & ul_;
                        }
                    }

                    IEnumerable<Encounter> ta_ = context.Operators.Where<Encounter>(sy_, sz_);

                    object tb_(Encounter @this) {
                        Period up_ = @this?.Period;
                        CqlInterval<CqlDateTime> uq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, up_);
                        CqlDateTime ur_ = context.Operators.End(uq_);
                        return ur_;
                    }

                    IEnumerable<Encounter> tc_ = context.Operators.SortBy<Encounter>(ta_, tb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter td_ = context.Operators.Last<Encounter>(tc_);
                    Period te_ = td_?.Period;
                    CqlInterval<CqlDateTime> tf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, te_);
                    CqlDateTime tg_ = context.Operators.Start(tf_);
                    Period th_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ti_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, th_);
                    CqlDateTime tj_ = context.Operators.Start(ti_);
                    CqlQuantity tk_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tl_ = context.Operators.Subtract(tg_ ?? tj_, tk_);

                    bool? tm_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> us_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ut_ = us_?.Value;
                        Code<Encounter.EncounterStatus> uu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ut_);
                        bool? uv_ = context.Operators.Equal(uu_, "finished");
                        // CQL 'and' (240:6-241:83): right operand skipped when left is false
                        if (uv_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period uw_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> ux_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uw_);
                            CqlDateTime uy_ = context.Operators.End(ux_);
                            Period uz_ = Visit?.Period;
                            CqlInterval<CqlDateTime> va_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uz_);
                            CqlDateTime vb_ = context.Operators.Start(va_);
                            CqlQuantity vc_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime vd_ = context.Operators.Subtract(vb_, vc_);
                            CqlInterval<CqlDateTime> ve_ = context.Operators.Interval(vd_, vb_, true, true);
                            bool? vf_ = context.Operators.In<CqlDateTime>(uy_, ve_, (string)default);
                            bool? vg_;
                            // CQL 'and' (241:15-241:83): right operand skipped when left is false
                            if (vf_ is false)
                            {
                                vg_ = false;
                            }
                            else
                            {
                                Period vh_ = Visit?.Period;
                                CqlInterval<CqlDateTime> vi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vh_);
                                CqlDateTime vj_ = context.Operators.Start(vi_);
                                vg_ = vf_ & (!((bool?)(vj_ is null)));
                            }
                            return uv_ & vg_;
                        }
                    }

                    IEnumerable<Encounter> tn_ = context.Operators.Where<Encounter>(sy_, tm_);

                    object to_(Encounter @this) {
                        Period vk_ = @this?.Period;
                        CqlInterval<CqlDateTime> vl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vk_);
                        CqlDateTime vm_ = context.Operators.End(vl_);
                        return vm_;
                    }

                    IEnumerable<Encounter> tp_ = context.Operators.SortBy<Encounter>(tn_, to_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter tq_ = context.Operators.Last<Encounter>(tp_);
                    Period tr_ = tq_?.Period;
                    CqlInterval<CqlDateTime> ts_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tr_);
                    CqlDateTime tt_ = context.Operators.Start(ts_);
                    CqlInterval<CqlDateTime> tu_ = context.Operators.Interval(tl_, tt_ ?? tj_, true, true);
                    bool? tv_ = context.Operators.In<CqlDateTime>(sw_, tu_, (string)default);
                    bool? tw_;
                    // CQL 'and' (247:15-247:71): right operand skipped when left is false
                    if (tv_ is false)
                    {
                        tw_ = false;
                    }
                    else
                    {
                        CqlValueSet vn_ = this.Observation_Services(context);
                        IEnumerable<Encounter> vo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? vp_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> wa_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? wb_ = wa_?.Value;
                            Code<Encounter.EncounterStatus> wc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wb_);
                            bool? wd_ = context.Operators.Equal(wc_, "finished");
                            // CQL 'and' (240:6-241:83): right operand skipped when left is false
                            if (wd_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period we_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> wf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, we_);
                                CqlDateTime wg_ = context.Operators.End(wf_);
                                Period wh_ = Visit?.Period;
                                CqlInterval<CqlDateTime> wi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wh_);
                                CqlDateTime wj_ = context.Operators.Start(wi_);
                                CqlQuantity wk_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime wl_ = context.Operators.Subtract(wj_, wk_);
                                CqlInterval<CqlDateTime> wm_ = context.Operators.Interval(wl_, wj_, true, true);
                                bool? wn_ = context.Operators.In<CqlDateTime>(wg_, wm_, (string)default);
                                bool? wo_;
                                // CQL 'and' (241:15-241:83): right operand skipped when left is false
                                if (wn_ is false)
                                {
                                    wo_ = false;
                                }
                                else
                                {
                                    Period wp_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> wq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wp_);
                                    CqlDateTime wr_ = context.Operators.Start(wq_);
                                    wo_ = wn_ & (!((bool?)(wr_ is null)));
                                }
                                return wd_ & wo_;
                            }
                        }

                        IEnumerable<Encounter> vq_ = context.Operators.Where<Encounter>(vo_, vp_);

                        object vr_(Encounter @this) {
                            Period ws_ = @this?.Period;
                            CqlInterval<CqlDateTime> wt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ws_);
                            CqlDateTime wu_ = context.Operators.End(wt_);
                            return wu_;
                        }

                        IEnumerable<Encounter> vs_ = context.Operators.SortBy<Encounter>(vq_, vr_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter vt_ = context.Operators.Last<Encounter>(vs_);
                        Period vu_ = vt_?.Period;
                        CqlInterval<CqlDateTime> vv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vu_);
                        CqlDateTime vw_ = context.Operators.Start(vv_);
                        Period vx_ = Visit?.Period;
                        CqlInterval<CqlDateTime> vy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vx_);
                        CqlDateTime vz_ = context.Operators.Start(vy_);
                        tw_ = tv_ & (!((bool?)((vw_ ?? vz_) is null)));
                    }
                    return st_ & tw_;
                }
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period wv_ = @this?.Period;
                CqlInterval<CqlDateTime> ww_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wv_);
                CqlDateTime wx_ = context.Operators.End(ww_);
                return wx_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlValueSet y_ = this.Observation_Services(context);
            IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? aa_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> wy_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? wz_ = wy_?.Value;
                Code<Encounter.EncounterStatus> xa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wz_);
                bool? xb_ = context.Operators.Equal(xa_, "finished");
                // CQL 'and' (240:6-241:83): right operand skipped when left is false
                if (xb_ is false)
                {
                    return false;
                }
                else
                {
                    Period xc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> xd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xc_);
                    CqlDateTime xe_ = context.Operators.End(xd_);
                    Period xf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> xg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xf_);
                    CqlDateTime xh_ = context.Operators.Start(xg_);
                    CqlQuantity xi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime xj_ = context.Operators.Subtract(xh_, xi_);
                    CqlInterval<CqlDateTime> xk_ = context.Operators.Interval(xj_, xh_, true, true);
                    bool? xl_ = context.Operators.In<CqlDateTime>(xe_, xk_, (string)default);
                    bool? xm_;
                    // CQL 'and' (241:15-241:83): right operand skipped when left is false
                    if (xl_ is false)
                    {
                        xm_ = false;
                    }
                    else
                    {
                        Period xn_ = Visit?.Period;
                        CqlInterval<CqlDateTime> xo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xn_);
                        CqlDateTime xp_ = context.Operators.Start(xo_);
                        xm_ = xl_ & (!((bool?)(xp_ is null)));
                    }
                    return xb_ & xm_;
                }
            }

            IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);

            object ac_(Encounter @this) {
                Period xq_ = @this?.Period;
                CqlInterval<CqlDateTime> xr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xq_);
                CqlDateTime xs_ = context.Operators.End(xr_);
                return xs_;
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
                                    Period ed_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ed_);
                                    CqlDateTime ef_ = context.Operators.Start(ee_);
                                    ec_ = eb_ & (!((bool?)(ef_ is null)));
                                }
                                return dr_ & ec_;
                            }
                        }

                        IEnumerable<Encounter> cr_ = context.Operators.Where<Encounter>(cp_, cq_);

                        object cs_(Encounter @this) {
                            Period eg_ = @this?.Period;
                            CqlInterval<CqlDateTime> eh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eg_);
                            CqlDateTime ei_ = context.Operators.End(eh_);
                            return ei_;
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
                            Code<Encounter.EncounterStatus> ej_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? ek_ = ej_?.Value;
                            Code<Encounter.EncounterStatus> el_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ek_);
                            bool? em_ = context.Operators.Equal(el_, "finished");
                            // CQL 'and' (263:6-264:83): right operand skipped when left is false
                            if (em_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period en_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> eo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, en_);
                                CqlDateTime ep_ = context.Operators.End(eo_);
                                Period eq_ = Visit?.Period;
                                CqlInterval<CqlDateTime> er_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eq_);
                                CqlDateTime es_ = context.Operators.Start(er_);
                                CqlQuantity et_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime eu_ = context.Operators.Subtract(es_, et_);
                                CqlInterval<CqlDateTime> ev_ = context.Operators.Interval(eu_, es_, true, true);
                                bool? ew_ = context.Operators.In<CqlDateTime>(ep_, ev_, (string)default);
                                bool? ex_;
                                // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                if (ew_ is false)
                                {
                                    ex_ = false;
                                }
                                else
                                {
                                    Period ey_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> ez_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ey_);
                                    CqlDateTime fa_ = context.Operators.Start(ez_);
                                    ex_ = ew_ & (!((bool?)(fa_ is null)));
                                }
                                return em_ & ex_;
                            }
                        }

                        IEnumerable<Encounter> de_ = context.Operators.Where<Encounter>(cp_, dd_);

                        object df_(Encounter @this) {
                            Period fb_ = @this?.Period;
                            CqlInterval<CqlDateTime> fc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fb_);
                            CqlDateTime fd_ = context.Operators.End(fc_);
                            return fd_;
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
                            CqlValueSet fe_ = this.Observation_Services(context);
                            IEnumerable<Encounter> ff_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, fe_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? fg_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> fr_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? fs_ = fr_?.Value;
                                Code<Encounter.EncounterStatus> ft_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fs_);
                                bool? fu_ = context.Operators.Equal(ft_, "finished");
                                // CQL 'and' (263:6-264:83): right operand skipped when left is false
                                if (fu_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period fv_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> fw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fv_);
                                    CqlDateTime fx_ = context.Operators.End(fw_);
                                    Period fy_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> fz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fy_);
                                    CqlDateTime ga_ = context.Operators.Start(fz_);
                                    CqlQuantity gb_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime gc_ = context.Operators.Subtract(ga_, gb_);
                                    CqlInterval<CqlDateTime> gd_ = context.Operators.Interval(gc_, ga_, true, true);
                                    bool? ge_ = context.Operators.In<CqlDateTime>(fx_, gd_, (string)default);
                                    bool? gf_;
                                    // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                    if (ge_ is false)
                                    {
                                        gf_ = false;
                                    }
                                    else
                                    {
                                        Period gg_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> gh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gg_);
                                        CqlDateTime gi_ = context.Operators.Start(gh_);
                                        gf_ = ge_ & (!((bool?)(gi_ is null)));
                                    }
                                    return fu_ & gf_;
                                }
                            }

                            IEnumerable<Encounter> fh_ = context.Operators.Where<Encounter>(ff_, fg_);

                            object fi_(Encounter @this) {
                                Period gj_ = @this?.Period;
                                CqlInterval<CqlDateTime> gk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gj_);
                                CqlDateTime gl_ = context.Operators.End(gk_);
                                return gl_;
                            }

                            IEnumerable<Encounter> fj_ = context.Operators.SortBy<Encounter>(fh_, fi_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter fk_ = context.Operators.Last<Encounter>(fj_);
                            Period fl_ = fk_?.Period;
                            CqlInterval<CqlDateTime> fm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fl_);
                            CqlDateTime fn_ = context.Operators.Start(fm_);
                            Period fo_ = Visit?.Period;
                            CqlInterval<CqlDateTime> fp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fo_);
                            CqlDateTime fq_ = context.Operators.Start(fp_);
                            dn_ = dm_ & (!((bool?)((fn_ ?? fq_) is null)));
                        }
                        return ck_ & dn_;
                    }
                }

                IEnumerable<Encounter> at_ = context.Operators.Where<Encounter>(ar_, as_);

                object au_(Encounter @this) {
                    Period gm_ = @this?.Period;
                    CqlInterval<CqlDateTime> gn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gm_);
                    CqlDateTime go_ = context.Operators.End(gn_);
                    return go_;
                }

                IEnumerable<Encounter> av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter aw_ = context.Operators.Last<Encounter>(av_);
                Period ax_ = aw_?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlValueSet ba_ = this.Observation_Services(context);
                IEnumerable<Encounter> bb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bc_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> gp_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? gq_ = gp_?.Value;
                    Code<Encounter.EncounterStatus> gr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gq_);
                    bool? gs_ = context.Operators.Equal(gr_, "finished");
                    // CQL 'and' (263:6-264:83): right operand skipped when left is false
                    if (gs_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period gt_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> gu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gt_);
                        CqlDateTime gv_ = context.Operators.End(gu_);
                        Period gw_ = Visit?.Period;
                        CqlInterval<CqlDateTime> gx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gw_);
                        CqlDateTime gy_ = context.Operators.Start(gx_);
                        CqlQuantity gz_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime ha_ = context.Operators.Subtract(gy_, gz_);
                        CqlInterval<CqlDateTime> hb_ = context.Operators.Interval(ha_, gy_, true, true);
                        bool? hc_ = context.Operators.In<CqlDateTime>(gv_, hb_, (string)default);
                        bool? hd_;
                        // CQL 'and' (264:15-264:83): right operand skipped when left is false
                        if (hc_ is false)
                        {
                            hd_ = false;
                        }
                        else
                        {
                            Period he_ = Visit?.Period;
                            CqlInterval<CqlDateTime> hf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, he_);
                            CqlDateTime hg_ = context.Operators.Start(hf_);
                            hd_ = hc_ & (!((bool?)(hg_ is null)));
                        }
                        return gs_ & hd_;
                    }
                }

                IEnumerable<Encounter> bd_ = context.Operators.Where<Encounter>(bb_, bc_);

                object be_(Encounter @this) {
                    Period hh_ = @this?.Period;
                    CqlInterval<CqlDateTime> hi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hh_);
                    CqlDateTime hj_ = context.Operators.End(hi_);
                    return hj_;
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
                    Code<Encounter.EncounterStatus> hk_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hl_ = hk_?.Value;
                    Code<Encounter.EncounterStatus> hm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hl_);
                    bool? hn_ = context.Operators.Equal(hm_, "finished");
                    // CQL 'and' (269:6-270:71): right operand skipped when left is false
                    if (hn_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period ho_ = LastED?.Period;
                        CqlInterval<CqlDateTime> hp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ho_);
                        CqlDateTime hq_ = context.Operators.End(hp_);
                        CqlValueSet hr_ = this.Observation_Services(context);
                        IEnumerable<Encounter> hs_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, hr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? ht_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> ir_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? is_ = ir_?.Value;
                            Code<Encounter.EncounterStatus> it_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(is_);
                            bool? iu_ = context.Operators.Equal(it_, "finished");
                            // CQL 'and' (263:6-264:83): right operand skipped when left is false
                            if (iu_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period iv_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> iw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iv_);
                                CqlDateTime ix_ = context.Operators.End(iw_);
                                Period iy_ = Visit?.Period;
                                CqlInterval<CqlDateTime> iz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iy_);
                                CqlDateTime ja_ = context.Operators.Start(iz_);
                                CqlQuantity jb_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime jc_ = context.Operators.Subtract(ja_, jb_);
                                CqlInterval<CqlDateTime> jd_ = context.Operators.Interval(jc_, ja_, true, true);
                                bool? je_ = context.Operators.In<CqlDateTime>(ix_, jd_, (string)default);
                                bool? jf_;
                                // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                if (je_ is false)
                                {
                                    jf_ = false;
                                }
                                else
                                {
                                    Period jg_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> jh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jg_);
                                    CqlDateTime ji_ = context.Operators.Start(jh_);
                                    jf_ = je_ & (!((bool?)(ji_ is null)));
                                }
                                return iu_ & jf_;
                            }
                        }

                        IEnumerable<Encounter> hu_ = context.Operators.Where<Encounter>(hs_, ht_);

                        object hv_(Encounter @this) {
                            Period jj_ = @this?.Period;
                            CqlInterval<CqlDateTime> jk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jj_);
                            CqlDateTime jl_ = context.Operators.End(jk_);
                            return jl_;
                        }

                        IEnumerable<Encounter> hw_ = context.Operators.SortBy<Encounter>(hu_, hv_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter hx_ = context.Operators.Last<Encounter>(hw_);
                        Period hy_ = hx_?.Period;
                        CqlInterval<CqlDateTime> hz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hy_);
                        CqlDateTime ia_ = context.Operators.Start(hz_);
                        Period ib_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ic_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ib_);
                        CqlDateTime id_ = context.Operators.Start(ic_);
                        CqlQuantity ie_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime if_ = context.Operators.Subtract(ia_ ?? id_, ie_);

                        bool? ig_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> jm_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? jn_ = jm_?.Value;
                            Code<Encounter.EncounterStatus> jo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jn_);
                            bool? jp_ = context.Operators.Equal(jo_, "finished");
                            // CQL 'and' (263:6-264:83): right operand skipped when left is false
                            if (jp_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period jq_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> jr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jq_);
                                CqlDateTime js_ = context.Operators.End(jr_);
                                Period jt_ = Visit?.Period;
                                CqlInterval<CqlDateTime> ju_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jt_);
                                CqlDateTime jv_ = context.Operators.Start(ju_);
                                CqlQuantity jw_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime jx_ = context.Operators.Subtract(jv_, jw_);
                                CqlInterval<CqlDateTime> jy_ = context.Operators.Interval(jx_, jv_, true, true);
                                bool? jz_ = context.Operators.In<CqlDateTime>(js_, jy_, (string)default);
                                bool? ka_;
                                // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                if (jz_ is false)
                                {
                                    ka_ = false;
                                }
                                else
                                {
                                    Period kb_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> kc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kb_);
                                    CqlDateTime kd_ = context.Operators.Start(kc_);
                                    ka_ = jz_ & (!((bool?)(kd_ is null)));
                                }
                                return jp_ & ka_;
                            }
                        }

                        IEnumerable<Encounter> ih_ = context.Operators.Where<Encounter>(hs_, ig_);

                        object ii_(Encounter @this) {
                            Period ke_ = @this?.Period;
                            CqlInterval<CqlDateTime> kf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ke_);
                            CqlDateTime kg_ = context.Operators.End(kf_);
                            return kg_;
                        }

                        IEnumerable<Encounter> ij_ = context.Operators.SortBy<Encounter>(ih_, ii_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter ik_ = context.Operators.Last<Encounter>(ij_);
                        Period il_ = ik_?.Period;
                        CqlInterval<CqlDateTime> im_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, il_);
                        CqlDateTime in_ = context.Operators.Start(im_);
                        CqlInterval<CqlDateTime> io_ = context.Operators.Interval(if_, in_ ?? id_, true, true);
                        bool? ip_ = context.Operators.In<CqlDateTime>(hq_, io_, (string)default);
                        bool? iq_;
                        // CQL 'and' (270:15-270:71): right operand skipped when left is false
                        if (ip_ is false)
                        {
                            iq_ = false;
                        }
                        else
                        {
                            CqlValueSet kh_ = this.Observation_Services(context);
                            IEnumerable<Encounter> ki_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, kh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? kj_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> ku_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? kv_ = ku_?.Value;
                                Code<Encounter.EncounterStatus> kw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kv_);
                                bool? kx_ = context.Operators.Equal(kw_, "finished");
                                // CQL 'and' (263:6-264:83): right operand skipped when left is false
                                if (kx_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period ky_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> kz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ky_);
                                    CqlDateTime la_ = context.Operators.End(kz_);
                                    Period lb_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> lc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lb_);
                                    CqlDateTime ld_ = context.Operators.Start(lc_);
                                    CqlQuantity le_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime lf_ = context.Operators.Subtract(ld_, le_);
                                    CqlInterval<CqlDateTime> lg_ = context.Operators.Interval(lf_, ld_, true, true);
                                    bool? lh_ = context.Operators.In<CqlDateTime>(la_, lg_, (string)default);
                                    bool? li_;
                                    // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                    if (lh_ is false)
                                    {
                                        li_ = false;
                                    }
                                    else
                                    {
                                        Period lj_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> lk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lj_);
                                        CqlDateTime ll_ = context.Operators.Start(lk_);
                                        li_ = lh_ & (!((bool?)(ll_ is null)));
                                    }
                                    return kx_ & li_;
                                }
                            }

                            IEnumerable<Encounter> kk_ = context.Operators.Where<Encounter>(ki_, kj_);

                            object kl_(Encounter @this) {
                                Period lm_ = @this?.Period;
                                CqlInterval<CqlDateTime> ln_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lm_);
                                CqlDateTime lo_ = context.Operators.End(ln_);
                                return lo_;
                            }

                            IEnumerable<Encounter> km_ = context.Operators.SortBy<Encounter>(kk_, kl_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter kn_ = context.Operators.Last<Encounter>(km_);
                            Period ko_ = kn_?.Period;
                            CqlInterval<CqlDateTime> kp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ko_);
                            CqlDateTime kq_ = context.Operators.Start(kp_);
                            Period kr_ = Visit?.Period;
                            CqlInterval<CqlDateTime> ks_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kr_);
                            CqlDateTime kt_ = context.Operators.Start(ks_);
                            iq_ = ip_ & (!((bool?)((kq_ ?? kt_) is null)));
                        }
                        return hn_ & iq_;
                    }
                }

                IEnumerable<Encounter> bq_ = context.Operators.Where<Encounter>(ar_, bp_);

                object br_(Encounter @this) {
                    Period lp_ = @this?.Period;
                    CqlInterval<CqlDateTime> lq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lp_);
                    CqlDateTime lr_ = context.Operators.End(lq_);
                    return lr_;
                }

                IEnumerable<Encounter> bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter bt_ = context.Operators.Last<Encounter>(bs_);
                Period bu_ = bt_?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);

                bool? bx_(Encounter LastObs) {
                    Code<Encounter.EncounterStatus> ls_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? lt_ = ls_?.Value;
                    Code<Encounter.EncounterStatus> lu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lt_);
                    bool? lv_ = context.Operators.Equal(lu_, "finished");
                    // CQL 'and' (263:6-264:83): right operand skipped when left is false
                    if (lv_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Period lw_ = LastObs?.Period;
                        CqlInterval<CqlDateTime> lx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lw_);
                        CqlDateTime ly_ = context.Operators.End(lx_);
                        Period lz_ = Visit?.Period;
                        CqlInterval<CqlDateTime> ma_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lz_);
                        CqlDateTime mb_ = context.Operators.Start(ma_);
                        CqlQuantity mc_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime md_ = context.Operators.Subtract(mb_, mc_);
                        CqlInterval<CqlDateTime> me_ = context.Operators.Interval(md_, mb_, true, true);
                        bool? mf_ = context.Operators.In<CqlDateTime>(ly_, me_, (string)default);
                        bool? mg_;
                        // CQL 'and' (264:15-264:83): right operand skipped when left is false
                        if (mf_ is false)
                        {
                            mg_ = false;
                        }
                        else
                        {
                            Period mh_ = Visit?.Period;
                            CqlInterval<CqlDateTime> mi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mh_);
                            CqlDateTime mj_ = context.Operators.Start(mi_);
                            mg_ = mf_ & (!((bool?)(mj_ is null)));
                        }
                        return lv_ & mg_;
                    }
                }

                IEnumerable<Encounter> by_ = context.Operators.Where<Encounter>(bb_, bx_);

                object bz_(Encounter @this) {
                    Period mk_ = @this?.Period;
                    CqlInterval<CqlDateTime> ml_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mk_);
                    CqlDateTime mm_ = context.Operators.End(ml_);
                    return mm_;
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
                    CqlValueSet mn_ = this.Emergency_Department_Visit(context);
                    IEnumerable<Encounter> mo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? mp_(Encounter LastED) {
                        Code<Encounter.EncounterStatus> nk_ = LastED?.StatusElement;
                        Encounter.EncounterStatus? nl_ = nk_?.Value;
                        Code<Encounter.EncounterStatus> nm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(nl_);
                        bool? nn_ = context.Operators.Equal(nm_, "finished");
                        // CQL 'and' (269:6-270:71): right operand skipped when left is false
                        if (nn_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period no_ = LastED?.Period;
                            CqlInterval<CqlDateTime> np_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, no_);
                            CqlDateTime nq_ = context.Operators.End(np_);
                            CqlValueSet nr_ = this.Observation_Services(context);
                            IEnumerable<Encounter> ns_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, nr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                            bool? nt_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> or_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? os_ = or_?.Value;
                                Code<Encounter.EncounterStatus> ot_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(os_);
                                bool? ou_ = context.Operators.Equal(ot_, "finished");
                                // CQL 'and' (263:6-264:83): right operand skipped when left is false
                                if (ou_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period ov_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> ow_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ov_);
                                    CqlDateTime ox_ = context.Operators.End(ow_);
                                    Period oy_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> oz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oy_);
                                    CqlDateTime pa_ = context.Operators.Start(oz_);
                                    CqlQuantity pb_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime pc_ = context.Operators.Subtract(pa_, pb_);
                                    CqlInterval<CqlDateTime> pd_ = context.Operators.Interval(pc_, pa_, true, true);
                                    bool? pe_ = context.Operators.In<CqlDateTime>(ox_, pd_, (string)default);
                                    bool? pf_;
                                    // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                    if (pe_ is false)
                                    {
                                        pf_ = false;
                                    }
                                    else
                                    {
                                        Period pg_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> ph_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pg_);
                                        CqlDateTime pi_ = context.Operators.Start(ph_);
                                        pf_ = pe_ & (!((bool?)(pi_ is null)));
                                    }
                                    return ou_ & pf_;
                                }
                            }

                            IEnumerable<Encounter> nu_ = context.Operators.Where<Encounter>(ns_, nt_);

                            object nv_(Encounter @this) {
                                Period pj_ = @this?.Period;
                                CqlInterval<CqlDateTime> pk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pj_);
                                CqlDateTime pl_ = context.Operators.End(pk_);
                                return pl_;
                            }

                            IEnumerable<Encounter> nw_ = context.Operators.SortBy<Encounter>(nu_, nv_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter nx_ = context.Operators.Last<Encounter>(nw_);
                            Period ny_ = nx_?.Period;
                            CqlInterval<CqlDateTime> nz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ny_);
                            CqlDateTime oa_ = context.Operators.Start(nz_);
                            Period ob_ = Visit?.Period;
                            CqlInterval<CqlDateTime> oc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ob_);
                            CqlDateTime od_ = context.Operators.Start(oc_);
                            CqlQuantity oe_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime of_ = context.Operators.Subtract(oa_ ?? od_, oe_);

                            bool? og_(Encounter LastObs) {
                                Code<Encounter.EncounterStatus> pm_ = LastObs?.StatusElement;
                                Encounter.EncounterStatus? pn_ = pm_?.Value;
                                Code<Encounter.EncounterStatus> po_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pn_);
                                bool? pp_ = context.Operators.Equal(po_, "finished");
                                // CQL 'and' (263:6-264:83): right operand skipped when left is false
                                if (pp_ is false)
                                {
                                    return false;
                                }
                                else
                                {
                                    Period pq_ = LastObs?.Period;
                                    CqlInterval<CqlDateTime> pr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pq_);
                                    CqlDateTime ps_ = context.Operators.End(pr_);
                                    Period pt_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> pu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pt_);
                                    CqlDateTime pv_ = context.Operators.Start(pu_);
                                    CqlQuantity pw_ = context.Operators.Quantity(1m, "hour");
                                    CqlDateTime px_ = context.Operators.Subtract(pv_, pw_);
                                    CqlInterval<CqlDateTime> py_ = context.Operators.Interval(px_, pv_, true, true);
                                    bool? pz_ = context.Operators.In<CqlDateTime>(ps_, py_, (string)default);
                                    bool? qa_;
                                    // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                    if (pz_ is false)
                                    {
                                        qa_ = false;
                                    }
                                    else
                                    {
                                        Period qb_ = Visit?.Period;
                                        CqlInterval<CqlDateTime> qc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qb_);
                                        CqlDateTime qd_ = context.Operators.Start(qc_);
                                        qa_ = pz_ & (!((bool?)(qd_ is null)));
                                    }
                                    return pp_ & qa_;
                                }
                            }

                            IEnumerable<Encounter> oh_ = context.Operators.Where<Encounter>(ns_, og_);

                            object oi_(Encounter @this) {
                                Period qe_ = @this?.Period;
                                CqlInterval<CqlDateTime> qf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qe_);
                                CqlDateTime qg_ = context.Operators.End(qf_);
                                return qg_;
                            }

                            IEnumerable<Encounter> oj_ = context.Operators.SortBy<Encounter>(oh_, oi_, System.ComponentModel.ListSortDirection.Ascending);
                            Encounter ok_ = context.Operators.Last<Encounter>(oj_);
                            Period ol_ = ok_?.Period;
                            CqlInterval<CqlDateTime> om_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ol_);
                            CqlDateTime on_ = context.Operators.Start(om_);
                            CqlInterval<CqlDateTime> oo_ = context.Operators.Interval(of_, on_ ?? od_, true, true);
                            bool? op_ = context.Operators.In<CqlDateTime>(nq_, oo_, (string)default);
                            bool? oq_;
                            // CQL 'and' (270:15-270:71): right operand skipped when left is false
                            if (op_ is false)
                            {
                                oq_ = false;
                            }
                            else
                            {
                                CqlValueSet qh_ = this.Observation_Services(context);
                                IEnumerable<Encounter> qi_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, qh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                                bool? qj_(Encounter LastObs) {
                                    Code<Encounter.EncounterStatus> qu_ = LastObs?.StatusElement;
                                    Encounter.EncounterStatus? qv_ = qu_?.Value;
                                    Code<Encounter.EncounterStatus> qw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qv_);
                                    bool? qx_ = context.Operators.Equal(qw_, "finished");
                                    // CQL 'and' (263:6-264:83): right operand skipped when left is false
                                    if (qx_ is false)
                                    {
                                        return false;
                                    }
                                    else
                                    {
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
                                        bool? ri_;
                                        // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                        if (rh_ is false)
                                        {
                                            ri_ = false;
                                        }
                                        else
                                        {
                                            Period rj_ = Visit?.Period;
                                            CqlInterval<CqlDateTime> rk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rj_);
                                            CqlDateTime rl_ = context.Operators.Start(rk_);
                                            ri_ = rh_ & (!((bool?)(rl_ is null)));
                                        }
                                        return qx_ & ri_;
                                    }
                                }

                                IEnumerable<Encounter> qk_ = context.Operators.Where<Encounter>(qi_, qj_);

                                object ql_(Encounter @this) {
                                    Period rm_ = @this?.Period;
                                    CqlInterval<CqlDateTime> rn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rm_);
                                    CqlDateTime ro_ = context.Operators.End(rn_);
                                    return ro_;
                                }

                                IEnumerable<Encounter> qm_ = context.Operators.SortBy<Encounter>(qk_, ql_, System.ComponentModel.ListSortDirection.Ascending);
                                Encounter qn_ = context.Operators.Last<Encounter>(qm_);
                                Period qo_ = qn_?.Period;
                                CqlInterval<CqlDateTime> qp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qo_);
                                CqlDateTime qq_ = context.Operators.Start(qp_);
                                Period qr_ = Visit?.Period;
                                CqlInterval<CqlDateTime> qs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qr_);
                                CqlDateTime qt_ = context.Operators.Start(qs_);
                                oq_ = op_ & (!((bool?)((qq_ ?? qt_) is null)));
                            }
                            return nn_ & oq_;
                        }
                    }

                    IEnumerable<Encounter> mq_ = context.Operators.Where<Encounter>(mo_, mp_);

                    object mr_(Encounter @this) {
                        Period rp_ = @this?.Period;
                        CqlInterval<CqlDateTime> rq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rp_);
                        CqlDateTime rr_ = context.Operators.End(rq_);
                        return rr_;
                    }

                    IEnumerable<Encounter> ms_ = context.Operators.SortBy<Encounter>(mq_, mr_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter mt_ = context.Operators.Last<Encounter>(ms_);
                    Period mu_ = mt_?.Period;
                    CqlInterval<CqlDateTime> mv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mu_);
                    CqlDateTime mw_ = context.Operators.Start(mv_);
                    CqlValueSet mx_ = this.Observation_Services(context);
                    IEnumerable<Encounter> my_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, mx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? mz_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> rs_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? rt_ = rs_?.Value;
                        Code<Encounter.EncounterStatus> ru_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rt_);
                        bool? rv_ = context.Operators.Equal(ru_, "finished");
                        // CQL 'and' (263:6-264:83): right operand skipped when left is false
                        if (rv_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period rw_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> rx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rw_);
                            CqlDateTime ry_ = context.Operators.End(rx_);
                            Period rz_ = Visit?.Period;
                            CqlInterval<CqlDateTime> sa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rz_);
                            CqlDateTime sb_ = context.Operators.Start(sa_);
                            CqlQuantity sc_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime sd_ = context.Operators.Subtract(sb_, sc_);
                            CqlInterval<CqlDateTime> se_ = context.Operators.Interval(sd_, sb_, true, true);
                            bool? sf_ = context.Operators.In<CqlDateTime>(ry_, se_, (string)default);
                            bool? sg_;
                            // CQL 'and' (264:15-264:83): right operand skipped when left is false
                            if (sf_ is false)
                            {
                                sg_ = false;
                            }
                            else
                            {
                                Period sh_ = Visit?.Period;
                                CqlInterval<CqlDateTime> si_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sh_);
                                CqlDateTime sj_ = context.Operators.Start(si_);
                                sg_ = sf_ & (!((bool?)(sj_ is null)));
                            }
                            return rv_ & sg_;
                        }
                    }

                    IEnumerable<Encounter> na_ = context.Operators.Where<Encounter>(my_, mz_);

                    object nb_(Encounter @this) {
                        Period sk_ = @this?.Period;
                        CqlInterval<CqlDateTime> sl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sk_);
                        CqlDateTime sm_ = context.Operators.End(sl_);
                        return sm_;
                    }

                    IEnumerable<Encounter> nc_ = context.Operators.SortBy<Encounter>(na_, nb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter nd_ = context.Operators.Last<Encounter>(nc_);
                    Period ne_ = nd_?.Period;
                    CqlInterval<CqlDateTime> nf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ne_);
                    CqlDateTime ng_ = context.Operators.Start(nf_);
                    Period nh_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ni_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nh_);
                    CqlDateTime nj_ = context.Operators.Start(ni_);
                    return cg_ & (!((bool?)((mw_ ?? ng_ ?? nj_) is null)));
                }
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period sn_ = @this?.Period;
                CqlInterval<CqlDateTime> so_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sn_);
                CqlDateTime sp_ = context.Operators.End(so_);
                return sp_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastED) {
                Code<Encounter.EncounterStatus> sq_ = LastED?.StatusElement;
                Encounter.EncounterStatus? sr_ = sq_?.Value;
                Code<Encounter.EncounterStatus> ss_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(sr_);
                bool? st_ = context.Operators.Equal(ss_, "finished");
                // CQL 'and' (269:6-270:71): right operand skipped when left is false
                if (st_ is false)
                {
                    return false;
                }
                else
                {
                    Period su_ = LastED?.Period;
                    CqlInterval<CqlDateTime> sv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, su_);
                    CqlDateTime sw_ = context.Operators.End(sv_);
                    CqlValueSet sx_ = this.Observation_Services(context);
                    IEnumerable<Encounter> sy_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, sx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? sz_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> tx_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ty_ = tx_?.Value;
                        Code<Encounter.EncounterStatus> tz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ty_);
                        bool? ua_ = context.Operators.Equal(tz_, "finished");
                        // CQL 'and' (263:6-264:83): right operand skipped when left is false
                        if (ua_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period ub_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> uc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ub_);
                            CqlDateTime ud_ = context.Operators.End(uc_);
                            Period ue_ = Visit?.Period;
                            CqlInterval<CqlDateTime> uf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ue_);
                            CqlDateTime ug_ = context.Operators.Start(uf_);
                            CqlQuantity uh_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime ui_ = context.Operators.Subtract(ug_, uh_);
                            CqlInterval<CqlDateTime> uj_ = context.Operators.Interval(ui_, ug_, true, true);
                            bool? uk_ = context.Operators.In<CqlDateTime>(ud_, uj_, (string)default);
                            bool? ul_;
                            // CQL 'and' (264:15-264:83): right operand skipped when left is false
                            if (uk_ is false)
                            {
                                ul_ = false;
                            }
                            else
                            {
                                Period um_ = Visit?.Period;
                                CqlInterval<CqlDateTime> un_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, um_);
                                CqlDateTime uo_ = context.Operators.Start(un_);
                                ul_ = uk_ & (!((bool?)(uo_ is null)));
                            }
                            return ua_ & ul_;
                        }
                    }

                    IEnumerable<Encounter> ta_ = context.Operators.Where<Encounter>(sy_, sz_);

                    object tb_(Encounter @this) {
                        Period up_ = @this?.Period;
                        CqlInterval<CqlDateTime> uq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, up_);
                        CqlDateTime ur_ = context.Operators.End(uq_);
                        return ur_;
                    }

                    IEnumerable<Encounter> tc_ = context.Operators.SortBy<Encounter>(ta_, tb_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter td_ = context.Operators.Last<Encounter>(tc_);
                    Period te_ = td_?.Period;
                    CqlInterval<CqlDateTime> tf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, te_);
                    CqlDateTime tg_ = context.Operators.Start(tf_);
                    Period th_ = Visit?.Period;
                    CqlInterval<CqlDateTime> ti_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, th_);
                    CqlDateTime tj_ = context.Operators.Start(ti_);
                    CqlQuantity tk_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime tl_ = context.Operators.Subtract(tg_ ?? tj_, tk_);

                    bool? tm_(Encounter LastObs) {
                        Code<Encounter.EncounterStatus> us_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? ut_ = us_?.Value;
                        Code<Encounter.EncounterStatus> uu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ut_);
                        bool? uv_ = context.Operators.Equal(uu_, "finished");
                        // CQL 'and' (263:6-264:83): right operand skipped when left is false
                        if (uv_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period uw_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> ux_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uw_);
                            CqlDateTime uy_ = context.Operators.End(ux_);
                            Period uz_ = Visit?.Period;
                            CqlInterval<CqlDateTime> va_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uz_);
                            CqlDateTime vb_ = context.Operators.Start(va_);
                            CqlQuantity vc_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime vd_ = context.Operators.Subtract(vb_, vc_);
                            CqlInterval<CqlDateTime> ve_ = context.Operators.Interval(vd_, vb_, true, true);
                            bool? vf_ = context.Operators.In<CqlDateTime>(uy_, ve_, (string)default);
                            bool? vg_;
                            // CQL 'and' (264:15-264:83): right operand skipped when left is false
                            if (vf_ is false)
                            {
                                vg_ = false;
                            }
                            else
                            {
                                Period vh_ = Visit?.Period;
                                CqlInterval<CqlDateTime> vi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vh_);
                                CqlDateTime vj_ = context.Operators.Start(vi_);
                                vg_ = vf_ & (!((bool?)(vj_ is null)));
                            }
                            return uv_ & vg_;
                        }
                    }

                    IEnumerable<Encounter> tn_ = context.Operators.Where<Encounter>(sy_, tm_);

                    object to_(Encounter @this) {
                        Period vk_ = @this?.Period;
                        CqlInterval<CqlDateTime> vl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vk_);
                        CqlDateTime vm_ = context.Operators.End(vl_);
                        return vm_;
                    }

                    IEnumerable<Encounter> tp_ = context.Operators.SortBy<Encounter>(tn_, to_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter tq_ = context.Operators.Last<Encounter>(tp_);
                    Period tr_ = tq_?.Period;
                    CqlInterval<CqlDateTime> ts_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tr_);
                    CqlDateTime tt_ = context.Operators.Start(ts_);
                    CqlInterval<CqlDateTime> tu_ = context.Operators.Interval(tl_, tt_ ?? tj_, true, true);
                    bool? tv_ = context.Operators.In<CqlDateTime>(sw_, tu_, (string)default);
                    bool? tw_;
                    // CQL 'and' (270:15-270:71): right operand skipped when left is false
                    if (tv_ is false)
                    {
                        tw_ = false;
                    }
                    else
                    {
                        CqlValueSet vn_ = this.Observation_Services(context);
                        IEnumerable<Encounter> vo_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vn_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? vp_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> wa_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? wb_ = wa_?.Value;
                            Code<Encounter.EncounterStatus> wc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wb_);
                            bool? wd_ = context.Operators.Equal(wc_, "finished");
                            // CQL 'and' (263:6-264:83): right operand skipped when left is false
                            if (wd_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period we_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> wf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, we_);
                                CqlDateTime wg_ = context.Operators.End(wf_);
                                Period wh_ = Visit?.Period;
                                CqlInterval<CqlDateTime> wi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wh_);
                                CqlDateTime wj_ = context.Operators.Start(wi_);
                                CqlQuantity wk_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime wl_ = context.Operators.Subtract(wj_, wk_);
                                CqlInterval<CqlDateTime> wm_ = context.Operators.Interval(wl_, wj_, true, true);
                                bool? wn_ = context.Operators.In<CqlDateTime>(wg_, wm_, (string)default);
                                bool? wo_;
                                // CQL 'and' (264:15-264:83): right operand skipped when left is false
                                if (wn_ is false)
                                {
                                    wo_ = false;
                                }
                                else
                                {
                                    Period wp_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> wq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wp_);
                                    CqlDateTime wr_ = context.Operators.Start(wq_);
                                    wo_ = wn_ & (!((bool?)(wr_ is null)));
                                }
                                return wd_ & wo_;
                            }
                        }

                        IEnumerable<Encounter> vq_ = context.Operators.Where<Encounter>(vo_, vp_);

                        object vr_(Encounter @this) {
                            Period ws_ = @this?.Period;
                            CqlInterval<CqlDateTime> wt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ws_);
                            CqlDateTime wu_ = context.Operators.End(wt_);
                            return wu_;
                        }

                        IEnumerable<Encounter> vs_ = context.Operators.SortBy<Encounter>(vq_, vr_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter vt_ = context.Operators.Last<Encounter>(vs_);
                        Period vu_ = vt_?.Period;
                        CqlInterval<CqlDateTime> vv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vu_);
                        CqlDateTime vw_ = context.Operators.Start(vv_);
                        Period vx_ = Visit?.Period;
                        CqlInterval<CqlDateTime> vy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vx_);
                        CqlDateTime vz_ = context.Operators.Start(vy_);
                        tw_ = tv_ & (!((bool?)((vw_ ?? vz_) is null)));
                    }
                    return st_ & tw_;
                }
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period wv_ = @this?.Period;
                CqlInterval<CqlDateTime> ww_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wv_);
                CqlDateTime wx_ = context.Operators.End(ww_);
                return wx_;
            }

            IEnumerable<Encounter> t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter u_ = context.Operators.Last<Encounter>(t_);
            Period v_ = u_?.Period;
            CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime x_ = context.Operators.Start(w_);
            CqlValueSet y_ = this.Observation_Services(context);
            IEnumerable<Encounter> z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? aa_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> wy_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? wz_ = wy_?.Value;
                Code<Encounter.EncounterStatus> xa_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wz_);
                bool? xb_ = context.Operators.Equal(xa_, "finished");
                // CQL 'and' (263:6-264:83): right operand skipped when left is false
                if (xb_ is false)
                {
                    return false;
                }
                else
                {
                    Period xc_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> xd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xc_);
                    CqlDateTime xe_ = context.Operators.End(xd_);
                    Period xf_ = Visit?.Period;
                    CqlInterval<CqlDateTime> xg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xf_);
                    CqlDateTime xh_ = context.Operators.Start(xg_);
                    CqlQuantity xi_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime xj_ = context.Operators.Subtract(xh_, xi_);
                    CqlInterval<CqlDateTime> xk_ = context.Operators.Interval(xj_, xh_, true, true);
                    bool? xl_ = context.Operators.In<CqlDateTime>(xe_, xk_, (string)default);
                    bool? xm_;
                    // CQL 'and' (264:15-264:83): right operand skipped when left is false
                    if (xl_ is false)
                    {
                        xm_ = false;
                    }
                    else
                    {
                        Period xn_ = Visit?.Period;
                        CqlInterval<CqlDateTime> xo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xn_);
                        CqlDateTime xp_ = context.Operators.Start(xo_);
                        xm_ = xl_ & (!((bool?)(xp_ is null)));
                    }
                    return xb_ & xm_;
                }
            }

            IEnumerable<Encounter> ab_ = context.Operators.Where<Encounter>(z_, aa_);

            object ac_(Encounter @this) {
                Period xq_ = @this?.Period;
                CqlInterval<CqlDateTime> xr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xq_);
                CqlDateTime xs_ = context.Operators.End(xr_);
                return xs_;
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
                                Period bz_ = Visit?.Period;
                                CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                                CqlDateTime cb_ = context.Operators.Start(ca_);
                                by_ = bx_ & (!((bool?)(cb_ is null)));
                            }
                            return bn_ & by_;
                        }
                    }

                    IEnumerable<Encounter> an_ = context.Operators.Where<Encounter>(al_, am_);

                    object ao_(Encounter @this) {
                        Period cc_ = @this?.Period;
                        CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                        CqlDateTime ce_ = context.Operators.End(cd_);
                        return ce_;
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
                        Code<Encounter.EncounterStatus> cf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? cg_ = cf_?.Value;
                        Code<Encounter.EncounterStatus> ch_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cg_);
                        bool? ci_ = context.Operators.Equal(ch_, "finished");
                        // CQL 'and' (287:7-288:85): right operand skipped when left is false
                        if (ci_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period cj_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cj_);
                            CqlDateTime cl_ = context.Operators.End(ck_);
                            Period cm_ = Visit?.Period;
                            CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                            CqlDateTime co_ = context.Operators.Start(cn_);
                            CqlQuantity cp_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime cq_ = context.Operators.Subtract(co_, cp_);
                            CqlInterval<CqlDateTime> cr_ = context.Operators.Interval(cq_, co_, true, true);
                            bool? cs_ = context.Operators.In<CqlDateTime>(cl_, cr_, (string)default);
                            bool? ct_;
                            // CQL 'and' (288:17-288:85): right operand skipped when left is false
                            if (cs_ is false)
                            {
                                ct_ = false;
                            }
                            else
                            {
                                Period cu_ = Visit?.Period;
                                CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cu_);
                                CqlDateTime cw_ = context.Operators.Start(cv_);
                                ct_ = cs_ & (!((bool?)(cw_ is null)));
                            }
                            return ci_ & ct_;
                        }
                    }

                    IEnumerable<Encounter> ba_ = context.Operators.Where<Encounter>(al_, az_);

                    object bb_(Encounter @this) {
                        Period cx_ = @this?.Period;
                        CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cx_);
                        CqlDateTime cz_ = context.Operators.End(cy_);
                        return cz_;
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
                        CqlValueSet da_ = this.Observation_Services(context);
                        IEnumerable<Encounter> db_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, da_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? dc_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> dn_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? do_ = dn_?.Value;
                            Code<Encounter.EncounterStatus> dp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(do_);
                            bool? dq_ = context.Operators.Equal(dp_, "finished");
                            // CQL 'and' (287:7-288:85): right operand skipped when left is false
                            if (dq_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period dr_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dr_);
                                CqlDateTime dt_ = context.Operators.End(ds_);
                                Period du_ = Visit?.Period;
                                CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, du_);
                                CqlDateTime dw_ = context.Operators.Start(dv_);
                                CqlQuantity dx_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime dy_ = context.Operators.Subtract(dw_, dx_);
                                CqlInterval<CqlDateTime> dz_ = context.Operators.Interval(dy_, dw_, true, true);
                                bool? ea_ = context.Operators.In<CqlDateTime>(dt_, dz_, (string)default);
                                bool? eb_;
                                // CQL 'and' (288:17-288:85): right operand skipped when left is false
                                if (ea_ is false)
                                {
                                    eb_ = false;
                                }
                                else
                                {
                                    Period ec_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> ed_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ec_);
                                    CqlDateTime ee_ = context.Operators.Start(ed_);
                                    eb_ = ea_ & (!((bool?)(ee_ is null)));
                                }
                                return dq_ & eb_;
                            }
                        }

                        IEnumerable<Encounter> dd_ = context.Operators.Where<Encounter>(db_, dc_);

                        object de_(Encounter @this) {
                            Period ef_ = @this?.Period;
                            CqlInterval<CqlDateTime> eg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ef_);
                            CqlDateTime eh_ = context.Operators.End(eg_);
                            return eh_;
                        }

                        IEnumerable<Encounter> df_ = context.Operators.SortBy<Encounter>(dd_, de_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter dg_ = context.Operators.Last<Encounter>(df_);
                        Period dh_ = dg_?.Period;
                        CqlInterval<CqlDateTime> di_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dh_);
                        CqlDateTime dj_ = context.Operators.Start(di_);
                        Period dk_ = Visit?.Period;
                        CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dk_);
                        CqlDateTime dm_ = context.Operators.Start(dl_);
                        bj_ = bi_ & (!((bool?)((dj_ ?? dm_) is null)));
                    }
                    return ag_ & bj_;
                }
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period ei_ = @this?.Period;
                CqlInterval<CqlDateTime> ej_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ei_);
                CqlDateTime ek_ = context.Operators.End(ej_);
                return ek_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> el_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? em_ = el_?.Value;
                Code<Encounter.EncounterStatus> en_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(em_);
                bool? eo_ = context.Operators.Equal(en_, "finished");
                // CQL 'and' (287:7-288:85): right operand skipped when left is false
                if (eo_ is false)
                {
                    return false;
                }
                else
                {
                    Period ep_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> eq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ep_);
                    CqlDateTime er_ = context.Operators.End(eq_);
                    Period es_ = Visit?.Period;
                    CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, es_);
                    CqlDateTime eu_ = context.Operators.Start(et_);
                    CqlQuantity ev_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ew_ = context.Operators.Subtract(eu_, ev_);
                    CqlInterval<CqlDateTime> ex_ = context.Operators.Interval(ew_, eu_, true, true);
                    bool? ey_ = context.Operators.In<CqlDateTime>(er_, ex_, (string)default);
                    bool? ez_;
                    // CQL 'and' (288:17-288:85): right operand skipped when left is false
                    if (ey_ is false)
                    {
                        ez_ = false;
                    }
                    else
                    {
                        Period fa_ = Visit?.Period;
                        CqlInterval<CqlDateTime> fb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fa_);
                        CqlDateTime fc_ = context.Operators.Start(fb_);
                        ez_ = ey_ & (!((bool?)(fc_ is null)));
                    }
                    return eo_ & ez_;
                }
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period fd_ = @this?.Period;
                CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fd_);
                CqlDateTime ff_ = context.Operators.End(fe_);
                return ff_;
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
                                Period bz_ = Visit?.Period;
                                CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                                CqlDateTime cb_ = context.Operators.Start(ca_);
                                by_ = bx_ & (!((bool?)(cb_ is null)));
                            }
                            return bn_ & by_;
                        }
                    }

                    IEnumerable<Encounter> an_ = context.Operators.Where<Encounter>(al_, am_);

                    object ao_(Encounter @this) {
                        Period cc_ = @this?.Period;
                        CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                        CqlDateTime ce_ = context.Operators.End(cd_);
                        return ce_;
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
                        Code<Encounter.EncounterStatus> cf_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? cg_ = cf_?.Value;
                        Code<Encounter.EncounterStatus> ch_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cg_);
                        bool? ci_ = context.Operators.Equal(ch_, "finished");
                        // CQL 'and' (305:7-306:85): right operand skipped when left is false
                        if (ci_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            Period cj_ = LastObs?.Period;
                            CqlInterval<CqlDateTime> ck_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cj_);
                            CqlDateTime cl_ = context.Operators.End(ck_);
                            Period cm_ = Visit?.Period;
                            CqlInterval<CqlDateTime> cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                            CqlDateTime co_ = context.Operators.Start(cn_);
                            CqlQuantity cp_ = context.Operators.Quantity(1m, "hour");
                            CqlDateTime cq_ = context.Operators.Subtract(co_, cp_);
                            CqlInterval<CqlDateTime> cr_ = context.Operators.Interval(cq_, co_, true, true);
                            bool? cs_ = context.Operators.In<CqlDateTime>(cl_, cr_, (string)default);
                            bool? ct_;
                            // CQL 'and' (306:17-306:85): right operand skipped when left is false
                            if (cs_ is false)
                            {
                                ct_ = false;
                            }
                            else
                            {
                                Period cu_ = Visit?.Period;
                                CqlInterval<CqlDateTime> cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cu_);
                                CqlDateTime cw_ = context.Operators.Start(cv_);
                                ct_ = cs_ & (!((bool?)(cw_ is null)));
                            }
                            return ci_ & ct_;
                        }
                    }

                    IEnumerable<Encounter> ba_ = context.Operators.Where<Encounter>(al_, az_);

                    object bb_(Encounter @this) {
                        Period cx_ = @this?.Period;
                        CqlInterval<CqlDateTime> cy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cx_);
                        CqlDateTime cz_ = context.Operators.End(cy_);
                        return cz_;
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
                        CqlValueSet da_ = this.Observation_Services(context);
                        IEnumerable<Encounter> db_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, da_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                        bool? dc_(Encounter LastObs) {
                            Code<Encounter.EncounterStatus> dn_ = LastObs?.StatusElement;
                            Encounter.EncounterStatus? do_ = dn_?.Value;
                            Code<Encounter.EncounterStatus> dp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(do_);
                            bool? dq_ = context.Operators.Equal(dp_, "finished");
                            // CQL 'and' (305:7-306:85): right operand skipped when left is false
                            if (dq_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                Period dr_ = LastObs?.Period;
                                CqlInterval<CqlDateTime> ds_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dr_);
                                CqlDateTime dt_ = context.Operators.End(ds_);
                                Period du_ = Visit?.Period;
                                CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, du_);
                                CqlDateTime dw_ = context.Operators.Start(dv_);
                                CqlQuantity dx_ = context.Operators.Quantity(1m, "hour");
                                CqlDateTime dy_ = context.Operators.Subtract(dw_, dx_);
                                CqlInterval<CqlDateTime> dz_ = context.Operators.Interval(dy_, dw_, true, true);
                                bool? ea_ = context.Operators.In<CqlDateTime>(dt_, dz_, (string)default);
                                bool? eb_;
                                // CQL 'and' (306:17-306:85): right operand skipped when left is false
                                if (ea_ is false)
                                {
                                    eb_ = false;
                                }
                                else
                                {
                                    Period ec_ = Visit?.Period;
                                    CqlInterval<CqlDateTime> ed_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ec_);
                                    CqlDateTime ee_ = context.Operators.Start(ed_);
                                    eb_ = ea_ & (!((bool?)(ee_ is null)));
                                }
                                return dq_ & eb_;
                            }
                        }

                        IEnumerable<Encounter> dd_ = context.Operators.Where<Encounter>(db_, dc_);

                        object de_(Encounter @this) {
                            Period ef_ = @this?.Period;
                            CqlInterval<CqlDateTime> eg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ef_);
                            CqlDateTime eh_ = context.Operators.End(eg_);
                            return eh_;
                        }

                        IEnumerable<Encounter> df_ = context.Operators.SortBy<Encounter>(dd_, de_, System.ComponentModel.ListSortDirection.Ascending);
                        Encounter dg_ = context.Operators.Last<Encounter>(df_);
                        Period dh_ = dg_?.Period;
                        CqlInterval<CqlDateTime> di_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dh_);
                        CqlDateTime dj_ = context.Operators.Start(di_);
                        Period dk_ = Visit?.Period;
                        CqlInterval<CqlDateTime> dl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dk_);
                        CqlDateTime dm_ = context.Operators.Start(dl_);
                        bj_ = bi_ & (!((bool?)((dj_ ?? dm_) is null)));
                    }
                    return ag_ & bj_;
                }
            }

            IEnumerable<Encounter> h_ = context.Operators.Where<Encounter>(f_, g_);

            object i_(Encounter @this) {
                Period ei_ = @this?.Period;
                CqlInterval<CqlDateTime> ej_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ei_);
                CqlDateTime ek_ = context.Operators.End(ej_);
                return ek_;
            }

            IEnumerable<Encounter> j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter k_ = context.Operators.Last<Encounter>(j_);
            Period l_ = k_?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.Start(m_);
            CqlValueSet o_ = this.Observation_Services(context);
            IEnumerable<Encounter> p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter LastObs) {
                Code<Encounter.EncounterStatus> el_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? em_ = el_?.Value;
                Code<Encounter.EncounterStatus> en_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(em_);
                bool? eo_ = context.Operators.Equal(en_, "finished");
                // CQL 'and' (305:7-306:85): right operand skipped when left is false
                if (eo_ is false)
                {
                    return false;
                }
                else
                {
                    Period ep_ = LastObs?.Period;
                    CqlInterval<CqlDateTime> eq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ep_);
                    CqlDateTime er_ = context.Operators.End(eq_);
                    Period es_ = Visit?.Period;
                    CqlInterval<CqlDateTime> et_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, es_);
                    CqlDateTime eu_ = context.Operators.Start(et_);
                    CqlQuantity ev_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime ew_ = context.Operators.Subtract(eu_, ev_);
                    CqlInterval<CqlDateTime> ex_ = context.Operators.Interval(ew_, eu_, true, true);
                    bool? ey_ = context.Operators.In<CqlDateTime>(er_, ex_, (string)default);
                    bool? ez_;
                    // CQL 'and' (306:17-306:85): right operand skipped when left is false
                    if (ey_ is false)
                    {
                        ez_ = false;
                    }
                    else
                    {
                        Period fa_ = Visit?.Period;
                        CqlInterval<CqlDateTime> fb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fa_);
                        CqlDateTime fc_ = context.Operators.Start(fb_);
                        ez_ = ey_ & (!((bool?)(fc_ is null)));
                    }
                    return eo_ & ez_;
                }
            }

            IEnumerable<Encounter> r_ = context.Operators.Where<Encounter>(p_, q_);

            object s_(Encounter @this) {
                Period fd_ = @this?.Period;
                CqlInterval<CqlDateTime> fe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fd_);
                CqlDateTime ff_ = context.Operators.End(fe_);
                return ff_;
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
                DataType i_ = PD?.Diagnosis;
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                Condition k_ = this.getCondition(context, j_ as ResourceReference);
                CodeableConcept l_ = k_?.Code;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                bool? n_ = context.Operators.ConceptInValueSet(m_, valueSet);
                return h_ | n_;
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
                    DataType k_ = CD?.Diagnosis;
                    object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                    Condition m_ = this.getCondition(context, l_ as ResourceReference);
                    CodeableConcept n_ = m_?.Code;
                    CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                    bool? p_ = context.Operators.ConceptInValueSet(o_, diagnosisValueSet);
                    j_ = i_ | p_;
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
