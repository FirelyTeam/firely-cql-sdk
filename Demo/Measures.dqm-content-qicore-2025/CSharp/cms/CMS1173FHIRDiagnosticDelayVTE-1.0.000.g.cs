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
            CqlBoolean n_ = context.Operators.Equal(m_, "finished");
            Period o_ = Encounter?.Period;
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            CqlDateTime s_ = context.Operators.Start(r_);
            CqlQuantity t_ = context.Operators.Quantity(180m, "days");
            CqlDateTime u_ = context.Operators.Subtract(s_, t_);
            CqlDateTime v_ = context.Operators.End(r_);
            CqlInterval<CqlDateTime> w_ = context.Operators.Interval(u_, v_, true, true);
            CqlBoolean x_ = context.Operators.In<CqlDateTime>(q_, w_, "day");
            CqlBoolean y_ = x_;
            return n_
                /* CQL 'and' (66:5-67:127) */ && y_;
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
        CqlBoolean e_ = context.Operators.Equivalent(b_, d_);
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
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return m_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.VTE_Diagnoses(context);
            CqlBoolean h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? j_(Condition VTECondition) {
                CqlBoolean n_ = this.isConfirmedCondition(context, VTECondition);
                List<ResourceReference> o_ = VTEEncounter?.ReasonReference;
                CqlBoolean p_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)o_, VTECondition);
                CqlBoolean q_ = p_;
                return n_
                    /* CQL 'and' (87:11-88:72) */ && q_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<Condition>(i_, j_);
            CqlBoolean l_ = k_;
            return h_
                /* CQL 'or' (85:5-89:7) */ || l_;
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
            CqlBoolean k_ = context.Operators.Equal(j_, "finished");
            Period l_ = PCPVisit?.Period;
            CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
            CqlDateTime n_ = context.Operators.End(m_);
            CqlInterval<CqlDateTime> o_ = this.Measurement_Period(context);
            CqlDateTime p_ = context.Operators.Start(o_);
            CqlQuantity q_ = context.Operators.Quantity(210m, "days");
            CqlDateTime r_ = context.Operators.Subtract(p_, q_);
            CqlDateTime s_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(r_, s_, true, true);
            CqlBoolean u_ = context.Operators.In<CqlDateTime>(n_, t_, "day");
            CqlBoolean v_ = u_;
            return k_
                /* CQL 'and' (72:5-73:124) */ && v_;
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
        CqlCode c_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept d_ = context.Operators.ConvertCodeToConcept(c_);
        CqlBoolean e_ = context.Operators.Equivalent(b_, d_);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        CqlBoolean h_ = context.Operators.Equivalent(b_, g_);
        CqlBoolean i_ = h_;
        CqlCode j_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
        CqlBoolean l_ = context.Operators.Equivalent(b_, k_);
        CqlBoolean m_ = l_;
        CqlCode n_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
        CqlBoolean p_ = context.Operators.Equivalent(b_, o_);
        CqlBoolean q_ = p_;
        CqlBoolean r_ = e_
            /* CQL 'or' (202:54-203:66) */ || i_
            /* CQL 'or' (202:54-204:66) */ || m_
            /* CQL 'or' (202:52-206:3) */ || q_;
        return (CqlBoolean)(b_ is null)
            /* CQL 'implies' (202:3-206:3) */ || r_;
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
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return m_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.VTE_Symptoms(context);
            CqlBoolean h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? j_(Condition VTESymptomCondition) {
                CqlBoolean n_ = this.isVerified(context, VTESymptomCondition as Condition);
                List<ResourceReference> o_ = IndexPCPVisit?.ReasonReference;
                CqlBoolean p_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)o_, VTESymptomCondition);
                CqlBoolean q_ = p_;
                return n_
                    /* CQL 'and' (79:11-80:80) */ && q_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<Condition>(i_, j_);
            CqlBoolean l_ = k_;
            return h_
                /* CQL 'or' (77:5-81:7) */ || l_;
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
            CqlBoolean i_ = context.Operators.In<string>(g_, (IEnumerable<string>)h_);
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
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object l_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object m_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> n_ = context.Operators.Split((string)m_, "/");
                string o_ = context.Operators.Last<string>(n_);
                CqlBoolean p_ = context.Operators.Equal(l_, o_);
                CodeableConcept q_ = M?.Code;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlValueSet s_ = this.Anticoagulant_Medications(context);
                CqlBoolean t_ = context.Operators.ConceptInValueSet(r_, s_);
                CqlBoolean u_ = t_;
                return p_
                    /* CQL 'and' */ && u_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Anticoagulant_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest AntiCoagulant) {
            Code<MedicationRequest.MedicationrequestStatus> v_ = AntiCoagulant?.StatusElement;
            MedicationRequest.MedicationrequestStatus? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            string[] y_ = [
                "active",
                "completed",
            ];
            CqlBoolean z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
            Code<MedicationRequest.MedicationRequestIntent> aa_ = AntiCoagulant?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            CqlBoolean ad_ = context.Operators.Equal(ac_, "order");
            CqlBoolean ae_ = ad_;
            return z_
                /* CQL 'and' (97:5-98:40) */ && ae_;
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
            (CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)? k_ = (CqlTupleMetadata_GAFATFEJifSPXLKbTBWFddDeY, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3, _valueTuple.Item4);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)? tuple_bundjkpliiuyymiejivrqjjcd) {
            DataType l_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEStudy?.Effective;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
            CqlDateTime o_ = context.Operators.Start(n_);
            Period p_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEEncounter?.Period;
            CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
            CqlBoolean r_ = context.Operators.In<CqlDateTime>(o_, q_, "day");
            FhirDateTime s_ = tuple_bundjkpliiuyymiejivrqjjcd?.AntiCoagulantOrdered?.AuthoredOnElement;
            CqlDateTime t_ = context.Operators.Convert<CqlDateTime>(s_);
            CqlQuantity u_ = context.Operators.Quantity(12m, "hours");
            CqlDateTime v_ = context.Operators.Subtract(m_ as CqlDateTime, u_);
            CqlInterval<CqlDateTime> w_ = context.Operators.Interval(v_, m_ as CqlDateTime, true, false);
            CqlBoolean x_ = context.Operators.In<CqlDateTime>(t_, w_, (string)default);
            CqlBoolean y_ = (CqlBoolean)(m_ is not null);
            CqlDateTime z_ = context.Operators.Add(m_ as CqlDateTime, u_);
            CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(m_ as CqlDateTime, z_ as CqlDateTime, false, true);
            CqlBoolean ab_ = context.Operators.In<CqlDateTime>(t_, aa_, (string)default);
            CqlBoolean ac_ = ab_
                /* CQL 'and' (108:14-108:86) */ && y_;
            CqlBoolean ad_ = (x_
                /* CQL 'and' (107:13-107:86) */ && y_)
                /* CQL 'or' (107:11-109:7) */ || ac_;
            Period ae_ = tuple_bundjkpliiuyymiejivrqjjcd?.IndexPCP?.Period;
            CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
            CqlDateTime ag_ = context.Operators.Start(af_);
            CqlQuantity ah_ = context.Operators.Quantity(30m, "days");
            CqlDateTime ai_ = context.Operators.Subtract(m_ as CqlDateTime, ah_);
            CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ai_, m_ as CqlDateTime, true, true);
            CqlBoolean ak_ = context.Operators.In<CqlDateTime>(ag_, aj_, (string)default);
            CqlBoolean al_ = ak_
                /* CQL 'and' (110:11-110:80) */ && y_;
            return r_
                /* CQL 'and' (106:11-109:7) */ && ad_
                /* CQL 'and' (106:5-110:80) */ && al_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Encounter, DiagnosticReport, MedicationRequest>, (CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)?>(e_, f_, g_);
        Encounter i_((CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)? tuple_bundjkpliiuyymiejivrqjjcd) => tuple_bundjkpliiuyymiejivrqjjcd?.VTEEncounter;
        IEnumerable<Encounter> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter VTEEncounter, Encounter IndexPCP, DiagnosticReport VTEStudy, MedicationRequest AntiCoagulantOrdered)?, Encounter>(h_, i_);
        return j_;
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
            CqlBoolean h_ = context.Operators.In<CqlDateTime>(f_, g_, "day");
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
            CqlBoolean m_ = context.Operators.GreaterOrEqual(l_, 18);
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
                Encounter.HospitalizationComponent ak_ = InpatientEncounter?.Hospitalization;
                CodeableConcept al_ = ak_?.DischargeDisposition;
                CqlConcept am_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, al_);
                CqlCode an_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept ao_ = context.Operators.ConvertCodeToConcept(an_);
                CqlBoolean ap_ = context.Operators.Equivalent(am_, ao_);
                CqlCode aq_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept ar_ = context.Operators.ConvertCodeToConcept(aq_);
                CqlBoolean as_ = context.Operators.Equivalent(am_, ar_);
                CqlBoolean at_ = as_;
                Period au_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                CqlDateTime aw_ = context.Operators.End(av_);
                Period ax_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                CqlDateTime az_ = context.Operators.Start(ay_);
                CqlQuantity ba_ = context.Operators.Quantity(90m, "days");
                CqlDateTime bb_ = context.Operators.Subtract(az_, ba_);
                CqlDateTime bc_ = context.Operators.End(ay_);
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(bb_, bc_, true, true);
                CqlBoolean be_ = context.Operators.In<CqlDateTime>(aw_, bd_, "day");
                CqlBoolean bf_ = be_;
                Code<Encounter.EncounterStatus> bg_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? bh_ = bg_?.Value;
                Code<Encounter.EncounterStatus> bi_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bh_);
                CqlBoolean bj_ = context.Operators.Equal(bi_, "finished");
                CqlBoolean bk_ = bj_;
                return (ap_
                    /* CQL 'or' (127:15-129:9) */ || at_)
                    /* CQL 'and' (127:15-130:87) */ && bf_
                    /* CQL 'and' (127:9-131:52) */ && bk_;
            }

            CqlBoolean g_ = context.Operators.WhereAny<Encounter>(e_, f_);
            CqlValueSet h_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? j_(Encounter HospiceEncounter) {
                Period bl_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime> bm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bl_);
                Period bn_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                CqlDateTime bp_ = context.Operators.Start(bo_);
                CqlQuantity bq_ = context.Operators.Quantity(90m, "days");
                CqlDateTime br_ = context.Operators.Subtract(bp_, bq_);
                CqlDateTime bs_ = context.Operators.End(bo_);
                CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(br_, bs_, true, true);
                CqlBoolean bu_ = context.Operators.Overlaps(bm_, bt_, "day");
                return bu_;
            }

            CqlBoolean k_ = context.Operators.WhereAny<Encounter>(i_, j_);
            CqlBoolean l_ = k_;
            CqlCode m_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode> n_ = context.Operators.ToList<CqlCode>(m_);
            IEnumerable<Observation> o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, n_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? p_(Observation HospiceAssessment) {
                DataType bv_ = HospiceAssessment?.Value;
                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                CqlCode bx_ = this.Yes__qualifier_value_(context);
                CqlConcept by_ = context.Operators.ConvertCodeToConcept(bx_);
                CqlBoolean bz_ = context.Operators.Equivalent(bw_ as CqlConcept, by_);
                DataType ca_ = HospiceAssessment?.Effective;
                object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                CqlInterval<CqlDateTime> cc_ = QICoreCommon_4_0_000.Instance.toInterval(context, cb_);
                Period cd_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> ce_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cd_);
                CqlDateTime cf_ = context.Operators.Start(ce_);
                CqlQuantity cg_ = context.Operators.Quantity(90m, "days");
                CqlDateTime ch_ = context.Operators.Subtract(cf_, cg_);
                CqlDateTime ci_ = context.Operators.End(ce_);
                CqlInterval<CqlDateTime> cj_ = context.Operators.Interval(ch_, ci_, true, true);
                CqlBoolean ck_ = context.Operators.Overlaps(cc_, cj_, "day");
                CqlBoolean cl_ = ck_;
                return bz_
                    /* CQL 'and' (137:11-138:103) */ && cl_;
            }

            CqlBoolean q_ = context.Operators.WhereAny<Observation>(o_, p_);
            CqlBoolean r_ = q_;
            CqlValueSet s_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest> t_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

            bool? u_(ServiceRequest HospiceOrder) {
                FhirDateTime cm_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime cn_ = context.Operators.Convert<CqlDateTime>(cm_);
                Period co_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                CqlDateTime cq_ = context.Operators.Start(cp_);
                CqlQuantity cr_ = context.Operators.Quantity(90m, "days");
                CqlDateTime cs_ = context.Operators.Subtract(cq_, cr_);
                CqlDateTime ct_ = context.Operators.End(cp_);
                CqlInterval<CqlDateTime> cu_ = context.Operators.Interval(cs_, ct_, true, true);
                CqlBoolean cv_ = context.Operators.In<CqlDateTime>(cn_, cu_, "day");
                Code<RequestStatus> cw_ = HospiceOrder?.StatusElement;
                RequestStatus? cx_ = cw_?.Value;
                Code<RequestStatus> cy_ = context.Operators.Convert<Code<RequestStatus>>(cx_);
                string cz_ = context.Operators.Convert<string>(cy_);
                string[] da_ = [
                    "active",
                    "completed",
                ];
                CqlBoolean db_ = context.Operators.In<string>(cz_, (IEnumerable<string>)da_);
                CqlBoolean dc_ = db_;
                return cv_
                    /* CQL 'and' (141:11-142:64) */ && dc_;
            }

            CqlBoolean v_ = context.Operators.WhereAny<ServiceRequest>(t_, u_);
            CqlBoolean w_ = v_;
            IEnumerable<Procedure> x_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, s_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? y_(Procedure HospicePerformed) {
                object dd_;
                DataType dn_ = HospicePerformed?.Performed;
                object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                bool dp_ = do_ is CqlDateTime;
                if (dp_)
                {
                    dd_ = do_ as CqlDateTime;
                }
                else
                {
                    bool dq_ = do_ is CqlQuantity;
                    if (dq_)
                    {
                        dd_ = do_ as CqlQuantity;
                    }
                    else
                    {
                        bool dr_ = do_ is CqlInterval<CqlDateTime>;
                        if (dr_)
                        {
                            dd_ = do_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool ds_ = do_ is CqlInterval<CqlQuantity>;
                            if (ds_)
                            {
                                dd_ = do_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                dd_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> de_ = QICoreCommon_4_0_000.Instance.toInterval(context, dd_);
                Period df_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> dg_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, df_);
                CqlDateTime dh_ = context.Operators.Start(dg_);
                CqlQuantity di_ = context.Operators.Quantity(90m, "days");
                CqlDateTime dj_ = context.Operators.Subtract(dh_, di_);
                CqlDateTime dk_ = context.Operators.End(dg_);
                CqlInterval<CqlDateTime> dl_ = context.Operators.Interval(dj_, dk_, true, true);
                CqlBoolean dm_ = context.Operators.Overlaps(de_, dl_, "day");
                return dm_;
            }

            CqlBoolean z_ = context.Operators.WhereAny<Procedure>(x_, y_);
            CqlBoolean aa_ = z_;
            CqlValueSet ab_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition> ac_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? ad_(Condition HospiceCareDiagnosis) {
                CqlInterval<CqlDateTime> dt_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis as Condition);
                Period du_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> dv_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, du_);
                CqlDateTime dw_ = context.Operators.Start(dv_);
                CqlQuantity dx_ = context.Operators.Quantity(90m, "days");
                CqlDateTime dy_ = context.Operators.Subtract(dw_, dx_);
                CqlDateTime dz_ = context.Operators.End(dv_);
                CqlInterval<CqlDateTime> ea_ = context.Operators.Interval(dy_, dz_, true, true);
                CqlBoolean eb_ = context.Operators.Overlaps(dt_, ea_, "day");
                return eb_
                    /* CQL 'and' (148:11-149:51) */ && this.isVerified(context, HospiceCareDiagnosis as Condition);
            }

            CqlBoolean ae_ = context.Operators.WhereAny<Condition>(ac_, ad_);
            CqlBoolean af_ = ae_;
            IEnumerable<Condition> ag_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? ah_(Condition HospiceCareConcern) {
                CqlInterval<CqlDateTime> ec_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareConcern as Condition);
                Period ed_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> ee_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ed_);
                CqlDateTime ef_ = context.Operators.Start(ee_);
                CqlQuantity eg_ = context.Operators.Quantity(90m, "days");
                CqlDateTime eh_ = context.Operators.Subtract(ef_, eg_);
                CqlDateTime ei_ = context.Operators.End(ee_);
                CqlInterval<CqlDateTime> ej_ = context.Operators.Interval(eh_, ei_, true, true);
                CqlBoolean ek_ = context.Operators.Overlaps(ec_, ej_, "day");
                return ek_
                    /* CQL 'and' (152:11-153:49) */ && this.isVerified(context, HospiceCareConcern as Condition);
            }

            CqlBoolean ai_ = context.Operators.WhereAny<Condition>(ag_, ah_);
            CqlBoolean aj_ = ai_;
            return g_
                /* CQL 'or' (126:11-135:7) */ || l_
                /* CQL 'or' (126:11-139:7) */ || r_
                /* CQL 'or' (126:11-143:7) */ || w_
                /* CQL 'or' (126:11-146:7) */ || aa_
                /* CQL 'or' (126:11-150:7) */ || af_
                /* CQL 'or' (126:5-154:7) */ || aj_;
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
                DataType ab_ = PalliativeAssessment?.Effective;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
                Period ae_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ae_);
                CqlDateTime ag_ = context.Operators.Start(af_);
                CqlQuantity ah_ = context.Operators.Quantity(90m, "days");
                CqlDateTime ai_ = context.Operators.Subtract(ag_, ah_);
                CqlDateTime aj_ = context.Operators.End(af_);
                CqlInterval<CqlDateTime> ak_ = context.Operators.Interval(ai_, aj_, true, true);
                CqlBoolean al_ = context.Operators.Overlaps(ad_, ak_, "day");
                Code<ObservationStatus> am_ = PalliativeAssessment?.StatusElement;
                ObservationStatus? an_ = am_?.Value;
                string ao_ = context.Operators.Convert<string>(an_);
                string[] ap_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                CqlBoolean aq_ = context.Operators.In<string>(ao_, (IEnumerable<string>)ap_);
                CqlBoolean ar_ = aq_;
                return al_
                    /* CQL 'and' (161:9-162:80) */ && ar_;
            }

            CqlBoolean h_ = context.Operators.WhereAny<Observation>(f_, g_);
            CqlValueSet i_ = this.Palliative_Care_Diagnosis(context);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? k_(Condition PalliativeCareDiagnosis) {
                CqlInterval<CqlDateTime> as_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeCareDiagnosis as Condition);
                Period at_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, at_);
                CqlDateTime av_ = context.Operators.Start(au_);
                CqlQuantity aw_ = context.Operators.Quantity(90m, "days");
                CqlDateTime ax_ = context.Operators.Subtract(av_, aw_);
                CqlDateTime ay_ = context.Operators.End(au_);
                CqlInterval<CqlDateTime> az_ = context.Operators.Interval(ax_, ay_, true, true);
                CqlBoolean ba_ = context.Operators.Overlaps(as_, az_, "day");
                return ba_
                    /* CQL 'and' (165:11-166:54) */ && this.isVerified(context, PalliativeCareDiagnosis as Condition);
            }

            CqlBoolean l_ = context.Operators.WhereAny<Condition>(j_, k_);
            CqlBoolean m_ = l_;
            IEnumerable<Condition> n_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? o_(Condition PalliativeCareConcern) {
                CqlInterval<CqlDateTime> bb_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeCareConcern as Condition);
                Period bc_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> bd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bc_);
                CqlDateTime be_ = context.Operators.Start(bd_);
                CqlQuantity bf_ = context.Operators.Quantity(90m, "days");
                CqlDateTime bg_ = context.Operators.Subtract(be_, bf_);
                CqlDateTime bh_ = context.Operators.End(bd_);
                CqlInterval<CqlDateTime> bi_ = context.Operators.Interval(bg_, bh_, true, true);
                CqlBoolean bj_ = context.Operators.Overlaps(bb_, bi_, "day");
                return bj_
                    /* CQL 'and' (169:11-170:52) */ && this.isVerified(context, PalliativeCareConcern as Condition);
            }

            CqlBoolean p_ = context.Operators.WhereAny<Condition>(n_, o_);
            CqlBoolean q_ = p_;
            CqlValueSet r_ = this.Palliative_Care_Encounter(context);
            IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? t_(Encounter PalliativeEncounter) {
                Period bk_ = PalliativeEncounter?.Period;
                CqlInterval<CqlDateTime> bl_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bk_);
                Period bm_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                CqlDateTime bo_ = context.Operators.Start(bn_);
                CqlQuantity bp_ = context.Operators.Quantity(90m, "days");
                CqlDateTime bq_ = context.Operators.Subtract(bo_, bp_);
                CqlDateTime br_ = context.Operators.End(bn_);
                CqlInterval<CqlDateTime> bs_ = context.Operators.Interval(bq_, br_, true, true);
                CqlBoolean bt_ = context.Operators.Overlaps(bl_, bs_, "day");
                return bt_;
            }

            CqlBoolean u_ = context.Operators.WhereAny<Encounter>(s_, t_);
            CqlBoolean v_ = u_;
            CqlValueSet w_ = this.Palliative_Care_Intervention(context);
            IEnumerable<Procedure> x_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, w_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? y_(Procedure PalliativeIntervention) {
                object bu_;
                DataType ce_ = PalliativeIntervention?.Performed;
                object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                bool cg_ = cf_ is CqlDateTime;
                if (cg_)
                {
                    bu_ = cf_ as CqlDateTime;
                }
                else
                {
                    bool ch_ = cf_ is CqlQuantity;
                    if (ch_)
                    {
                        bu_ = cf_ as CqlQuantity;
                    }
                    else
                    {
                        bool ci_ = cf_ is CqlInterval<CqlDateTime>;
                        if (ci_)
                        {
                            bu_ = cf_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool cj_ = cf_ is CqlInterval<CqlQuantity>;
                            if (cj_)
                            {
                                bu_ = cf_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                bu_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> bv_ = QICoreCommon_4_0_000.Instance.toInterval(context, bu_);
                Period bw_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> bx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bw_);
                CqlDateTime by_ = context.Operators.Start(bx_);
                CqlQuantity bz_ = context.Operators.Quantity(90m, "days");
                CqlDateTime ca_ = context.Operators.Subtract(by_, bz_);
                CqlDateTime cb_ = context.Operators.End(bx_);
                CqlInterval<CqlDateTime> cc_ = context.Operators.Interval(ca_, cb_, true, true);
                CqlBoolean cd_ = context.Operators.Overlaps(bv_, cc_, "day");
                return cd_;
            }

            CqlBoolean z_ = context.Operators.WhereAny<Procedure>(x_, y_);
            CqlBoolean aa_ = z_;
            return h_
                /* CQL 'or' (160:11-167:7) */ || m_
                /* CQL 'or' (160:11-171:7) */ || q_
                /* CQL 'or' (160:11-174:7) */ || v_
                /* CQL 'or' (160:5-177:7) */ || aa_;
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
                Period g_ = PreviousQualifiedVTE?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                CqlDateTime i_ = context.Operators.Start(h_);
                Period j_ = CurrentQualifiedVTE?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlQuantity m_ = context.Operators.Quantity(6m, "months");
                CqlDateTime n_ = context.Operators.Subtract(l_, m_);
                CqlInterval<CqlDateTime> o_ = context.Operators.Interval(n_, l_, true, false);
                CqlBoolean p_ = context.Operators.In<CqlDateTime>(i_, o_, (string)default);
                CqlBoolean q_ = (CqlBoolean)(l_ is not null);
                return p_
                    /* CQL 'and' (182:17-182:110) */ && q_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return f_;
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
                Period g_ = DelayedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
                CqlDateTime i_ = context.Operators.Start(h_);
                Period j_ = IndexPCPVisit?.Period;
                CqlInterval<CqlDateTime> k_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, j_);
                CqlDateTime l_ = context.Operators.End(k_);
                CqlQuantity m_ = context.Operators.Quantity(2m, "day");
                CqlDateTime n_ = context.Operators.Add(l_, m_);
                CqlQuantity o_ = context.Operators.Quantity(30m, "days");
                CqlDateTime p_ = context.Operators.Add(l_, o_);
                CqlInterval<CqlDateTime> q_ = context.Operators.Interval(n_, p_, true, true);
                CqlBoolean r_ = context.Operators.In<CqlDateTime>(i_, q_, "day");
                return r_;
            }

            CqlBoolean f_ = context.Operators.WhereAny<Encounter>(d_, e_);
            return f_;
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
