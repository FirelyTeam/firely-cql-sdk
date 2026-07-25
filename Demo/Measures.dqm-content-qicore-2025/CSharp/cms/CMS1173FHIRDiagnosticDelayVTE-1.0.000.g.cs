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
[CqlLibrary("CMS1173FHIRDiagnosticDelayVTE", "1.0.000")]
public partial class CMS1173FHIRDiagnosticDelayVTE_1_0_000 : ILibrary, ISingleton<CMS1173FHIRDiagnosticDelayVTE_1_0_000>
{
    #region ValueSets (14)

    [CqlValueSetDefinition("Anticoagulant Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.19", valueSetVersion: null)]
    public CqlValueSet Anticoagulant_Medications(CqlContext _) => _Anticoagulant_Medications;
    private static readonly CqlValueSet _Anticoagulant_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.19", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Hospice Care Ambulatory", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", valueSetVersion: null)]
    public CqlValueSet Hospice_Care_Ambulatory(CqlContext _) => _Hospice_Care_Ambulatory;
    private static readonly CqlValueSet _Hospice_Care_Ambulatory = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15", null);

    [CqlValueSetDefinition("Hospice Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", valueSetVersion: null)]
    public CqlValueSet Hospice_Diagnosis(CqlContext _) => _Hospice_Diagnosis;
    private static readonly CqlValueSet _Hospice_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1165", null);

    [CqlValueSetDefinition("Hospice Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", valueSetVersion: null)]
    public CqlValueSet Hospice_Encounter(CqlContext _) => _Hospice_Encounter;
    private static readonly CqlValueSet _Hospice_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1003", null);

    [CqlValueSetDefinition("Imaging Related to VTE", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.47", valueSetVersion: null)]
    public CqlValueSet Imaging_Related_to_VTE(CqlContext _) => _Imaging_Related_to_VTE;
    private static readonly CqlValueSet _Imaging_Related_to_VTE = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.47", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Outpatient Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", valueSetVersion: null)]
    public CqlValueSet Outpatient_Encounter(CqlContext _) => _Outpatient_Encounter;
    private static readonly CqlValueSet _Outpatient_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1087", null);

