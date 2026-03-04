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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.0.0")]
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
            CqlDateTime w_ = context.Operators.End(r_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(u_, w_, true, true);
            bool? y_ = context.Operators.In<CqlDateTime>(q_, x_, "day");
            bool? z_ = context.Operators.And(n_, y_);
            return z_;
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
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.VTE_Diagnoses(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? k_(Condition VTECondition) {
                bool? p_ = this.isConfirmedCondition(context, VTECondition);
                List<ResourceReference> q_ = VTEEncounter?.ReasonReference;
                bool? r_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)q_, VTECondition);
                bool? s_ = context.Operators.And(p_, r_);
                return s_;
            }

            IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
            bool? m_ = context.Operators.Exists<Condition>(l_);
            bool? n_ = context.Operators.Or(h_, m_);
            return n_;
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
            CqlDateTime t_ = context.Operators.End(o_);
            CqlInterval<CqlDateTime> u_ = context.Operators.Interval(r_, t_, true, true);
            bool? v_ = context.Operators.In<CqlDateTime>(n_, u_, "day");
            bool? w_ = context.Operators.And(k_, v_);
            return w_;
        }

        IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
        return g_;
    }


    [CqlFunctionDefinition("isVerified")]
    [CqlTag("description", "Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential")]
    public bool? isVerified(CqlContext context, object condition)
    {
        object a_ = context.Operators.LateBoundProperty<object>(condition, "verificationStatus");
        CqlConcept b_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        bool? c_ = context.Operators.Not((bool?)(b_ is null));
        CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
        CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
        bool? h_ = context.Operators.Equivalent(e_, g_);
        CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode k_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
        CqlConcept l_ = context.Operators.ConvertCodeToConcept(k_);
        bool? m_ = context.Operators.Equivalent(j_, l_);
        bool? n_ = context.Operators.Or(h_, m_);
        CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode q_ = QICoreCommon_4_0_000.Instance.provisional(context);
        CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
        bool? s_ = context.Operators.Equivalent(p_, r_);
        bool? t_ = context.Operators.Or(n_, s_);
        CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, a_ as CodeableConcept);
        CqlCode w_ = QICoreCommon_4_0_000.Instance.differential(context);
        CqlConcept x_ = context.Operators.ConvertCodeToConcept(w_);
        bool? y_ = context.Operators.Equivalent(v_, x_);
        bool? z_ = context.Operators.Or(t_, y_);
        bool? aa_ = context.Operators.Implies(c_, z_);
        return aa_;
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
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return o_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.VTE_Symptoms(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? k_(Condition VTESymptomCondition) {
                bool? p_ = this.isVerified(context, VTESymptomCondition as object);
                List<ResourceReference> q_ = IndexPCPVisit?.ReasonReference;
                bool? r_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)q_, VTESymptomCondition);
                bool? s_ = context.Operators.And(p_, r_);
                return s_;
            }

            IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
            bool? m_ = context.Operators.Exists<Condition>(l_);
            bool? n_ = context.Operators.Or(h_, m_);
            return n_;
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

        IEnumerable<MedicationRequest> d_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                string q_ = context.Operators.Last<string>(p_);
                bool? r_ = context.Operators.Equal(n_, q_);
                CodeableConcept s_ = M?.Code;
                CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                CqlValueSet u_ = this.Anticoagulant_Medications(context);
                bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                bool? w_ = context.Operators.And(r_, v_);
                return w_;
            }

            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            MedicationRequest l_(Medication M) => MR;
            IEnumerable<MedicationRequest> m_ = context.Operators.Select<Medication, MedicationRequest>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationRequest> e_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(c_, d_);
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(b_, e_);

        bool? g_(MedicationRequest AntiCoagulant) {
            Code<MedicationRequest.MedicationrequestStatus> x_ = AntiCoagulant?.StatusElement;
            MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
            string z_ = context.Operators.Convert<string>(y_);
            string[] aa_ = [
                "active",
                "completed",
            ];
            bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
            Code<MedicationRequest.MedicationRequestIntent> ac_ = AntiCoagulant?.IntentElement;
            MedicationRequest.MedicationRequestIntent? ad_ = ac_?.Value;
            string ae_ = context.Operators.Convert<string>(ad_);
            bool? af_ = context.Operators.Equal(ae_, "order");
            bool? ag_ = context.Operators.And(ab_, af_);
            return ag_;
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
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity y_ = context.Operators.Quantity(12m, "hours");
            CqlDateTime z_ = context.Operators.Subtract(x_ as CqlDateTime, y_);
            object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(z_, ab_ as CqlDateTime, true, false);
            bool? ad_ = context.Operators.In<CqlDateTime>(v_, ac_, (string)default);
            object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            bool? ag_ = context.Operators.Not((bool?)(af_ is null));
            bool? ah_ = context.Operators.And(ad_, ag_);
            CqlDateTime aj_ = context.Operators.Convert<CqlDateTime>(u_);
            object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlDateTime ap_ = context.Operators.Add(an_ as CqlDateTime, y_);
            CqlInterval<CqlDate> aq_ = context.Operators.Interval((CqlDate)al_, (CqlDate)(ap_ as object), false, true);
            CqlInterval<object> ar_ = context.Operators.Convert<CqlInterval<object>>(aq_);
            object as_ = ar_?.low;
            object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlDateTime ay_ = context.Operators.Add(aw_ as CqlDateTime, y_);
            CqlInterval<CqlDate> az_ = context.Operators.Interval((CqlDate)au_, (CqlDate)(ay_ as object), false, true);
            CqlInterval<object> ba_ = context.Operators.Convert<CqlInterval<object>>(az_);
            object bb_ = ba_?.high;
            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            object bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlDateTime bh_ = context.Operators.Add(bf_ as CqlDateTime, y_);
            CqlInterval<CqlDate> bi_ = context.Operators.Interval((CqlDate)bd_, (CqlDate)(bh_ as object), false, true);
            CqlInterval<object> bj_ = context.Operators.Convert<CqlInterval<object>>(bi_);
            bool? bk_ = bj_?.lowClosed;
            object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlDateTime bq_ = context.Operators.Add(bo_ as CqlDateTime, y_);
            CqlInterval<CqlDate> br_ = context.Operators.Interval((CqlDate)bm_, (CqlDate)(bq_ as object), false, true);
            CqlInterval<object> bs_ = context.Operators.Convert<CqlInterval<object>>(br_);
            bool? bt_ = bs_?.highClosed;
            CqlInterval<CqlDateTime> bu_ = context.Operators.Interval(as_ as CqlDateTime, bb_ as CqlDateTime, bk_, bt_);
            bool? bv_ = context.Operators.In<CqlDateTime>(aj_, bu_, (string)default);
            object bx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            bool? by_ = context.Operators.Not((bool?)(bx_ is null));
            bool? bz_ = context.Operators.And(bv_, by_);
            bool? ca_ = context.Operators.Or(ah_, bz_);
            bool? cb_ = context.Operators.And(t_, ca_);
            Period cc_ = tuple_bundjkpliiuyymiejivrqjjcd?.IndexPCP?.Period;
            CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
            CqlDateTime ce_ = context.Operators.Start(cd_);
            object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlQuantity ch_ = context.Operators.Quantity(30m, "days");
            CqlDateTime ci_ = context.Operators.Subtract(cg_ as CqlDateTime, ch_);
            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            CqlInterval<CqlDateTime> cl_ = context.Operators.Interval(ci_, ck_ as CqlDateTime, true, true);
            bool? cm_ = context.Operators.In<CqlDateTime>(ce_, cl_, (string)default);
            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            bool? cp_ = context.Operators.Not((bool?)(co_ is null));
            bool? cq_ = context.Operators.And(cm_, cp_);
            bool? cr_ = context.Operators.And(cb_, cq_);
            return cr_;
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
                Encounter.HospitalizationComponent at_ = InpatientEncounter?.Hospitalization;
                CodeableConcept au_ = at_?.DischargeDisposition;
                CqlConcept av_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, au_);
                CqlCode aw_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept ax_ = context.Operators.ConvertCodeToConcept(aw_);
                bool? ay_ = context.Operators.Equivalent(av_, ax_);
                CodeableConcept ba_ = at_?.DischargeDisposition;
                CqlConcept bb_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ba_);
                CqlCode bc_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                CqlConcept bd_ = context.Operators.ConvertCodeToConcept(bc_);
                bool? be_ = context.Operators.Equivalent(bb_, bd_);
                bool? bf_ = context.Operators.Or(ay_, be_);
                Period bg_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bg_);
                CqlDateTime bi_ = context.Operators.End(bh_);
                Period bj_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                CqlQuantity bm_ = context.Operators.Quantity(90m, "days");
                CqlDateTime bn_ = context.Operators.Subtract(bl_, bm_);
                CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                CqlDateTime bq_ = context.Operators.End(bp_);
                CqlInterval<CqlDateTime> br_ = context.Operators.Interval(bn_, bq_, true, true);
                bool? bs_ = context.Operators.In<CqlDateTime>(bi_, br_, "day");
                bool? bt_ = context.Operators.And(bf_, bs_);
                Code<Encounter.EncounterStatus> bu_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? bv_ = bu_?.Value;
                Code<Encounter.EncounterStatus> bw_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(bv_);
                bool? bx_ = context.Operators.Equal(bw_, "finished");
                bool? by_ = context.Operators.And(bt_, bx_);
                return by_;
            }

            IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
            bool? h_ = context.Operators.Exists<Encounter>(g_);
            CqlValueSet i_ = this.Hospice_Encounter(context);
            IEnumerable<Encounter> j_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? k_(Encounter HospiceEncounter) {
                Period bz_ = HospiceEncounter?.Period;
                CqlInterval<CqlDateTime> ca_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bz_);
                Period cb_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                CqlDateTime cd_ = context.Operators.Start(cc_);
                CqlQuantity ce_ = context.Operators.Quantity(90m, "days");
                CqlDateTime cf_ = context.Operators.Subtract(cd_, ce_);
                CqlInterval<CqlDateTime> ch_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                CqlDateTime ci_ = context.Operators.End(ch_);
                CqlInterval<CqlDateTime> cj_ = context.Operators.Interval(cf_, ci_, true, true);
                bool? ck_ = context.Operators.Overlaps(ca_, cj_, "day");
                return ck_;
            }

            IEnumerable<Encounter> l_ = context.Operators.Where<Encounter>(j_, k_);
            bool? m_ = context.Operators.Exists<Encounter>(l_);
            bool? n_ = context.Operators.Or(h_, m_);
            CqlCode o_ = this.Hospice_care__Minimum_Data_Set_(context);
            IEnumerable<CqlCode> p_ = context.Operators.ToList<CqlCode>(o_);
            IEnumerable<Observation> q_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, p_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

            bool? r_(Observation HospiceAssessment) {
                DataType cl_ = HospiceAssessment?.Value;
                object cm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cl_);
                CqlCode cn_ = this.Yes__qualifier_value_(context);
                CqlConcept co_ = context.Operators.ConvertCodeToConcept(cn_);
                bool? cp_ = context.Operators.Equivalent(cm_ as CqlConcept, co_);
                DataType cq_ = HospiceAssessment?.Effective;
                object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                CqlInterval<CqlDateTime> cs_ = QICoreCommon_4_0_000.Instance.toInterval(context, cr_);
                Period ct_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                CqlDateTime cv_ = context.Operators.Start(cu_);
                CqlQuantity cw_ = context.Operators.Quantity(90m, "days");
                CqlDateTime cx_ = context.Operators.Subtract(cv_, cw_);
                CqlInterval<CqlDateTime> cz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ct_);
                CqlDateTime da_ = context.Operators.End(cz_);
                CqlInterval<CqlDateTime> db_ = context.Operators.Interval(cx_, da_, true, true);
                bool? dc_ = context.Operators.Overlaps(cs_, db_, "day");
                bool? dd_ = context.Operators.And(cp_, dc_);
                return dd_;
            }

            IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
            bool? t_ = context.Operators.Exists<Observation>(s_);
            bool? u_ = context.Operators.Or(n_, t_);
            CqlValueSet v_ = this.Hospice_Care_Ambulatory(context);
            IEnumerable<ServiceRequest> w_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

            bool? x_(ServiceRequest HospiceOrder) {
                FhirDateTime de_ = HospiceOrder?.AuthoredOnElement;
                CqlDateTime df_ = context.Operators.Convert<CqlDateTime>(de_);
                Period dg_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> dh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                CqlDateTime di_ = context.Operators.Start(dh_);
                CqlQuantity dj_ = context.Operators.Quantity(90m, "days");
                CqlDateTime dk_ = context.Operators.Subtract(di_, dj_);
                CqlInterval<CqlDateTime> dm_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dg_);
                CqlDateTime dn_ = context.Operators.End(dm_);
                CqlInterval<CqlDateTime> do_ = context.Operators.Interval(dk_, dn_, true, true);
                bool? dp_ = context.Operators.In<CqlDateTime>(df_, do_, "day");
                Code<RequestStatus> dq_ = HospiceOrder?.StatusElement;
                RequestStatus? dr_ = dq_?.Value;
                Code<RequestStatus> ds_ = context.Operators.Convert<Code<RequestStatus>>(dr_);
                string dt_ = context.Operators.Convert<string>(ds_);
                string[] du_ = [
                    "active",
                    "completed",
                ];
                bool? dv_ = context.Operators.In<string>(dt_, (IEnumerable<string>)du_);
                bool? dw_ = context.Operators.And(dp_, dv_);
                return dw_;
            }

            IEnumerable<ServiceRequest> y_ = context.Operators.Where<ServiceRequest>(w_, x_);
            bool? z_ = context.Operators.Exists<ServiceRequest>(y_);
            bool? aa_ = context.Operators.Or(u_, z_);
            IEnumerable<Procedure> ac_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? ad_(Procedure HospicePerformed) {

                object dx_() {

                    bool ej_() {
                        DataType en_ = HospicePerformed?.Performed;
                        object eo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, en_);
                        bool ep_ = eo_ is CqlDateTime;
                        return ep_;
                    }


                    bool ek_() {
                        DataType eq_ = HospicePerformed?.Performed;
                        object er_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eq_);
                        bool es_ = er_ is CqlInterval<CqlDateTime>;
                        return es_;
                    }


                    bool el_() {
                        DataType et_ = HospicePerformed?.Performed;
                        object eu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, et_);
                        bool ev_ = eu_ is CqlQuantity;
                        return ev_;
                    }


                    bool em_() {
                        DataType ew_ = HospicePerformed?.Performed;
                        object ex_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ew_);
                        bool ey_ = ex_ is CqlInterval<CqlQuantity>;
                        return ey_;
                    }

                    if (ej_())
                    {
                        DataType ez_ = HospicePerformed?.Performed;
                        object fa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ez_);
                        return (fa_ as CqlDateTime) as object;
                    }
                    else if (ek_())
                    {
                        DataType fb_ = HospicePerformed?.Performed;
                        object fc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fb_);
                        return (fc_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (el_())
                    {
                        DataType fd_ = HospicePerformed?.Performed;
                        object fe_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fd_);
                        return (fe_ as CqlQuantity) as object;
                    }
                    else if (em_())
                    {
                        DataType ff_ = HospicePerformed?.Performed;
                        object fg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ff_);
                        return (fg_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> dy_ = QICoreCommon_4_0_000.Instance.toInterval(context, dx_());
                Period dz_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> ea_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dz_);
                CqlDateTime eb_ = context.Operators.Start(ea_);
                CqlQuantity ec_ = context.Operators.Quantity(90m, "days");
                CqlDateTime ed_ = context.Operators.Subtract(eb_, ec_);
                CqlInterval<CqlDateTime> ef_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dz_);
                CqlDateTime eg_ = context.Operators.End(ef_);
                CqlInterval<CqlDateTime> eh_ = context.Operators.Interval(ed_, eg_, true, true);
                bool? ei_ = context.Operators.Overlaps(dy_, eh_, "day");
                return ei_;
            }

            IEnumerable<Procedure> ae_ = context.Operators.Where<Procedure>(ac_, ad_);
            bool? af_ = context.Operators.Exists<Procedure>(ae_);
            bool? ag_ = context.Operators.Or(aa_, af_);
            CqlValueSet ah_ = this.Hospice_Diagnosis(context);
            IEnumerable<Condition> ai_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? aj_(Condition HospiceCareDiagnosis) {
                CqlInterval<CqlDateTime> fh_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis as object);
                Period fi_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> fj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fi_);
                CqlDateTime fk_ = context.Operators.Start(fj_);
                CqlQuantity fl_ = context.Operators.Quantity(90m, "days");
                CqlDateTime fm_ = context.Operators.Subtract(fk_, fl_);
                CqlInterval<CqlDateTime> fo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fi_);
                CqlDateTime fp_ = context.Operators.End(fo_);
                CqlInterval<CqlDateTime> fq_ = context.Operators.Interval(fm_, fp_, true, true);
                bool? fr_ = context.Operators.Overlaps(fh_, fq_, "day");
                bool? fs_ = this.isVerified(context, HospiceCareDiagnosis as object);
                bool? ft_ = context.Operators.And(fr_, fs_);
                return ft_;
            }

            IEnumerable<Condition> ak_ = context.Operators.Where<Condition>(ai_, aj_);
            bool? al_ = context.Operators.Exists<Condition>(ak_);
            bool? am_ = context.Operators.Or(ag_, al_);
            IEnumerable<Condition> ao_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ah_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? ap_(Condition HospiceCareConcern) {
                CqlInterval<CqlDateTime> fu_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareConcern as object);
                Period fv_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> fw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fv_);
                CqlDateTime fx_ = context.Operators.Start(fw_);
                CqlQuantity fy_ = context.Operators.Quantity(90m, "days");
                CqlDateTime fz_ = context.Operators.Subtract(fx_, fy_);
                CqlInterval<CqlDateTime> gb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, fv_);
                CqlDateTime gc_ = context.Operators.End(gb_);
                CqlInterval<CqlDateTime> gd_ = context.Operators.Interval(fz_, gc_, true, true);
                bool? ge_ = context.Operators.Overlaps(fu_, gd_, "day");
                bool? gf_ = this.isVerified(context, HospiceCareConcern as object);
                bool? gg_ = context.Operators.And(ge_, gf_);
                return gg_;
            }

            IEnumerable<Condition> aq_ = context.Operators.Where<Condition>(ao_, ap_);
            bool? ar_ = context.Operators.Exists<Condition>(aq_);
            bool? as_ = context.Operators.Or(am_, ar_);
            return as_;
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
                DataType ah_ = PalliativeAssessment?.Effective;
                object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                CqlInterval<CqlDateTime> aj_ = QICoreCommon_4_0_000.Instance.toInterval(context, ai_);
                Period ak_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime am_ = context.Operators.Start(al_);
                CqlQuantity an_ = context.Operators.Quantity(90m, "days");
                CqlDateTime ao_ = context.Operators.Subtract(am_, an_);
                CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ak_);
                CqlDateTime ar_ = context.Operators.End(aq_);
                CqlInterval<CqlDateTime> as_ = context.Operators.Interval(ao_, ar_, true, true);
                bool? at_ = context.Operators.Overlaps(aj_, as_, "day");
                Code<ObservationStatus> au_ = PalliativeAssessment?.StatusElement;
                ObservationStatus? av_ = au_?.Value;
                string aw_ = context.Operators.Convert<string>(av_);
                string[] ax_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? ay_ = context.Operators.In<string>(aw_, (IEnumerable<string>)ax_);
                bool? az_ = context.Operators.And(at_, ay_);
                return az_;
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
            bool? i_ = context.Operators.Exists<Observation>(h_);
            CqlValueSet j_ = this.Palliative_Care_Diagnosis(context);
            IEnumerable<Condition> k_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? l_(Condition PalliativeCareDiagnosis) {
                CqlInterval<CqlDateTime> ba_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeCareDiagnosis as object);
                Period bb_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> bc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
                CqlDateTime bd_ = context.Operators.Start(bc_);
                CqlQuantity be_ = context.Operators.Quantity(90m, "days");
                CqlDateTime bf_ = context.Operators.Subtract(bd_, be_);
                CqlInterval<CqlDateTime> bh_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bb_);
                CqlDateTime bi_ = context.Operators.End(bh_);
                CqlInterval<CqlDateTime> bj_ = context.Operators.Interval(bf_, bi_, true, true);
                bool? bk_ = context.Operators.Overlaps(ba_, bj_, "day");
                bool? bl_ = this.isVerified(context, PalliativeCareDiagnosis as object);
                bool? bm_ = context.Operators.And(bk_, bl_);
                return bm_;
            }

            IEnumerable<Condition> m_ = context.Operators.Where<Condition>(k_, l_);
            bool? n_ = context.Operators.Exists<Condition>(m_);
            bool? o_ = context.Operators.Or(i_, n_);
            IEnumerable<Condition> q_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? r_(Condition PalliativeCareConcern) {
                CqlInterval<CqlDateTime> bn_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeCareConcern as object);
                Period bo_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> bp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                CqlDateTime bq_ = context.Operators.Start(bp_);
                CqlQuantity br_ = context.Operators.Quantity(90m, "days");
                CqlDateTime bs_ = context.Operators.Subtract(bq_, br_);
                CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bo_);
                CqlDateTime bv_ = context.Operators.End(bu_);
                CqlInterval<CqlDateTime> bw_ = context.Operators.Interval(bs_, bv_, true, true);
                bool? bx_ = context.Operators.Overlaps(bn_, bw_, "day");
                bool? by_ = this.isVerified(context, PalliativeCareConcern as object);
                bool? bz_ = context.Operators.And(bx_, by_);
                return bz_;
            }

            IEnumerable<Condition> s_ = context.Operators.Where<Condition>(q_, r_);
            bool? t_ = context.Operators.Exists<Condition>(s_);
            bool? u_ = context.Operators.Or(o_, t_);
            CqlValueSet v_ = this.Palliative_Care_Encounter(context);
            IEnumerable<Encounter> w_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, v_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

            bool? x_(Encounter PalliativeEncounter) {
                Period ca_ = PalliativeEncounter?.Period;
                CqlInterval<CqlDateTime> cb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ca_);
                Period cc_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> cd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime ce_ = context.Operators.Start(cd_);
                CqlQuantity cf_ = context.Operators.Quantity(90m, "days");
                CqlDateTime cg_ = context.Operators.Subtract(ce_, cf_);
                CqlInterval<CqlDateTime> ci_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cc_);
                CqlDateTime cj_ = context.Operators.End(ci_);
                CqlInterval<CqlDateTime> ck_ = context.Operators.Interval(cg_, cj_, true, true);
                bool? cl_ = context.Operators.Overlaps(cb_, ck_, "day");
                return cl_;
            }

            IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);
            bool? z_ = context.Operators.Exists<Encounter>(y_);
            bool? aa_ = context.Operators.Or(u_, z_);
            CqlValueSet ab_ = this.Palliative_Care_Intervention(context);
            IEnumerable<Procedure> ac_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

            bool? ad_(Procedure PalliativeIntervention) {

                object cm_() {

                    bool cy_() {
                        DataType dc_ = PalliativeIntervention?.Performed;
                        object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                        bool de_ = dd_ is CqlDateTime;
                        return de_;
                    }


                    bool cz_() {
                        DataType df_ = PalliativeIntervention?.Performed;
                        object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                        bool dh_ = dg_ is CqlInterval<CqlDateTime>;
                        return dh_;
                    }


                    bool da_() {
                        DataType di_ = PalliativeIntervention?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlQuantity;
                        return dk_;
                    }


                    bool db_() {
                        DataType dl_ = PalliativeIntervention?.Performed;
                        object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                        bool dn_ = dm_ is CqlInterval<CqlQuantity>;
                        return dn_;
                    }

                    if (cy_())
                    {
                        DataType do_ = PalliativeIntervention?.Performed;
                        object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                        return (dp_ as CqlDateTime) as object;
                    }
                    else if (cz_())
                    {
                        DataType dq_ = PalliativeIntervention?.Performed;
                        object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                        return (dr_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (da_())
                    {
                        DataType ds_ = PalliativeIntervention?.Performed;
                        object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                        return (dt_ as CqlQuantity) as object;
                    }
                    else if (db_())
                    {
                        DataType du_ = PalliativeIntervention?.Performed;
                        object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                        return (dv_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> cn_ = QICoreCommon_4_0_000.Instance.toInterval(context, cm_());
                Period co_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> cp_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                CqlDateTime cq_ = context.Operators.Start(cp_);
                CqlQuantity cr_ = context.Operators.Quantity(90m, "days");
                CqlDateTime cs_ = context.Operators.Subtract(cq_, cr_);
                CqlInterval<CqlDateTime> cu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, co_);
                CqlDateTime cv_ = context.Operators.End(cu_);
                CqlInterval<CqlDateTime> cw_ = context.Operators.Interval(cs_, cv_, true, true);
                bool? cx_ = context.Operators.Overlaps(cn_, cw_, "day");
                return cx_;
            }

            IEnumerable<Procedure> ae_ = context.Operators.Where<Procedure>(ac_, ad_);
            bool? af_ = context.Operators.Exists<Procedure>(ae_);
            bool? ag_ = context.Operators.Or(aa_, af_);
            return ag_;
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

        IEnumerable<Encounter> b_(Encounter CurrentQualifiedVTE) {
            IEnumerable<Encounter> d_ = this.Qualified_VTE_Encounters(context);

            bool? e_(Encounter PreviousQualifiedVTE) {
                Period i_ = PreviousQualifiedVTE?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = CurrentQualifiedVTE?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlQuantity o_ = context.Operators.Quantity(6m, "months");
                CqlDateTime p_ = context.Operators.Subtract(n_, o_);
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime s_ = context.Operators.Start(r_);
                CqlInterval<CqlDateTime> t_ = context.Operators.Interval(p_, s_, true, false);
                bool? u_ = context.Operators.In<CqlDateTime>(k_, t_, (string)default);
                CqlInterval<CqlDateTime> w_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime x_ = context.Operators.Start(w_);
                bool? y_ = context.Operators.Not((bool?)(x_ is null));
                bool? z_ = context.Operators.And(u_, y_);
                return z_;
            }

            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            Encounter g_(Encounter PreviousQualifiedVTE) => CurrentQualifiedVTE;
            IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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

        IEnumerable<Encounter> b_(Encounter DelayedVTEEncounter) {
            IEnumerable<Encounter> d_ = this.Qualifying_Performed_PCP_Visits_With_VTE_Symptom(context);

            bool? e_(Encounter IndexPCPVisit) {
                Period i_ = DelayedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                Period l_ = IndexPCPVisit?.Period;
                CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime n_ = context.Operators.End(m_);
                CqlQuantity o_ = context.Operators.Quantity(2m, "day");
                CqlDateTime p_ = context.Operators.Add(n_, o_);
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, l_);
                CqlDateTime s_ = context.Operators.End(r_);
                CqlQuantity t_ = context.Operators.Quantity(30m, "days");
                CqlDateTime u_ = context.Operators.Add(s_, t_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(p_, u_, true, true);
                bool? w_ = context.Operators.In<CqlDateTime>(k_, v_, "day");
                return w_;
            }

            IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);
            Encounter g_(Encounter IndexPCPVisit) => DelayedVTEEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<Encounter, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
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
