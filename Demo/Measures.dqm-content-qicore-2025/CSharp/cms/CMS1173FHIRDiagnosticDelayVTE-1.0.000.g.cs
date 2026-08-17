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

            CqlBoolean o_() {
                Period p_ = Encounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                CqlDateTime t_ = context.Operators.Start(s_);
                CqlQuantity u_ = context.Operators.Quantity(180m, "days");
                CqlDateTime v_ = context.Operators.Subtract(t_, u_);
                CqlDateTime w_ = context.Operators.End(s_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(v_, w_, true, true);
                bool? y_ = context.Operators.In<CqlDateTime>(r_, x_, "day");
                return y_;
            }

            return (bool?)(/* CQL 'and' (66:5-67:127) */ ((CqlBoolean)n_
                && o_()));
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.VTE_Diagnoses(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);

            CqlBoolean i_() {
                CqlValueSet k_ = this.VTE_Diagnoses(context);
                IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

                bool? m_(Condition VTECondition) {
                    bool? o_ = this.isConfirmedCondition(context, VTECondition);

                    CqlBoolean p_() {
                        List<ResourceReference> q_ = VTEEncounter?.ReasonReference;
                        bool? r_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)q_, VTECondition);
                        return r_;
                    }

                    return (bool?)(/* CQL 'and' (87:11-88:72) */ ((CqlBoolean)o_
                        && p_()));
                }

                bool? n_ = context.Operators.WhereAny<Condition>(l_, m_);
                return n_;
            }

            return (bool?)(/* CQL 'or' (85:5-89:7) */ ((CqlBoolean)h_
                || i_()));
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

            CqlBoolean l_() {
                Period m_ = PCPVisit?.Period;
                CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, m_);
                CqlDateTime o_ = context.Operators.End(n_);
                CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlQuantity r_ = context.Operators.Quantity(210m, "days");
                CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                CqlDateTime t_ = context.Operators.End(p_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(s_, t_, true, true);
                bool? v_ = context.Operators.In<CqlDateTime>(o_, u_, "day");
                return v_;
            }

            return (bool?)(/* CQL 'and' (72:5-73:124) */ ((CqlBoolean)k_
                && l_()));
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

        CqlBoolean c_() {
            CodeableConcept d_ = condition?.VerificationStatus;
            CqlConcept e_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, d_);
            CqlCode f_ = QICoreCommon_4_0_000.Instance.confirmed(context);
            CqlConcept g_ = context.Operators.ConvertCodeToConcept(f_);
            bool? h_ = context.Operators.Equivalent(e_, g_);

            CqlBoolean i_() {
                CodeableConcept l_ = condition?.VerificationStatus;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                CqlCode n_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept o_ = context.Operators.ConvertCodeToConcept(n_);
                bool? p_ = context.Operators.Equivalent(m_, o_);
                return p_;
            }


            CqlBoolean j_() {
                CodeableConcept q_ = condition?.VerificationStatus;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlCode s_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept t_ = context.Operators.ConvertCodeToConcept(s_);
                bool? u_ = context.Operators.Equivalent(r_, t_);
                return u_;
            }


            CqlBoolean k_() {
                CodeableConcept v_ = condition?.VerificationStatus;
                CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                CqlCode x_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept y_ = context.Operators.ConvertCodeToConcept(x_);
                bool? z_ = context.Operators.Equivalent(w_, y_);
                return z_;
            }

            return /* CQL 'or' (202:52-206:3) */ (/* CQL 'or' (202:54-204:66) */ (/* CQL 'or' (202:54-203:66) */ ((CqlBoolean)h_
                || i_())
                || j_())
                || k_());
        }

        return (bool?)(/* CQL 'implies' (202:3-206:3) */ ((CqlBoolean)(!(!((bool?)(b_ is null))))
            || c_()));
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
                CqlConcept j_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return j_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.VTE_Symptoms(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);

            CqlBoolean i_() {
                CqlValueSet k_ = this.VTE_Symptoms(context);
                IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

                bool? m_(Condition VTESymptomCondition) {
                    bool? o_ = this.isVerified(context, VTESymptomCondition as Condition);

                    CqlBoolean p_() {
                        List<ResourceReference> q_ = IndexPCPVisit?.ReasonReference;
                        bool? r_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)q_, VTESymptomCondition);
                        return r_;
                    }

                    return (bool?)(/* CQL 'and' (79:11-80:80) */ ((CqlBoolean)o_
                        && p_()));
                }

                bool? n_ = context.Operators.WhereAny<Condition>(l_, m_);
                return n_;
            }

            return (bool?)(/* CQL 'or' (77:5-81:7) */ ((CqlBoolean)h_
                || i_()));
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
        IEnumerable<MedicationRequest> a_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

        bool? b_(MedicationRequest MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object l_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object m_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> n_ = context.Operators.Split((string)m_, "/");
                string o_ = context.Operators.Last<string>(n_);
                bool? p_ = context.Operators.Equal(l_, o_);

                CqlBoolean q_() {
                    CodeableConcept r_ = M?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    CqlValueSet t_ = this.Anticoagulant_Medications(context);
                    bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                    return u_;
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)p_
                    && q_()));
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
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
            bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);

            CqlBoolean aa_() {
                Code<MedicationRequest.MedicationRequestIntent> ab_ = AntiCoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ac_ = ab_?.Value;
                string ad_ = context.Operators.Convert<string>(ac_);
                bool? ae_ = context.Operators.Equal(ad_, "order");
                return ae_;
            }

            return (bool?)(/* CQL 'and' (97:5-98:40) */ ((CqlBoolean)z_
                && aa_()));
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
            bool? r_ = context.Operators.In<CqlDateTime>(o_, q_, "day");

            CqlBoolean s_() {
                FhirDateTime u_ = tuple_bundjkpliiuyymiejivrqjjcd?.AntiCoagulantOrdered?.AuthoredOnElement;
                CqlDateTime v_ = context.Operators.Convert<CqlDateTime>(u_);
                DataType w_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEStudy?.Effective;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlQuantity y_ = context.Operators.Quantity(12m, "hours");
                CqlDateTime z_ = context.Operators.Subtract(x_ as CqlDateTime, y_);
                CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(z_, x_ as CqlDateTime, true, false);
                bool? ab_ = context.Operators.In<CqlDateTime>(v_, aa_, (string)default);

                CqlBoolean ac_() {
                    DataType ae_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEStudy?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    return !((bool?)(af_ is null));
                }


                CqlBoolean ad_() {
                    FhirDateTime ag_ = tuple_bundjkpliiuyymiejivrqjjcd?.AntiCoagulantOrdered?.AuthoredOnElement;
                    CqlDateTime ah_ = context.Operators.Convert<CqlDateTime>(ag_);
                    DataType ai_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEStudy?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    CqlQuantity ak_ = context.Operators.Quantity(12m, "hours");
                    CqlDateTime al_ = context.Operators.Add(aj_ as CqlDateTime, ak_);
                    CqlInterval<CqlDateTime> am_ = context.Operators.Interval(aj_ as CqlDateTime, al_ as CqlDateTime, false, true);
                    bool? an_ = context.Operators.In<CqlDateTime>(ah_, am_, (string)default);

                    CqlBoolean ao_() {
                        DataType ap_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEStudy?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return !((bool?)(aq_ is null));
                    }

                    return /* CQL 'and' (108:14-108:86) */ ((CqlBoolean)an_
                        && ao_());
                }

                return /* CQL 'or' (107:11-109:7) */ (/* CQL 'and' (107:13-107:86) */ ((CqlBoolean)ab_
                    && ac_())
                    || ad_());
            }


            CqlBoolean t_() {
                Period ar_ = tuple_bundjkpliiuyymiejivrqjjcd?.IndexPCP?.Period;
                CqlInterval<CqlDateTime> as_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ar_);
                CqlDateTime at_ = context.Operators.Start(as_);
                DataType au_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEStudy?.Effective;
                object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                CqlQuantity aw_ = context.Operators.Quantity(30m, "days");
                CqlDateTime ax_ = context.Operators.Subtract(av_ as CqlDateTime, aw_);
                CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(ax_, av_ as CqlDateTime, true, true);
                bool? az_ = context.Operators.In<CqlDateTime>(at_, ay_, (string)default);

                CqlBoolean ba_() {
                    DataType bb_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEStudy?.Effective;
                    object bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    return !((bool?)(bc_ is null));
                }

                return /* CQL 'and' (110:11-110:80) */ ((CqlBoolean)az_
                    && ba_());
            }

            return (bool?)(/* CQL 'and' (106:5-110:80) */ (/* CQL 'and' (106:11-109:7) */ ((CqlBoolean)r_
                && s_())
                && t_()));
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
                Encounter.HospitalizationComponent n_ = InpatientEncounter?.Hospitalization;
                CodeableConcept o_ = n_?.DischargeDisposition;
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, o_);
                CqlCode q_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept r_ = context.Operators.ConvertCodeToConcept(q_);
                bool? s_ = context.Operators.Equivalent(p_, r_);

                CqlBoolean t_() {
                    Encounter.HospitalizationComponent w_ = InpatientEncounter?.Hospitalization;
                    CodeableConcept x_ = w_?.DischargeDisposition;
                    CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                    CqlCode z_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                    CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
                    bool? ab_ = context.Operators.Equivalent(y_, aa_);
                    return ab_;
                }


                CqlBoolean u_() {
                    Period ac_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    Period af_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                    CqlDateTime ah_ = context.Operators.Start(ag_);
                    CqlQuantity ai_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime aj_ = context.Operators.Subtract(ah_, ai_);
                    CqlDateTime ak_ = context.Operators.End(ag_);
                    CqlInterval<CqlDateTime> al_ = context.Operators.Interval(aj_, ak_, true, true);
                    bool? am_ = context.Operators.In<CqlDateTime>(ae_, al_, "day");
                    return am_;
                }


                CqlBoolean v_() {
                    Code<Encounter.EncounterStatus> an_ = InpatientEncounter?.StatusElement;
                    Encounter.EncounterStatus? ao_ = an_?.Value;
                    Code<Encounter.EncounterStatus> ap_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ao_);
                    bool? aq_ = context.Operators.Equal(ap_, "finished");
                    return aq_;
                }

                return (bool?)(/* CQL 'and' (127:9-131:52) */ (/* CQL 'and' (127:15-130:87) */ (/* CQL 'or' (127:15-129:9) */ ((CqlBoolean)s_
                    || t_())
                    && u_())
                    && v_()));
            }

            bool? g_ = context.Operators.WhereAny<Encounter>(e_, f_);

            CqlBoolean h_() {
                CqlValueSet ar_ = this.Hospice_Encounter(context);
                IEnumerable<Encounter> as_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ar_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? at_(Encounter HospiceEncounter) {
                    Period av_ = HospiceEncounter?.Period;
                    CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                    Period ax_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> ay_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ax_);
                    CqlDateTime az_ = context.Operators.Start(ay_);
                    CqlQuantity ba_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime bb_ = context.Operators.Subtract(az_, ba_);
                    CqlDateTime bc_ = context.Operators.End(ay_);
                    CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(bb_, bc_, true, true);
                    bool? be_ = context.Operators.Overlaps(aw_, bd_, "day");
                    return be_;
                }

                bool? au_ = context.Operators.WhereAny<Encounter>(as_, at_);
                return au_;
            }


            CqlBoolean i_() {
                CqlCode bf_ = this.Hospice_care__Minimum_Data_Set_(context);
                IEnumerable<CqlCode> bg_ = context.Operators.ToList<CqlCode>(bf_);
                IEnumerable<Observation> bh_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

                bool? bi_(Observation HospiceAssessment) {
                    DataType bk_ = HospiceAssessment?.Value;
                    object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    CqlCode bm_ = this.Yes__qualifier_value_(context);
                    CqlConcept bn_ = context.Operators.ConvertCodeToConcept(bm_);
                    bool? bo_ = context.Operators.Equivalent(bl_ as CqlConcept, bn_);

                    CqlBoolean bp_() {
                        DataType bq_ = HospiceAssessment?.Effective;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        CqlInterval<CqlDateTime> bs_ = QICoreCommon_4_0_000.Instance.toInterval(context, br_);
                        Period bt_ = QualifiedVTEEncounter?.Period;
                        CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                        CqlDateTime bv_ = context.Operators.Start(bu_);
                        CqlQuantity bw_ = context.Operators.Quantity(90m, "days");
                        CqlDateTime bx_ = context.Operators.Subtract(bv_, bw_);
                        CqlDateTime by_ = context.Operators.End(bu_);
                        CqlInterval<CqlDateTime> bz_ = context.Operators.Interval(bx_, by_, true, true);
                        bool? ca_ = context.Operators.Overlaps(bs_, bz_, "day");
                        return ca_;
                    }

                    return (bool?)(/* CQL 'and' (137:11-138:103) */ ((CqlBoolean)bo_
                        && bp_()));
                }

                bool? bj_ = context.Operators.WhereAny<Observation>(bh_, bi_);
                return bj_;
            }


            CqlBoolean j_() {
                CqlValueSet cb_ = this.Hospice_Care_Ambulatory(context);
                IEnumerable<ServiceRequest> cc_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, cb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

                bool? cd_(ServiceRequest HospiceOrder) {
                    FhirDateTime cf_ = HospiceOrder?.AuthoredOnElement;
                    CqlDateTime cg_ = context.Operators.Convert<CqlDateTime>(cf_);
                    Period ch_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> ci_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ch_);
                    CqlDateTime cj_ = context.Operators.Start(ci_);
                    CqlQuantity ck_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime cl_ = context.Operators.Subtract(cj_, ck_);
                    CqlDateTime cm_ = context.Operators.End(ci_);
                    CqlInterval<CqlDateTime> cn_ = context.Operators.Interval(cl_, cm_, true, true);
                    bool? co_ = context.Operators.In<CqlDateTime>(cg_, cn_, "day");

                    CqlBoolean cp_() {
                        Code<RequestStatus> cq_ = HospiceOrder?.StatusElement;
                        RequestStatus? cr_ = cq_?.Value;
                        Code<RequestStatus> cs_ = context.Operators.Convert<Code<RequestStatus>>(cr_);
                        string ct_ = context.Operators.Convert<string>(cs_);
                        string[] cu_ = [
                            "active",
                            "completed",
                        ];
                        bool? cv_ = context.Operators.In<string>(ct_, (IEnumerable<string>)cu_);
                        return cv_;
                    }

                    return (bool?)(/* CQL 'and' (141:11-142:64) */ ((CqlBoolean)co_
                        && cp_()));
                }

                bool? ce_ = context.Operators.WhereAny<ServiceRequest>(cc_, cd_);
                return ce_;
            }


            CqlBoolean k_() {
                CqlValueSet cw_ = this.Hospice_Care_Ambulatory(context);
                IEnumerable<Procedure> cx_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, cw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                bool? cy_(Procedure HospicePerformed) {
                    object da_;
                    DataType dk_ = HospicePerformed?.Performed;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                    bool dm_ = dl_ is CqlDateTime;
                    if (dm_)
                    {
                        da_ = dl_ as CqlDateTime;
                    }
                    else
                    {
                        bool dn_ = dl_ is CqlQuantity;
                        if (dn_)
                        {
                            da_ = dl_ as CqlQuantity;
                        }
                        else
                        {
                            bool do_ = dl_ is CqlInterval<CqlDateTime>;
                            if (do_)
                            {
                                da_ = dl_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool dp_ = dl_ is CqlInterval<CqlQuantity>;
                                if (dp_)
                                {
                                    da_ = dl_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    da_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> db_ = QICoreCommon_4_0_000.Instance.toInterval(context, da_);
                    Period dc_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> dd_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dc_);
                    CqlDateTime de_ = context.Operators.Start(dd_);
                    CqlQuantity df_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime dg_ = context.Operators.Subtract(de_, df_);
                    CqlDateTime dh_ = context.Operators.End(dd_);
                    CqlInterval<CqlDateTime> di_ = context.Operators.Interval(dg_, dh_, true, true);
                    bool? dj_ = context.Operators.Overlaps(db_, di_, "day");
                    return dj_;
                }

                bool? cz_ = context.Operators.WhereAny<Procedure>(cx_, cy_);
                return cz_;
            }


            CqlBoolean l_() {
                CqlValueSet dq_ = this.Hospice_Diagnosis(context);
                IEnumerable<Condition> dr_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

                bool? ds_(Condition HospiceCareDiagnosis) {
                    CqlInterval<CqlDateTime> du_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis as Condition);
                    Period dv_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> dw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, dv_);
                    CqlDateTime dx_ = context.Operators.Start(dw_);
                    CqlQuantity dy_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime dz_ = context.Operators.Subtract(dx_, dy_);
                    CqlDateTime ea_ = context.Operators.End(dw_);
                    CqlInterval<CqlDateTime> eb_ = context.Operators.Interval(dz_, ea_, true, true);
                    bool? ec_ = context.Operators.Overlaps(du_, eb_, "day");
                    return (bool?)(/* CQL 'and' (148:11-149:51) */ ((CqlBoolean)ec_
                        && (CqlBoolean)(this.isVerified(context, HospiceCareDiagnosis as Condition))));
                }

                bool? dt_ = context.Operators.WhereAny<Condition>(dr_, ds_);
                return dt_;
            }


            CqlBoolean m_() {
                CqlValueSet ed_ = this.Hospice_Diagnosis(context);
                IEnumerable<Condition> ee_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ed_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? ef_(Condition HospiceCareConcern) {
                    CqlInterval<CqlDateTime> eh_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareConcern as Condition);
                    Period ei_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> ej_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ei_);
                    CqlDateTime ek_ = context.Operators.Start(ej_);
                    CqlQuantity el_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime em_ = context.Operators.Subtract(ek_, el_);
                    CqlDateTime en_ = context.Operators.End(ej_);
                    CqlInterval<CqlDateTime> eo_ = context.Operators.Interval(em_, en_, true, true);
                    bool? ep_ = context.Operators.Overlaps(eh_, eo_, "day");
                    return (bool?)(/* CQL 'and' (152:11-153:49) */ ((CqlBoolean)ep_
                        && (CqlBoolean)(this.isVerified(context, HospiceCareConcern as Condition))));
                }

                bool? eg_ = context.Operators.WhereAny<Condition>(ee_, ef_);
                return eg_;
            }

            return (bool?)(/* CQL 'or' (126:5-154:7) */ (/* CQL 'or' (126:11-150:7) */ (/* CQL 'or' (126:11-146:7) */ (/* CQL 'or' (126:11-143:7) */ (/* CQL 'or' (126:11-139:7) */ (/* CQL 'or' (126:11-135:7) */ ((CqlBoolean)g_
                || h_())
                || i_())
                || j_())
                || k_())
                || l_())
                || m_()));
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
                DataType m_ = PalliativeAssessment?.Effective;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlInterval<CqlDateTime> o_ = QICoreCommon_4_0_000.Instance.toInterval(context, n_);
                Period p_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.Start(q_);
                CqlQuantity s_ = context.Operators.Quantity(90m, "days");
                CqlDateTime t_ = context.Operators.Subtract(r_, s_);
                CqlDateTime u_ = context.Operators.End(q_);
                CqlInterval<CqlDateTime> v_ = context.Operators.Interval(t_, u_, true, true);
                bool? w_ = context.Operators.Overlaps(o_, v_, "day");

                CqlBoolean x_() {
                    Code<ObservationStatus> y_ = PalliativeAssessment?.StatusElement;
                    ObservationStatus? z_ = y_?.Value;
                    string aa_ = context.Operators.Convert<string>(z_);
                    string[] ab_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ac_ = context.Operators.In<string>(aa_, (IEnumerable<string>)ab_);
                    return ac_;
                }

                return (bool?)(/* CQL 'and' (161:9-162:80) */ ((CqlBoolean)w_
                    && x_()));
            }

            bool? h_ = context.Operators.WhereAny<Observation>(f_, g_);

            CqlBoolean i_() {
                CqlValueSet ad_ = this.Palliative_Care_Diagnosis(context);
                IEnumerable<Condition> ae_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

                bool? af_(Condition PalliativeCareDiagnosis) {
                    CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeCareDiagnosis as Condition);
                    Period ai_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> aj_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ai_);
                    CqlDateTime ak_ = context.Operators.Start(aj_);
                    CqlQuantity al_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime am_ = context.Operators.Subtract(ak_, al_);
                    CqlDateTime an_ = context.Operators.End(aj_);
                    CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(am_, an_, true, true);
                    bool? ap_ = context.Operators.Overlaps(ah_, ao_, "day");
                    return (bool?)(/* CQL 'and' (165:11-166:54) */ ((CqlBoolean)ap_
                        && (CqlBoolean)(this.isVerified(context, PalliativeCareDiagnosis as Condition))));
                }

                bool? ag_ = context.Operators.WhereAny<Condition>(ae_, af_);
                return ag_;
            }


            CqlBoolean j_() {
                CqlValueSet aq_ = this.Palliative_Care_Diagnosis(context);
                IEnumerable<Condition> ar_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, aq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? as_(Condition PalliativeCareConcern) {
                    CqlInterval<CqlDateTime> au_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeCareConcern as Condition);
                    Period av_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> aw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, av_);
                    CqlDateTime ax_ = context.Operators.Start(aw_);
                    CqlQuantity ay_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime az_ = context.Operators.Subtract(ax_, ay_);
                    CqlDateTime ba_ = context.Operators.End(aw_);
                    CqlInterval<CqlDateTime> bb_ = context.Operators.Interval(az_, ba_, true, true);
                    bool? bc_ = context.Operators.Overlaps(au_, bb_, "day");
                    return (bool?)(/* CQL 'and' (169:11-170:52) */ ((CqlBoolean)bc_
                        && (CqlBoolean)(this.isVerified(context, PalliativeCareConcern as Condition))));
                }

                bool? at_ = context.Operators.WhereAny<Condition>(ar_, as_);
                return at_;
            }


            CqlBoolean k_() {
                CqlValueSet bd_ = this.Palliative_Care_Encounter(context);
                IEnumerable<Encounter> be_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bd_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? bf_(Encounter PalliativeEncounter) {
                    Period bh_ = PalliativeEncounter?.Period;
                    CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                    Period bj_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> bk_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bj_);
                    CqlDateTime bl_ = context.Operators.Start(bk_);
                    CqlQuantity bm_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime bn_ = context.Operators.Subtract(bl_, bm_);
                    CqlDateTime bo_ = context.Operators.End(bk_);
                    CqlInterval<CqlDateTime> bp_ = context.Operators.Interval(bn_, bo_, true, true);
                    bool? bq_ = context.Operators.Overlaps(bi_, bp_, "day");
                    return bq_;
                }

                bool? bg_ = context.Operators.WhereAny<Encounter>(be_, bf_);
                return bg_;
            }


            CqlBoolean l_() {
                CqlValueSet br_ = this.Palliative_Care_Intervention(context);
                IEnumerable<Procedure> bs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, br_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                bool? bt_(Procedure PalliativeIntervention) {
                    object bv_;
                    DataType cf_ = PalliativeIntervention?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlDateTime;
                    if (ch_)
                    {
                        bv_ = cg_ as CqlDateTime;
                    }
                    else
                    {
                        bool ci_ = cg_ is CqlQuantity;
                        if (ci_)
                        {
                            bv_ = cg_ as CqlQuantity;
                        }
                        else
                        {
                            bool cj_ = cg_ is CqlInterval<CqlDateTime>;
                            if (cj_)
                            {
                                bv_ = cg_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                bool ck_ = cg_ is CqlInterval<CqlQuantity>;
                                if (ck_)
                                {
                                    bv_ = cg_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    bv_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> bw_ = QICoreCommon_4_0_000.Instance.toInterval(context, bv_);
                    Period bx_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> by_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bx_);
                    CqlDateTime bz_ = context.Operators.Start(by_);
                    CqlQuantity ca_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime cb_ = context.Operators.Subtract(bz_, ca_);
                    CqlDateTime cc_ = context.Operators.End(by_);
                    CqlInterval<CqlDateTime> cd_ = context.Operators.Interval(cb_, cc_, true, true);
                    bool? ce_ = context.Operators.Overlaps(bw_, cd_, "day");
                    return ce_;
                }

                bool? bu_ = context.Operators.WhereAny<Procedure>(bs_, bt_);
                return bu_;
            }

            return (bool?)(/* CQL 'or' (160:5-177:7) */ (/* CQL 'or' (160:11-174:7) */ (/* CQL 'or' (160:11-171:7) */ (/* CQL 'or' (160:11-167:7) */ ((CqlBoolean)h_
                || i_())
                || j_())
                || k_())
                || l_()));
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
                bool? p_ = context.Operators.In<CqlDateTime>(i_, o_, (string)default);

                CqlBoolean q_() {
                    Period r_ = CurrentQualifiedVTE?.Period;
                    CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, r_);
                    CqlDateTime t_ = context.Operators.Start(s_);
                    return !((bool?)(t_ is null));
                }

                return (bool?)(/* CQL 'and' (182:17-182:110) */ ((CqlBoolean)p_
                    && q_()));
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
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
                bool? r_ = context.Operators.In<CqlDateTime>(i_, q_, "day");
                return r_;
            }

            bool? f_ = context.Operators.WhereAny<Encounter>(d_, e_);
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