    [CqlValueSetDefinition("Palliative Care Diagnosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Diagnosis(CqlContext _) => _Palliative_Care_Diagnosis;
    private static readonly CqlValueSet _Palliative_Care_Diagnosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1167", null);

    [CqlValueSetDefinition("Palliative Care Encounter", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Encounter(CqlContext _) => _Palliative_Care_Encounter;
    private static readonly CqlValueSet _Palliative_Care_Encounter = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1090", null);

    [CqlValueSetDefinition("Palliative Care Intervention", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", valueSetVersion: null)]
    public CqlValueSet Palliative_Care_Intervention(CqlContext _) => _Palliative_Care_Intervention;
    private static readonly CqlValueSet _Palliative_Care_Intervention = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.198.12.1135", null);

    [CqlValueSetDefinition("VTE Diagnoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.49", valueSetVersion: null)]
    public CqlValueSet VTE_Diagnoses(CqlContext _) => _VTE_Diagnoses;
    private static readonly CqlValueSet _VTE_Diagnoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.49", null);

    [CqlValueSetDefinition("VTE Symptoms", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.51", valueSetVersion: null)]
    public CqlValueSet VTE_Symptoms(CqlContext _) => _VTE_Symptoms;
    private static readonly CqlValueSet _VTE_Symptoms = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1206.51", null);

    #endregion ValueSets

    #region Codes (5)

    [CqlCodeDefinition("Discharge to healthcare facility for hospice care (procedure)", codeId: "428371000124100", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_healthcare_facility_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_healthcare_facility_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_healthcare_facility_for_hospice_care__procedure_ = new CqlCode("428371000124100", "http://snomed.info/sct");

    [CqlCodeDefinition("Discharge to home for hospice care (procedure)", codeId: "428361000124107", codeSystem: "http://snomed.info/sct")]
    public CqlCode Discharge_to_home_for_hospice_care__procedure_(CqlContext _) => _Discharge_to_home_for_hospice_care__procedure_;
    private static readonly CqlCode _Discharge_to_home_for_hospice_care__procedure_ = new CqlCode("428361000124107", "http://snomed.info/sct");

    [CqlCodeDefinition("Hospice care [Minimum Data Set]", codeId: "45755-6", codeSystem: "http://loinc.org")]
    public CqlCode Hospice_care__Minimum_Data_Set_(CqlContext _) => _Hospice_care__Minimum_Data_Set_;
    private static readonly CqlCode _Hospice_care__Minimum_Data_Set_ = new CqlCode("45755-6", "http://loinc.org");

    [CqlCodeDefinition("Yes (qualifier value)", codeId: "373066001", codeSystem: "http://snomed.info/sct")]
    public CqlCode Yes__qualifier_value_(CqlContext _) => _Yes__qualifier_value_;
    private static readonly CqlCode _Yes__qualifier_value_ = new CqlCode("373066001", "http://snomed.info/sct");

    [CqlCodeDefinition("Functional Assessment of Chronic Illness Therapy - Palliative Care Questionnaire (FACIT-Pal)", codeId: "71007-9", codeSystem: "http://loinc.org")]
    public CqlCode Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(CqlContext _) => _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_;
    private static readonly CqlCode _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_ = new CqlCode("71007-9", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (2)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Hospice_care__Minimum_Data_Set_,
          _Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_]);

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Discharge_to_healthcare_facility_for_hospice_care__procedure_,
          _Discharge_to_home_for_hospice_care__procedure_,
          _Yes__qualifier_value_]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -2155954010635899892L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS1173FHIRDiagnosticDelayVTE-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (23)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 5541395162049134047L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Performed Encounters")]
    public IEnumerable<Encounter> Qualifying_Performed_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Performed_Encounters, Qualifying_Performed_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Performed_Encounters = 2536520436514206342L;

    private IEnumerable<Encounter> Qualifying_Performed_Encounters_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Office_Visit(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Outpatient_Encounter(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
        CqlValueSet f_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> h_ = context.Operators.Union<Encounter>(e_, g_);

        bool? i_(Encounter Encounter) {
            Code<Encounter.EncounterStatus> k_ = Encounter?.StatusElement;
            Encounter.EncounterStatus? l_ = k_?.Value;
            Code<Encounter.EncounterStatus> m_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(l_);
            bool? n_ = context.Operators.Equal(m_, "finished");
            Period o_ = Encounter?.Period;
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            CqlDateTime v_ = context.Operators.End(r_);
            CqlInterval<CqlDateTime> w_ = context.Operators.Interval(u_, v_, true, true);
            bool? x_ = context.Operators.In<CqlDateTime>(q_, w_, "day");
            bool? y_ = context.Operators.And(n_, x_);
            return y_;
        }

        IEnumerable<Encounter> j_ = context.Operators.Where<Encounter>(h_, i_);
        return j_;
    }


    [CqlFunctionDefinition("isConfirmedCondition")]
    [CqlTag("description", "Returns true if the given Condition is confirmed")]
    public bool? isConfirmedCondition(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        CqlCode c_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        bool? e_ = context.Operators.Equivalent(b_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Qualifying Performed VTE Encounters")]
    public IEnumerable<Encounter> Qualifying_Performed_VTE_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Performed_VTE_Encounters, Qualifying_Performed_VTE_Encounters_Compute);

    private const long _cacheIndex_Qualifying_Performed_VTE_Encounters = 8792642716030250222L;

    private IEnumerable<Encounter> Qualifying_Performed_VTE_Encounters_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Performed_Encounters(context);

        bool? b_(Encounter VTEEncounter) {
            List<CodeableConcept> d_ = VTEEncounter?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return n_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.VTE_Diagnoses(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? j_(Condition VTECondition) {
                bool? o_ = this.isConfirmedCondition(context, VTECondition);
                List<ResourceReference> p_ = VTEEncounter?.ReasonReference;
                bool? q_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)p_, VTECondition);
                bool? r_ = context.Operators.And(o_, q_);
                return r_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
            bool? l_ = context.Operators.Exists<Condition>(k_);
            bool? m_ = context.Operators.Or(h_, l_);
            return m_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Qualifying Performed PCP Visits")]
    public IEnumerable<Encounter> Qualifying_Performed_PCP_Visits(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Performed_PCP_Visits, Qualifying_Performed_PCP_Visits_Compute);

    private const long _cacheIndex_Qualifying_Performed_PCP_Visits = -5215233933916997501L;

    private IEnumerable<Encounter> Qualifying_Performed_PCP_Visits_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Outpatient_Encounter(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        CqlValueSet c_ = this.Office_Visit(context);
        IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);

        bool? f_(Encounter PCPVisit) {
            Code<Encounter.EncounterStatus> h_ = PCPVisit?.StatusElement;
            Encounter.EncounterStatus? i_ = h_?.Value;
            Code<Encounter.EncounterStatus> j_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(i_);
            bool? k_ = context.Operators.Equal(j_, "finished");
            Period l_ = PCPVisit?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.End(m_);
            CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlQuantity q_ = context.Operators.Quantity(210m, "days");
            CqlDateTime r_ = context.Operators.Subtract(p_, q_);
            CqlDateTime s_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(r_, s_, true, true);
            bool? u_ = context.Operators.In<CqlDateTime>(n_, t_, "day");
            bool? v_ = context.Operators.And(k_, u_);
            return v_;
        }

        IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
        return g_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, Condition condition)
    {
        CodeableConcept a_ = condition?.VerificationStatus;
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlCode d_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept e_ = context.Operators.ConvertCodeToConcept(d_);
        bool? f_ = context.Operators.Equivalent(b_, e_);
        CqlCode g_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
        bool? i_ = context.Operators.Equivalent(b_, h_);
        bool? j_ = context.Operators.Or(f_, i_);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(b_, l_);
        bool? n_ = context.Operators.Or(j_, m_);
        CqlCode o_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept p_ = context.Operators.ConvertCodeToConcept(o_);
        bool? q_ = context.Operators.Equivalent(b_, p_);
        bool? r_ = context.Operators.Or(n_, q_);
        bool? s_ = context.Operators.Implies(c_, r_);
        return s_;
    }


    [CqlExpressionDefinition("Qualifying Performed PCP Visits With VTE Symptom")]
    public IEnumerable<Encounter> Qualifying_Performed_PCP_Visits_With_VTE_Symptom(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Performed_PCP_Visits_With_VTE_Symptom, Qualifying_Performed_PCP_Visits_With_VTE_Symptom_Compute);

    private const long _cacheIndex_Qualifying_Performed_PCP_Visits_With_VTE_Symptom = -1971924271945246505L;

    private IEnumerable<Encounter> Qualifying_Performed_PCP_Visits_With_VTE_Symptom_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Performed_PCP_Visits(context);

        bool? b_(Encounter IndexPCPVisit) {
            List<CodeableConcept> d_ = IndexPCPVisit?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept n_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return n_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.VTE_Symptoms(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? j_(Condition VTESymptomCondition) {
                bool? o_ = this.isVerified(context, VTESymptomCondition as Condition);
                List<ResourceReference> p_ = IndexPCPVisit?.ReasonReference;
                bool? q_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)p_, VTESymptomCondition);
                bool? r_ = context.Operators.And(o_, q_);
                return r_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
            bool? l_ = context.Operators.Exists<Condition>(k_);
            bool? m_ = context.Operators.Or(h_, l_);
            return m_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Qualifying VTE Imaging Diagnostic Report")]
    public IEnumerable<DiagnosticReport> Qualifying_VTE_Imaging_Diagnostic_Report(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_VTE_Imaging_Diagnostic_Report, Qualifying_VTE_Imaging_Diagnostic_Report_Compute);

    private const long _cacheIndex_Qualifying_VTE_Imaging_Diagnostic_Report = -8519356969433798899L;

    private IEnumerable<DiagnosticReport> Qualifying_VTE_Imaging_Diagnostic_Report_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Imaging_Related_to_VTE(context);
        IEnumerable<DiagnosticReport> b_ = context.Operators.Retrieve<DiagnosticReport>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-diagnosticreport-note"));

        bool? c_(DiagnosticReport VTEDiagnosticReport) {
            Code<DiagnosticReport.DiagnosticReportStatus> e_ = VTEDiagnosticReport?.StatusElement;
            DiagnosticReport.DiagnosticReportStatus? f_ = e_?.Value;
            string g_ = context.Operators.Convert<string>(f_);
            string[] h_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? i_ = context.Operators.In<string>(g_, (IEnumerable<string>)h_);
            return i_;
        }

        IEnumerable<DiagnosticReport> d_ = context.Operators.Where<DiagnosticReport>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("AntiCoagulant Therapy Ordered")]
    public IEnumerable<MedicationRequest> AntiCoagulant_Therapy_Ordered(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_AntiCoagulant_Therapy_Ordered, AntiCoagulant_Therapy_Ordered_Compute);

    private const long _cacheIndex_AntiCoagulant_Therapy_Ordered = -231287711048350331L;

    private IEnumerable<MedicationRequest> AntiCoagulant_Therapy_Ordered_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Anticoagulant_Medications(context);
        IEnumerable<MedicationRequest> b_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> c_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? d_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Anticoagulant_Medications(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            bool? l_ = context.Operators.Exists<Medication>(k_);
            return l_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.Where<MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest AntiCoagulant) {
            Code<MedicationRequest.MedicationrequestStatus> w_ = AntiCoagulant?.StatusElement;
            MedicationRequest.MedicationrequestStatus? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            string[] z_ = [
                "active",
                "completed",
            ];
            bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
            Code<MedicationRequest.MedicationRequestIntent> ab_ = AntiCoagulant?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ac_ = ab_?.Value;
            string ad_ = context.Operators.Convert<string>(ac_);
            bool? ae_ = context.Operators.Equal(ad_, "order");
            bool? af_ = context.Operators.And(aa_, ae_);
            return af_;
        }

        IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Qualified VTE Encounters")]
    public IEnumerable<Encounter> Qualified_VTE_Encounters(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualified_VTE_Encounters, Qualified_VTE_Encounters_Compute);

    private const long _cacheIndex_Qualified_VTE_Encounters = 4136544579450247243L;

    private IEnumerable<Encounter> Qualified_VTE_Encounters_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Performed_VTE_Encounters(context);
        IEnumerable<Encounter> b_ = this.Qualifying_Performed_PCP_Visits_With_VTE_Symptom(context);
        IEnumerable<DiagnosticReport> c_ = this.Qualifying_VTE_Imaging_Diagnostic_Report(context);
        IEnumerable<MedicationRequest> d_ = this.AntiCoagulant_Therapy_Ordered(context);
        IEnumerable<ValueTuple<Encounter, Encounter, DiagnosticReport, MedicationRequest>> e_ = context.Operators.CrossJoin<Encounter, Encounter, DiagnosticReport, MedicationRequest>(a_, b_, c_, d_);

        (CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)? f_(ValueTuple<Encounter, Encounter, DiagnosticReport, MedicationRequest> _valueTuple) {
            (CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)? m_ = (CqlTupleMetadata_GAFATFEJifSPXLKbTBWFddDeY, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)?> g_ = context.Operators.Select<ValueTuple<Encounter, Encounter, DiagnosticReport, MedicationRequest>, (CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)? tuple_bundjkpliiuyymiejivrqjjcd) {
            DataType n_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEStudy?.Effective;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlInterval<CqlDateTime> p_ = QICoreCommon_4_0_000.Instance.toInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            Period r_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEEncounter?.Period;
            CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
            bool? t_ = context.Operators.In<CqlDateTime>(q_, s_, "day");
            FhirDateTime u_ = tuple_bundjkpliiuyymiejivrqjjcd?.AntiCoagulantOrdered?.AuthoredOnElement;
            CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
            CqlQuantity w_ = context.Operators.Quantity(12m, "hours");
            CqlDateTime x_ = context.Operators.Subtract(o_ as CqlDateTime, w_);
            CqlInterval<CqlDateTime> y_ = context.Operators.Interval(x_, o_ as CqlDateTime, true, false);
            bool? z_ = context.Operators.In<CqlDateTime>(v_, y_, (string)default);
            bool? aa_ = context.Operators.Not((bool?)(o_ is null));
            bool? ab_ = context.Operators.And(z_, aa_);
            CqlDateTime ac_ = context.Operators.Add(o_ as CqlDateTime, w_);
            CqlInterval<CqlDate> ad_ = context.Operators.Interval((CqlDate)o_, (CqlDate)((object)ac_), false, true);
            CqlInterval<object> ae_ = context.Operators.Convert<CqlInterval<object>>(ad_);
            object af_ = ae_?.low;
            object ag_ = ae_?.high;
            bool? ah_ = ae_?.lowClosed;
            bool? ai_ = ae_?.highClosed;
            CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(af_ as CqlDateTime, ag_ as CqlDateTime, ah_, ai_);
            bool? ak_ = context.Operators.In<CqlDateTime>(v_, aj_, (string)default);
            bool? al_ = context.Operators.And(ak_, aa_);
            bool? am_ = context.Operators.Or(ab_, al_);
            bool? an_ = context.Operators.And(t_, am_);
            Period ao_ = tuple_bundjkpliiuyymiejivrqjjcd?.IndexPCP?.Period;
            CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ao_);
            CqlDateTime aq_ = context.Operators.Start(ap_);
            CqlQuantity ar_ = context.Operators.Quantity(30m, "days");
            CqlDateTime as_ = context.Operators.Subtract(o_ as CqlDateTime, ar_);
            CqlInterval<CqlDateTime> at_ = context.Operators.Interval(as_, o_ as CqlDateTime, true, true);
            bool? au_ = context.Operators.In<CqlDateTime>(aq_, at_, (string)default);
            bool? av_ = context.Operators.And(au_, aa_);
            bool? aw_ = context.Operators.And(an_, av_);
            return aw_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)?>(g_, h_);
        Encounter j_((CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)? tuple_bundjkpliiuyymiejivrqjjcd) => tuple_bundjkpliiuyymiejivrqjjcd?.VTEEncounter;
        IEnumerable<Encounter> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)?, Encounter>(i_, j_);
        IEnumerable<Encounter> l_ = context.Operators.Distinct<Encounter>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Qualified VTE Encounters During Measurement Period")]
    public IEnumerable<Encounter> Qualified_VTE_Encounters_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualified_VTE_Encounters_During_Measurement_Period, Qualified_VTE_Encounters_During_Measurement_Period_Compute);

    private const long _cacheIndex_Qualified_VTE_Encounters_During_Measurement_Period = 1440120495755591922L;

    private IEnumerable<Encounter> Qualified_VTE_Encounters_During_Measurement_Period_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualified_VTE_Encounters(context);

        bool? b_(Encounter QualifiedVTEEncounter) {
            Period d_ = QualifiedVTEEncounter?.Period;
            CqlInterval<CqlDateTime> e_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, d_);
            CqlDateTime f_ = context.Operators.Start(e_);
            CqlInterval<CqlDateTime> g_ = this.Measurement_Period(context);
            bool? h_ = context.Operators.In<CqlDateTime>(f_, g_, "day");
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 6831690428904324054L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualified_VTE_Encounters_During_Measurement_Period(context);

        bool? b_(Encounter QualifiedEncounter) {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDate g_ = context.Operators.ConvertStringToDate(f_);
            Period h_ = QualifiedEncounter?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.Start(i_);
            CqlDate k_ = context.Operators.DateFrom(j_);
            int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
            bool? m_ = context.Operators.GreaterOrEqual(l_, 18);
            return m_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 7523999450907459220L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Qualified VTE Encounter With Hospice Services Within Previous 90 Days")]
    public IEnumerable<Encounter> Qualified_VTE_Encounter_With_Hospice_Services_Within_Previous_90_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualified_VTE_Encounter_With_Hospice_Services_Within_Previous_90_Days, Qualified_VTE_Encounter_With_Hospice_Services_Within_Previous_90_Days_Compute);

    private const long _cacheIndex_Qualified_VTE_Encounter_With_Hospice_Services_Within_Previous_90_Days = -9163851338437726610L;

    private IEnumerable<Encounter> Qualified_VTE_Encounter_With_Hospice_Services_Within_Previous_90_Days_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualified_VTE_Encounters(context);

        bool? b_(Encounter QualifiedVTEEncounter) {
            CqlValueSet d_ = this.Encounter_Inpatient(context);
            IEnumerable<Encounter> e_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? f_(Encounter InpatientEncounter) {
                Encounter.HospitalizationComponent ar_ = InpatientEncounter?.Hospitalization;
                CodeableConcept as_ = ar_?.DischargeDisposition;
                CqlConcept at_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, as_);
                CqlCode au_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
                bool? aw_ = context.Operators.Equivalent(at_, av_);
                CqlCode ax_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept ay_ = context.Operators.ConvertCodeToConcept(ax_);
                bool? az_ = context.Operators.Equivalent(at_, ay_);
                bool? ba_ = context.Operators.Or(aw_, az_);
                Period bb_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
                CqlDateTime bd_ = context.Operators.End(bc_);
                Period be_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                CqlDateTime bg_ = context.Operators.Start(bf_);
                CqlQuantity bh_ = context.Operators.Quantity(90m, "days");
                CqlDateTime bi_ = context.Operators.Subtract(bg_, bh_);
                CqlDateTime bj_ = context.Operators.End(bf_);
                CqlInterval<CqlDateTime> bk_ = context.Operators.Interval(bi_, bj_, true, true);
                bool? bl_ = context.Operators.In<CqlDateTime>(bd_, bk_, "day");
                bool? bm_ = context.Operators.And(ba_, bl_);
                Code<Encounter.EncounterStatus> bn_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? bo_ = bn_?.Value;
                Code<Encounter.EncounterStatus> bp_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bo_);
                bool? bq_ = context.Operators.Equal(bp_, "finished");
                bool? br_ = context.Operators.And(bm_, bq_);
                return br_;
            }

            IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
            bool? h_ = context.Operators.Exists<Encounter>(g_);
            CqlValueSet i_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? k_(Encounter HospiceEncounter) {
                Period bs_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime> bt_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bs_);
                Period bu_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> bv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bu_);
                CqlDateTime bw_ = context.Operators.Start(bv_);
                CqlQuantity bx_ = context.Operators.Quantity(90m, "days");
                CqlDateTime by_ = context.Operators.Subtract(bw_, bx_);
                CqlDateTime bz_ = context.Operators.End(bv_);
                CqlInterval<CqlDateTime> ca_ = context.Operators.Interval(by_, bz_, true, true);
                bool? cb_ = context.Operators.Overlaps(bt_, ca_, "day");
                return cb_;
            }

            IEnumerable<Encounter> l_ = context.Operators.Where<Encounter>(j_, k_);
            bool? m_ = context.Operators.Exists<Encounter>(l_);
            bool? n_ = context.Operators.Or(h_, m_);
            CqlCode o_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode> p_ = context.Operators.ToList<CqlCode>(o_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, p_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? r_(Observation HospiceAssessment) {
                DataType cc_ = HospiceAssessment?.Value;
                object cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                CqlCode ce_ = this.Yes__qualifier_value_(context);
                CqlConcept cf_ = context.Operators.ConvertCodeToConcept(ce_);
                bool? cg_ = context.Operators.Equivalent(cd_ as CqlConcept, cf_);
                DataType ch_ = HospiceAssessment?.Effective;
                object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                CqlInterval<CqlDateTime> cj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ci_);
                Period ck_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> cl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ck_);
                CqlDateTime cm_ = context.Operators.Start(cl_);
                CqlQuantity cn_ = context.Operators.Quantity(90m, "days");
                CqlDateTime co_ = context.Operators.Subtract(cm_, cn_);
                CqlDateTime cp_ = context.Operators.End(cl_);
                CqlInterval<CqlDateTime> cq_ = context.Operators.Interval(co_, cp_, true, true);
                bool? cr_ = context.Operators.Overlaps(cj_, cq_, "day");
                bool? cs_ = context.Operators.And(cg_, cr_);
                return cs_;
            }

            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            bool? t_ = context.Operators.Exists<Observation>(s_);
            bool? u_ = context.Operators.Or(n_, t_);
            CqlValueSet v_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest> w_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

            bool? x_(ServiceRequest HospiceOrder) {
                FhirDateTime ct_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime cu_ = context.Operators.Convert<CqlDateTime>(ct_);
                Period cv_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                CqlDateTime cx_ = context.Operators.Start(cw_);
                CqlQuantity cy_ = context.Operators.Quantity(90m, "days");
                CqlDateTime cz_ = context.Operators.Subtract(cx_, cy_);
                CqlDateTime da_ = context.Operators.End(cw_);
                CqlInterval<CqlDateTime> db_ = context.Operators.Interval(cz_, da_, true, true);
                bool? dc_ = context.Operators.In<CqlDateTime>(cu_, db_, "day");
                Code<RequestStatus> dd_ = HospiceOrder?.StatusElement;
                RequestStatus? de_ = dd_?.Value;
                Code<RequestStatus> df_ = context.Operators.Convert<Code<RequestStatus>>(de_);
                string dg_ = context.Operators.Convert<string>(df_);
                string[] dh_ = [
                    "active",
                    "completed",
                ];
                bool? di_ = context.Operators.In<string>(dg_, (IEnumerable<string>)dh_);
                bool? dj_ = context.Operators.And(dc_, di_);
                return dj_;
            }

            IEnumerable<ServiceRequest> y_ = context.Operators.Where<ServiceRequest>(w_, x_);
            bool? z_ = context.Operators.Exists<ServiceRequest>(y_);
            bool? aa_ = context.Operators.Or(u_, z_);
            IEnumerable<Procedure> ab_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? ac_(Procedure HospicePerformed) {
                object dk_;
                DataType du_ = HospicePerformed?.Performed;
                object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                bool dw_ = dv_ is CqlDateTime;
                if (dw_)
                {
                    DataType dx_ = HospicePerformed?.Performed;
                    object dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
                    dk_ = dy_ as CqlDateTime;
                }
                else
                {
                    DataType dz_ = HospicePerformed?.Performed;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlInterval<CqlDateTime>;
                    if (eb_)
                    {
                        DataType ec_ = HospicePerformed?.Performed;
                        object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                        dk_ = ed_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType ee_ = HospicePerformed?.Performed;
                        object ef_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ee_);
                        bool eg_ = ef_ is CqlQuantity;
                        if (eg_)
                        {
                            DataType eh_ = HospicePerformed?.Performed;
                            object ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                            dk_ = ei_ as CqlQuantity;
                        }
                        else
                        {
                            DataType ej_ = HospicePerformed?.Performed;
                            object ek_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ej_);
                            bool el_ = ek_ is CqlInterval<CqlQuantity>;
                            if (el_)
                            {
                                DataType em_ = HospicePerformed?.Performed;
                                object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                                dk_ = en_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                dk_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> dl_ = QICoreCommon_4_0_000.Instance.toInterval(context, dk_);
                Period dm_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> dn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dm_);
                CqlDateTime do_ = context.Operators.Start(dn_);
                CqlQuantity dp_ = context.Operators.Quantity(90m, "days");
                CqlDateTime dq_ = context.Operators.Subtract(do_, dp_);
                CqlDateTime dr_ = context.Operators.End(dn_);
                CqlInterval<CqlDateTime> ds_ = context.Operators.Interval(dq_, dr_, true, true);
                bool? dt_ = context.Operators.Overlaps(dl_, ds_, "day");
                return dt_;
            }

            IEnumerable<Procedure> ad_ = context.Operators.Where<Procedure>(ab_, ac_);
            bool? ae_ = context.Operators.Exists<Procedure>(ad_);
            bool? af_ = context.Operators.Or(aa_, ae_);
            CqlValueSet ag_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition> ah_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? ai_(Condition HospiceCareDiagnosis) {
                CqlInterval<CqlDateTime> eo_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis as Condition);
                Period ep_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> eq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ep_);
                CqlDateTime er_ = context.Operators.Start(eq_);
                CqlQuantity es_ = context.Operators.Quantity(90m, "days");
                CqlDateTime et_ = context.Operators.Subtract(er_, es_);
                CqlDateTime eu_ = context.Operators.End(eq_);
                CqlInterval<CqlDateTime> ev_ = context.Operators.Interval(et_, eu_, true, true);
                bool? ew_ = context.Operators.Overlaps(eo_, ev_, "day");
                bool? ex_ = this.isVerified(context, HospiceCareDiagnosis as Condition);
                bool? ey_ = context.Operators.And(ew_, ex_);
                return ey_;
            }

            IEnumerable<Condition> aj_ = context.Operators.Where<Condition>(ah_, ai_);
            bool? ak_ = context.Operators.Exists<Condition>(aj_);
            bool? al_ = context.Operators.Or(af_, ak_);
            IEnumerable<Condition> am_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ag_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? an_(Condition HospiceCareConcern) {
                CqlInterval<CqlDateTime> ez_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareConcern as Condition);
                Period fa_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> fb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fa_);
                CqlDateTime fc_ = context.Operators.Start(fb_);
                CqlQuantity fd_ = context.Operators.Quantity(90m, "days");
                CqlDateTime fe_ = context.Operators.Subtract(fc_, fd_);
                CqlDateTime ff_ = context.Operators.End(fb_);
                CqlInterval<CqlDateTime> fg_ = context.Operators.Interval(fe_, ff_, true, true);
                bool? fh_ = context.Operators.Overlaps(ez_, fg_, "day");
                bool? fi_ = this.isVerified(context, HospiceCareConcern as Condition);
                bool? fj_ = context.Operators.And(fh_, fi_);
                return fj_;
            }

