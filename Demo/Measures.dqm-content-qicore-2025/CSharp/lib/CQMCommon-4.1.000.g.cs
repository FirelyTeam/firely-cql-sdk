#nullable enable annotations

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
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 8782724425627446250L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        object? a_ = context.ResolveParameter("CQMCommon-4.1.000", "Measurement Period", (object)null);
        return (CqlInterval<CqlDateTime?>?)a_;
    }


    #endregion Parameters

    #region Functions and Expressions (45)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -1022634852813303399L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Inpatient Encounter")]
    public IEnumerable<Encounter?>? Inpatient_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter, Inpatient_Encounter_Compute);

    private const long _cacheIndex_Inpatient_Encounter = -6472726403027980764L;

    private IEnumerable<Encounter?>? Inpatient_Encounter_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter? EncounterInpatient) {
            Code<Encounter.EncounterStatus>? e_ = EncounterInpatient?.StatusElement;
            Encounter.EncounterStatus? f_ = e_?.Value;
            Code<Encounter.EncounterStatus>? g_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(f_);
            bool? h_ = context.Operators.Equal(g_, "finished");
            Period? i_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime?>? j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime? k_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime?>? l_ = this.Measurement_Period(context);
            bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
            bool? n_ = context.Operators.And(h_, m_);
            return n_;
        }

        IEnumerable<Encounter?>? d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlFunctionDefinition("ToDateInterval")]
    [CqlTag("description", "Returns an interval of date values extracted from the input interval of date-time values")]
    [CqlTag("comment", "This function returns an interval constructed using the `date from` extractor on the start\nand end values of the input date-time interval. Note that using a precision specifier such as `day of`\nas part of a timing phrase is preferred to communicate intent to perform day-level comparison, as well\nas for general readability.")]
    public CqlInterval<CqlDate?>? ToDateInterval(CqlContext context, CqlInterval<CqlDateTime?>? period)
    {
        CqlDateTime? a_ = context.Operators.Start(period);
        CqlDate? b_ = context.Operators.DateFrom(a_);
        CqlDateTime? c_ = context.Operators.End(period);
        CqlDate? d_ = context.Operators.DateFrom(c_);
        CqlInterval<CqlDate?>? e_ = context.Operators.Interval(b_, d_, true, true);
        return e_;
    }


    [CqlFunctionDefinition("LengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    [CqlTag("deprecated", "This function in deprecated. Use the fluent function `lengthInDays()` instead.")]
    public int? LengthInDays(CqlContext context, CqlInterval<CqlDateTime?>? Value)
    {
        CqlDateTime? a_ = context.Operators.Start(Value);
        CqlDateTime? b_ = context.Operators.End(Value);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");
        return c_;
    }


    [CqlFunctionDefinition("lengthInDays")]
    [CqlTag("description", "Calculates the difference in calendar days between the start and end of the given interval.")]
    public int? lengthInDays(CqlContext context, CqlInterval<CqlDateTime?>? Value)
    {
        CqlDateTime? a_ = context.Operators.Start(Value);
        CqlDateTime? b_ = context.Operators.End(Value);
        int? c_ = context.Operators.DifferenceBetween(a_, b_, "day");
        return c_;
    }


    [CqlFunctionDefinition("ED Visit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `edVisit()` instead.")]
    public Encounter? ED_Visit(CqlContext context, Encounter? TheEncounter)
    {
        CqlValueSet? a_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter? EDVisit) {
            Code<Encounter.EncounterStatus>? h_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? i_ = h_?.Value;
            Code<Encounter.EncounterStatus>? j_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(i_);
            bool? k_ = context.Operators.Equal(j_, "finished");
            Period? l_ = EDVisit?.Period;
            CqlInterval<CqlDateTime?>? m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime? n_ = context.Operators.End(m_);
            Period? o_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime?>? p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime? q_ = context.Operators.Start(p_);
            CqlQuantity? r_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime? s_ = context.Operators.Subtract(q_, r_);
            CqlInterval<CqlDateTime?>? t_ = context.Operators.Interval(s_, q_, true, true);
            bool? u_ = context.Operators.In<CqlDateTime>(n_, t_, (string)default);
            bool? v_ = context.Operators.Not((bool?)(q_ is null));
            bool? w_ = context.Operators.And(u_, v_);
            bool? x_ = context.Operators.And(k_, w_);
            return x_;
        }

        IEnumerable<Encounter?>? d_ = context.Operators.Where<Encounter>(b_, c_);

        object? e_(Encounter? @this) {
            Period? y_ = @this?.Period;
            CqlInterval<CqlDateTime?>? z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime? aa_ = context.Operators.End(z_);
            return aa_;
        }

        IEnumerable<Encounter?>? f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter? g_ = context.Operators.Last<Encounter>(f_);
        return g_;
    }


    [CqlFunctionDefinition("edVisit")]
    [CqlTag("description", "Returns the most recent emergency department visit, if any, that occurs 1 hour or less prior to the given encounter.")]
    public Encounter? edVisit(CqlContext context, Encounter? TheEncounter)
    {
        CqlValueSet? a_ = this.Emergency_Department_Visit(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter? EDVisit) {
            Code<Encounter.EncounterStatus>? h_ = EDVisit?.StatusElement;
            Encounter.EncounterStatus? i_ = h_?.Value;
            Code<Encounter.EncounterStatus>? j_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(i_);
            bool? k_ = context.Operators.Equal(j_, "finished");
            Period? l_ = EDVisit?.Period;
            CqlInterval<CqlDateTime?>? m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime? n_ = context.Operators.End(m_);
            Period? o_ = TheEncounter?.Period;
            CqlInterval<CqlDateTime?>? p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime? q_ = context.Operators.Start(p_);
            CqlQuantity? r_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime? s_ = context.Operators.Subtract(q_, r_);
            CqlInterval<CqlDateTime?>? t_ = context.Operators.Interval(s_, q_, true, true);
            bool? u_ = context.Operators.In<CqlDateTime>(n_, t_, (string)default);
            bool? v_ = context.Operators.Not((bool?)(q_ is null));
            bool? w_ = context.Operators.And(u_, v_);
            bool? x_ = context.Operators.And(k_, w_);
            return x_;
        }

        IEnumerable<Encounter?>? d_ = context.Operators.Where<Encounter>(b_, c_);

        object? e_(Encounter? @this) {
            Period? y_ = @this?.Period;
            CqlInterval<CqlDateTime?>? z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime? aa_ = context.Operators.End(z_);
            return aa_;
        }

        IEnumerable<Encounter?>? f_ = context.Operators.SortBy<Encounter>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter? g_ = context.Operators.Last<Encounter>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalization()` instead.")]
    public CqlInterval<CqlDateTime?>? Hospitalization(CqlContext context, Encounter? TheEncounter)
    {
        Encounter? a_ = this.ED_Visit(context, TheEncounter);
        Encounter?[]? b_ = [
            a_,
        ];

        CqlInterval<CqlDateTime?>? c_(Encounter? X) {
            if (X is null)
            {
                Period? f_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime?>? g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
                return g_;
            }
            else
            {
                Period? h_ = X?.Period;
                CqlInterval<CqlDateTime?>? i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlDateTime? j_ = context.Operators.Start(i_);
                Period? k_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime?>? l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime? m_ = context.Operators.End(l_);
                CqlInterval<CqlDateTime?>? n_ = context.Operators.Interval(j_, m_, true, false);
                return n_;
            }
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? d_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter?>?)b_, c_);
        CqlInterval<CqlDateTime?>? e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("hospitalization")]
    [CqlTag("description", "Hospitalization returns the total interval for admission to discharge for the given encounter, or for the admission of any immediately prior emergency department visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime?>? hospitalization(CqlContext context, Encounter? TheEncounter)
    {
        Encounter? a_ = this.edVisit(context, TheEncounter);
        Encounter?[]? b_ = [
            a_,
        ];

        CqlInterval<CqlDateTime?>? c_(Encounter? X) {
            if (X is null)
            {
                Period? f_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime?>? g_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, f_);
                return g_;
            }
            else
            {
                Period? h_ = X?.Period;
                CqlInterval<CqlDateTime?>? i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlDateTime? j_ = context.Operators.Start(i_);
                Period? k_ = TheEncounter?.Period;
                CqlInterval<CqlDateTime?>? l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime? m_ = context.Operators.End(l_);
                CqlInterval<CqlDateTime?>? n_ = context.Operators.Interval(j_, m_, true, true);
                return n_;
            }
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? d_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter?>?)b_, c_);
        CqlInterval<CqlDateTime?>? e_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Hospitalization Locations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLocations()` instead.")]
    public IEnumerable<Encounter.LocationComponent?>? Hospitalization_Locations(CqlContext context, Encounter? TheEncounter)
    {
        Encounter? a_ = this.ED_Visit(context, TheEncounter);
        Encounter?[]? b_ = [
            a_,
        ];

        IEnumerable<Encounter.LocationComponent?>? c_(Encounter? EDEncounter) {
            if (EDEncounter is null)
            {
                List<Encounter.LocationComponent?>? f_ = TheEncounter?.Location;
                return (IEnumerable<Encounter.LocationComponent?>?)f_;
            }
            else
            {
                List<Encounter.LocationComponent?>? g_ = EDEncounter?.Location;
                List<Encounter.LocationComponent?>? h_ = TheEncounter?.Location;
                IEnumerable<Encounter.LocationComponent?>?[]? i_ = [
                    (IEnumerable<Encounter.LocationComponent?>?)g_,
                    (IEnumerable<Encounter.LocationComponent?>?)h_,
                ];
                IEnumerable<Encounter.LocationComponent?>? j_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent?>?>?)i_);
                return j_;
            }
        }

        IEnumerable<IEnumerable<Encounter.LocationComponent?>?>? d_ = context.Operators.SelectDistinct<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter?>?)b_, c_);
        IEnumerable<Encounter.LocationComponent?>? e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("hospitalizationLocations")]
    [CqlTag("description", "Returns list of all locations within an encounter, including locations for immediately prior ED visit.")]
    public IEnumerable<Encounter.LocationComponent?>? hospitalizationLocations(CqlContext context, Encounter? TheEncounter)
    {
        Encounter? a_ = this.edVisit(context, TheEncounter);
        Encounter?[]? b_ = [
            a_,
        ];

        IEnumerable<Encounter.LocationComponent?>? c_(Encounter? EDEncounter) {
            if (EDEncounter is null)
            {
                List<Encounter.LocationComponent?>? f_ = TheEncounter?.Location;
                return (IEnumerable<Encounter.LocationComponent?>?)f_;
            }
            else
            {
                List<Encounter.LocationComponent?>? g_ = EDEncounter?.Location;
                List<Encounter.LocationComponent?>? h_ = TheEncounter?.Location;
                IEnumerable<Encounter.LocationComponent?>?[]? i_ = [
                    (IEnumerable<Encounter.LocationComponent?>?)g_,
                    (IEnumerable<Encounter.LocationComponent?>?)h_,
                ];
                IEnumerable<Encounter.LocationComponent?>? j_ = context.Operators.Flatten<Encounter.LocationComponent>((IEnumerable<IEnumerable<Encounter.LocationComponent?>?>?)i_);
                return j_;
            }
        }

        IEnumerable<IEnumerable<Encounter.LocationComponent?>?>? d_ = context.Operators.SelectDistinct<Encounter, IEnumerable<Encounter.LocationComponent>>((IEnumerable<Encounter?>?)b_, c_);
        IEnumerable<Encounter.LocationComponent?>? e_ = context.Operators.SingletonFrom<IEnumerable<Encounter.LocationComponent>>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Hospitalization Length of Stay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationLengthOfStay()` instead.")]
    public int? Hospitalization_Length_of_Stay(CqlContext context, Encounter? TheEncounter)
    {
        CqlInterval<CqlDateTime?>? a_ = this.Hospitalization(context, TheEncounter);
        int? b_ = this.LengthInDays(context, a_);
        return b_;
    }


    [CqlFunctionDefinition("hospitalizationLengthOfStay")]
    [CqlTag("description", "Returns the length of stay in days (i.e. the number of days between admission and discharge) for the given encounter, or from the admission of any immediately prior emergency department visit to the discharge of the encounter")]
    public int? hospitalizationLengthOfStay(CqlContext context, Encounter? TheEncounter)
    {
        CqlInterval<CqlDateTime?>? a_ = this.hospitalization(context, TheEncounter);
        int? b_ = this.lengthInDays(context, a_);
        return b_;
    }


    [CqlFunctionDefinition("Hospital Admission Time")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalAdmissionTime()` instead.")]
    public CqlDateTime? Hospital_Admission_Time(CqlContext context, Encounter? TheEncounter)
    {
        CqlInterval<CqlDateTime?>? a_ = this.Hospitalization(context, TheEncounter);
        CqlDateTime? b_ = context.Operators.Start(a_);
        return b_;
    }


    [CqlFunctionDefinition("hospitalAdmissionTime")]
    [CqlTag("description", "Returns admission time for an encounter or for immediately prior emergency department visit.")]
    public CqlDateTime? hospitalAdmissionTime(CqlContext context, Encounter? TheEncounter)
    {
        CqlInterval<CqlDateTime?>? a_ = this.hospitalization(context, TheEncounter);
        CqlDateTime? b_ = context.Operators.Start(a_);
        return b_;
    }


    [CqlFunctionDefinition("Hospital Discharge Time")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDischargeTime()` instead.")]
    public CqlDateTime? Hospital_Discharge_Time(CqlContext context, Encounter? TheEncounter)
    {
        Period? a_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime?>? b_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, a_);
        CqlDateTime? c_ = context.Operators.End(b_);
        return c_;
    }


    [CqlFunctionDefinition("hospitalDischargeTime")]
    [CqlTag("description", "Hospital Discharge Time returns the discharge time for an encounter")]
    public CqlDateTime? hospitalDischargeTime(CqlContext context, Encounter? TheEncounter)
    {
        Period? a_ = TheEncounter?.Period;
        CqlInterval<CqlDateTime?>? b_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, a_);
        CqlDateTime? c_ = context.Operators.End(b_);
        return c_;
    }


    [CqlFunctionDefinition("Hospital Arrival Time")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalArrivalTime()` instead.")]
    public CqlDateTime? Hospital_Arrival_Time(CqlContext context, Encounter? TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent?>? a_ = this.Hospitalization_Locations(context, TheEncounter);

        object? b_(Encounter.LocationComponent? @this) {
            Period? h_ = @this?.Period;
            CqlInterval<CqlDateTime?>? i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime? j_ = context.Operators.Start(i_);
            return j_;
        }

        IEnumerable<Encounter.LocationComponent?>? c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent? d_ = context.Operators.First<Encounter.LocationComponent>(c_);
        Period? e_ = d_?.Period;
        CqlInterval<CqlDateTime?>? f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime? g_ = context.Operators.Start(f_);
        return g_;
    }


    [CqlFunctionDefinition("hospitalArrivalTime")]
    [CqlTag("description", "Returns earliest arrival time for an encounter including any prior ED visit.")]
    public CqlDateTime? hospitalArrivalTime(CqlContext context, Encounter? TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent?>? a_ = this.hospitalizationLocations(context, TheEncounter);

        object? b_(Encounter.LocationComponent? @this) {
            Period? h_ = @this?.Period;
            CqlInterval<CqlDateTime?>? i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime? j_ = context.Operators.Start(i_);
            return j_;
        }

        IEnumerable<Encounter.LocationComponent?>? c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent? d_ = context.Operators.First<Encounter.LocationComponent>(c_);
        Period? e_ = d_?.Period;
        CqlInterval<CqlDateTime?>? f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime? g_ = context.Operators.Start(f_);
        return g_;
    }


    [CqlFunctionDefinition("Hospital Departure Time")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalDepartureTime()` instead.")]
    public CqlDateTime? Hospital_Departure_Time(CqlContext context, Encounter? TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent?>? a_ = this.Hospitalization_Locations(context, TheEncounter);

        object? b_(Encounter.LocationComponent? @this) {
            Period? h_ = @this?.Period;
            CqlInterval<CqlDateTime?>? i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime? j_ = context.Operators.Start(i_);
            return j_;
        }

        IEnumerable<Encounter.LocationComponent?>? c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent? d_ = context.Operators.Last<Encounter.LocationComponent>(c_);
        Period? e_ = d_?.Period;
        CqlInterval<CqlDateTime?>? f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime? g_ = context.Operators.End(f_);
        return g_;
    }


    [CqlFunctionDefinition("hospitalDepartureTime")]
    [CqlTag("description", "Returns the latest departure time for encounter including any prior ED visit.")]
    public CqlDateTime? hospitalDepartureTime(CqlContext context, Encounter? TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent?>? a_ = this.hospitalizationLocations(context, TheEncounter);

        object? b_(Encounter.LocationComponent? @this) {
            Period? h_ = @this?.Period;
            CqlInterval<CqlDateTime?>? i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime? j_ = context.Operators.Start(i_);
            return j_;
        }

        IEnumerable<Encounter.LocationComponent?>? c_ = context.Operators.SortBy<Encounter.LocationComponent>(a_, b_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent? d_ = context.Operators.Last<Encounter.LocationComponent>(c_);
        Period? e_ = d_?.Period;
        CqlInterval<CqlDateTime?>? f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime? g_ = context.Operators.End(f_);
        return g_;
    }


    [CqlFunctionDefinition("Emergency Department Arrival Time")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime? Emergency_Department_Arrival_Time(CqlContext context, Encounter? TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent?>? a_ = this.Hospitalization_Locations(context, TheEncounter);

        bool? b_(Encounter.LocationComponent? HospitalLocation) {
            ResourceReference? h_ = HospitalLocation?.Location;
            Location? i_ = this.GetLocation(context, h_);
            List<CodeableConcept?>? j_ = i_?.Type;

            CqlConcept? k_(CodeableConcept? @this) {
                CqlConcept? o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept?>? l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept?>?)j_, k_);
            CqlValueSet? m_ = this.Emergency_Department_Visit(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            return n_;
        }

        IEnumerable<Encounter.LocationComponent?>? c_ = context.Operators.Where<Encounter.LocationComponent>(a_, b_);
        Encounter.LocationComponent? d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
        Period? e_ = d_?.Period;
        CqlInterval<CqlDateTime?>? f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime? g_ = context.Operators.Start(f_);
        return g_;
    }


    [CqlFunctionDefinition("GetLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getLocation()` instead.")]
    public Location? GetLocation(CqlContext context, ResourceReference? reference)
    {
        IEnumerable<Location?>? a_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

        bool? b_(Location? L) {
            bool? e_ = QICoreCommon_4_0_000.Instance.references(context, reference, L);
            return e_;
        }

        IEnumerable<Location?>? c_ = context.Operators.Where<Location>(a_, b_);
        Location? d_ = context.Operators.SingletonFrom<Location>(c_);
        return d_;
    }


    [CqlFunctionDefinition("emergencyDepartmentArrivalTime")]
    [CqlTag("description", "Returns the emergency department arrival time for the encounter.")]
    public CqlDateTime? emergencyDepartmentArrivalTime(CqlContext context, Encounter? TheEncounter)
    {
        IEnumerable<Encounter.LocationComponent?>? a_ = this.hospitalizationLocations(context, TheEncounter);

        bool? b_(Encounter.LocationComponent? HospitalLocation) {
            ResourceReference? h_ = HospitalLocation?.Location;
            Location? i_ = this.GetLocation(context, h_);
            List<CodeableConcept?>? j_ = i_?.Type;

            CqlConcept? k_(CodeableConcept? @this) {
                CqlConcept? o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept?>? l_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept?>?)j_, k_);
            CqlValueSet? m_ = this.Emergency_Department_Visit(context);
            bool? n_ = context.Operators.ConceptsInValueSet(l_, m_);
            return n_;
        }

        IEnumerable<Encounter.LocationComponent?>? c_ = context.Operators.Where<Encounter.LocationComponent>(a_, b_);
        Encounter.LocationComponent? d_ = context.Operators.SingletonFrom<Encounter.LocationComponent>(c_);
        Period? e_ = d_?.Period;
        CqlInterval<CqlDateTime?>? f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
        CqlDateTime? g_ = context.Operators.Start(f_);
        return g_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationAndOutpatientSurgeryService()` instead.")]
    public CqlInterval<CqlDateTime?>? HospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter? TheEncounter)
    {
        Encounter?[]? a_ = [
            TheEncounter,
        ];

        CqlInterval<CqlDateTime?>? b_(Encounter? Visit) {
            CqlValueSet? e_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter?>? f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? g_(Encounter? LastSurgeryOP) {
                Period? an_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime?>? ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime? ap_ = context.Operators.End(ao_);
                CqlValueSet? aq_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter?>? ar_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? as_(Encounter? LastED) {
                    Code<Encounter.EncounterStatus>? cz_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? da_ = cz_?.Value;
                    Code<Encounter.EncounterStatus>? db_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(da_);
                    bool? dc_ = context.Operators.Equal(db_, "finished");
                    Period? dd_ = LastED?.Period;
                    CqlInterval<CqlDateTime?>? de_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dd_);
                    CqlDateTime? df_ = context.Operators.End(de_);
                    CqlValueSet? dg_ = this.Observation_Services(context);
                    IEnumerable<Encounter?>? dh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? di_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? eq_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? er_ = eq_?.Value;
                        Code<Encounter.EncounterStatus>? es_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(er_);
                        bool? et_ = context.Operators.Equal(es_, "finished");
                        Period? eu_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? ev_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eu_);
                        CqlDateTime? ew_ = context.Operators.End(ev_);
                        Period? ex_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? ey_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ex_);
                        CqlDateTime? ez_ = context.Operators.Start(ey_);
                        CqlQuantity? fa_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? fb_ = context.Operators.Subtract(ez_, fa_);
                        CqlInterval<CqlDateTime?>? fc_ = context.Operators.Interval(fb_, ez_, true, true);
                        bool? fd_ = context.Operators.In<CqlDateTime>(ew_, fc_, (string)default);
                        bool? fe_ = context.Operators.Not((bool?)(ez_ is null));
                        bool? ff_ = context.Operators.And(fd_, fe_);
                        bool? fg_ = context.Operators.And(et_, ff_);
                        return fg_;
                    }

                    IEnumerable<Encounter?>? dj_ = context.Operators.Where<Encounter>(dh_, di_);

                    object? dk_(Encounter? @this) {
                        Period? fh_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? fi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fh_);
                        CqlDateTime? fj_ = context.Operators.End(fi_);
                        return fj_;
                    }

                    IEnumerable<Encounter?>? dl_ = context.Operators.SortBy<Encounter>(dj_, dk_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? dm_ = context.Operators.Last<Encounter>(dl_);
                    Period? dn_ = dm_?.Period;
                    CqlInterval<CqlDateTime?>? do_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dn_);
                    CqlDateTime? dp_ = context.Operators.Start(do_);
                    Period? dq_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? dr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dq_);
                    CqlDateTime? ds_ = context.Operators.Start(dr_);
                    CqlQuantity? dt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? du_ = context.Operators.Subtract(dp_ ?? ds_, dt_);

                    bool? dv_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? fk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fl_ = fk_?.Value;
                        Code<Encounter.EncounterStatus>? fm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fl_);
                        bool? fn_ = context.Operators.Equal(fm_, "finished");
                        Period? fo_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? fp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fo_);
                        CqlDateTime? fq_ = context.Operators.End(fp_);
                        Period? fr_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? fs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fr_);
                        CqlDateTime? ft_ = context.Operators.Start(fs_);
                        CqlQuantity? fu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? fv_ = context.Operators.Subtract(ft_, fu_);
                        CqlInterval<CqlDateTime?>? fw_ = context.Operators.Interval(fv_, ft_, true, true);
                        bool? fx_ = context.Operators.In<CqlDateTime>(fq_, fw_, (string)default);
                        bool? fy_ = context.Operators.Not((bool?)(ft_ is null));
                        bool? fz_ = context.Operators.And(fx_, fy_);
                        bool? ga_ = context.Operators.And(fn_, fz_);
                        return ga_;
                    }

                    IEnumerable<Encounter?>? dw_ = context.Operators.Where<Encounter>(dh_, dv_);

                    object? dx_(Encounter? @this) {
                        Period? gb_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? gc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gb_);
                        CqlDateTime? gd_ = context.Operators.End(gc_);
                        return gd_;
                    }

                    IEnumerable<Encounter?>? dy_ = context.Operators.SortBy<Encounter>(dw_, dx_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? dz_ = context.Operators.Last<Encounter>(dy_);
                    Period? ea_ = dz_?.Period;
                    CqlInterval<CqlDateTime?>? eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                    CqlDateTime? ec_ = context.Operators.Start(eb_);
                    CqlInterval<CqlDateTime?>? ed_ = context.Operators.Interval(du_, ec_ ?? ds_, true, true);
                    bool? ee_ = context.Operators.In<CqlDateTime>(df_, ed_, (string)default);

                    bool? ef_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? ge_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gf_ = ge_?.Value;
                        Code<Encounter.EncounterStatus>? gg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gf_);
                        bool? gh_ = context.Operators.Equal(gg_, "finished");
                        Period? gi_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? gj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gi_);
                        CqlDateTime? gk_ = context.Operators.End(gj_);
                        Period? gl_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? gm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gl_);
                        CqlDateTime? gn_ = context.Operators.Start(gm_);
                        CqlQuantity? go_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? gp_ = context.Operators.Subtract(gn_, go_);
                        CqlInterval<CqlDateTime?>? gq_ = context.Operators.Interval(gp_, gn_, true, true);
                        bool? gr_ = context.Operators.In<CqlDateTime>(gk_, gq_, (string)default);
                        bool? gs_ = context.Operators.Not((bool?)(gn_ is null));
                        bool? gt_ = context.Operators.And(gr_, gs_);
                        bool? gu_ = context.Operators.And(gh_, gt_);
                        return gu_;
                    }

                    IEnumerable<Encounter?>? eg_ = context.Operators.Where<Encounter>(dh_, ef_);

                    object? eh_(Encounter? @this) {
                        Period? gv_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? gw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gv_);
                        CqlDateTime? gx_ = context.Operators.End(gw_);
                        return gx_;
                    }

                    IEnumerable<Encounter?>? ei_ = context.Operators.SortBy<Encounter>(eg_, eh_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? ej_ = context.Operators.Last<Encounter>(ei_);
                    Period? ek_ = ej_?.Period;
                    CqlInterval<CqlDateTime?>? el_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ek_);
                    CqlDateTime? em_ = context.Operators.Start(el_);
                    bool? en_ = context.Operators.Not((bool?)((em_ ?? ds_) is null));
                    bool? eo_ = context.Operators.And(ee_, en_);
                    bool? ep_ = context.Operators.And(dc_, eo_);
                    return ep_;
                }

                IEnumerable<Encounter?>? at_ = context.Operators.Where<Encounter>(ar_, as_);

                object? au_(Encounter? @this) {
                    Period? gy_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? gz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gy_);
                    CqlDateTime? ha_ = context.Operators.End(gz_);
                    return ha_;
                }

                IEnumerable<Encounter?>? av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? aw_ = context.Operators.Last<Encounter>(av_);
                Period? ax_ = aw_?.Period;
                CqlInterval<CqlDateTime?>? ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime? az_ = context.Operators.Start(ay_);
                CqlValueSet? ba_ = this.Observation_Services(context);
                IEnumerable<Encounter?>? bb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bc_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? hb_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? hc_ = hb_?.Value;
                    Code<Encounter.EncounterStatus>? hd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hc_);
                    bool? he_ = context.Operators.Equal(hd_, "finished");
                    Period? hf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? hg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hf_);
                    CqlDateTime? hh_ = context.Operators.End(hg_);
                    Period? hi_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? hj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hi_);
                    CqlDateTime? hk_ = context.Operators.Start(hj_);
                    CqlQuantity? hl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? hm_ = context.Operators.Subtract(hk_, hl_);
                    CqlInterval<CqlDateTime?>? hn_ = context.Operators.Interval(hm_, hk_, true, true);
                    bool? ho_ = context.Operators.In<CqlDateTime>(hh_, hn_, (string)default);
                    bool? hp_ = context.Operators.Not((bool?)(hk_ is null));
                    bool? hq_ = context.Operators.And(ho_, hp_);
                    bool? hr_ = context.Operators.And(he_, hq_);
                    return hr_;
                }

                IEnumerable<Encounter?>? bd_ = context.Operators.Where<Encounter>(bb_, bc_);

                object? be_(Encounter? @this) {
                    Period? hs_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? ht_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hs_);
                    CqlDateTime? hu_ = context.Operators.End(ht_);
                    return hu_;
                }

                IEnumerable<Encounter?>? bf_ = context.Operators.SortBy<Encounter>(bd_, be_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? bg_ = context.Operators.Last<Encounter>(bf_);
                Period? bh_ = bg_?.Period;
                CqlInterval<CqlDateTime?>? bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                CqlDateTime? bj_ = context.Operators.Start(bi_);
                Period? bk_ = Visit?.Period;
                CqlInterval<CqlDateTime?>? bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                CqlDateTime? bm_ = context.Operators.Start(bl_);
                CqlQuantity? bn_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime? bo_ = context.Operators.Subtract(az_ ?? bj_ ?? bm_, bn_);

                bool? bp_(Encounter? LastED) {
                    Code<Encounter.EncounterStatus>? hv_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hw_ = hv_?.Value;
                    Code<Encounter.EncounterStatus>? hx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hw_);
                    bool? hy_ = context.Operators.Equal(hx_, "finished");
                    Period? hz_ = LastED?.Period;
                    CqlInterval<CqlDateTime?>? ia_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hz_);
                    CqlDateTime? ib_ = context.Operators.End(ia_);
                    CqlValueSet? ic_ = this.Observation_Services(context);
                    IEnumerable<Encounter?>? id_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ic_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? ie_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? jm_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jn_ = jm_?.Value;
                        Code<Encounter.EncounterStatus>? jo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jn_);
                        bool? jp_ = context.Operators.Equal(jo_, "finished");
                        Period? jq_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? jr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jq_);
                        CqlDateTime? js_ = context.Operators.End(jr_);
                        Period? jt_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? ju_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jt_);
                        CqlDateTime? jv_ = context.Operators.Start(ju_);
                        CqlQuantity? jw_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? jx_ = context.Operators.Subtract(jv_, jw_);
                        CqlInterval<CqlDateTime?>? jy_ = context.Operators.Interval(jx_, jv_, true, true);
                        bool? jz_ = context.Operators.In<CqlDateTime>(js_, jy_, (string)default);
                        bool? ka_ = context.Operators.Not((bool?)(jv_ is null));
                        bool? kb_ = context.Operators.And(jz_, ka_);
                        bool? kc_ = context.Operators.And(jp_, kb_);
                        return kc_;
                    }

                    IEnumerable<Encounter?>? if_ = context.Operators.Where<Encounter>(id_, ie_);

                    object? ig_(Encounter? @this) {
                        Period? kd_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? ke_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kd_);
                        CqlDateTime? kf_ = context.Operators.End(ke_);
                        return kf_;
                    }

                    IEnumerable<Encounter?>? ih_ = context.Operators.SortBy<Encounter>(if_, ig_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? ii_ = context.Operators.Last<Encounter>(ih_);
                    Period? ij_ = ii_?.Period;
                    CqlInterval<CqlDateTime?>? ik_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ij_);
                    CqlDateTime? il_ = context.Operators.Start(ik_);
                    Period? im_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? in_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, im_);
                    CqlDateTime? io_ = context.Operators.Start(in_);
                    CqlQuantity? ip_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? iq_ = context.Operators.Subtract(il_ ?? io_, ip_);

                    bool? ir_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? kg_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? kh_ = kg_?.Value;
                        Code<Encounter.EncounterStatus>? ki_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kh_);
                        bool? kj_ = context.Operators.Equal(ki_, "finished");
                        Period? kk_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? kl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kk_);
                        CqlDateTime? km_ = context.Operators.End(kl_);
                        Period? kn_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? ko_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kn_);
                        CqlDateTime? kp_ = context.Operators.Start(ko_);
                        CqlQuantity? kq_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? kr_ = context.Operators.Subtract(kp_, kq_);
                        CqlInterval<CqlDateTime?>? ks_ = context.Operators.Interval(kr_, kp_, true, true);
                        bool? kt_ = context.Operators.In<CqlDateTime>(km_, ks_, (string)default);
                        bool? ku_ = context.Operators.Not((bool?)(kp_ is null));
                        bool? kv_ = context.Operators.And(kt_, ku_);
                        bool? kw_ = context.Operators.And(kj_, kv_);
                        return kw_;
                    }

                    IEnumerable<Encounter?>? is_ = context.Operators.Where<Encounter>(id_, ir_);

                    object? it_(Encounter? @this) {
                        Period? kx_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? ky_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kx_);
                        CqlDateTime? kz_ = context.Operators.End(ky_);
                        return kz_;
                    }

                    IEnumerable<Encounter?>? iu_ = context.Operators.SortBy<Encounter>(is_, it_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? iv_ = context.Operators.Last<Encounter>(iu_);
                    Period? iw_ = iv_?.Period;
                    CqlInterval<CqlDateTime?>? ix_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iw_);
                    CqlDateTime? iy_ = context.Operators.Start(ix_);
                    CqlInterval<CqlDateTime?>? iz_ = context.Operators.Interval(iq_, iy_ ?? io_, true, true);
                    bool? ja_ = context.Operators.In<CqlDateTime>(ib_, iz_, (string)default);

                    bool? jb_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? la_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lb_ = la_?.Value;
                        Code<Encounter.EncounterStatus>? lc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lb_);
                        bool? ld_ = context.Operators.Equal(lc_, "finished");
                        Period? le_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? lf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, le_);
                        CqlDateTime? lg_ = context.Operators.End(lf_);
                        Period? lh_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? li_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lh_);
                        CqlDateTime? lj_ = context.Operators.Start(li_);
                        CqlQuantity? lk_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? ll_ = context.Operators.Subtract(lj_, lk_);
                        CqlInterval<CqlDateTime?>? lm_ = context.Operators.Interval(ll_, lj_, true, true);
                        bool? ln_ = context.Operators.In<CqlDateTime>(lg_, lm_, (string)default);
                        bool? lo_ = context.Operators.Not((bool?)(lj_ is null));
                        bool? lp_ = context.Operators.And(ln_, lo_);
                        bool? lq_ = context.Operators.And(ld_, lp_);
                        return lq_;
                    }

                    IEnumerable<Encounter?>? jc_ = context.Operators.Where<Encounter>(id_, jb_);

                    object? jd_(Encounter? @this) {
                        Period? lr_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? ls_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lr_);
                        CqlDateTime? lt_ = context.Operators.End(ls_);
                        return lt_;
                    }

                    IEnumerable<Encounter?>? je_ = context.Operators.SortBy<Encounter>(jc_, jd_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? jf_ = context.Operators.Last<Encounter>(je_);
                    Period? jg_ = jf_?.Period;
                    CqlInterval<CqlDateTime?>? jh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jg_);
                    CqlDateTime? ji_ = context.Operators.Start(jh_);
                    bool? jj_ = context.Operators.Not((bool?)((ji_ ?? io_) is null));
                    bool? jk_ = context.Operators.And(ja_, jj_);
                    bool? jl_ = context.Operators.And(hy_, jk_);
                    return jl_;
                }

                IEnumerable<Encounter?>? bq_ = context.Operators.Where<Encounter>(ar_, bp_);

                object? br_(Encounter? @this) {
                    Period? lu_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? lv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lu_);
                    CqlDateTime? lw_ = context.Operators.End(lv_);
                    return lw_;
                }

                IEnumerable<Encounter?>? bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? bt_ = context.Operators.Last<Encounter>(bs_);
                Period? bu_ = bt_?.Period;
                CqlInterval<CqlDateTime?>? bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime? bw_ = context.Operators.Start(bv_);

                bool? bx_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? lx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ly_ = lx_?.Value;
                    Code<Encounter.EncounterStatus>? lz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ly_);
                    bool? ma_ = context.Operators.Equal(lz_, "finished");
                    Period? mb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? mc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mb_);
                    CqlDateTime? md_ = context.Operators.End(mc_);
                    Period? me_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? mf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, me_);
                    CqlDateTime? mg_ = context.Operators.Start(mf_);
                    CqlQuantity? mh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? mi_ = context.Operators.Subtract(mg_, mh_);
                    CqlInterval<CqlDateTime?>? mj_ = context.Operators.Interval(mi_, mg_, true, true);
                    bool? mk_ = context.Operators.In<CqlDateTime>(md_, mj_, (string)default);
                    bool? ml_ = context.Operators.Not((bool?)(mg_ is null));
                    bool? mm_ = context.Operators.And(mk_, ml_);
                    bool? mn_ = context.Operators.And(ma_, mm_);
                    return mn_;
                }

                IEnumerable<Encounter?>? by_ = context.Operators.Where<Encounter>(bb_, bx_);

                object? bz_(Encounter? @this) {
                    Period? mo_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? mp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mo_);
                    CqlDateTime? mq_ = context.Operators.End(mp_);
                    return mq_;
                }

                IEnumerable<Encounter?>? ca_ = context.Operators.SortBy<Encounter>(by_, bz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? cb_ = context.Operators.Last<Encounter>(ca_);
                Period? cc_ = cb_?.Period;
                CqlInterval<CqlDateTime?>? cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime? ce_ = context.Operators.Start(cd_);
                CqlInterval<CqlDateTime?>? cf_ = context.Operators.Interval(bo_, bw_ ?? ce_ ?? bm_, true, true);
                bool? cg_ = context.Operators.In<CqlDateTime>(ap_, cf_, (string)default);

                bool? ch_(Encounter? LastED) {
                    Code<Encounter.EncounterStatus>? mr_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? ms_ = mr_?.Value;
                    Code<Encounter.EncounterStatus>? mt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ms_);
                    bool? mu_ = context.Operators.Equal(mt_, "finished");
                    Period? mv_ = LastED?.Period;
                    CqlInterval<CqlDateTime?>? mw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mv_);
                    CqlDateTime? mx_ = context.Operators.End(mw_);
                    CqlValueSet? my_ = this.Observation_Services(context);
                    IEnumerable<Encounter?>? mz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, my_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? na_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? oi_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? oj_ = oi_?.Value;
                        Code<Encounter.EncounterStatus>? ok_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(oj_);
                        bool? ol_ = context.Operators.Equal(ok_, "finished");
                        Period? om_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? on_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, om_);
                        CqlDateTime? oo_ = context.Operators.End(on_);
                        Period? op_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? oq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, op_);
                        CqlDateTime? or_ = context.Operators.Start(oq_);
                        CqlQuantity? os_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? ot_ = context.Operators.Subtract(or_, os_);
                        CqlInterval<CqlDateTime?>? ou_ = context.Operators.Interval(ot_, or_, true, true);
                        bool? ov_ = context.Operators.In<CqlDateTime>(oo_, ou_, (string)default);
                        bool? ow_ = context.Operators.Not((bool?)(or_ is null));
                        bool? ox_ = context.Operators.And(ov_, ow_);
                        bool? oy_ = context.Operators.And(ol_, ox_);
                        return oy_;
                    }

                    IEnumerable<Encounter?>? nb_ = context.Operators.Where<Encounter>(mz_, na_);

                    object? nc_(Encounter? @this) {
                        Period? oz_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? pa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oz_);
                        CqlDateTime? pb_ = context.Operators.End(pa_);
                        return pb_;
                    }

                    IEnumerable<Encounter?>? nd_ = context.Operators.SortBy<Encounter>(nb_, nc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? ne_ = context.Operators.Last<Encounter>(nd_);
                    Period? nf_ = ne_?.Period;
                    CqlInterval<CqlDateTime?>? ng_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nf_);
                    CqlDateTime? nh_ = context.Operators.Start(ng_);
                    Period? ni_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? nj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ni_);
                    CqlDateTime? nk_ = context.Operators.Start(nj_);
                    CqlQuantity? nl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? nm_ = context.Operators.Subtract(nh_ ?? nk_, nl_);

                    bool? nn_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? pc_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pd_ = pc_?.Value;
                        Code<Encounter.EncounterStatus>? pe_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pd_);
                        bool? pf_ = context.Operators.Equal(pe_, "finished");
                        Period? pg_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? ph_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pg_);
                        CqlDateTime? pi_ = context.Operators.End(ph_);
                        Period? pj_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? pk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pj_);
                        CqlDateTime? pl_ = context.Operators.Start(pk_);
                        CqlQuantity? pm_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? pn_ = context.Operators.Subtract(pl_, pm_);
                        CqlInterval<CqlDateTime?>? po_ = context.Operators.Interval(pn_, pl_, true, true);
                        bool? pp_ = context.Operators.In<CqlDateTime>(pi_, po_, (string)default);
                        bool? pq_ = context.Operators.Not((bool?)(pl_ is null));
                        bool? pr_ = context.Operators.And(pp_, pq_);
                        bool? ps_ = context.Operators.And(pf_, pr_);
                        return ps_;
                    }

                    IEnumerable<Encounter?>? no_ = context.Operators.Where<Encounter>(mz_, nn_);

                    object? np_(Encounter? @this) {
                        Period? pt_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? pu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pt_);
                        CqlDateTime? pv_ = context.Operators.End(pu_);
                        return pv_;
                    }

                    IEnumerable<Encounter?>? nq_ = context.Operators.SortBy<Encounter>(no_, np_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? nr_ = context.Operators.Last<Encounter>(nq_);
                    Period? ns_ = nr_?.Period;
                    CqlInterval<CqlDateTime?>? nt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ns_);
                    CqlDateTime? nu_ = context.Operators.Start(nt_);
                    CqlInterval<CqlDateTime?>? nv_ = context.Operators.Interval(nm_, nu_ ?? nk_, true, true);
                    bool? nw_ = context.Operators.In<CqlDateTime>(mx_, nv_, (string)default);

                    bool? nx_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? pw_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? px_ = pw_?.Value;
                        Code<Encounter.EncounterStatus>? py_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(px_);
                        bool? pz_ = context.Operators.Equal(py_, "finished");
                        Period? qa_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? qb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qa_);
                        CqlDateTime? qc_ = context.Operators.End(qb_);
                        Period? qd_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? qe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qd_);
                        CqlDateTime? qf_ = context.Operators.Start(qe_);
                        CqlQuantity? qg_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? qh_ = context.Operators.Subtract(qf_, qg_);
                        CqlInterval<CqlDateTime?>? qi_ = context.Operators.Interval(qh_, qf_, true, true);
                        bool? qj_ = context.Operators.In<CqlDateTime>(qc_, qi_, (string)default);
                        bool? qk_ = context.Operators.Not((bool?)(qf_ is null));
                        bool? ql_ = context.Operators.And(qj_, qk_);
                        bool? qm_ = context.Operators.And(pz_, ql_);
                        return qm_;
                    }

                    IEnumerable<Encounter?>? ny_ = context.Operators.Where<Encounter>(mz_, nx_);

                    object? nz_(Encounter? @this) {
                        Period? qn_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? qo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qn_);
                        CqlDateTime? qp_ = context.Operators.End(qo_);
                        return qp_;
                    }

                    IEnumerable<Encounter?>? oa_ = context.Operators.SortBy<Encounter>(ny_, nz_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? ob_ = context.Operators.Last<Encounter>(oa_);
                    Period? oc_ = ob_?.Period;
                    CqlInterval<CqlDateTime?>? od_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oc_);
                    CqlDateTime? oe_ = context.Operators.Start(od_);
                    bool? of_ = context.Operators.Not((bool?)((oe_ ?? nk_) is null));
                    bool? og_ = context.Operators.And(nw_, of_);
                    bool? oh_ = context.Operators.And(mu_, og_);
                    return oh_;
                }

                IEnumerable<Encounter?>? ci_ = context.Operators.Where<Encounter>(ar_, ch_);

                object? cj_(Encounter? @this) {
                    Period? qq_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? qr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qq_);
                    CqlDateTime? qs_ = context.Operators.End(qr_);
                    return qs_;
                }

                IEnumerable<Encounter?>? ck_ = context.Operators.SortBy<Encounter>(ci_, cj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? cl_ = context.Operators.Last<Encounter>(ck_);
                Period? cm_ = cl_?.Period;
                CqlInterval<CqlDateTime?>? cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                CqlDateTime? co_ = context.Operators.Start(cn_);

                bool? cp_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? qt_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? qu_ = qt_?.Value;
                    Code<Encounter.EncounterStatus>? qv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qu_);
                    bool? qw_ = context.Operators.Equal(qv_, "finished");
                    Period? qx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? qy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qx_);
                    CqlDateTime? qz_ = context.Operators.End(qy_);
                    Period? ra_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? rb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ra_);
                    CqlDateTime? rc_ = context.Operators.Start(rb_);
                    CqlQuantity? rd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? re_ = context.Operators.Subtract(rc_, rd_);
                    CqlInterval<CqlDateTime?>? rf_ = context.Operators.Interval(re_, rc_, true, true);
                    bool? rg_ = context.Operators.In<CqlDateTime>(qz_, rf_, (string)default);
                    bool? rh_ = context.Operators.Not((bool?)(rc_ is null));
                    bool? ri_ = context.Operators.And(rg_, rh_);
                    bool? rj_ = context.Operators.And(qw_, ri_);
                    return rj_;
                }

                IEnumerable<Encounter?>? cq_ = context.Operators.Where<Encounter>(bb_, cp_);

                object? cr_(Encounter? @this) {
                    Period? rk_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? rl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rk_);
                    CqlDateTime? rm_ = context.Operators.End(rl_);
                    return rm_;
                }

                IEnumerable<Encounter?>? cs_ = context.Operators.SortBy<Encounter>(cq_, cr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? ct_ = context.Operators.Last<Encounter>(cs_);
                Period? cu_ = ct_?.Period;
                CqlInterval<CqlDateTime?>? cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cu_);
                CqlDateTime? cw_ = context.Operators.Start(cv_);
                bool? cx_ = context.Operators.Not((bool?)((co_ ?? cw_ ?? bm_) is null));
                bool? cy_ = context.Operators.And(cg_, cx_);
                return cy_;
            }

            IEnumerable<Encounter?>? h_ = context.Operators.Where<Encounter>(f_, g_);

            object? i_(Encounter? @this) {
                Period? rn_ = @this?.Period;
                CqlInterval<CqlDateTime?>? ro_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rn_);
                CqlDateTime? rp_ = context.Operators.End(ro_);
                return rp_;
            }

            IEnumerable<Encounter?>? j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter? k_ = context.Operators.Last<Encounter>(j_);
            Period? l_ = k_?.Period;
            CqlInterval<CqlDateTime?>? m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime? n_ = context.Operators.Start(m_);
            CqlValueSet? o_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter?>? p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter? LastED) {
                Code<Encounter.EncounterStatus>? rq_ = LastED?.StatusElement;
                Encounter.EncounterStatus? rr_ = rq_?.Value;
                Code<Encounter.EncounterStatus>? rs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rr_);
                bool? rt_ = context.Operators.Equal(rs_, "finished");
                Period? ru_ = LastED?.Period;
                CqlInterval<CqlDateTime?>? rv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ru_);
                CqlDateTime? rw_ = context.Operators.End(rv_);
                CqlValueSet? rx_ = this.Observation_Services(context);
                IEnumerable<Encounter?>? ry_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? rz_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? th_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ti_ = th_?.Value;
                    Code<Encounter.EncounterStatus>? tj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ti_);
                    bool? tk_ = context.Operators.Equal(tj_, "finished");
                    Period? tl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? tm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tl_);
                    CqlDateTime? tn_ = context.Operators.End(tm_);
                    Period? to_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? tp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, to_);
                    CqlDateTime? tq_ = context.Operators.Start(tp_);
                    CqlQuantity? tr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? ts_ = context.Operators.Subtract(tq_, tr_);
                    CqlInterval<CqlDateTime?>? tt_ = context.Operators.Interval(ts_, tq_, true, true);
                    bool? tu_ = context.Operators.In<CqlDateTime>(tn_, tt_, (string)default);
                    bool? tv_ = context.Operators.Not((bool?)(tq_ is null));
                    bool? tw_ = context.Operators.And(tu_, tv_);
                    bool? tx_ = context.Operators.And(tk_, tw_);
                    return tx_;
                }

                IEnumerable<Encounter?>? sa_ = context.Operators.Where<Encounter>(ry_, rz_);

                object? sb_(Encounter? @this) {
                    Period? ty_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? tz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ty_);
                    CqlDateTime? ua_ = context.Operators.End(tz_);
                    return ua_;
                }

                IEnumerable<Encounter?>? sc_ = context.Operators.SortBy<Encounter>(sa_, sb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? sd_ = context.Operators.Last<Encounter>(sc_);
                Period? se_ = sd_?.Period;
                CqlInterval<CqlDateTime?>? sf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, se_);
                CqlDateTime? sg_ = context.Operators.Start(sf_);
                Period? sh_ = Visit?.Period;
                CqlInterval<CqlDateTime?>? si_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sh_);
                CqlDateTime? sj_ = context.Operators.Start(si_);
                CqlQuantity? sk_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime? sl_ = context.Operators.Subtract(sg_ ?? sj_, sk_);

                bool? sm_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? ub_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? uc_ = ub_?.Value;
                    Code<Encounter.EncounterStatus>? ud_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uc_);
                    bool? ue_ = context.Operators.Equal(ud_, "finished");
                    Period? uf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? ug_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uf_);
                    CqlDateTime? uh_ = context.Operators.End(ug_);
                    Period? ui_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? uj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ui_);
                    CqlDateTime? uk_ = context.Operators.Start(uj_);
                    CqlQuantity? ul_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? um_ = context.Operators.Subtract(uk_, ul_);
                    CqlInterval<CqlDateTime?>? un_ = context.Operators.Interval(um_, uk_, true, true);
                    bool? uo_ = context.Operators.In<CqlDateTime>(uh_, un_, (string)default);
                    bool? up_ = context.Operators.Not((bool?)(uk_ is null));
                    bool? uq_ = context.Operators.And(uo_, up_);
                    bool? ur_ = context.Operators.And(ue_, uq_);
                    return ur_;
                }

                IEnumerable<Encounter?>? sn_ = context.Operators.Where<Encounter>(ry_, sm_);

                object? so_(Encounter? @this) {
                    Period? us_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? ut_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, us_);
                    CqlDateTime? uu_ = context.Operators.End(ut_);
                    return uu_;
                }

                IEnumerable<Encounter?>? sp_ = context.Operators.SortBy<Encounter>(sn_, so_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? sq_ = context.Operators.Last<Encounter>(sp_);
                Period? sr_ = sq_?.Period;
                CqlInterval<CqlDateTime?>? ss_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sr_);
                CqlDateTime? st_ = context.Operators.Start(ss_);
                CqlInterval<CqlDateTime?>? su_ = context.Operators.Interval(sl_, st_ ?? sj_, true, true);
                bool? sv_ = context.Operators.In<CqlDateTime>(rw_, su_, (string)default);

                bool? sw_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? uv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? uw_ = uv_?.Value;
                    Code<Encounter.EncounterStatus>? ux_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uw_);
                    bool? uy_ = context.Operators.Equal(ux_, "finished");
                    Period? uz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? va_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uz_);
                    CqlDateTime? vb_ = context.Operators.End(va_);
                    Period? vc_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? vd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vc_);
                    CqlDateTime? ve_ = context.Operators.Start(vd_);
                    CqlQuantity? vf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? vg_ = context.Operators.Subtract(ve_, vf_);
                    CqlInterval<CqlDateTime?>? vh_ = context.Operators.Interval(vg_, ve_, true, true);
                    bool? vi_ = context.Operators.In<CqlDateTime>(vb_, vh_, (string)default);
                    bool? vj_ = context.Operators.Not((bool?)(ve_ is null));
                    bool? vk_ = context.Operators.And(vi_, vj_);
                    bool? vl_ = context.Operators.And(uy_, vk_);
                    return vl_;
                }

                IEnumerable<Encounter?>? sx_ = context.Operators.Where<Encounter>(ry_, sw_);

                object? sy_(Encounter? @this) {
                    Period? vm_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? vn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vm_);
                    CqlDateTime? vo_ = context.Operators.End(vn_);
                    return vo_;
                }

                IEnumerable<Encounter?>? sz_ = context.Operators.SortBy<Encounter>(sx_, sy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? ta_ = context.Operators.Last<Encounter>(sz_);
                Period? tb_ = ta_?.Period;
                CqlInterval<CqlDateTime?>? tc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tb_);
                CqlDateTime? td_ = context.Operators.Start(tc_);
                bool? te_ = context.Operators.Not((bool?)((td_ ?? sj_) is null));
                bool? tf_ = context.Operators.And(sv_, te_);
                bool? tg_ = context.Operators.And(rt_, tf_);
                return tg_;
            }

            IEnumerable<Encounter?>? r_ = context.Operators.Where<Encounter>(p_, q_);

            object? s_(Encounter? @this) {
                Period? vp_ = @this?.Period;
                CqlInterval<CqlDateTime?>? vq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vp_);
                CqlDateTime? vr_ = context.Operators.End(vq_);
                return vr_;
            }

            IEnumerable<Encounter?>? t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter? u_ = context.Operators.Last<Encounter>(t_);
            Period? v_ = u_?.Period;
            CqlInterval<CqlDateTime?>? w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(w_);
            CqlValueSet? y_ = this.Observation_Services(context);
            IEnumerable<Encounter?>? z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? aa_(Encounter? LastObs) {
                Code<Encounter.EncounterStatus>? vs_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? vt_ = vs_?.Value;
                Code<Encounter.EncounterStatus>? vu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vt_);
                bool? vv_ = context.Operators.Equal(vu_, "finished");
                Period? vw_ = LastObs?.Period;
                CqlInterval<CqlDateTime?>? vx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vw_);
                CqlDateTime? vy_ = context.Operators.End(vx_);
                Period? vz_ = Visit?.Period;
                CqlInterval<CqlDateTime?>? wa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vz_);
                CqlDateTime? wb_ = context.Operators.Start(wa_);
                CqlQuantity? wc_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime? wd_ = context.Operators.Subtract(wb_, wc_);
                CqlInterval<CqlDateTime?>? we_ = context.Operators.Interval(wd_, wb_, true, true);
                bool? wf_ = context.Operators.In<CqlDateTime>(vy_, we_, (string)default);
                bool? wg_ = context.Operators.Not((bool?)(wb_ is null));
                bool? wh_ = context.Operators.And(wf_, wg_);
                bool? wi_ = context.Operators.And(vv_, wh_);
                return wi_;
            }

            IEnumerable<Encounter?>? ab_ = context.Operators.Where<Encounter>(z_, aa_);

            object? ac_(Encounter? @this) {
                Period? wj_ = @this?.Period;
                CqlInterval<CqlDateTime?>? wk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wj_);
                CqlDateTime? wl_ = context.Operators.End(wk_);
                return wl_;
            }

            IEnumerable<Encounter?>? ad_ = context.Operators.SortBy<Encounter>(ab_, ac_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter? ae_ = context.Operators.Last<Encounter>(ad_);
            Period? af_ = ae_?.Period;
            CqlInterval<CqlDateTime?>? ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
            CqlDateTime? ah_ = context.Operators.Start(ag_);
            Period? ai_ = Visit?.Period;
            CqlInterval<CqlDateTime?>? aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
            CqlDateTime? ak_ = context.Operators.Start(aj_);
            CqlDateTime? al_ = context.Operators.End(aj_);
            CqlInterval<CqlDateTime?>? am_ = context.Operators.Interval(n_ ?? x_ ?? ah_ ?? ak_, al_, true, true);
            return am_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter?>?)a_, b_);
        CqlInterval<CqlDateTime?>? d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("hospitalizationWithObservationAndOutpatientSurgeryService")]
    [CqlTag("description", "Hospitalization with Observation and Outpatient Surgery Service returns the total interval from the start of any immediately prior emergency department visit, outpatient surgery visit or observation visit to the discharge of the given encounter.")]
    public CqlInterval<CqlDateTime?>? hospitalizationWithObservationAndOutpatientSurgeryService(CqlContext context, Encounter? TheEncounter)
    {
        Encounter?[]? a_ = [
            TheEncounter,
        ];

        CqlInterval<CqlDateTime?>? b_(Encounter? Visit) {
            CqlValueSet? e_ = this.Outpatient_Surgery_Service(context);
            IEnumerable<Encounter?>? f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? g_(Encounter? LastSurgeryOP) {
                Period? an_ = LastSurgeryOP?.Period;
                CqlInterval<CqlDateTime?>? ao_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, an_);
                CqlDateTime? ap_ = context.Operators.End(ao_);
                CqlValueSet? aq_ = this.Emergency_Department_Visit(context);
                IEnumerable<Encounter?>? ar_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? as_(Encounter? LastED) {
                    Code<Encounter.EncounterStatus>? cz_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? da_ = cz_?.Value;
                    Code<Encounter.EncounterStatus>? db_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(da_);
                    bool? dc_ = context.Operators.Equal(db_, "finished");
                    Period? dd_ = LastED?.Period;
                    CqlInterval<CqlDateTime?>? de_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dd_);
                    CqlDateTime? df_ = context.Operators.End(de_);
                    CqlValueSet? dg_ = this.Observation_Services(context);
                    IEnumerable<Encounter?>? dh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, dg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? di_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? eq_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? er_ = eq_?.Value;
                        Code<Encounter.EncounterStatus>? es_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(er_);
                        bool? et_ = context.Operators.Equal(es_, "finished");
                        Period? eu_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? ev_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eu_);
                        CqlDateTime? ew_ = context.Operators.End(ev_);
                        Period? ex_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? ey_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ex_);
                        CqlDateTime? ez_ = context.Operators.Start(ey_);
                        CqlQuantity? fa_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? fb_ = context.Operators.Subtract(ez_, fa_);
                        CqlInterval<CqlDateTime?>? fc_ = context.Operators.Interval(fb_, ez_, true, true);
                        bool? fd_ = context.Operators.In<CqlDateTime>(ew_, fc_, (string)default);
                        bool? fe_ = context.Operators.Not((bool?)(ez_ is null));
                        bool? ff_ = context.Operators.And(fd_, fe_);
                        bool? fg_ = context.Operators.And(et_, ff_);
                        return fg_;
                    }

                    IEnumerable<Encounter?>? dj_ = context.Operators.Where<Encounter>(dh_, di_);

                    object? dk_(Encounter? @this) {
                        Period? fh_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? fi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fh_);
                        CqlDateTime? fj_ = context.Operators.End(fi_);
                        return fj_;
                    }

                    IEnumerable<Encounter?>? dl_ = context.Operators.SortBy<Encounter>(dj_, dk_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? dm_ = context.Operators.Last<Encounter>(dl_);
                    Period? dn_ = dm_?.Period;
                    CqlInterval<CqlDateTime?>? do_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dn_);
                    CqlDateTime? dp_ = context.Operators.Start(do_);
                    Period? dq_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? dr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dq_);
                    CqlDateTime? ds_ = context.Operators.Start(dr_);
                    CqlQuantity? dt_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? du_ = context.Operators.Subtract(dp_ ?? ds_, dt_);

                    bool? dv_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? fk_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? fl_ = fk_?.Value;
                        Code<Encounter.EncounterStatus>? fm_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(fl_);
                        bool? fn_ = context.Operators.Equal(fm_, "finished");
                        Period? fo_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? fp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fo_);
                        CqlDateTime? fq_ = context.Operators.End(fp_);
                        Period? fr_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? fs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fr_);
                        CqlDateTime? ft_ = context.Operators.Start(fs_);
                        CqlQuantity? fu_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? fv_ = context.Operators.Subtract(ft_, fu_);
                        CqlInterval<CqlDateTime?>? fw_ = context.Operators.Interval(fv_, ft_, true, true);
                        bool? fx_ = context.Operators.In<CqlDateTime>(fq_, fw_, (string)default);
                        bool? fy_ = context.Operators.Not((bool?)(ft_ is null));
                        bool? fz_ = context.Operators.And(fx_, fy_);
                        bool? ga_ = context.Operators.And(fn_, fz_);
                        return ga_;
                    }

                    IEnumerable<Encounter?>? dw_ = context.Operators.Where<Encounter>(dh_, dv_);

                    object? dx_(Encounter? @this) {
                        Period? gb_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? gc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gb_);
                        CqlDateTime? gd_ = context.Operators.End(gc_);
                        return gd_;
                    }

                    IEnumerable<Encounter?>? dy_ = context.Operators.SortBy<Encounter>(dw_, dx_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? dz_ = context.Operators.Last<Encounter>(dy_);
                    Period? ea_ = dz_?.Period;
                    CqlInterval<CqlDateTime?>? eb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ea_);
                    CqlDateTime? ec_ = context.Operators.Start(eb_);
                    CqlInterval<CqlDateTime?>? ed_ = context.Operators.Interval(du_, ec_ ?? ds_, true, true);
                    bool? ee_ = context.Operators.In<CqlDateTime>(df_, ed_, (string)default);

                    bool? ef_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? ge_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? gf_ = ge_?.Value;
                        Code<Encounter.EncounterStatus>? gg_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(gf_);
                        bool? gh_ = context.Operators.Equal(gg_, "finished");
                        Period? gi_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? gj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gi_);
                        CqlDateTime? gk_ = context.Operators.End(gj_);
                        Period? gl_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? gm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gl_);
                        CqlDateTime? gn_ = context.Operators.Start(gm_);
                        CqlQuantity? go_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? gp_ = context.Operators.Subtract(gn_, go_);
                        CqlInterval<CqlDateTime?>? gq_ = context.Operators.Interval(gp_, gn_, true, true);
                        bool? gr_ = context.Operators.In<CqlDateTime>(gk_, gq_, (string)default);
                        bool? gs_ = context.Operators.Not((bool?)(gn_ is null));
                        bool? gt_ = context.Operators.And(gr_, gs_);
                        bool? gu_ = context.Operators.And(gh_, gt_);
                        return gu_;
                    }

                    IEnumerable<Encounter?>? eg_ = context.Operators.Where<Encounter>(dh_, ef_);

                    object? eh_(Encounter? @this) {
                        Period? gv_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? gw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gv_);
                        CqlDateTime? gx_ = context.Operators.End(gw_);
                        return gx_;
                    }

                    IEnumerable<Encounter?>? ei_ = context.Operators.SortBy<Encounter>(eg_, eh_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? ej_ = context.Operators.Last<Encounter>(ei_);
                    Period? ek_ = ej_?.Period;
                    CqlInterval<CqlDateTime?>? el_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ek_);
                    CqlDateTime? em_ = context.Operators.Start(el_);
                    bool? en_ = context.Operators.Not((bool?)((em_ ?? ds_) is null));
                    bool? eo_ = context.Operators.And(ee_, en_);
                    bool? ep_ = context.Operators.And(dc_, eo_);
                    return ep_;
                }

                IEnumerable<Encounter?>? at_ = context.Operators.Where<Encounter>(ar_, as_);

                object? au_(Encounter? @this) {
                    Period? gy_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? gz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, gy_);
                    CqlDateTime? ha_ = context.Operators.End(gz_);
                    return ha_;
                }

                IEnumerable<Encounter?>? av_ = context.Operators.SortBy<Encounter>(at_, au_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? aw_ = context.Operators.Last<Encounter>(av_);
                Period? ax_ = aw_?.Period;
                CqlInterval<CqlDateTime?>? ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime? az_ = context.Operators.Start(ay_);
                CqlValueSet? ba_ = this.Observation_Services(context);
                IEnumerable<Encounter?>? bb_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ba_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bc_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? hb_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? hc_ = hb_?.Value;
                    Code<Encounter.EncounterStatus>? hd_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hc_);
                    bool? he_ = context.Operators.Equal(hd_, "finished");
                    Period? hf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? hg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hf_);
                    CqlDateTime? hh_ = context.Operators.End(hg_);
                    Period? hi_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? hj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hi_);
                    CqlDateTime? hk_ = context.Operators.Start(hj_);
                    CqlQuantity? hl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? hm_ = context.Operators.Subtract(hk_, hl_);
                    CqlInterval<CqlDateTime?>? hn_ = context.Operators.Interval(hm_, hk_, true, true);
                    bool? ho_ = context.Operators.In<CqlDateTime>(hh_, hn_, (string)default);
                    bool? hp_ = context.Operators.Not((bool?)(hk_ is null));
                    bool? hq_ = context.Operators.And(ho_, hp_);
                    bool? hr_ = context.Operators.And(he_, hq_);
                    return hr_;
                }

                IEnumerable<Encounter?>? bd_ = context.Operators.Where<Encounter>(bb_, bc_);

                object? be_(Encounter? @this) {
                    Period? hs_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? ht_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hs_);
                    CqlDateTime? hu_ = context.Operators.End(ht_);
                    return hu_;
                }

                IEnumerable<Encounter?>? bf_ = context.Operators.SortBy<Encounter>(bd_, be_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? bg_ = context.Operators.Last<Encounter>(bf_);
                Period? bh_ = bg_?.Period;
                CqlInterval<CqlDateTime?>? bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                CqlDateTime? bj_ = context.Operators.Start(bi_);
                Period? bk_ = Visit?.Period;
                CqlInterval<CqlDateTime?>? bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                CqlDateTime? bm_ = context.Operators.Start(bl_);
                CqlQuantity? bn_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime? bo_ = context.Operators.Subtract(az_ ?? bj_ ?? bm_, bn_);

                bool? bp_(Encounter? LastED) {
                    Code<Encounter.EncounterStatus>? hv_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? hw_ = hv_?.Value;
                    Code<Encounter.EncounterStatus>? hx_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(hw_);
                    bool? hy_ = context.Operators.Equal(hx_, "finished");
                    Period? hz_ = LastED?.Period;
                    CqlInterval<CqlDateTime?>? ia_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, hz_);
                    CqlDateTime? ib_ = context.Operators.End(ia_);
                    CqlValueSet? ic_ = this.Observation_Services(context);
                    IEnumerable<Encounter?>? id_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ic_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? ie_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? jm_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? jn_ = jm_?.Value;
                        Code<Encounter.EncounterStatus>? jo_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(jn_);
                        bool? jp_ = context.Operators.Equal(jo_, "finished");
                        Period? jq_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? jr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jq_);
                        CqlDateTime? js_ = context.Operators.End(jr_);
                        Period? jt_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? ju_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jt_);
                        CqlDateTime? jv_ = context.Operators.Start(ju_);
                        CqlQuantity? jw_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? jx_ = context.Operators.Subtract(jv_, jw_);
                        CqlInterval<CqlDateTime?>? jy_ = context.Operators.Interval(jx_, jv_, true, true);
                        bool? jz_ = context.Operators.In<CqlDateTime>(js_, jy_, (string)default);
                        bool? ka_ = context.Operators.Not((bool?)(jv_ is null));
                        bool? kb_ = context.Operators.And(jz_, ka_);
                        bool? kc_ = context.Operators.And(jp_, kb_);
                        return kc_;
                    }

                    IEnumerable<Encounter?>? if_ = context.Operators.Where<Encounter>(id_, ie_);

                    object? ig_(Encounter? @this) {
                        Period? kd_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? ke_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kd_);
                        CqlDateTime? kf_ = context.Operators.End(ke_);
                        return kf_;
                    }

                    IEnumerable<Encounter?>? ih_ = context.Operators.SortBy<Encounter>(if_, ig_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? ii_ = context.Operators.Last<Encounter>(ih_);
                    Period? ij_ = ii_?.Period;
                    CqlInterval<CqlDateTime?>? ik_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ij_);
                    CqlDateTime? il_ = context.Operators.Start(ik_);
                    Period? im_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? in_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, im_);
                    CqlDateTime? io_ = context.Operators.Start(in_);
                    CqlQuantity? ip_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? iq_ = context.Operators.Subtract(il_ ?? io_, ip_);

                    bool? ir_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? kg_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? kh_ = kg_?.Value;
                        Code<Encounter.EncounterStatus>? ki_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(kh_);
                        bool? kj_ = context.Operators.Equal(ki_, "finished");
                        Period? kk_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? kl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kk_);
                        CqlDateTime? km_ = context.Operators.End(kl_);
                        Period? kn_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? ko_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kn_);
                        CqlDateTime? kp_ = context.Operators.Start(ko_);
                        CqlQuantity? kq_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? kr_ = context.Operators.Subtract(kp_, kq_);
                        CqlInterval<CqlDateTime?>? ks_ = context.Operators.Interval(kr_, kp_, true, true);
                        bool? kt_ = context.Operators.In<CqlDateTime>(km_, ks_, (string)default);
                        bool? ku_ = context.Operators.Not((bool?)(kp_ is null));
                        bool? kv_ = context.Operators.And(kt_, ku_);
                        bool? kw_ = context.Operators.And(kj_, kv_);
                        return kw_;
                    }

                    IEnumerable<Encounter?>? is_ = context.Operators.Where<Encounter>(id_, ir_);

                    object? it_(Encounter? @this) {
                        Period? kx_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? ky_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, kx_);
                        CqlDateTime? kz_ = context.Operators.End(ky_);
                        return kz_;
                    }

                    IEnumerable<Encounter?>? iu_ = context.Operators.SortBy<Encounter>(is_, it_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? iv_ = context.Operators.Last<Encounter>(iu_);
                    Period? iw_ = iv_?.Period;
                    CqlInterval<CqlDateTime?>? ix_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, iw_);
                    CqlDateTime? iy_ = context.Operators.Start(ix_);
                    CqlInterval<CqlDateTime?>? iz_ = context.Operators.Interval(iq_, iy_ ?? io_, true, true);
                    bool? ja_ = context.Operators.In<CqlDateTime>(ib_, iz_, (string)default);

                    bool? jb_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? la_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? lb_ = la_?.Value;
                        Code<Encounter.EncounterStatus>? lc_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(lb_);
                        bool? ld_ = context.Operators.Equal(lc_, "finished");
                        Period? le_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? lf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, le_);
                        CqlDateTime? lg_ = context.Operators.End(lf_);
                        Period? lh_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? li_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lh_);
                        CqlDateTime? lj_ = context.Operators.Start(li_);
                        CqlQuantity? lk_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? ll_ = context.Operators.Subtract(lj_, lk_);
                        CqlInterval<CqlDateTime?>? lm_ = context.Operators.Interval(ll_, lj_, true, true);
                        bool? ln_ = context.Operators.In<CqlDateTime>(lg_, lm_, (string)default);
                        bool? lo_ = context.Operators.Not((bool?)(lj_ is null));
                        bool? lp_ = context.Operators.And(ln_, lo_);
                        bool? lq_ = context.Operators.And(ld_, lp_);
                        return lq_;
                    }

                    IEnumerable<Encounter?>? jc_ = context.Operators.Where<Encounter>(id_, jb_);

                    object? jd_(Encounter? @this) {
                        Period? lr_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? ls_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lr_);
                        CqlDateTime? lt_ = context.Operators.End(ls_);
                        return lt_;
                    }

                    IEnumerable<Encounter?>? je_ = context.Operators.SortBy<Encounter>(jc_, jd_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? jf_ = context.Operators.Last<Encounter>(je_);
                    Period? jg_ = jf_?.Period;
                    CqlInterval<CqlDateTime?>? jh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, jg_);
                    CqlDateTime? ji_ = context.Operators.Start(jh_);
                    bool? jj_ = context.Operators.Not((bool?)((ji_ ?? io_) is null));
                    bool? jk_ = context.Operators.And(ja_, jj_);
                    bool? jl_ = context.Operators.And(hy_, jk_);
                    return jl_;
                }

                IEnumerable<Encounter?>? bq_ = context.Operators.Where<Encounter>(ar_, bp_);

                object? br_(Encounter? @this) {
                    Period? lu_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? lv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, lu_);
                    CqlDateTime? lw_ = context.Operators.End(lv_);
                    return lw_;
                }

                IEnumerable<Encounter?>? bs_ = context.Operators.SortBy<Encounter>(bq_, br_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? bt_ = context.Operators.Last<Encounter>(bs_);
                Period? bu_ = bt_?.Period;
                CqlInterval<CqlDateTime?>? bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime? bw_ = context.Operators.Start(bv_);

                bool? bx_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? lx_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ly_ = lx_?.Value;
                    Code<Encounter.EncounterStatus>? lz_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ly_);
                    bool? ma_ = context.Operators.Equal(lz_, "finished");
                    Period? mb_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? mc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mb_);
                    CqlDateTime? md_ = context.Operators.End(mc_);
                    Period? me_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? mf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, me_);
                    CqlDateTime? mg_ = context.Operators.Start(mf_);
                    CqlQuantity? mh_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? mi_ = context.Operators.Subtract(mg_, mh_);
                    CqlInterval<CqlDateTime?>? mj_ = context.Operators.Interval(mi_, mg_, true, true);
                    bool? mk_ = context.Operators.In<CqlDateTime>(md_, mj_, (string)default);
                    bool? ml_ = context.Operators.Not((bool?)(mg_ is null));
                    bool? mm_ = context.Operators.And(mk_, ml_);
                    bool? mn_ = context.Operators.And(ma_, mm_);
                    return mn_;
                }

                IEnumerable<Encounter?>? by_ = context.Operators.Where<Encounter>(bb_, bx_);

                object? bz_(Encounter? @this) {
                    Period? mo_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? mp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mo_);
                    CqlDateTime? mq_ = context.Operators.End(mp_);
                    return mq_;
                }

                IEnumerable<Encounter?>? ca_ = context.Operators.SortBy<Encounter>(by_, bz_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? cb_ = context.Operators.Last<Encounter>(ca_);
                Period? cc_ = cb_?.Period;
                CqlInterval<CqlDateTime?>? cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime? ce_ = context.Operators.Start(cd_);
                CqlInterval<CqlDateTime?>? cf_ = context.Operators.Interval(bo_, bw_ ?? ce_ ?? bm_, true, true);
                bool? cg_ = context.Operators.In<CqlDateTime>(ap_, cf_, (string)default);

                bool? ch_(Encounter? LastED) {
                    Code<Encounter.EncounterStatus>? mr_ = LastED?.StatusElement;
                    Encounter.EncounterStatus? ms_ = mr_?.Value;
                    Code<Encounter.EncounterStatus>? mt_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ms_);
                    bool? mu_ = context.Operators.Equal(mt_, "finished");
                    Period? mv_ = LastED?.Period;
                    CqlInterval<CqlDateTime?>? mw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, mv_);
                    CqlDateTime? mx_ = context.Operators.End(mw_);
                    CqlValueSet? my_ = this.Observation_Services(context);
                    IEnumerable<Encounter?>? mz_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, my_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                    bool? na_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? oi_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? oj_ = oi_?.Value;
                        Code<Encounter.EncounterStatus>? ok_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(oj_);
                        bool? ol_ = context.Operators.Equal(ok_, "finished");
                        Period? om_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? on_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, om_);
                        CqlDateTime? oo_ = context.Operators.End(on_);
                        Period? op_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? oq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, op_);
                        CqlDateTime? or_ = context.Operators.Start(oq_);
                        CqlQuantity? os_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? ot_ = context.Operators.Subtract(or_, os_);
                        CqlInterval<CqlDateTime?>? ou_ = context.Operators.Interval(ot_, or_, true, true);
                        bool? ov_ = context.Operators.In<CqlDateTime>(oo_, ou_, (string)default);
                        bool? ow_ = context.Operators.Not((bool?)(or_ is null));
                        bool? ox_ = context.Operators.And(ov_, ow_);
                        bool? oy_ = context.Operators.And(ol_, ox_);
                        return oy_;
                    }

                    IEnumerable<Encounter?>? nb_ = context.Operators.Where<Encounter>(mz_, na_);

                    object? nc_(Encounter? @this) {
                        Period? oz_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? pa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oz_);
                        CqlDateTime? pb_ = context.Operators.End(pa_);
                        return pb_;
                    }

                    IEnumerable<Encounter?>? nd_ = context.Operators.SortBy<Encounter>(nb_, nc_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? ne_ = context.Operators.Last<Encounter>(nd_);
                    Period? nf_ = ne_?.Period;
                    CqlInterval<CqlDateTime?>? ng_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, nf_);
                    CqlDateTime? nh_ = context.Operators.Start(ng_);
                    Period? ni_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? nj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ni_);
                    CqlDateTime? nk_ = context.Operators.Start(nj_);
                    CqlQuantity? nl_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? nm_ = context.Operators.Subtract(nh_ ?? nk_, nl_);

                    bool? nn_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? pc_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? pd_ = pc_?.Value;
                        Code<Encounter.EncounterStatus>? pe_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(pd_);
                        bool? pf_ = context.Operators.Equal(pe_, "finished");
                        Period? pg_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? ph_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pg_);
                        CqlDateTime? pi_ = context.Operators.End(ph_);
                        Period? pj_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? pk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pj_);
                        CqlDateTime? pl_ = context.Operators.Start(pk_);
                        CqlQuantity? pm_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? pn_ = context.Operators.Subtract(pl_, pm_);
                        CqlInterval<CqlDateTime?>? po_ = context.Operators.Interval(pn_, pl_, true, true);
                        bool? pp_ = context.Operators.In<CqlDateTime>(pi_, po_, (string)default);
                        bool? pq_ = context.Operators.Not((bool?)(pl_ is null));
                        bool? pr_ = context.Operators.And(pp_, pq_);
                        bool? ps_ = context.Operators.And(pf_, pr_);
                        return ps_;
                    }

                    IEnumerable<Encounter?>? no_ = context.Operators.Where<Encounter>(mz_, nn_);

                    object? np_(Encounter? @this) {
                        Period? pt_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? pu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, pt_);
                        CqlDateTime? pv_ = context.Operators.End(pu_);
                        return pv_;
                    }

                    IEnumerable<Encounter?>? nq_ = context.Operators.SortBy<Encounter>(no_, np_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? nr_ = context.Operators.Last<Encounter>(nq_);
                    Period? ns_ = nr_?.Period;
                    CqlInterval<CqlDateTime?>? nt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ns_);
                    CqlDateTime? nu_ = context.Operators.Start(nt_);
                    CqlInterval<CqlDateTime?>? nv_ = context.Operators.Interval(nm_, nu_ ?? nk_, true, true);
                    bool? nw_ = context.Operators.In<CqlDateTime>(mx_, nv_, (string)default);

                    bool? nx_(Encounter? LastObs) {
                        Code<Encounter.EncounterStatus>? pw_ = LastObs?.StatusElement;
                        Encounter.EncounterStatus? px_ = pw_?.Value;
                        Code<Encounter.EncounterStatus>? py_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(px_);
                        bool? pz_ = context.Operators.Equal(py_, "finished");
                        Period? qa_ = LastObs?.Period;
                        CqlInterval<CqlDateTime?>? qb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qa_);
                        CqlDateTime? qc_ = context.Operators.End(qb_);
                        Period? qd_ = Visit?.Period;
                        CqlInterval<CqlDateTime?>? qe_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qd_);
                        CqlDateTime? qf_ = context.Operators.Start(qe_);
                        CqlQuantity? qg_ = context.Operators.Quantity(1m, "hour");
                        CqlDateTime? qh_ = context.Operators.Subtract(qf_, qg_);
                        CqlInterval<CqlDateTime?>? qi_ = context.Operators.Interval(qh_, qf_, true, true);
                        bool? qj_ = context.Operators.In<CqlDateTime>(qc_, qi_, (string)default);
                        bool? qk_ = context.Operators.Not((bool?)(qf_ is null));
                        bool? ql_ = context.Operators.And(qj_, qk_);
                        bool? qm_ = context.Operators.And(pz_, ql_);
                        return qm_;
                    }

                    IEnumerable<Encounter?>? ny_ = context.Operators.Where<Encounter>(mz_, nx_);

                    object? nz_(Encounter? @this) {
                        Period? qn_ = @this?.Period;
                        CqlInterval<CqlDateTime?>? qo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qn_);
                        CqlDateTime? qp_ = context.Operators.End(qo_);
                        return qp_;
                    }

                    IEnumerable<Encounter?>? oa_ = context.Operators.SortBy<Encounter>(ny_, nz_, System.ComponentModel.ListSortDirection.Ascending);
                    Encounter? ob_ = context.Operators.Last<Encounter>(oa_);
                    Period? oc_ = ob_?.Period;
                    CqlInterval<CqlDateTime?>? od_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, oc_);
                    CqlDateTime? oe_ = context.Operators.Start(od_);
                    bool? of_ = context.Operators.Not((bool?)((oe_ ?? nk_) is null));
                    bool? og_ = context.Operators.And(nw_, of_);
                    bool? oh_ = context.Operators.And(mu_, og_);
                    return oh_;
                }

                IEnumerable<Encounter?>? ci_ = context.Operators.Where<Encounter>(ar_, ch_);

                object? cj_(Encounter? @this) {
                    Period? qq_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? qr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qq_);
                    CqlDateTime? qs_ = context.Operators.End(qr_);
                    return qs_;
                }

                IEnumerable<Encounter?>? ck_ = context.Operators.SortBy<Encounter>(ci_, cj_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? cl_ = context.Operators.Last<Encounter>(ck_);
                Period? cm_ = cl_?.Period;
                CqlInterval<CqlDateTime?>? cn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cm_);
                CqlDateTime? co_ = context.Operators.Start(cn_);

                bool? cp_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? qt_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? qu_ = qt_?.Value;
                    Code<Encounter.EncounterStatus>? qv_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(qu_);
                    bool? qw_ = context.Operators.Equal(qv_, "finished");
                    Period? qx_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? qy_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, qx_);
                    CqlDateTime? qz_ = context.Operators.End(qy_);
                    Period? ra_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? rb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ra_);
                    CqlDateTime? rc_ = context.Operators.Start(rb_);
                    CqlQuantity? rd_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? re_ = context.Operators.Subtract(rc_, rd_);
                    CqlInterval<CqlDateTime?>? rf_ = context.Operators.Interval(re_, rc_, true, true);
                    bool? rg_ = context.Operators.In<CqlDateTime>(qz_, rf_, (string)default);
                    bool? rh_ = context.Operators.Not((bool?)(rc_ is null));
                    bool? ri_ = context.Operators.And(rg_, rh_);
                    bool? rj_ = context.Operators.And(qw_, ri_);
                    return rj_;
                }

                IEnumerable<Encounter?>? cq_ = context.Operators.Where<Encounter>(bb_, cp_);

                object? cr_(Encounter? @this) {
                    Period? rk_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? rl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rk_);
                    CqlDateTime? rm_ = context.Operators.End(rl_);
                    return rm_;
                }

                IEnumerable<Encounter?>? cs_ = context.Operators.SortBy<Encounter>(cq_, cr_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? ct_ = context.Operators.Last<Encounter>(cs_);
                Period? cu_ = ct_?.Period;
                CqlInterval<CqlDateTime?>? cv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cu_);
                CqlDateTime? cw_ = context.Operators.Start(cv_);
                bool? cx_ = context.Operators.Not((bool?)((co_ ?? cw_ ?? bm_) is null));
                bool? cy_ = context.Operators.And(cg_, cx_);
                return cy_;
            }

            IEnumerable<Encounter?>? h_ = context.Operators.Where<Encounter>(f_, g_);

            object? i_(Encounter? @this) {
                Period? rn_ = @this?.Period;
                CqlInterval<CqlDateTime?>? ro_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, rn_);
                CqlDateTime? rp_ = context.Operators.End(ro_);
                return rp_;
            }

            IEnumerable<Encounter?>? j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter? k_ = context.Operators.Last<Encounter>(j_);
            Period? l_ = k_?.Period;
            CqlInterval<CqlDateTime?>? m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime? n_ = context.Operators.Start(m_);
            CqlValueSet? o_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter?>? p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter? LastED) {
                Code<Encounter.EncounterStatus>? rq_ = LastED?.StatusElement;
                Encounter.EncounterStatus? rr_ = rq_?.Value;
                Code<Encounter.EncounterStatus>? rs_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(rr_);
                bool? rt_ = context.Operators.Equal(rs_, "finished");
                Period? ru_ = LastED?.Period;
                CqlInterval<CqlDateTime?>? rv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ru_);
                CqlDateTime? rw_ = context.Operators.End(rv_);
                CqlValueSet? rx_ = this.Observation_Services(context);
                IEnumerable<Encounter?>? ry_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, rx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? rz_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? th_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? ti_ = th_?.Value;
                    Code<Encounter.EncounterStatus>? tj_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ti_);
                    bool? tk_ = context.Operators.Equal(tj_, "finished");
                    Period? tl_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? tm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tl_);
                    CqlDateTime? tn_ = context.Operators.End(tm_);
                    Period? to_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? tp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, to_);
                    CqlDateTime? tq_ = context.Operators.Start(tp_);
                    CqlQuantity? tr_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? ts_ = context.Operators.Subtract(tq_, tr_);
                    CqlInterval<CqlDateTime?>? tt_ = context.Operators.Interval(ts_, tq_, true, true);
                    bool? tu_ = context.Operators.In<CqlDateTime>(tn_, tt_, (string)default);
                    bool? tv_ = context.Operators.Not((bool?)(tq_ is null));
                    bool? tw_ = context.Operators.And(tu_, tv_);
                    bool? tx_ = context.Operators.And(tk_, tw_);
                    return tx_;
                }

                IEnumerable<Encounter?>? sa_ = context.Operators.Where<Encounter>(ry_, rz_);

                object? sb_(Encounter? @this) {
                    Period? ty_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? tz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ty_);
                    CqlDateTime? ua_ = context.Operators.End(tz_);
                    return ua_;
                }

                IEnumerable<Encounter?>? sc_ = context.Operators.SortBy<Encounter>(sa_, sb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? sd_ = context.Operators.Last<Encounter>(sc_);
                Period? se_ = sd_?.Period;
                CqlInterval<CqlDateTime?>? sf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, se_);
                CqlDateTime? sg_ = context.Operators.Start(sf_);
                Period? sh_ = Visit?.Period;
                CqlInterval<CqlDateTime?>? si_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sh_);
                CqlDateTime? sj_ = context.Operators.Start(si_);
                CqlQuantity? sk_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime? sl_ = context.Operators.Subtract(sg_ ?? sj_, sk_);

                bool? sm_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? ub_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? uc_ = ub_?.Value;
                    Code<Encounter.EncounterStatus>? ud_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uc_);
                    bool? ue_ = context.Operators.Equal(ud_, "finished");
                    Period? uf_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? ug_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uf_);
                    CqlDateTime? uh_ = context.Operators.End(ug_);
                    Period? ui_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? uj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ui_);
                    CqlDateTime? uk_ = context.Operators.Start(uj_);
                    CqlQuantity? ul_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? um_ = context.Operators.Subtract(uk_, ul_);
                    CqlInterval<CqlDateTime?>? un_ = context.Operators.Interval(um_, uk_, true, true);
                    bool? uo_ = context.Operators.In<CqlDateTime>(uh_, un_, (string)default);
                    bool? up_ = context.Operators.Not((bool?)(uk_ is null));
                    bool? uq_ = context.Operators.And(uo_, up_);
                    bool? ur_ = context.Operators.And(ue_, uq_);
                    return ur_;
                }

                IEnumerable<Encounter?>? sn_ = context.Operators.Where<Encounter>(ry_, sm_);

                object? so_(Encounter? @this) {
                    Period? us_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? ut_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, us_);
                    CqlDateTime? uu_ = context.Operators.End(ut_);
                    return uu_;
                }

                IEnumerable<Encounter?>? sp_ = context.Operators.SortBy<Encounter>(sn_, so_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? sq_ = context.Operators.Last<Encounter>(sp_);
                Period? sr_ = sq_?.Period;
                CqlInterval<CqlDateTime?>? ss_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, sr_);
                CqlDateTime? st_ = context.Operators.Start(ss_);
                CqlInterval<CqlDateTime?>? su_ = context.Operators.Interval(sl_, st_ ?? sj_, true, true);
                bool? sv_ = context.Operators.In<CqlDateTime>(rw_, su_, (string)default);

                bool? sw_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? uv_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? uw_ = uv_?.Value;
                    Code<Encounter.EncounterStatus>? ux_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(uw_);
                    bool? uy_ = context.Operators.Equal(ux_, "finished");
                    Period? uz_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? va_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, uz_);
                    CqlDateTime? vb_ = context.Operators.End(va_);
                    Period? vc_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? vd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vc_);
                    CqlDateTime? ve_ = context.Operators.Start(vd_);
                    CqlQuantity? vf_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? vg_ = context.Operators.Subtract(ve_, vf_);
                    CqlInterval<CqlDateTime?>? vh_ = context.Operators.Interval(vg_, ve_, true, true);
                    bool? vi_ = context.Operators.In<CqlDateTime>(vb_, vh_, (string)default);
                    bool? vj_ = context.Operators.Not((bool?)(ve_ is null));
                    bool? vk_ = context.Operators.And(vi_, vj_);
                    bool? vl_ = context.Operators.And(uy_, vk_);
                    return vl_;
                }

                IEnumerable<Encounter?>? sx_ = context.Operators.Where<Encounter>(ry_, sw_);

                object? sy_(Encounter? @this) {
                    Period? vm_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? vn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vm_);
                    CqlDateTime? vo_ = context.Operators.End(vn_);
                    return vo_;
                }

                IEnumerable<Encounter?>? sz_ = context.Operators.SortBy<Encounter>(sx_, sy_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? ta_ = context.Operators.Last<Encounter>(sz_);
                Period? tb_ = ta_?.Period;
                CqlInterval<CqlDateTime?>? tc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, tb_);
                CqlDateTime? td_ = context.Operators.Start(tc_);
                bool? te_ = context.Operators.Not((bool?)((td_ ?? sj_) is null));
                bool? tf_ = context.Operators.And(sv_, te_);
                bool? tg_ = context.Operators.And(rt_, tf_);
                return tg_;
            }

            IEnumerable<Encounter?>? r_ = context.Operators.Where<Encounter>(p_, q_);

            object? s_(Encounter? @this) {
                Period? vp_ = @this?.Period;
                CqlInterval<CqlDateTime?>? vq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vp_);
                CqlDateTime? vr_ = context.Operators.End(vq_);
                return vr_;
            }

            IEnumerable<Encounter?>? t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter? u_ = context.Operators.Last<Encounter>(t_);
            Period? v_ = u_?.Period;
            CqlInterval<CqlDateTime?>? w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(w_);
            CqlValueSet? y_ = this.Observation_Services(context);
            IEnumerable<Encounter?>? z_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, y_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? aa_(Encounter? LastObs) {
                Code<Encounter.EncounterStatus>? vs_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? vt_ = vs_?.Value;
                Code<Encounter.EncounterStatus>? vu_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(vt_);
                bool? vv_ = context.Operators.Equal(vu_, "finished");
                Period? vw_ = LastObs?.Period;
                CqlInterval<CqlDateTime?>? vx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vw_);
                CqlDateTime? vy_ = context.Operators.End(vx_);
                Period? vz_ = Visit?.Period;
                CqlInterval<CqlDateTime?>? wa_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vz_);
                CqlDateTime? wb_ = context.Operators.Start(wa_);
                CqlQuantity? wc_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime? wd_ = context.Operators.Subtract(wb_, wc_);
                CqlInterval<CqlDateTime?>? we_ = context.Operators.Interval(wd_, wb_, true, true);
                bool? wf_ = context.Operators.In<CqlDateTime>(vy_, we_, (string)default);
                bool? wg_ = context.Operators.Not((bool?)(wb_ is null));
                bool? wh_ = context.Operators.And(wf_, wg_);
                bool? wi_ = context.Operators.And(vv_, wh_);
                return wi_;
            }

            IEnumerable<Encounter?>? ab_ = context.Operators.Where<Encounter>(z_, aa_);

            object? ac_(Encounter? @this) {
                Period? wj_ = @this?.Period;
                CqlInterval<CqlDateTime?>? wk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wj_);
                CqlDateTime? wl_ = context.Operators.End(wk_);
                return wl_;
            }

            IEnumerable<Encounter?>? ad_ = context.Operators.SortBy<Encounter>(ab_, ac_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter? ae_ = context.Operators.Last<Encounter>(ad_);
            Period? af_ = ae_?.Period;
            CqlInterval<CqlDateTime?>? ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
            CqlDateTime? ah_ = context.Operators.Start(ag_);
            Period? ai_ = Visit?.Period;
            CqlInterval<CqlDateTime?>? aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
            CqlDateTime? ak_ = context.Operators.Start(aj_);
            CqlDateTime? al_ = context.Operators.End(aj_);
            CqlInterval<CqlDateTime?>? am_ = context.Operators.Interval(n_ ?? x_ ?? ah_ ?? ak_, al_, true, true);
            return am_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter?>?)a_, b_);
        CqlInterval<CqlDateTime?>? d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservation()` instead.")]
    public CqlInterval<CqlDateTime?>? HospitalizationWithObservation(CqlContext context, Encounter? TheEncounter)
    {
        Encounter?[]? a_ = [
            TheEncounter,
        ];

        CqlInterval<CqlDateTime?>? b_(Encounter? Visit) {
            CqlValueSet? e_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter?>? f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? g_(Encounter? LastED) {
                Code<Encounter.EncounterStatus>? ad_ = LastED?.StatusElement;
                Encounter.EncounterStatus? ae_ = ad_?.Value;
                Code<Encounter.EncounterStatus>? af_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ae_);
                bool? ag_ = context.Operators.Equal(af_, "finished");
                Period? ah_ = LastED?.Period;
                CqlInterval<CqlDateTime?>? ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                CqlDateTime? aj_ = context.Operators.End(ai_);
                CqlValueSet? ak_ = this.Observation_Services(context);
                IEnumerable<Encounter?>? al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? am_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? bu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? bv_ = bu_?.Value;
                    Code<Encounter.EncounterStatus>? bw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bv_);
                    bool? bx_ = context.Operators.Equal(bw_, "finished");
                    Period? by_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? bz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, by_);
                    CqlDateTime? ca_ = context.Operators.End(bz_);
                    Period? cb_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                    CqlDateTime? cd_ = context.Operators.Start(cc_);
                    CqlQuantity? ce_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? cf_ = context.Operators.Subtract(cd_, ce_);
                    CqlInterval<CqlDateTime?>? cg_ = context.Operators.Interval(cf_, cd_, true, true);
                    bool? ch_ = context.Operators.In<CqlDateTime>(ca_, cg_, (string)default);
                    bool? ci_ = context.Operators.Not((bool?)(cd_ is null));
                    bool? cj_ = context.Operators.And(ch_, ci_);
                    bool? ck_ = context.Operators.And(bx_, cj_);
                    return ck_;
                }

                IEnumerable<Encounter?>? an_ = context.Operators.Where<Encounter>(al_, am_);

                object? ao_(Encounter? @this) {
                    Period? cl_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? cm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cl_);
                    CqlDateTime? cn_ = context.Operators.End(cm_);
                    return cn_;
                }

                IEnumerable<Encounter?>? ap_ = context.Operators.SortBy<Encounter>(an_, ao_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? aq_ = context.Operators.Last<Encounter>(ap_);
                Period? ar_ = aq_?.Period;
                CqlInterval<CqlDateTime?>? as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                CqlDateTime? at_ = context.Operators.Start(as_);
                Period? au_ = Visit?.Period;
                CqlInterval<CqlDateTime?>? av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime? aw_ = context.Operators.Start(av_);
                CqlQuantity? ax_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime? ay_ = context.Operators.Subtract(at_ ?? aw_, ax_);

                bool? az_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? co_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? cp_ = co_?.Value;
                    Code<Encounter.EncounterStatus>? cq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cp_);
                    bool? cr_ = context.Operators.Equal(cq_, "finished");
                    Period? cs_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? ct_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cs_);
                    CqlDateTime? cu_ = context.Operators.End(ct_);
                    Period? cv_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                    CqlDateTime? cx_ = context.Operators.Start(cw_);
                    CqlQuantity? cy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? cz_ = context.Operators.Subtract(cx_, cy_);
                    CqlInterval<CqlDateTime?>? da_ = context.Operators.Interval(cz_, cx_, true, true);
                    bool? db_ = context.Operators.In<CqlDateTime>(cu_, da_, (string)default);
                    bool? dc_ = context.Operators.Not((bool?)(cx_ is null));
                    bool? dd_ = context.Operators.And(db_, dc_);
                    bool? de_ = context.Operators.And(cr_, dd_);
                    return de_;
                }

                IEnumerable<Encounter?>? ba_ = context.Operators.Where<Encounter>(al_, az_);

                object? bb_(Encounter? @this) {
                    Period? df_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? dg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, df_);
                    CqlDateTime? dh_ = context.Operators.End(dg_);
                    return dh_;
                }

                IEnumerable<Encounter?>? bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? bd_ = context.Operators.Last<Encounter>(bc_);
                Period? be_ = bd_?.Period;
                CqlInterval<CqlDateTime?>? bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                CqlDateTime? bg_ = context.Operators.Start(bf_);
                CqlInterval<CqlDateTime?>? bh_ = context.Operators.Interval(ay_, bg_ ?? aw_, true, true);
                bool? bi_ = context.Operators.In<CqlDateTime>(aj_, bh_, (string)default);

                bool? bj_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? di_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dj_ = di_?.Value;
                    Code<Encounter.EncounterStatus>? dk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dj_);
                    bool? dl_ = context.Operators.Equal(dk_, "finished");
                    Period? dm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                    CqlDateTime? do_ = context.Operators.End(dn_);
                    Period? dp_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? dq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dp_);
                    CqlDateTime? dr_ = context.Operators.Start(dq_);
                    CqlQuantity? ds_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? dt_ = context.Operators.Subtract(dr_, ds_);
                    CqlInterval<CqlDateTime?>? du_ = context.Operators.Interval(dt_, dr_, true, true);
                    bool? dv_ = context.Operators.In<CqlDateTime>(do_, du_, (string)default);
                    bool? dw_ = context.Operators.Not((bool?)(dr_ is null));
                    bool? dx_ = context.Operators.And(dv_, dw_);
                    bool? dy_ = context.Operators.And(dl_, dx_);
                    return dy_;
                }

                IEnumerable<Encounter?>? bk_ = context.Operators.Where<Encounter>(al_, bj_);

                object? bl_(Encounter? @this) {
                    Period? dz_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? ea_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dz_);
                    CqlDateTime? eb_ = context.Operators.End(ea_);
                    return eb_;
                }

                IEnumerable<Encounter?>? bm_ = context.Operators.SortBy<Encounter>(bk_, bl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? bn_ = context.Operators.Last<Encounter>(bm_);
                Period? bo_ = bn_?.Period;
                CqlInterval<CqlDateTime?>? bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                CqlDateTime? bq_ = context.Operators.Start(bp_);
                bool? br_ = context.Operators.Not((bool?)((bq_ ?? aw_) is null));
                bool? bs_ = context.Operators.And(bi_, br_);
                bool? bt_ = context.Operators.And(ag_, bs_);
                return bt_;
            }

            IEnumerable<Encounter?>? h_ = context.Operators.Where<Encounter>(f_, g_);

            object? i_(Encounter? @this) {
                Period? ec_ = @this?.Period;
                CqlInterval<CqlDateTime?>? ed_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ec_);
                CqlDateTime? ee_ = context.Operators.End(ed_);
                return ee_;
            }

            IEnumerable<Encounter?>? j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter? k_ = context.Operators.Last<Encounter>(j_);
            Period? l_ = k_?.Period;
            CqlInterval<CqlDateTime?>? m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime? n_ = context.Operators.Start(m_);
            CqlValueSet? o_ = this.Observation_Services(context);
            IEnumerable<Encounter?>? p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter? LastObs) {
                Code<Encounter.EncounterStatus>? ef_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? eg_ = ef_?.Value;
                Code<Encounter.EncounterStatus>? eh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eg_);
                bool? ei_ = context.Operators.Equal(eh_, "finished");
                Period? ej_ = LastObs?.Period;
                CqlInterval<CqlDateTime?>? ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                CqlDateTime? el_ = context.Operators.End(ek_);
                Period? em_ = Visit?.Period;
                CqlInterval<CqlDateTime?>? en_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, em_);
                CqlDateTime? eo_ = context.Operators.Start(en_);
                CqlQuantity? ep_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime? eq_ = context.Operators.Subtract(eo_, ep_);
                CqlInterval<CqlDateTime?>? er_ = context.Operators.Interval(eq_, eo_, true, true);
                bool? es_ = context.Operators.In<CqlDateTime>(el_, er_, (string)default);
                bool? et_ = context.Operators.Not((bool?)(eo_ is null));
                bool? eu_ = context.Operators.And(es_, et_);
                bool? ev_ = context.Operators.And(ei_, eu_);
                return ev_;
            }

            IEnumerable<Encounter?>? r_ = context.Operators.Where<Encounter>(p_, q_);

            object? s_(Encounter? @this) {
                Period? ew_ = @this?.Period;
                CqlInterval<CqlDateTime?>? ex_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ew_);
                CqlDateTime? ey_ = context.Operators.End(ex_);
                return ey_;
            }

            IEnumerable<Encounter?>? t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter? u_ = context.Operators.Last<Encounter>(t_);
            Period? v_ = u_?.Period;
            CqlInterval<CqlDateTime?>? w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(w_);
            Period? y_ = Visit?.Period;
            CqlInterval<CqlDateTime?>? z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime? aa_ = context.Operators.Start(z_);
            CqlDateTime? ab_ = context.Operators.End(z_);
            CqlInterval<CqlDateTime?>? ac_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ab_, true, true);
            return ac_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter?>?)a_, b_);
        CqlInterval<CqlDateTime?>? d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("hospitalizationWithObservation")]
    [CqlTag("description", "Hospitalization with Observation returns the total interval from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public CqlInterval<CqlDateTime?>? hospitalizationWithObservation(CqlContext context, Encounter? TheEncounter)
    {
        Encounter?[]? a_ = [
            TheEncounter,
        ];

        CqlInterval<CqlDateTime?>? b_(Encounter? Visit) {
            CqlValueSet? e_ = this.Emergency_Department_Visit(context);
            IEnumerable<Encounter?>? f_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? g_(Encounter? LastED) {
                Code<Encounter.EncounterStatus>? ad_ = LastED?.StatusElement;
                Encounter.EncounterStatus? ae_ = ad_?.Value;
                Code<Encounter.EncounterStatus>? af_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ae_);
                bool? ag_ = context.Operators.Equal(af_, "finished");
                Period? ah_ = LastED?.Period;
                CqlInterval<CqlDateTime?>? ai_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ah_);
                CqlDateTime? aj_ = context.Operators.End(ai_);
                CqlValueSet? ak_ = this.Observation_Services(context);
                IEnumerable<Encounter?>? al_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? am_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? bu_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? bv_ = bu_?.Value;
                    Code<Encounter.EncounterStatus>? bw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bv_);
                    bool? bx_ = context.Operators.Equal(bw_, "finished");
                    Period? by_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? bz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, by_);
                    CqlDateTime? ca_ = context.Operators.End(bz_);
                    Period? cb_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                    CqlDateTime? cd_ = context.Operators.Start(cc_);
                    CqlQuantity? ce_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? cf_ = context.Operators.Subtract(cd_, ce_);
                    CqlInterval<CqlDateTime?>? cg_ = context.Operators.Interval(cf_, cd_, true, true);
                    bool? ch_ = context.Operators.In<CqlDateTime>(ca_, cg_, (string)default);
                    bool? ci_ = context.Operators.Not((bool?)(cd_ is null));
                    bool? cj_ = context.Operators.And(ch_, ci_);
                    bool? ck_ = context.Operators.And(bx_, cj_);
                    return ck_;
                }

                IEnumerable<Encounter?>? an_ = context.Operators.Where<Encounter>(al_, am_);

                object? ao_(Encounter? @this) {
                    Period? cl_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? cm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cl_);
                    CqlDateTime? cn_ = context.Operators.End(cm_);
                    return cn_;
                }

                IEnumerable<Encounter?>? ap_ = context.Operators.SortBy<Encounter>(an_, ao_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? aq_ = context.Operators.Last<Encounter>(ap_);
                Period? ar_ = aq_?.Period;
                CqlInterval<CqlDateTime?>? as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                CqlDateTime? at_ = context.Operators.Start(as_);
                Period? au_ = Visit?.Period;
                CqlInterval<CqlDateTime?>? av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime? aw_ = context.Operators.Start(av_);
                CqlQuantity? ax_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime? ay_ = context.Operators.Subtract(at_ ?? aw_, ax_);

                bool? az_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? co_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? cp_ = co_?.Value;
                    Code<Encounter.EncounterStatus>? cq_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(cp_);
                    bool? cr_ = context.Operators.Equal(cq_, "finished");
                    Period? cs_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? ct_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cs_);
                    CqlDateTime? cu_ = context.Operators.End(ct_);
                    Period? cv_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                    CqlDateTime? cx_ = context.Operators.Start(cw_);
                    CqlQuantity? cy_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? cz_ = context.Operators.Subtract(cx_, cy_);
                    CqlInterval<CqlDateTime?>? da_ = context.Operators.Interval(cz_, cx_, true, true);
                    bool? db_ = context.Operators.In<CqlDateTime>(cu_, da_, (string)default);
                    bool? dc_ = context.Operators.Not((bool?)(cx_ is null));
                    bool? dd_ = context.Operators.And(db_, dc_);
                    bool? de_ = context.Operators.And(cr_, dd_);
                    return de_;
                }

                IEnumerable<Encounter?>? ba_ = context.Operators.Where<Encounter>(al_, az_);

                object? bb_(Encounter? @this) {
                    Period? df_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? dg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, df_);
                    CqlDateTime? dh_ = context.Operators.End(dg_);
                    return dh_;
                }

                IEnumerable<Encounter?>? bc_ = context.Operators.SortBy<Encounter>(ba_, bb_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? bd_ = context.Operators.Last<Encounter>(bc_);
                Period? be_ = bd_?.Period;
                CqlInterval<CqlDateTime?>? bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                CqlDateTime? bg_ = context.Operators.Start(bf_);
                CqlInterval<CqlDateTime?>? bh_ = context.Operators.Interval(ay_, bg_ ?? aw_, true, true);
                bool? bi_ = context.Operators.In<CqlDateTime>(aj_, bh_, (string)default);

                bool? bj_(Encounter? LastObs) {
                    Code<Encounter.EncounterStatus>? di_ = LastObs?.StatusElement;
                    Encounter.EncounterStatus? dj_ = di_?.Value;
                    Code<Encounter.EncounterStatus>? dk_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(dj_);
                    bool? dl_ = context.Operators.Equal(dk_, "finished");
                    Period? dm_ = LastObs?.Period;
                    CqlInterval<CqlDateTime?>? dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                    CqlDateTime? do_ = context.Operators.End(dn_);
                    Period? dp_ = Visit?.Period;
                    CqlInterval<CqlDateTime?>? dq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dp_);
                    CqlDateTime? dr_ = context.Operators.Start(dq_);
                    CqlQuantity? ds_ = context.Operators.Quantity(1m, "hour");
                    CqlDateTime? dt_ = context.Operators.Subtract(dr_, ds_);
                    CqlInterval<CqlDateTime?>? du_ = context.Operators.Interval(dt_, dr_, true, true);
                    bool? dv_ = context.Operators.In<CqlDateTime>(do_, du_, (string)default);
                    bool? dw_ = context.Operators.Not((bool?)(dr_ is null));
                    bool? dx_ = context.Operators.And(dv_, dw_);
                    bool? dy_ = context.Operators.And(dl_, dx_);
                    return dy_;
                }

                IEnumerable<Encounter?>? bk_ = context.Operators.Where<Encounter>(al_, bj_);

                object? bl_(Encounter? @this) {
                    Period? dz_ = @this?.Period;
                    CqlInterval<CqlDateTime?>? ea_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dz_);
                    CqlDateTime? eb_ = context.Operators.End(ea_);
                    return eb_;
                }

                IEnumerable<Encounter?>? bm_ = context.Operators.SortBy<Encounter>(bk_, bl_, System.ComponentModel.ListSortDirection.Ascending);
                Encounter? bn_ = context.Operators.Last<Encounter>(bm_);
                Period? bo_ = bn_?.Period;
                CqlInterval<CqlDateTime?>? bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                CqlDateTime? bq_ = context.Operators.Start(bp_);
                bool? br_ = context.Operators.Not((bool?)((bq_ ?? aw_) is null));
                bool? bs_ = context.Operators.And(bi_, br_);
                bool? bt_ = context.Operators.And(ag_, bs_);
                return bt_;
            }

            IEnumerable<Encounter?>? h_ = context.Operators.Where<Encounter>(f_, g_);

            object? i_(Encounter? @this) {
                Period? ec_ = @this?.Period;
                CqlInterval<CqlDateTime?>? ed_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ec_);
                CqlDateTime? ee_ = context.Operators.End(ed_);
                return ee_;
            }

            IEnumerable<Encounter?>? j_ = context.Operators.SortBy<Encounter>(h_, i_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter? k_ = context.Operators.Last<Encounter>(j_);
            Period? l_ = k_?.Period;
            CqlInterval<CqlDateTime?>? m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime? n_ = context.Operators.Start(m_);
            CqlValueSet? o_ = this.Observation_Services(context);
            IEnumerable<Encounter?>? p_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, o_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? q_(Encounter? LastObs) {
                Code<Encounter.EncounterStatus>? ef_ = LastObs?.StatusElement;
                Encounter.EncounterStatus? eg_ = ef_?.Value;
                Code<Encounter.EncounterStatus>? eh_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(eg_);
                bool? ei_ = context.Operators.Equal(eh_, "finished");
                Period? ej_ = LastObs?.Period;
                CqlInterval<CqlDateTime?>? ek_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ej_);
                CqlDateTime? el_ = context.Operators.End(ek_);
                Period? em_ = Visit?.Period;
                CqlInterval<CqlDateTime?>? en_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, em_);
                CqlDateTime? eo_ = context.Operators.Start(en_);
                CqlQuantity? ep_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime? eq_ = context.Operators.Subtract(eo_, ep_);
                CqlInterval<CqlDateTime?>? er_ = context.Operators.Interval(eq_, eo_, true, true);
                bool? es_ = context.Operators.In<CqlDateTime>(el_, er_, (string)default);
                bool? et_ = context.Operators.Not((bool?)(eo_ is null));
                bool? eu_ = context.Operators.And(es_, et_);
                bool? ev_ = context.Operators.And(ei_, eu_);
                return ev_;
            }

            IEnumerable<Encounter?>? r_ = context.Operators.Where<Encounter>(p_, q_);

            object? s_(Encounter? @this) {
                Period? ew_ = @this?.Period;
                CqlInterval<CqlDateTime?>? ex_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ew_);
                CqlDateTime? ey_ = context.Operators.End(ex_);
                return ey_;
            }

            IEnumerable<Encounter?>? t_ = context.Operators.SortBy<Encounter>(r_, s_, System.ComponentModel.ListSortDirection.Ascending);
            Encounter? u_ = context.Operators.Last<Encounter>(t_);
            Period? v_ = u_?.Period;
            CqlInterval<CqlDateTime?>? w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(w_);
            Period? y_ = Visit?.Period;
            CqlInterval<CqlDateTime?>? z_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, y_);
            CqlDateTime? aa_ = context.Operators.Start(z_);
            CqlDateTime? ab_ = context.Operators.End(z_);
            CqlInterval<CqlDateTime?>? ac_ = context.Operators.Interval(n_ ?? x_ ?? aa_, ab_, true, true);
            return ac_;
        }

        IEnumerable<CqlInterval<CqlDateTime?>?>? c_ = context.Operators.SelectDistinct<Encounter, CqlInterval<CqlDateTime>>((IEnumerable<Encounter?>?)a_, b_);
        CqlInterval<CqlDateTime?>? d_ = context.Operators.SingletonFrom<CqlInterval<CqlDateTime>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("HospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `hospitalizationWithObservationLengthofStay()` instead.")]
    public int? HospitalizationWithObservationLengthofStay(CqlContext context, Encounter? TheEncounter)
    {
        CqlInterval<CqlDateTime?>? a_ = this.HospitalizationWithObservation(context, TheEncounter);
        int? b_ = this.LengthInDays(context, a_);
        return b_;
    }


    [CqlFunctionDefinition("hospitalizationWithObservationLengthofStay")]
    [CqlTag("description", "Hospitalization with Observation Length of Stay returns the length in days from the start of any immediately prior emergency department visit through the observation visit to the discharge of the given encounter")]
    public int? hospitalizationWithObservationLengthofStay(CqlContext context, Encounter? TheEncounter)
    {
        CqlInterval<CqlDateTime?>? a_ = this.hospitalizationWithObservation(context, TheEncounter);
        int? b_ = this.lengthInDays(context, a_);
        return b_;
    }


    [CqlFunctionDefinition("FirstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `firstInpatientIntensiveCareUnit()` instead.")]
    public Encounter.LocationComponent? FirstInpatientIntensiveCareUnit(CqlContext context, Encounter? Encounter)
    {
        List<Encounter.LocationComponent?>? a_ = Encounter?.Location;

        bool? b_(Encounter.LocationComponent? HospitalLocation) {
            ResourceReference? g_ = HospitalLocation?.Location;
            Location? h_ = this.GetLocation(context, g_);
            List<CodeableConcept?>? i_ = h_?.Type;

            CqlConcept? j_(CodeableConcept? @this) {
                CqlConcept? t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            }

            IEnumerable<CqlConcept?>? k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept?>?)i_, j_);
            CqlValueSet? l_ = this.Intensive_Care_Unit(context);
            bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
            Period? n_ = Encounter?.Period;
            CqlInterval<CqlDateTime?>? o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            Period? p_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime?>? q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, (string)default);
            bool? s_ = context.Operators.And(m_, r_);
            return s_;
        }

        IEnumerable<Encounter.LocationComponent?>? c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent?>?)a_, b_);

        object? d_(Encounter.LocationComponent? @this) {
            Period? u_ = @this?.Period;
            CqlInterval<CqlDateTime?>? v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime? w_ = context.Operators.Start(v_);
            return w_;
        }

        IEnumerable<Encounter.LocationComponent?>? e_ = context.Operators.SortBy<Encounter.LocationComponent>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent? f_ = context.Operators.First<Encounter.LocationComponent>(e_);
        return f_;
    }


    [CqlFunctionDefinition("firstInpatientIntensiveCareUnit")]
    [CqlTag("description", "First Inpatient Intensive Care Unit returns the first intensive care unit for the given encounter, without considering any immediately prior emergency department visit.")]
    public Encounter.LocationComponent? firstInpatientIntensiveCareUnit(CqlContext context, Encounter? Encounter)
    {
        List<Encounter.LocationComponent?>? a_ = Encounter?.Location;

        bool? b_(Encounter.LocationComponent? HospitalLocation) {
            ResourceReference? g_ = HospitalLocation?.Location;
            Location? h_ = this.GetLocation(context, g_);
            List<CodeableConcept?>? i_ = h_?.Type;

            CqlConcept? j_(CodeableConcept? @this) {
                CqlConcept? t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return t_;
            }

            IEnumerable<CqlConcept?>? k_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept?>?)i_, j_);
            CqlValueSet? l_ = this.Intensive_Care_Unit(context);
            bool? m_ = context.Operators.ConceptsInValueSet(k_, l_);
            Period? n_ = Encounter?.Period;
            CqlInterval<CqlDateTime?>? o_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, n_);
            Period? p_ = HospitalLocation?.Period;
            CqlInterval<CqlDateTime?>? q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            bool? r_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(o_, q_, (string)default);
            bool? s_ = context.Operators.And(m_, r_);
            return s_;
        }

        IEnumerable<Encounter.LocationComponent?>? c_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent?>?)a_, b_);

        object? d_(Encounter.LocationComponent? @this) {
            Period? u_ = @this?.Period;
            CqlInterval<CqlDateTime?>? v_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, u_);
            CqlDateTime? w_ = context.Operators.Start(v_);
            return w_;
        }

        IEnumerable<Encounter.LocationComponent?>? e_ = context.Operators.SortBy<Encounter.LocationComponent>(c_, d_, System.ComponentModel.ListSortDirection.Ascending);
        Encounter.LocationComponent? f_ = context.Operators.First<Encounter.LocationComponent>(e_);
        return f_;
    }


    [CqlFunctionDefinition("EncounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resource referenced by the `diagnosis.condition` element of the Encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `encounterDiagnosis()` instead.")]
    public IEnumerable<Condition?>? EncounterDiagnosis(CqlContext context, Encounter? Encounter)
    {
        List<Encounter.DiagnosisComponent?>? a_ = Encounter?.Diagnosis;

        Condition? b_(Encounter.DiagnosisComponent? D) {
            IEnumerable<Condition?>? d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition?>? e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? f_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition?>?, e_ as IEnumerable<Condition?>?);

            bool? g_(Condition? C) {
                ResourceReference? j_ = D?.Condition;
                Id? k_ = C?.IdElement;
                string? l_ = k_?.Value;
                bool? m_ = QICoreCommon_4_0_000.Instance.references(context, j_, l_);
                return m_;
            }

            IEnumerable<Condition?>? h_ = context.Operators.Where<Condition>(f_, g_);
            Condition? i_ = context.Operators.SingletonFrom<Condition>(h_);
            return i_;
        }

        IEnumerable<Condition?>? c_ = context.Operators.SelectDistinct<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent?>?)a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("encounterDiagnosis")]
    [CqlTag("description", "Returns the Condition resources referenced by the diagnosis element of the Encounter")]
    public IEnumerable<Condition?>? encounterDiagnosis(CqlContext context, Encounter? Encounter)
    {
        List<ResourceReference?>? a_ = Encounter?.ReasonReference;

        Condition? b_(ResourceReference? D) {
            IEnumerable<Condition?>? d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition?>? e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? f_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition?>?, e_ as IEnumerable<Condition?>?);

            bool? g_(Condition? C) {
                Id? j_ = C?.IdElement;
                string? k_ = j_?.Value;
                bool? l_ = QICoreCommon_4_0_000.Instance.references(context, D, k_);
                return l_;
            }

            IEnumerable<Condition?>? h_ = context.Operators.Where<Condition>(f_, g_);
            Condition? i_ = context.Operators.SingletonFrom<Condition>(h_);
            return i_;
        }

        IEnumerable<Condition?>? c_ = context.Operators.SelectDistinct<ResourceReference, Condition>((IEnumerable<ResourceReference?>?)a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("GetCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getCondition()` instead")]
    public Condition? GetCondition(CqlContext context, ResourceReference? reference)
    {
        IEnumerable<Condition?>? a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Union<Condition>(a_ as IEnumerable<Condition?>?, b_ as IEnumerable<Condition?>?);

        bool? d_(Condition? C) {
            Id? g_ = C?.IdElement;
            string? h_ = g_?.Value;
            bool? i_ = QICoreCommon_4_0_000.Instance.references(context, reference, h_);
            return i_;
        }

        IEnumerable<Condition?>? e_ = context.Operators.Where<Condition>(c_, d_);
        Condition? f_ = context.Operators.SingletonFrom<Condition>(e_);
        return f_;
    }


    [CqlFunctionDefinition("getCondition")]
    [CqlTag("description", "Returns the Condition resource for the given reference")]
    public Condition? getCondition(CqlContext context, ResourceReference? reference)
    {
        IEnumerable<Condition?>? a_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
        IEnumerable<Condition?>? b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
        IEnumerable<Condition?>? c_ = context.Operators.Union<Condition>(a_ as IEnumerable<Condition?>?, b_ as IEnumerable<Condition?>?);

        bool? d_(Condition? C) {
            Id? g_ = C?.IdElement;
            string? h_ = g_?.Value;
            bool? i_ = QICoreCommon_4_0_000.Instance.references(context, reference, h_);
            return i_;
        }

        IEnumerable<Condition?>? e_ = context.Operators.Where<Condition>(c_, d_);
        Condition? f_ = context.Operators.SingletonFrom<Condition>(e_);
        return f_;
    }


    [CqlFunctionDefinition("PrincipalDiagnosis")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `principalDiagnosis()` instead.")]
    public Condition? PrincipalDiagnosis(CqlContext context, Encounter? Encounter)
    {
        List<Encounter.DiagnosisComponent?>? a_ = Encounter?.Diagnosis;

        bool? b_(Encounter.DiagnosisComponent? D) {
            PositiveInt? g_ = D?.RankElement;
            int? h_ = g_?.Value;
            bool? i_ = context.Operators.Equal(h_, 1);
            CodeableConcept? j_ = D?.Use;
            CqlConcept? k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            CqlCode? l_ = this.Billing(context);
            CqlConcept? m_ = context.Operators.ConvertCodeToConcept(l_);
            bool? n_ = context.Operators.Equivalent(k_, m_);
            bool? o_ = context.Operators.And(i_, n_);
            return o_;
        }


        Condition? c_(Encounter.DiagnosisComponent? PD) {
            IEnumerable<Condition?>? p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition?>? q_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition?>? r_ = context.Operators.Union<Condition>(p_ as IEnumerable<Condition?>?, q_ as IEnumerable<Condition?>?);

            bool? s_(Condition? C) {
                ResourceReference? v_ = PD?.Condition;
                Id? w_ = C?.IdElement;
                string? x_ = w_?.Value;
                bool? y_ = QICoreCommon_4_0_000.Instance.references(context, v_, x_);
                return y_;
            }

            IEnumerable<Condition?>? t_ = context.Operators.Where<Condition>(r_, s_);
            Condition? u_ = context.Operators.SingletonFrom<Condition>(t_);
            return u_;
        }

        IEnumerable<Condition?>? d_ = context.Operators.WhereSelect<Encounter.DiagnosisComponent, Condition>((IEnumerable<Encounter.DiagnosisComponent?>?)a_, b_, c_);
        IEnumerable<Condition?>? e_ = context.Operators.Distinct<Condition>(d_);
        Condition? f_ = context.Operators.SingletonFrom<Condition>(e_);
        return f_;
    }


    [CqlFunctionDefinition("principalDiagnosis")]
    [CqlTag("description", "Returns the claim diagnosis element that is specified as the principal diagnosis for the encounter")]
    [CqlTag("comment", "See the QICore 6 Authoring Patterns discussion on [Principal Diagnosis and Present on Admission](https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Authoring-Patterns-QICore-v6.0.0#conditions-present-on-admission-and-principal-diagnoses) for more information")]
    public Claim.DiagnosisComponent? principalDiagnosis(CqlContext context, Encounter? encounter)
    {
        IEnumerable<Claim.DiagnosisComponent?>? a_ = this.claimDiagnosis(context, encounter);

        bool? b_(Claim.DiagnosisComponent? CD) {
            List<CodeableConcept?>? e_ = CD?.Type;

            CqlConcept? f_(CodeableConcept? @this) {
                CqlConcept? j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept?>? g_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept?>?)e_, f_);
            CqlCode? h_ = this.Principal_Diagnosis(context);
            bool? i_ = QICoreCommon_4_0_000.Instance.includesCode(context, g_, h_);
            return i_;
        }

        IEnumerable<Claim.DiagnosisComponent?>? c_ = context.Operators.Where<Claim.DiagnosisComponent>(a_, b_);
        Claim.DiagnosisComponent? d_ = context.Operators.SingletonFrom<Claim.DiagnosisComponent>(c_);
        return d_;
    }


    [CqlFunctionDefinition("claimDiagnosis")]
    [CqlTag("description", "Returns the claim diagnosis elements for the given encounter")]
    [CqlTag("comment", "See the QICore 6 Authoring Patterns discussion on [Principal Diagnosis and Present on Admission](https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Authoring-Patterns-QICore-v6.0.0#conditions-present-on-admission-and-principal-diagnoses) for more information")]
    public IEnumerable<Claim.DiagnosisComponent?>? claimDiagnosis(CqlContext context, Encounter? encounter)
    {
        Encounter?[]? a_ = [
            encounter,
        ];

        IEnumerable<Claim.DiagnosisComponent?>? b_(Encounter? E) {
            IEnumerable<Claim?>? e_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? f_(Claim? C) {
                Code<FinancialResourceStatusCodes>? n_ = C?.StatusElement;
                FinancialResourceStatusCodes? o_ = n_?.Value;
                Code<FinancialResourceStatusCodes>? p_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(o_);
                bool? q_ = context.Operators.Equal(p_, "active");
                Code<ClaimUseCode>? r_ = C?.UseElement;
                ClaimUseCode? s_ = r_?.Value;
                Code<ClaimUseCode>? t_ = context.Operators.Convert<Code<ClaimUseCode>>(s_);
                bool? u_ = context.Operators.Equal(t_, "claim");
                bool? v_ = context.Operators.And(q_, u_);
                List<Claim.ItemComponent?>? w_ = C?.Item;

                bool? x_(Claim.ItemComponent? I) {
                    List<ResourceReference?>? aa_ = I?.Encounter;
                    bool? ab_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference?>?)aa_, E);
                    return ab_;
                }

                bool? y_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent?>?)w_, x_);
                bool? z_ = context.Operators.And(v_, y_);
                return z_;
            }

            IEnumerable<Claim?>? g_ = context.Operators.Where<Claim>(e_, f_);

            bool? h_(Claim? @this) {
                List<Claim.DiagnosisComponent?>? ac_ = @this?.Diagnosis;
                bool? ad_ = context.Operators.Not((bool?)(ac_ is null));
                return ad_;
            }


            List<Claim.DiagnosisComponent?>? i_(Claim? @this) {
                List<Claim.DiagnosisComponent?>? ae_ = @this?.Diagnosis;
                return ae_;
            }

            IEnumerable<List<Claim.DiagnosisComponent?>?>? j_ = context.Operators.WhereSelect<Claim, List<Claim.DiagnosisComponent>>(g_, h_, i_);
            IEnumerable<Claim.DiagnosisComponent?>? k_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent?>?>?)j_);

            bool? l_(Claim.DiagnosisComponent? D) {
                PositiveInt? af_ = D?.SequenceElement;
                int? ag_ = af_?.Value;
                IEnumerable<Claim?>? ah_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? ai_(Claim? C) {
                    Code<FinancialResourceStatusCodes>? av_ = C?.StatusElement;
                    FinancialResourceStatusCodes? aw_ = av_?.Value;
                    Code<FinancialResourceStatusCodes>? ax_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(aw_);
                    bool? ay_ = context.Operators.Equal(ax_, "active");
                    Code<ClaimUseCode>? az_ = C?.UseElement;
                    ClaimUseCode? ba_ = az_?.Value;
                    Code<ClaimUseCode>? bb_ = context.Operators.Convert<Code<ClaimUseCode>>(ba_);
                    bool? bc_ = context.Operators.Equal(bb_, "claim");
                    bool? bd_ = context.Operators.And(ay_, bc_);
                    List<Claim.ItemComponent?>? be_ = C?.Item;

                    bool? bf_(Claim.ItemComponent? I) {
                        List<ResourceReference?>? bi_ = I?.Encounter;
                        bool? bj_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference?>?)bi_, E);
                        return bj_;
                    }

                    bool? bg_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent?>?)be_, bf_);
                    bool? bh_ = context.Operators.And(bd_, bg_);
                    return bh_;
                }

                IEnumerable<Claim?>? aj_ = context.Operators.Where<Claim>(ah_, ai_);

                bool? ak_(Claim? @this) {
                    List<Claim.ItemComponent?>? bk_ = @this?.Item;
                    bool? bl_ = context.Operators.Not((bool?)(bk_ is null));
                    return bl_;
                }


                List<Claim.ItemComponent?>? al_(Claim? @this) {
                    List<Claim.ItemComponent?>? bm_ = @this?.Item;
                    return bm_;
                }

                IEnumerable<List<Claim.ItemComponent?>?>? am_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(aj_, ak_, al_);
                IEnumerable<Claim.ItemComponent?>? an_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent?>?>?)am_);

                bool? ao_(Claim.ItemComponent? I) {
                    List<ResourceReference?>? bn_ = I?.Encounter;
                    bool? bo_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference?>?)bn_, E);
                    return bo_;
                }

                IEnumerable<Claim.ItemComponent?>? ap_ = context.Operators.Where<Claim.ItemComponent>(an_, ao_);

                bool? aq_(Claim.ItemComponent? @this) {
                    List<PositiveInt?>? bp_ = @this?.DiagnosisSequenceElement;

                    int? bq_(PositiveInt? @this) {
                        int? bt_ = @this?.Value;
                        return bt_;
                    }

                    IEnumerable<int?>? br_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt?>?)bp_, bq_);
                    bool? bs_ = context.Operators.Not((bool?)(br_ is null));
                    return bs_;
                }


                IEnumerable<int?>? ar_(Claim.ItemComponent? @this) {
                    List<PositiveInt?>? bu_ = @this?.DiagnosisSequenceElement;

                    int? bv_(PositiveInt? @this) {
                        int? bx_ = @this?.Value;
                        return bx_;
                    }

                    IEnumerable<int?>? bw_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt?>?)bu_, bv_);
                    return bw_;
                }

                IEnumerable<IEnumerable<int?>?>? as_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>(ap_, aq_, ar_);
                IEnumerable<int?>? at_ = context.Operators.Flatten<int?>(as_);
                bool? au_ = context.Operators.In<int?>(ag_, at_);
                return au_;
            }

            IEnumerable<Claim.DiagnosisComponent?>? m_ = context.Operators.Where<Claim.DiagnosisComponent>(k_, l_);
            return m_;
        }

        IEnumerable<IEnumerable<Claim.DiagnosisComponent?>?>? c_ = context.Operators.SelectDistinct<Encounter, IEnumerable<Claim.DiagnosisComponent>>((IEnumerable<Encounter?>?)a_, b_);
        IEnumerable<Claim.DiagnosisComponent?>? d_ = context.Operators.SingletonFrom<IEnumerable<Claim.DiagnosisComponent>>(c_);
        return d_;
    }


    [CqlFunctionDefinition("hasPrincipalDiagnosisOf")]
    [CqlTag("description", "Returns the condition that is specified as the principal diagnosis for the encounter and has a code in the given valueSet.")]
    [CqlTag("comment", "See the QICore 6 Authoring Patterns discussion on [Principal Diagnosis and Present on Admission](https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Authoring-Patterns-QICore-v6.0.0#conditions-present-on-admission-and-principal-diagnoses) for more information")]
    public bool? hasPrincipalDiagnosisOf(CqlContext context, Encounter? encounter, CqlValueSet? valueSet)
    {
        Claim.DiagnosisComponent? a_ = this.principalDiagnosis(context, encounter);
        Claim.DiagnosisComponent?[]? b_ = [
            a_,
        ];

        bool? c_(Claim.DiagnosisComponent? PD) {
            DataType? f_ = PD?.Diagnosis;
            object? g_ = FHIRHelpers_4_4_000.Instance.ToValue(context, f_);
            bool? h_ = context.Operators.ConceptInValueSet(g_ as CqlConcept?, valueSet);
            Condition? i_ = this.getCondition(context, g_ as ResourceReference?);
            CodeableConcept? j_ = i_?.Code;
            CqlConcept? k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            bool? l_ = context.Operators.ConceptInValueSet(k_, valueSet);
            bool? m_ = context.Operators.Or(h_, l_);
            return m_;
        }

        IEnumerable<bool?>? d_ = context.Operators.SelectDistinct<Claim.DiagnosisComponent, bool?>((IEnumerable<Claim.DiagnosisComponent?>?)b_, c_);
        bool? e_ = context.Operators.SingletonFrom<bool?>(d_);
        return e_;
    }


    [CqlFunctionDefinition("isDiagnosisPresentOnAdmission")]
    [CqlTag("description", "Returns true if the given diagnosis is present on admission, based on the given poaValueSet")]
    [CqlTag("comment", "See the QICore 6 Authoring Patterns discussion on [Principal Diagnosis and Present on Admission](https://github.com/cqframework/CQL-Formatting-and-Usage-Wiki/wiki/Authoring-Patterns-QICore-v6.0.0#conditions-present-on-admission-and-principal-diagnoses) for more information")]
    public bool? isDiagnosisPresentOnAdmission(CqlContext context, Encounter? encounter, CqlValueSet? diagnosisValueSet, CqlValueSet? poaValueSet)
    {
        IEnumerable<Claim.DiagnosisComponent?>? a_ = this.claimDiagnosis(context, encounter);

        bool? b_(Claim.DiagnosisComponent? CD) {
            CodeableConcept? d_ = CD?.OnAdmission;
            CqlConcept? e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            bool? f_ = context.Operators.ConceptInValueSet(e_, poaValueSet);
            DataType? g_ = CD?.Diagnosis;
            object? h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
            bool? i_ = context.Operators.ConceptInValueSet(h_ as CqlConcept?, diagnosisValueSet);
            Condition? j_ = this.getCondition(context, h_ as ResourceReference?);
            CodeableConcept? k_ = j_?.Code;
            CqlConcept? l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
            bool? m_ = context.Operators.ConceptInValueSet(l_, diagnosisValueSet);
            bool? n_ = context.Operators.Or(i_, m_);
            bool? o_ = context.Operators.And(f_, n_);
            return o_;
        }

        bool? c_ = context.Operators.WhereAny<Claim.DiagnosisComponent>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("getLocation")]
    [CqlTag("description", "Returns the Location resource specified by the given reference.")]
    public Location? getLocation(CqlContext context, ResourceReference? reference)
    {
        IEnumerable<Location?>? a_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-location"));

        bool? b_(Location? L) {
            bool? e_ = QICoreCommon_4_0_000.Instance.references(context, reference, L);
            return e_;
        }

        IEnumerable<Location?>? c_ = context.Operators.Where<Location>(a_, b_);
        Location? d_ = context.Operators.SingletonFrom<Location>(c_);
        return d_;
    }


    [CqlFunctionDefinition("GetMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    [CqlTag("deprecated", "This function is deprecated. Use the fluent function `getMedicationCode()` instead.")]
    public CqlConcept? GetMedicationCode(CqlContext context, MedicationRequest? request)
    {
        DataType? a_ = request?.Medication;
        object? b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        bool c_ = b_ is CqlConcept;
        if (c_)
        {
            DataType? d_ = request?.Medication;
            object? e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            return e_ as CqlConcept?;
        }
        else
        {
            IEnumerable<Medication?>? f_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? g_(Medication? M) {
                DataType? l_ = request?.Medication;
                object? m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                bool? n_ = QICoreCommon_4_0_000.Instance.references(context, m_ as ResourceReference?, M);
                return n_;
            }

            IEnumerable<Medication?>? h_ = context.Operators.Where<Medication>(f_, g_);
            Medication? i_ = context.Operators.SingletonFrom<Medication>(h_);
            CodeableConcept? j_ = i_?.Code;
            CqlConcept? k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            return k_;
        }
    }


    [CqlFunctionDefinition("getMedicationCode")]
    [CqlTag("description", "Returns the medication code for the given MedicationRequest")]
    public CqlConcept? getMedicationCode(CqlContext context, MedicationRequest? request)
    {
        DataType? a_ = request?.Medication;
        object? b_ = FHIRHelpers_4_4_000.Instance.ToValue(context, a_);
        bool c_ = b_ is CqlConcept;
        if (c_)
        {
            DataType? d_ = request?.Medication;
            object? e_ = FHIRHelpers_4_4_000.Instance.ToValue(context, d_);
            return e_ as CqlConcept?;
        }
        else
        {
            IEnumerable<Medication?>? f_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? g_(Medication? M) {
                DataType? l_ = request?.Medication;
                object? m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                bool? n_ = QICoreCommon_4_0_000.Instance.references(context, m_ as ResourceReference?, M);
                return n_;
            }

            IEnumerable<Medication?>? h_ = context.Operators.Where<Medication>(f_, g_);
            Medication? i_ = context.Operators.SingletonFrom<Medication>(h_);
            CodeableConcept? j_ = i_?.Code;
            CqlConcept? k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            return k_;
        }
    }


    [CqlFunctionDefinition("principalProcedure")]
    [CqlTag("description", "Returns the claim procedure elements for the given encounter")]
    public Claim.ProcedureComponent? principalProcedure(CqlContext context, Encounter? encounter)
    {
        Encounter?[]? a_ = [
            encounter,
        ];

        Claim.ProcedureComponent? b_(Encounter? E) {
            IEnumerable<Claim?>? e_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? f_(Claim? C) {
                Code<FinancialResourceStatusCodes>? o_ = C?.StatusElement;
                FinancialResourceStatusCodes? p_ = o_?.Value;
                Code<FinancialResourceStatusCodes>? q_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(p_);
                bool? r_ = context.Operators.Equal(q_, "active");
                Code<ClaimUseCode>? s_ = C?.UseElement;
                ClaimUseCode? t_ = s_?.Value;
                Code<ClaimUseCode>? u_ = context.Operators.Convert<Code<ClaimUseCode>>(t_);
                bool? v_ = context.Operators.Equal(u_, "claim");
                bool? w_ = context.Operators.And(r_, v_);
                List<Claim.ItemComponent?>? x_ = C?.Item;

                bool? y_(Claim.ItemComponent? I) {
                    List<ResourceReference?>? ab_ = I?.Encounter;
                    bool? ac_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference?>?)ab_, E);
                    return ac_;
                }

                bool? z_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent?>?)x_, y_);
                bool? aa_ = context.Operators.And(w_, z_);
                return aa_;
            }

            IEnumerable<Claim?>? g_ = context.Operators.Where<Claim>(e_, f_);

            bool? h_(Claim? @this) {
                List<Claim.ProcedureComponent?>? ad_ = @this?.Procedure;
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                return ae_;
            }


            List<Claim.ProcedureComponent?>? i_(Claim? @this) {
                List<Claim.ProcedureComponent?>? af_ = @this?.Procedure;
                return af_;
            }

            IEnumerable<List<Claim.ProcedureComponent?>?>? j_ = context.Operators.WhereSelect<Claim, List<Claim.ProcedureComponent>>(g_, h_, i_);
            IEnumerable<Claim.ProcedureComponent?>? k_ = context.Operators.Flatten<Claim.ProcedureComponent>((IEnumerable<IEnumerable<Claim.ProcedureComponent?>?>?)j_);

            bool? l_(Claim.ProcedureComponent? P) {
                PositiveInt? ag_ = P?.SequenceElement;
                int? ah_ = ag_?.Value;
                IEnumerable<Claim?>? ai_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? aj_(Claim? C) {
                    Code<FinancialResourceStatusCodes>? bc_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bd_ = bc_?.Value;
                    Code<FinancialResourceStatusCodes>? be_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bd_);
                    bool? bf_ = context.Operators.Equal(be_, "active");
                    Code<ClaimUseCode>? bg_ = C?.UseElement;
                    ClaimUseCode? bh_ = bg_?.Value;
                    Code<ClaimUseCode>? bi_ = context.Operators.Convert<Code<ClaimUseCode>>(bh_);
                    bool? bj_ = context.Operators.Equal(bi_, "claim");
                    bool? bk_ = context.Operators.And(bf_, bj_);
                    List<Claim.ItemComponent?>? bl_ = C?.Item;

                    bool? bm_(Claim.ItemComponent? I) {
                        List<ResourceReference?>? bp_ = I?.Encounter;
                        bool? bq_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference?>?)bp_, E);
                        return bq_;
                    }

                    bool? bn_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent?>?)bl_, bm_);
                    bool? bo_ = context.Operators.And(bk_, bn_);
                    return bo_;
                }

                IEnumerable<Claim?>? ak_ = context.Operators.Where<Claim>(ai_, aj_);

                bool? al_(Claim? @this) {
                    List<Claim.ItemComponent?>? br_ = @this?.Item;
                    bool? bs_ = context.Operators.Not((bool?)(br_ is null));
                    return bs_;
                }


                List<Claim.ItemComponent?>? am_(Claim? @this) {
                    List<Claim.ItemComponent?>? bt_ = @this?.Item;
                    return bt_;
                }

                IEnumerable<List<Claim.ItemComponent?>?>? an_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(ak_, al_, am_);
                IEnumerable<Claim.ItemComponent?>? ao_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent?>?>?)an_);

                bool? ap_(Claim.ItemComponent? I) {
                    List<ResourceReference?>? bu_ = I?.Encounter;
                    bool? bv_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference?>?)bu_, E);
                    return bv_;
                }

                IEnumerable<Claim.ItemComponent?>? aq_ = context.Operators.Where<Claim.ItemComponent>(ao_, ap_);

                bool? ar_(Claim.ItemComponent? @this) {
                    List<PositiveInt?>? bw_ = @this?.ProcedureSequenceElement;

                    int? bx_(PositiveInt? @this) {
                        int? ca_ = @this?.Value;
                        return ca_;
                    }

                    IEnumerable<int?>? by_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt?>?)bw_, bx_);
                    bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                    return bz_;
                }


                IEnumerable<int?>? as_(Claim.ItemComponent? @this) {
                    List<PositiveInt?>? cb_ = @this?.ProcedureSequenceElement;

                    int? cc_(PositiveInt? @this) {
                        int? ce_ = @this?.Value;
                        return ce_;
                    }

                    IEnumerable<int?>? cd_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt?>?)cb_, cc_);
                    return cd_;
                }

                IEnumerable<IEnumerable<int?>?>? at_ = context.Operators.WhereSelect<Claim.ItemComponent, IEnumerable<int?>>(aq_, ar_, as_);
                IEnumerable<int?>? au_ = context.Operators.Flatten<int?>(at_);
                bool? av_ = context.Operators.In<int?>(ah_, au_);
                List<CodeableConcept?>? aw_ = P?.Type;

                CqlConcept? ax_(CodeableConcept? @this) {
                    CqlConcept? cf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return cf_;
                }

                IEnumerable<CqlConcept?>? ay_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept?>?)aw_, ax_);
                CqlCode? az_ = this.Primary_procedure(context);
                bool? ba_ = QICoreCommon_4_0_000.Instance.includesCode(context, ay_, az_);
                bool? bb_ = context.Operators.And(av_, ba_);
                return bb_;
            }

            IEnumerable<Claim.ProcedureComponent?>? m_ = context.Operators.Where<Claim.ProcedureComponent>(k_, l_);
            Claim.ProcedureComponent? n_ = context.Operators.SingletonFrom<Claim.ProcedureComponent>(m_);
            return n_;
        }

        IEnumerable<Claim.ProcedureComponent?>? c_ = context.Operators.SelectDistinct<Encounter, Claim.ProcedureComponent>((IEnumerable<Encounter?>?)a_, b_);
        Claim.ProcedureComponent? d_ = context.Operators.SingletonFrom<Claim.ProcedureComponent>(c_);
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
