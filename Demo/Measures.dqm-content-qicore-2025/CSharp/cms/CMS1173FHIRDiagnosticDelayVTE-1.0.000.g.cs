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
            // CQL 'and' (66:5-67:127): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
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
                return n_ & x_;
            }
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
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return i_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.VTE_Diagnoses(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            // CQL 'or' (85:5-89:7): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

                bool? k_(Condition VTECondition) {
                    bool? m_ = this.isConfirmedCondition(context, VTECondition);
                    // CQL 'and' (87:11-88:72): right operand skipped when left is false
                    if (m_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        List<ResourceReference> n_ = VTEEncounter?.ReasonReference;
                        bool? o_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)n_, VTECondition);
                        return m_ & o_;
                    }
                }

                bool? l_ = context.Operators.WhereAny<Condition>(j_, k_);
                return h_ | l_;
            }
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
            // CQL 'and' (72:5-73:124): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
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
                return k_ & u_;
            }
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
        bool? e_ = context.Operators.Equivalent(b_, d_);
        bool? f_;
        // CQL 'or' (202:54-203:66): right operand skipped when left is true
        if (e_ is true)
        {
            f_ = true;
        }
        else
        {
            CqlCode j_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
            CqlConcept k_ = context.Operators.ConvertCodeToConcept(j_);
            bool? l_ = context.Operators.Equivalent(b_, k_);
            f_ = e_ | l_;
        }
        bool? g_;
        // CQL 'or' (202:54-204:66): right operand skipped when left is true
        if (f_ is true)
        {
            g_ = true;
        }
        else
        {
            CqlCode m_ = QICoreCommon_4_0_000.Instance.provisional(context);
            CqlConcept n_ = context.Operators.ConvertCodeToConcept(m_);
            bool? o_ = context.Operators.Equivalent(b_, n_);
            g_ = f_ | o_;
        }
        bool? h_;
        // CQL 'or' (202:52-206:3): right operand skipped when left is true
        if (g_ is true)
        {
            h_ = true;
        }
        else
        {
            CqlCode p_ = QICoreCommon_4_0_000.Instance.differential(context);
            CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
            bool? r_ = context.Operators.Equivalent(b_, q_);
            h_ = g_ | r_;
        }
        bool? i_ = context.Operators.Implies(!((bool?)(b_ is null)), h_);
        return i_;
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
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return i_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.VTE_Symptoms(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            // CQL 'or' (77:5-81:7): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

                bool? k_(Condition VTESymptomCondition) {
                    bool? m_ = this.isVerified(context, VTESymptomCondition as Condition);
                    // CQL 'and' (79:11-80:80): right operand skipped when left is false
                    if (m_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        List<ResourceReference> n_ = IndexPCPVisit?.ReasonReference;
                        bool? o_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)n_, VTESymptomCondition);
                        return m_ & o_;
                    }
                }

                bool? l_ = context.Operators.WhereAny<Condition>(j_, k_);
                return h_ | l_;
            }
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
                // CQL 'and': right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept q_ = M?.Code;
                    CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                    CqlValueSet s_ = this.Anticoagulant_Medications(context);
                    bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                    return p_ & t_;
                }
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationRequest> c_ = context.Operators.Where<MedicationRequest>(a_, b_);
        CqlValueSet d_ = this.Anticoagulant_Medications(context);
        IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> f_ = context.Operators.Union<MedicationRequest>(c_, e_);

        bool? g_(MedicationRequest AntiCoagulant) {
            Code<MedicationRequest.MedicationrequestStatus> u_ = AntiCoagulant?.StatusElement;
            MedicationRequest.MedicationrequestStatus? v_ = u_?.Value;
            string w_ = context.Operators.Convert<string>(v_);
            string[] x_ = [
                "active",
                "completed",
            ];
            bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
            // CQL 'and' (97:5-98:40): right operand skipped when left is false
            if (y_ is false)
            {
                return false;
            }
            else
            {
                Code<MedicationRequest.MedicationRequestIntent> z_ = AntiCoagulant?.IntentElement;
                MedicationRequest.MedicationRequestIntent? aa_ = z_?.Value;
                string ab_ = context.Operators.Convert<string>(aa_);
                bool? ac_ = context.Operators.Equal(ab_, "order");
                return y_ & ac_;
            }
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
            bool? s_;
            // CQL 'and' (106:11-109:7): right operand skipped when left is false
            if (r_ is false)
            {
                s_ = false;
            }
            else
            {
                FhirDateTime t_ = tuple_bundjkpliiuyymiejivrqjjcd?.AntiCoagulantOrdered?.AuthoredOnElement;
                CqlDateTime u_ = context.Operators.Convert<CqlDateTime>(t_);
                CqlQuantity v_ = context.Operators.Quantity(12m, "hours");
                CqlDateTime w_ = context.Operators.Subtract(m_ as CqlDateTime, v_);
                CqlInterval<CqlDateTime> x_ = context.Operators.Interval(w_, m_ as CqlDateTime, true, false);
                bool? y_ = context.Operators.In<CqlDateTime>(u_, x_, (string)default);
                bool? z_;
                // CQL 'and' (107:13-107:86): right operand skipped when left is false
                if (y_ is false)
                {
                    z_ = false;
                }
                else
                {
                    DataType ab_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEStudy?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    z_ = y_ & (!((bool?)(ac_ is null)));
                }
                bool? aa_;
                // CQL 'or' (107:11-109:7): right operand skipped when left is true
                if (z_ is true)
                {
                    aa_ = true;
                }
                else
                {
                    DataType ad_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEStudy?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    CqlDateTime af_ = context.Operators.Add(ae_ as CqlDateTime, v_);
                    CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ae_ as CqlDateTime, af_ as CqlDateTime, false, true);
                    bool? ah_ = context.Operators.In<CqlDateTime>(u_, ag_, (string)default);
                    bool? ai_;
                    // CQL 'and' (108:14-108:86): right operand skipped when left is false
                    if (ah_ is false)
                    {
                        ai_ = false;
                    }
                    else
                    {
                        ai_ = ah_ & (!((bool?)(ae_ is null)));
                    }
                    aa_ = z_ | ai_;
                }
                s_ = r_ & aa_;
            }
            // CQL 'and' (106:5-110:80): right operand skipped when left is false
            if (s_ is false)
            {
                return false;
            }
            else
            {
                Period aj_ = tuple_bundjkpliiuyymiejivrqjjcd?.IndexPCP?.Period;
                CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aj_);
                CqlDateTime al_ = context.Operators.Start(ak_);
                CqlQuantity am_ = context.Operators.Quantity(30m, "days");
                CqlDateTime an_ = context.Operators.Subtract(m_ as CqlDateTime, am_);
                CqlInterval<CqlDateTime> ao_ = context.Operators.Interval(an_, m_ as CqlDateTime, true, true);
                bool? ap_ = context.Operators.In<CqlDateTime>(al_, ao_, (string)default);
                bool? aq_;
                // CQL 'and' (110:11-110:80): right operand skipped when left is false
                if (ap_ is false)
                {
                    aq_ = false;
                }
                else
                {
                    DataType ar_ = tuple_bundjkpliiuyymiejivrqjjcd?.VTEStudy?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    aq_ = ap_ & (!((bool?)(as_ is null)));
                }
                return s_ & aq_;
            }
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
                Encounter.HospitalizationComponent m_ = InpatientEncounter?.Hospitalization;
                CodeableConcept n_ = m_?.DischargeDisposition;
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                CqlCode p_ = this.Discharge_to_home_for_hospice_care__procedure_(context);
                CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
                bool? r_ = context.Operators.Equivalent(o_, q_);
                bool? s_;
                // CQL 'or' (127:15-129:9): right operand skipped when left is true
                if (r_ is true)
                {
                    s_ = true;
                }
                else
                {
                    CqlCode u_ = this.Discharge_to_healthcare_facility_for_hospice_care__procedure_(context);
                    CqlConcept v_ = context.Operators.ConvertCodeToConcept(u_);
                    bool? w_ = context.Operators.Equivalent(o_, v_);
                    s_ = r_ | w_;
                }
                bool? t_;
                // CQL 'and' (127:15-130:87): right operand skipped when left is false
                if (s_ is false)
                {
                    t_ = false;
                }
                else
                {
                    Period x_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> y_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, x_);
                    CqlDateTime z_ = context.Operators.End(y_);
                    Period aa_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aa_);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    CqlQuantity ad_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime ae_ = context.Operators.Subtract(ac_, ad_);
                    CqlDateTime af_ = context.Operators.End(ab_);
                    CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ae_, af_, true, true);
                    bool? ah_ = context.Operators.In<CqlDateTime>(z_, ag_, "day");
                    t_ = s_ & ah_;
                }
                // CQL 'and' (127:9-131:52): right operand skipped when left is false
                if (t_ is false)
                {
                    return false;
                }
                else
                {
                    Code<Encounter.EncounterStatus> ai_ = InpatientEncounter?.StatusElement;
                    Encounter.EncounterStatus? aj_ = ai_?.Value;
                    Code<Encounter.EncounterStatus> ak_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(aj_);
                    bool? al_ = context.Operators.Equal(ak_, "finished");
                    return t_ & al_;
                }
            }

            bool? g_ = context.Operators.WhereAny<Encounter>(e_, f_);
            bool? h_;
            // CQL 'or' (126:11-135:7): right operand skipped when left is true
            if (g_ is true)
            {
                h_ = true;
            }
            else
            {
                CqlValueSet am_ = this.Hospice_Encounter(context);
                IEnumerable<Encounter> an_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, am_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

                bool? ao_(Encounter HospiceEncounter) {
                    Period aq_ = HospiceEncounter?.Period;
                    CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, aq_);
                    Period as_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> at_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, as_);
                    CqlDateTime au_ = context.Operators.Start(at_);
                    CqlQuantity av_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime aw_ = context.Operators.Subtract(au_, av_);
                    CqlDateTime ax_ = context.Operators.End(at_);
                    CqlInterval<CqlDateTime> ay_ = context.Operators.Interval(aw_, ax_, true, true);
                    bool? az_ = context.Operators.Overlaps(ar_, ay_, "day");
                    return az_;
                }

                bool? ap_ = context.Operators.WhereAny<Encounter>(an_, ao_);
                h_ = g_ | ap_;
            }
            bool? i_;
            // CQL 'or' (126:11-139:7): right operand skipped when left is true
            if (h_ is true)
            {
                i_ = true;
            }
            else
            {
                CqlCode ba_ = this.Hospice_care__Minimum_Data_Set_(context);
                IEnumerable<CqlCode> bb_ = context.Operators.ToList<CqlCode>(ba_);
                IEnumerable<Observation> bc_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, bb_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-screening-assessment"));

                bool? bd_(Observation HospiceAssessment) {
                    DataType bf_ = HospiceAssessment?.Value;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    CqlCode bh_ = this.Yes__qualifier_value_(context);
                    CqlConcept bi_ = context.Operators.ConvertCodeToConcept(bh_);
                    bool? bj_ = context.Operators.Equivalent(bg_ as CqlConcept, bi_);
                    // CQL 'and' (137:11-138:103): right operand skipped when left is false
                    if (bj_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        DataType bk_ = HospiceAssessment?.Effective;
                        object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                        CqlInterval<CqlDateTime> bm_ = QICoreCommon_4_0_000.Instance.toInterval(context, bl_);
                        Period bn_ = QualifiedVTEEncounter?.Period;
                        CqlInterval<CqlDateTime> bo_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bn_);
                        CqlDateTime bp_ = context.Operators.Start(bo_);
                        CqlQuantity bq_ = context.Operators.Quantity(90m, "days");
                        CqlDateTime br_ = context.Operators.Subtract(bp_, bq_);
                        CqlDateTime bs_ = context.Operators.End(bo_);
                        CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(br_, bs_, true, true);
                        bool? bu_ = context.Operators.Overlaps(bm_, bt_, "day");
                        return bj_ & bu_;
                    }
                }

                bool? be_ = context.Operators.WhereAny<Observation>(bc_, bd_);
                i_ = h_ | be_;
            }
            bool? j_;
            // CQL 'or' (126:11-143:7): right operand skipped when left is true
            if (i_ is true)
            {
                j_ = true;
            }
            else
            {
                CqlValueSet bv_ = this.Hospice_Care_Ambulatory(context);
                IEnumerable<ServiceRequest> bw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, bv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

                bool? bx_(ServiceRequest HospiceOrder) {
                    FhirDateTime bz_ = HospiceOrder?.AuthoredOnElement;
                    CqlDateTime ca_ = context.Operators.Convert<CqlDateTime>(bz_);
                    Period cb_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> cc_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cb_);
                    CqlDateTime cd_ = context.Operators.Start(cc_);
                    CqlQuantity ce_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime cf_ = context.Operators.Subtract(cd_, ce_);
                    CqlDateTime cg_ = context.Operators.End(cc_);
                    CqlInterval<CqlDateTime> ch_ = context.Operators.Interval(cf_, cg_, true, true);
                    bool? ci_ = context.Operators.In<CqlDateTime>(ca_, ch_, "day");
                    // CQL 'and' (141:11-142:64): right operand skipped when left is false
                    if (ci_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        Code<RequestStatus> cj_ = HospiceOrder?.StatusElement;
                        RequestStatus? ck_ = cj_?.Value;
                        Code<RequestStatus> cl_ = context.Operators.Convert<Code<RequestStatus>>(ck_);
                        string cm_ = context.Operators.Convert<string>(cl_);
                        string[] cn_ = [
                            "active",
                            "completed",
                        ];
                        bool? co_ = context.Operators.In<string>(cm_, (IEnumerable<string>)cn_);
                        return ci_ & co_;
                    }
                }

                bool? by_ = context.Operators.WhereAny<ServiceRequest>(bw_, bx_);
                j_ = i_ | by_;
            }
            bool? k_;
            // CQL 'or' (126:11-146:7): right operand skipped when left is true
            if (j_ is true)
            {
                k_ = true;
            }
            else
            {
                CqlValueSet cp_ = this.Hospice_Care_Ambulatory(context);
                IEnumerable<Procedure> cq_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, cp_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                bool? cr_(Procedure HospicePerformed) {
                    object ct_;
                    DataType dd_ = HospicePerformed?.Performed;
                    object de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlDateTime;
                    if (df_)
                    {
                        DataType dg_ = HospicePerformed?.Performed;
                        object dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        ct_ = dh_ as CqlDateTime;
                    }
                    else
                    {
                        DataType di_ = HospicePerformed?.Performed;
                        object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                        bool dk_ = dj_ is CqlQuantity;
                        if (dk_)
                        {
                            DataType dl_ = HospicePerformed?.Performed;
                            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                            ct_ = dm_ as CqlQuantity;
                        }
                        else
                        {
                            DataType dn_ = HospicePerformed?.Performed;
                            object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                            bool dp_ = do_ is CqlInterval<CqlDateTime>;
                            if (dp_)
                            {
                                DataType dq_ = HospicePerformed?.Performed;
                                object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                                ct_ = dr_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType ds_ = HospicePerformed?.Performed;
                                object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                                bool du_ = dt_ is CqlInterval<CqlQuantity>;
                                if (du_)
                                {
                                    DataType dv_ = HospicePerformed?.Performed;
                                    object dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                                    ct_ = dw_ as CqlInterval<CqlQuantity>;
                                }
                                else
                                {
                                    ct_ = null;
                                }
                            }
                        }
                    }
                    CqlInterval<CqlDateTime> cu_ = QICoreCommon_4_0_000.Instance.toInterval(context, ct_);
                    Period cv_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> cw_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, cv_);
                    CqlDateTime cx_ = context.Operators.Start(cw_);
                    CqlQuantity cy_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime cz_ = context.Operators.Subtract(cx_, cy_);
                    CqlDateTime da_ = context.Operators.End(cw_);
                    CqlInterval<CqlDateTime> db_ = context.Operators.Interval(cz_, da_, true, true);
                    bool? dc_ = context.Operators.Overlaps(cu_, db_, "day");
                    return dc_;
                }

                bool? cs_ = context.Operators.WhereAny<Procedure>(cq_, cr_);
                k_ = j_ | cs_;
            }
            bool? l_;
            // CQL 'or' (126:11-150:7): right operand skipped when left is true
            if (k_ is true)
            {
                l_ = true;
            }
            else
            {
                CqlValueSet dx_ = this.Hospice_Diagnosis(context);
                IEnumerable<Condition> dy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, dx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

                bool? dz_(Condition HospiceCareDiagnosis) {
                    CqlInterval<CqlDateTime> eb_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareDiagnosis as Condition);
                    Period ec_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> ed_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ec_);
                    CqlDateTime ee_ = context.Operators.Start(ed_);
                    CqlQuantity ef_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime eg_ = context.Operators.Subtract(ee_, ef_);
                    CqlDateTime eh_ = context.Operators.End(ed_);
                    CqlInterval<CqlDateTime> ei_ = context.Operators.Interval(eg_, eh_, true, true);
                    bool? ej_ = context.Operators.Overlaps(eb_, ei_, "day");
                    // CQL 'and' (148:11-149:51): right operand skipped when left is false
                    if (ej_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        bool? ek_ = this.isVerified(context, HospiceCareDiagnosis as Condition);
                        return ej_ & ek_;
                    }
                }

                bool? ea_ = context.Operators.WhereAny<Condition>(dy_, dz_);
                l_ = k_ | ea_;
            }
            // CQL 'or' (126:5-154:7): right operand skipped when left is true
            if (l_ is true)
            {
                return true;
            }
            else
            {
                CqlValueSet el_ = this.Hospice_Diagnosis(context);
                IEnumerable<Condition> em_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, el_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? en_(Condition HospiceCareConcern) {
                    CqlInterval<CqlDateTime> ep_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, HospiceCareConcern as Condition);
                    Period eq_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> er_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, eq_);
                    CqlDateTime es_ = context.Operators.Start(er_);
                    CqlQuantity et_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime eu_ = context.Operators.Subtract(es_, et_);
                    CqlDateTime ev_ = context.Operators.End(er_);
                    CqlInterval<CqlDateTime> ew_ = context.Operators.Interval(eu_, ev_, true, true);
                    bool? ex_ = context.Operators.Overlaps(ep_, ew_, "day");
                    // CQL 'and' (152:11-153:49): right operand skipped when left is false
                    if (ex_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        bool? ey_ = this.isVerified(context, HospiceCareConcern as Condition);
                        return ex_ & ey_;
                    }
                }

                bool? eo_ = context.Operators.WhereAny<Condition>(em_, en_);
                return l_ | eo_;
            }
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
                DataType l_ = PalliativeAssessment?.Effective;
                object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                Period o_ = QualifiedVTEEncounter?.Period;
                CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, o_);
                CqlDateTime q_ = context.Operators.Start(p_);
                CqlQuantity r_ = context.Operators.Quantity(90m, "days");
                CqlDateTime s_ = context.Operators.Subtract(q_, r_);
                CqlDateTime t_ = context.Operators.End(p_);
                CqlInterval<CqlDateTime> u_ = context.Operators.Interval(s_, t_, true, true);
                bool? v_ = context.Operators.Overlaps(n_, u_, "day");
                // CQL 'and' (161:9-162:80): right operand skipped when left is false
                if (v_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> w_ = PalliativeAssessment?.StatusElement;
                    ObservationStatus? x_ = w_?.Value;
                    string y_ = context.Operators.Convert<string>(x_);
                    string[] z_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
                    return v_ & aa_;
                }
            }

            bool? h_ = context.Operators.WhereAny<Observation>(f_, g_);
            bool? i_;
            // CQL 'or' (160:11-167:7): right operand skipped when left is true
            if (h_ is true)
            {
                i_ = true;
            }
            else
            {
                CqlValueSet ab_ = this.Palliative_Care_Diagnosis(context);
                IEnumerable<Condition> ac_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ab_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

                bool? ad_(Condition PalliativeCareDiagnosis) {
                    CqlInterval<CqlDateTime> af_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeCareDiagnosis as Condition);
                    Period ag_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> ah_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ag_);
                    CqlDateTime ai_ = context.Operators.Start(ah_);
                    CqlQuantity aj_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime ak_ = context.Operators.Subtract(ai_, aj_);
                    CqlDateTime al_ = context.Operators.End(ah_);
                    CqlInterval<CqlDateTime> am_ = context.Operators.Interval(ak_, al_, true, true);
                    bool? an_ = context.Operators.Overlaps(af_, am_, "day");
                    // CQL 'and' (165:11-166:54): right operand skipped when left is false
                    if (an_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        bool? ao_ = this.isVerified(context, PalliativeCareDiagnosis as Condition);
                        return an_ & ao_;
                    }
                }

                bool? ae_ = context.Operators.WhereAny<Condition>(ac_, ad_);
                i_ = h_ | ae_;
            }
            bool? j_;
            // CQL 'or' (160:11-171:7): right operand skipped when left is true
            if (i_ is true)
            {
                j_ = true;
            }
            else
            {
                CqlValueSet ap_ = this.Palliative_Care_Diagnosis(context);
                IEnumerable<Condition> aq_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, ap_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

                bool? ar_(Condition PalliativeCareConcern) {
                    CqlInterval<CqlDateTime> at_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, PalliativeCareConcern as Condition);
                    Period au_ = QualifiedVTEEncounter?.Period;
                    CqlInterval<CqlDateTime> av_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, au_);
                    CqlDateTime aw_ = context.Operators.Start(av_);
                    CqlQuantity ax_ = context.Operators.Quantity(90m, "days");
                    CqlDateTime ay_ = context.Operators.Subtract(aw_, ax_);
                    CqlDateTime az_ = context.Operators.End(av_);
                    CqlInterval<CqlDateTime> ba_ = context.Operators.Interval(ay_, az_, true, true);
                    bool? bb_ = context.Operators.Overlaps(at_, ba_, "day");
                    // CQL 'and' (169:11-170:52): right operand skipped when left is false
                    if (bb_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        bool? bc_ = this.isVerified(context, PalliativeCareConcern as Condition);
                        return bb_ & bc_;
                    }
                }

                bool? as_ = context.Operators.WhereAny<Condition>(aq_, ar_);
                j_ = i_ | as_;
            }
            bool? k_;
            // CQL 'or' (160:11-174:7): right operand skipped when left is true
            if (j_ is true)
            {
                k_ = true;
            }
            else
            {
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
                k_ = j_ | bg_;
            }
            // CQL 'or' (160:5-177:7): right operand skipped when left is true
            if (k_ is true)
            {
                return true;
            }
            else
            {
                CqlValueSet br_ = this.Palliative_Care_Intervention(context);
                IEnumerable<Procedure> bs_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, br_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

                bool? bt_(Procedure PalliativeIntervention) {
                    object bv_;
                    DataType cf_ = PalliativeIntervention?.Performed;
                    object cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlDateTime;
                    if (ch_)
                    {
                        DataType ci_ = PalliativeIntervention?.Performed;
                        object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        bv_ = cj_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ck_ = PalliativeIntervention?.Performed;
                        object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                        bool cm_ = cl_ is CqlQuantity;
                        if (cm_)
                        {
                            DataType cn_ = PalliativeIntervention?.Performed;
                            object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                            bv_ = co_ as CqlQuantity;
                        }
                        else
                        {
                            DataType cp_ = PalliativeIntervention?.Performed;
                            object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                            bool cr_ = cq_ is CqlInterval<CqlDateTime>;
                            if (cr_)
                            {
                                DataType cs_ = PalliativeIntervention?.Performed;
                                object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                                bv_ = ct_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                DataType cu_ = PalliativeIntervention?.Performed;
                                object cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                                bool cw_ = cv_ is CqlInterval<CqlQuantity>;
                                if (cw_)
                                {
                                    DataType cx_ = PalliativeIntervention?.Performed;
                                    object cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                                    bv_ = cy_ as CqlInterval<CqlQuantity>;
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
                return k_ | bu_;
            }
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
                // CQL 'and' (182:17-182:110): right operand skipped when left is false
                if (p_ is false)
                {
                    return false;
                }
                else
                {
                    return p_ & (!((bool?)(l_ is null)));
                }
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