            IEnumerable<Condition> ao_ = context.Operators.Where<Condition>(am_, an_);
            bool? ap_ = context.Operators.Exists<Condition>(ao_);
            bool? aq_ = context.Operators.Or(al_, ap_);
            return aq_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Qualified VTE Encounter With Palliative Care Within Previous 90 Days")]
    public IEnumerable<Encounter> Qualified_VTE_Encounter_With_Palliative_Care_Within_Previous_90_Days(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualified_VTE_Encounter_With_Palliative_Care_Within_Previous_90_Days, Qualified_VTE_Encounter_With_Palliative_Care_Within_Previous_90_Days_Compute);

    private const long _cacheIndex_Qualified_VTE_Encounter_With_Palliative_Care_Within_Previous_90_Days = 6905458705983036257L;

    private IEnumerable<Encounter> Qualified_VTE_Encounter_With_Palliative_Care_Within_Previous_90_Days_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualified_VTE_Encounters(context);

        bool? b_(Encounter QualifiedVTEEncounter) {
            CqlCode d_ = this.Functional_Assessment_of_Chronic_Illness_Therapy___Palliative_Care_Questionnaire__FACIT_Pal_(context);
            IEnumerable<CqlCode> e_ = context.Operators.ToList<CqlCode>(d_);
            IEnumerable<Observation> f_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, e_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? g_(Observation PalliativeAssessment) {
                DataType ag_ = PalliativeAssessment?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
                Period aj_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                CqlQuantity am_ = context.Operators.Quantity(90m, "days");
                CqlDateTime an_ = context.Operators.Subtract(al_, am_);
                CqlDateTime ao_ = context.Operators.End(ak_);
                CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(an_, ao_, true, true);
                bool? aq_ = context.Operators.Overlaps(ai_, ap_, "day");
                Code<ObservationStatus> ar_ = PalliativeAssessment?.StatusElement;
                ObservationStatus? as_ = ar_?.Value;
                string at_ = context.Operators.Convert<string>(as_);
                string[] au_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
                bool? aw_ = context.Operators.And(aq_, av_);
                return aw_;
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
            bool? i_ = context.Operators.Exists<Observation>(h_);
            CqlValueSet j_ = this.Palliative_Care_Diagnosis(context);
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? l_(Condition PalliativeCareDiagnosis) {
                CqlInterval<CqlDateTime> ax_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeCareDiagnosis as Condition);
                Period ay_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> az_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ay_);
                CqlDateTime ba_ = context.Operators.Start(az_);
                CqlQuantity bb_ = context.Operators.Quantity(90m, "days");
                CqlDateTime bc_ = context.Operators.Subtract(ba_, bb_);
                CqlDateTime bd_ = context.Operators.End(az_);
                CqlInterval<CqlDateTime> be_ = context.Operators.Interval(bc_, bd_, true, true);
                bool? bf_ = context.Operators.Overlaps(ax_, be_, "day");
                bool? bg_ = this.isVerified(context, PalliativeCareDiagnosis as Condition);
                bool? bh_ = context.Operators.And(bf_, bg_);
                return bh_;
            }

            IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
            bool? n_ = context.Operators.Exists<Condition>(m_);
            bool? o_ = context.Operators.Or(i_, n_);
            IEnumerable<Condition> p_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? q_(Condition PalliativeCareConcern) {
                CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeCareConcern as Condition);
                Period bj_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                CqlQuantity bm_ = context.Operators.Quantity(90m, "days");
                CqlDateTime bn_ = context.Operators.Subtract(bl_, bm_);
                CqlDateTime bo_ = context.Operators.End(bk_);
                CqlInterval<CqlDateTime> bp_ = context.Operators.Interval(bn_, bo_, true, true);
                bool? bq_ = context.Operators.Overlaps(bi_, bp_, "day");
                bool? br_ = this.isVerified(context, PalliativeCareConcern as Condition);
                bool? bs_ = context.Operators.And(bq_, br_);
                return bs_;
            }

            IEnumerable<Condition> r_ = context.Operators.Where<Condition>(p_, q_);
            bool? s_ = context.Operators.Exists<Condition>(r_);
            bool? t_ = context.Operators.Or(o_, s_);
            CqlValueSet u_ = this.Palliative_Care_Encounter(context);
            IEnumerable<Encounter> v_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, u_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? w_(Encounter PalliativeEncounter) {
                Period bt_ = PalliativeEncounter?.Period;
                CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                Period bv_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> bw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bv_);
                CqlDateTime bx_ = context.Operators.Start(bw_);
                CqlQuantity by_ = context.Operators.Quantity(90m, "days");
                CqlDateTime bz_ = context.Operators.Subtract(bx_, by_);
                CqlDateTime ca_ = context.Operators.End(bw_);
                CqlInterval<CqlDateTime> cb_ = context.Operators.Interval(bz_, ca_, true, true);
                bool? cc_ = context.Operators.Overlaps(bu_, cb_, "day");
                return cc_;
            }

            IEnumerable<Encounter> x_ = context.Operators.Where<Encounter>(v_, w_);
            bool? y_ = context.Operators.Exists<Encounter>(x_);
            bool? z_ = context.Operators.Or(t_, y_);
            CqlValueSet aa_ = this.Palliative_Care_Intervention(context);
            IEnumerable<Procedure> ab_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, aa_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? ac_(Procedure PalliativeIntervention) {
                object cd_;
                DataType cn_ = PalliativeIntervention?.Performed;
                object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                bool cp_ = co_ is CqlDateTime;
                if (cp_)
                {
                    DataType cq_ = PalliativeIntervention?.Performed;
                    object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                    cd_ = cr_ as CqlDateTime;
                }
                else
                {
                    DataType cs_ = PalliativeIntervention?.Performed;
                    object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                    bool cu_ = ct_ is CqlInterval<CqlDateTime>;
                    if (cu_)
                    {
                        DataType cv_ = PalliativeIntervention?.Performed;
                        object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                        cd_ = cw_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        DataType cx_ = PalliativeIntervention?.Performed;
                        object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        bool cz_ = cy_ is CqlQuantity;
                        if (cz_)
                        {
                            DataType da_ = PalliativeIntervention?.Performed;
                            object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                            cd_ = db_ as CqlQuantity;
                        }
                        else
                        {
                            DataType dc_ = PalliativeIntervention?.Performed;
                            object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                            bool de_ = dd_ is CqlInterval<CqlQuantity>;
                            if (de_)
                            {
                                DataType df_ = PalliativeIntervention?.Performed;
                                object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                                cd_ = dg_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                cd_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> ce_ = QICoreCommon_4_0_000.Instance.toInterval(context, cd_);
                Period cf_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> cg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cf_);
                CqlDateTime ch_ = context.Operators.Start(cg_);
                CqlQuantity ci_ = context.Operators.Quantity(90m, "days");
                CqlDateTime cj_ = context.Operators.Subtract(ch_, ci_);
                CqlDateTime ck_ = context.Operators.End(cg_);
                CqlInterval<CqlDateTime> cl_ = context.Operators.Interval(cj_, ck_, true, true);
                bool? cm_ = context.Operators.Overlaps(ce_, cl_, "day");
                return cm_;
            }

            IEnumerable<Procedure> ad_ = context.Operators.Where<Procedure>(ab_, ac_);
            bool? ae_ = context.Operators.Exists<Procedure>(ad_);
            bool? af_ = context.Operators.Or(z_, ae_);
            return af_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Qualified VTE Encounter With Other Qualified VTE Encounter Documented Within Previous 6 Months")]
    public IEnumerable<Encounter> Qualified_VTE_Encounter_With_Other_Qualified_VTE_Encounter_Documented_Within_Previous_6_Months(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualified_VTE_Encounter_With_Other_Qualified_VTE_Encounter_Documented_Within_Previous_6_Months, Qualified_VTE_Encounter_With_Other_Qualified_VTE_Encounter_Documented_Within_Previous_6_Months_Compute);

    private const long _cacheIndex_Qualified_VTE_Encounter_With_Other_Qualified_VTE_Encounter_Documented_Within_Previous_6_Months = 5744213313538605082L;

    private IEnumerable<Encounter> Qualified_VTE_Encounter_With_Other_Qualified_VTE_Encounter_Documented_Within_Previous_6_Months_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualified_VTE_Encounters(context);

        bool? b_(Encounter CurrentQualifiedVTE) {
            IEnumerable<Encounter> d_ = this.Qualified_VTE_Encounters(context);

            bool? e_(Encounter PreviousQualifiedVTE) {
                Period h_ = PreviousQualifiedVTE?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = CurrentQualifiedVTE?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlQuantity n_ = context.Operators.Quantity(6m, "months");
                CqlDateTime o_ = context.Operators.Subtract(m_, n_);
                CqlInterval<CqlDateTime> p_ = context.Operators.Interval(o_, m_, true, false);
                bool? q_ = context.Operators.In<CqlDateTime>(j_, p_, (string)default);
                bool? r_ = context.Operators.Not((bool?)(m_ is null));
                bool? s_ = context.Operators.And(q_, r_);
                return s_;
            }

            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            bool? g_ = context.Operators.Exists<Encounter>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 2926763216967038693L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualified_VTE_Encounter_With_Hospice_Services_Within_Previous_90_Days(context);
        IEnumerable<Encounter> b_ = this.Qualified_VTE_Encounter_With_Palliative_Care_Within_Previous_90_Days(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Qualified_VTE_Encounter_With_Other_Qualified_VTE_Encounter_Documented_Within_Previous_6_Months(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Qualifying Delayed VTE Encounter")]
    public IEnumerable<Encounter> Qualifying_Delayed_VTE_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Delayed_VTE_Encounter, Qualifying_Delayed_VTE_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Delayed_VTE_Encounter = 1933165867950008933L;

    private IEnumerable<Encounter> Qualifying_Delayed_VTE_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualified_VTE_Encounters_During_Measurement_Period(context);

        bool? b_(Encounter DelayedVTEEncounter) {
            IEnumerable<Encounter> d_ = this.Qualifying_Performed_PCP_Visits_With_VTE_Symptom(context);

            bool? e_(Encounter IndexPCPVisit) {
                Period h_ = DelayedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                Period k_ = IndexPCPVisit?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.End(l_);
                CqlQuantity n_ = context.Operators.Quantity(2m, "day");
                CqlDateTime o_ = context.Operators.Add(m_, n_);
                CqlQuantity p_ = context.Operators.Quantity(30m, "days");
                CqlDateTime q_ = context.Operators.Add(m_, p_);
                CqlInterval<CqlDateTime> r_ = context.Operators.Interval(o_, q_, true, true);
                bool? s_ = context.Operators.In<CqlDateTime>(j_, r_, "day");
                return s_;
            }

            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            bool? g_ = context.Operators.Exists<Encounter>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 2150200294726777213L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Delayed_VTE_Encounter(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -4641750971103456558L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 6534542512085165381L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 5664667190711607769L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 7998407842162547825L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS1173FHIRDiagnosticDelayVTE_1_0_000() {}

    public static CMS1173FHIRDiagnosticDelayVTE_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1173FHIRDiagnosticDelayVTE";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [CQMCommon_4_1_000.Instance, FHIRHelpers_4_4_000.Instance, QICoreCommon_4_0_000.Instance, SupplementalDataElements_5_1_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GAFATFEJifSPXLKbTBWFddDeY = new(
       [typeof(Encounter), typeof(Encounter), typeof(DiagnosticReport), typeof(MedicationRequest)],
       ["VTEEncounter", "IndexPCP", "VTEStudy", "AntiCoagulantOrdered"]);

    #endregion CqlTupleMetadata Properties

}
