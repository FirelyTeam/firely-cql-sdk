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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.2.0")]
[CqlLibrary("CMS1017FHIRHHFI", "1.0.000")]
public partial class CMS1017FHIRHHFI_1_0_000 : ILibrary, ISingleton<CMS1017FHIRHHFI_1_0_000>
{
    #region ValueSets (28)

    [CqlValueSetDefinition("Abnormal Weight Loss", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1258.2", valueSetVersion: null)]
    public CqlValueSet Abnormal_Weight_Loss(CqlContext _) => _Abnormal_Weight_Loss;
    private static readonly CqlValueSet _Abnormal_Weight_Loss = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1258.2", null);

    [CqlValueSetDefinition("Anticoagulants for All Indications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.22", valueSetVersion: null)]
    public CqlValueSet Anticoagulants_for_All_Indications(CqlContext _) => _Anticoagulants_for_All_Indications;
    private static readonly CqlValueSet _Anticoagulants_for_All_Indications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.22", null);

    [CqlValueSetDefinition("Antidepressants", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.163", valueSetVersion: null)]
    public CqlValueSet Antidepressants(CqlContext _) => _Antidepressants;
    private static readonly CqlValueSet _Antidepressants = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.163", null);

    [CqlValueSetDefinition("Antihypertensives", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.164", valueSetVersion: null)]
    public CqlValueSet Antihypertensives(CqlContext _) => _Antihypertensives;
    private static readonly CqlValueSet _Antihypertensives = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.164", null);

    [CqlValueSetDefinition("Central Nervous System Depressants", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.134", valueSetVersion: null)]
    public CqlValueSet Central_Nervous_System_Depressants(CqlContext _) => _Central_Nervous_System_Depressants;
    private static readonly CqlValueSet _Central_Nervous_System_Depressants = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.134", null);

    [CqlValueSetDefinition("Coagulation Disorders", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.23", valueSetVersion: null)]
    public CqlValueSet Coagulation_Disorders(CqlContext _) => _Coagulation_Disorders;
    private static readonly CqlValueSet _Coagulation_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.23", null);

    [CqlValueSetDefinition("Delirium, Dementia, and Other Psychoses", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.168", valueSetVersion: null)]
    public CqlValueSet Delirium__Dementia__and_Other_Psychoses(CqlContext _) => _Delirium__Dementia__and_Other_Psychoses;
    private static readonly CqlValueSet _Delirium__Dementia__and_Other_Psychoses = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.168", null);

    [CqlValueSetDefinition("Depression", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.169", valueSetVersion: null)]
    public CqlValueSet Depression(CqlContext _) => _Depression;
    private static readonly CqlValueSet _Depression = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.169", null);

    [CqlValueSetDefinition("Diuretics", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.170", valueSetVersion: null)]
    public CqlValueSet Diuretics(CqlContext _) => _Diuretics;
    private static readonly CqlValueSet _Diuretics = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.170", null);

    [CqlValueSetDefinition("Epilepsy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.171", valueSetVersion: null)]
    public CqlValueSet Epilepsy(CqlContext _) => _Epilepsy;
    private static readonly CqlValueSet _Epilepsy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.171", null);

    [CqlValueSetDefinition("Inpatient Falls", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.171", valueSetVersion: null)]
    public CqlValueSet Inpatient_Falls(CqlContext _) => _Inpatient_Falls;
    private static readonly CqlValueSet _Inpatient_Falls = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.171", null);

    [CqlValueSetDefinition("Leukemia or Lymphoma", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.136", valueSetVersion: null)]
    public CqlValueSet Leukemia_or_Lymphoma(CqlContext _) => _Leukemia_or_Lymphoma;
    private static readonly CqlValueSet _Leukemia_or_Lymphoma = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.136", null);

    [CqlValueSetDefinition("Liver Disease Moderate to Severe", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.137", valueSetVersion: null)]
    public CqlValueSet Liver_Disease_Moderate_to_Severe(CqlContext _) => _Liver_Disease_Moderate_to_Severe;
    private static readonly CqlValueSet _Liver_Disease_Moderate_to_Severe = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.137", null);

    [CqlValueSetDefinition("Major Injuries", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.120", valueSetVersion: null)]
    public CqlValueSet Major_Injuries(CqlContext _) => _Major_Injuries;
    private static readonly CqlValueSet _Major_Injuries = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.120", null);

    [CqlValueSetDefinition("Malignant Bone Disease", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.24", valueSetVersion: null)]
    public CqlValueSet Malignant_Bone_Disease(CqlContext _) => _Malignant_Bone_Disease;
    private static readonly CqlValueSet _Malignant_Bone_Disease = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.24", null);

    [CqlValueSetDefinition("Malnutrition", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1272.1", valueSetVersion: null)]
    public CqlValueSet Malnutrition(CqlContext _) => _Malnutrition;
    private static readonly CqlValueSet _Malnutrition = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1272.1", null);

    [CqlValueSetDefinition("Moderate Injuries", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.205", valueSetVersion: null)]
    public CqlValueSet Moderate_Injuries(CqlContext _) => _Moderate_Injuries;
    private static readonly CqlValueSet _Moderate_Injuries = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.205", null);

    [CqlValueSetDefinition("Neurologic Movement and Related Disorders", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.174", valueSetVersion: null)]
    public CqlValueSet Neurologic_Movement_and_Related_Disorders(CqlContext _) => _Neurologic_Movement_and_Related_Disorders;
    private static readonly CqlValueSet _Neurologic_Movement_and_Related_Disorders = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.174", null);

    [CqlValueSetDefinition("Not Present On Admission or Documentation Insufficient to Determine", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", valueSetVersion: null)]
    public CqlValueSet Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(CqlContext _) => _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine;
    private static readonly CqlValueSet _Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.198", null);

    [CqlValueSetDefinition("Obesity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.162", valueSetVersion: null)]
    public CqlValueSet Obesity(CqlContext _) => _Obesity;
    private static readonly CqlValueSet _Obesity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.162", null);

    [CqlValueSetDefinition("Opioids", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.120", valueSetVersion: null)]
    public CqlValueSet Opioids(CqlContext _) => _Opioids;
    private static readonly CqlValueSet _Opioids = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.120", null);

    [CqlValueSetDefinition("Osteoporosis", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1200.147", valueSetVersion: null)]
    public CqlValueSet Osteoporosis(CqlContext _) => _Osteoporosis;
    private static readonly CqlValueSet _Osteoporosis = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1200.147", null);

    [CqlValueSetDefinition("Peripheral Neuropathy", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.175", valueSetVersion: null)]
    public CqlValueSet Peripheral_Neuropathy(CqlContext _) => _Peripheral_Neuropathy;
    private static readonly CqlValueSet _Peripheral_Neuropathy = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.175", null);

    [CqlValueSetDefinition("Present on Admission or Clinically Undetermined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", valueSetVersion: null)]
    public CqlValueSet Present_on_Admission_or_Clinically_Undetermined(CqlContext _) => _Present_on_Admission_or_Clinically_Undetermined;
    private static readonly CqlValueSet _Present_on_Admission_or_Clinically_Undetermined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1147.197", null);

    [CqlValueSetDefinition("Stroke", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.176", valueSetVersion: null)]
    public CqlValueSet Stroke(CqlContext _) => _Stroke;
    private static readonly CqlValueSet _Stroke = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.176", null);

    [CqlValueSetDefinition("Suicide Attempt", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.130", valueSetVersion: null)]
    public CqlValueSet Suicide_Attempt(CqlContext _) => _Suicide_Attempt;
    private static readonly CqlValueSet _Suicide_Attempt = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.130", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    #endregion ValueSets

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, []);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 7239015735015004398L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS1017FHIRHHFI-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (45)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -2859982306975276846L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter, Qualifying_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Encounter = 6631354683532865594L;

    private IEnumerable<Encounter> Qualifying_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = CQMCommon_4_1_000.Instance.Inpatient_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlInterval<CqlDateTime> d_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
            int? e_ = CQMCommon_4_1_000.Instance.lengthInDays(context, d_);
            bool? f_ = context.Operators.LessOrEqual(e_, 120);
            // CQL 'and' (49:5-50:74): right operand skipped when left is false
            if (f_ is false)
            {
                return false;
            }
            else
            {
                Patient g_ = this.Patient(context);
                Date h_ = g_?.BirthDateElement;
                string i_ = h_?.Value;
                CqlDate j_ = context.Operators.ConvertStringToDate(i_);
                Period k_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, k_);
                CqlDateTime m_ = context.Operators.Start(l_);
                CqlDate n_ = context.Operators.DateFrom(m_);
                int? o_ = context.Operators.CalculateAgeAt(j_, n_, "year");
                bool? p_ = context.Operators.GreaterOrEqual(o_, 18);
                return f_ & p_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = 8909640820178408265L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 8325884910617275031L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlFunctionDefinition("encountersDiagnosis")]
    public IEnumerable<Condition> encountersDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<ResourceReference> a_ = Encounter?.ReasonReference;

        Condition b_(ResourceReference EncDiag) {
            IEnumerable<Condition> d_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> f_ = context.Operators.Union<Condition>(d_ as IEnumerable<Condition>, e_ as IEnumerable<Condition>);

            bool? g_(Condition Cond) {
                Id j_ = Cond?.IdElement;
                string k_ = j_?.Value;
                bool? l_ = QICoreCommon_4_0_000.Instance.references(context, EncDiag, k_);
                return l_;
            }

            IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
            Condition i_ = context.Operators.SingletonFrom<Condition>(h_);
            return i_;
        }

        IEnumerable<Condition> c_ = context.Operators.SelectDistinct<ResourceReference, Condition>((IEnumerable<ResourceReference>)a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With A Fall Diagnosis")]
    public IEnumerable<Encounter> Encounter_With_A_Fall_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_A_Fall_Diagnosis, Encounter_With_A_Fall_Diagnosis_Compute);

    private const long _cacheIndex_Encounter_With_A_Fall_Diagnosis = -4260035697956895772L;

    private IEnumerable<Encounter> Encounter_With_A_Fall_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter QualifyingFall) {
            List<CodeableConcept> d_ = QualifyingFall?.ReasonCode;

            CqlConcept e_(CodeableConcept @this) {
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return i_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Inpatient_Falls(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            // CQL 'or' (94:5-95:73): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                IEnumerable<Condition> j_ = this.encountersDiagnosis(context, QualifyingFall);

                bool? k_(Condition @this) {
                    CodeableConcept p_ = @this?.Code;
                    CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, p_);
                    return !((bool?)(q_ is null));
                }


                CqlConcept l_(Condition @this) {
                    CodeableConcept r_ = @this?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    return s_;
                }

                IEnumerable<CqlConcept> m_ = context.Operators.WhereSelect<Condition, CqlConcept>(j_, k_, l_);
                CqlValueSet n_ = this.Inpatient_Falls(context);
                bool? o_ = context.Operators.ConceptsInValueSet(m_, n_);
                return h_ | o_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With A Fall Event")]
    public IEnumerable<Encounter> Encounter_With_A_Fall_Event(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_A_Fall_Event, Encounter_With_A_Fall_Event_Compute);

    private const long _cacheIndex_Encounter_With_A_Fall_Event = 867772196484577946L;

    private IEnumerable<Encounter> Encounter_With_A_Fall_Event_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Inpatient_Falls(context);
            IEnumerable<AdverseEvent> e_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));

            bool? f_(AdverseEvent FallsDocumentation) {
                FhirDateTime h_ = FallsDocumentation?.DateElement;
                CqlDateTime i_ = context.Operators.Convert<CqlDateTime>(h_);
                FhirDateTime j_ = FallsDocumentation?.RecordedDateElement;
                CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? m_ = context.Operators.In<CqlDateTime>(i_ ?? k_, l_, (string)default);
                return m_;
            }

            bool? g_ = context.Operators.WhereAny<AdverseEvent>(e_, f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter Where A Fall Occurred")]
    public IEnumerable<Encounter> Encounter_Where_A_Fall_Occurred(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_Where_A_Fall_Occurred, Encounter_Where_A_Fall_Occurred_Compute);

    private const long _cacheIndex_Encounter_Where_A_Fall_Occurred = 795907075661115072L;

    private IEnumerable<Encounter> Encounter_Where_A_Fall_Occurred_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_A_Fall_Diagnosis(context);
        IEnumerable<Encounter> b_ = this.Encounter_With_A_Fall_Event(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("hasDiagnosisNotPresentOnAdmissionOrNull")]
    public bool? hasDiagnosisNotPresentOnAdmissionOrNull(CqlContext context, Encounter encounter, CqlValueSet diagnosisValueSet)
    {
        IEnumerable<Claim> a_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

        bool? b_(Claim C) {
            Code<FinancialResourceStatusCodes> g_ = C?.StatusElement;
            FinancialResourceStatusCodes? h_ = g_?.Value;
            Code<FinancialResourceStatusCodes> i_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(h_);
            bool? j_ = context.Operators.Equal(i_, "active");
            bool? k_;
            // CQL 'and' (300:13-301:27): right operand skipped when left is false
            if (j_ is false)
            {
                k_ = false;
            }
            else
            {
                Code<ClaimUseCode> l_ = C?.UseElement;
                ClaimUseCode? m_ = l_?.Value;
                Code<ClaimUseCode> n_ = context.Operators.Convert<Code<ClaimUseCode>>(m_);
                bool? o_ = context.Operators.Equal(n_, "claim");
                k_ = j_ & o_;
            }
            // CQL 'and' (300:7-304:9): right operand skipped when left is false
            if (k_ is false)
            {
                return false;
            }
            else
            {
                List<Claim.ItemComponent> p_ = C?.Item;

                bool? q_(Claim.ItemComponent I) {
                    List<ResourceReference> s_ = I?.Encounter;
                    bool? t_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)s_, encounter);
                    return t_;
                }

                bool? r_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)p_, q_);
                return k_ & r_;
            }
        }


        IEnumerable<Claim.DiagnosisComponent> c_(Claim C) {
            List<Claim.DiagnosisComponent> u_ = C?.Diagnosis;

            bool? v_(Claim.DiagnosisComponent D) {
                List<Claim.ItemComponent> x_ = C?.Item;

                bool? y_(Claim.ItemComponent I) {
                    List<ResourceReference> ab_ = I?.Encounter;
                    bool? ac_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ab_, encounter);
                    // CQL 'and' (307:13-308:51): right operand skipped when left is false
                    if (ac_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        PositiveInt ad_ = D?.SequenceElement;
                        int? ae_ = ad_?.Value;
                        List<PositiveInt> af_ = I?.DiagnosisSequenceElement;

                        int? ag_(PositiveInt @this) {
                            int? aj_ = @this?.Value;
                            return aj_;
                        }

                        IEnumerable<int?> ah_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)af_, ag_);
                        bool? ai_ = context.Operators.In<int?>(ae_, ah_);
                        return ac_ & ai_;
                    }
                }

                bool? z_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)x_, y_);
                bool? aa_;
                // CQL 'and' (306:15-312:11): right operand skipped when left is false
                if (z_ is false)
                {
                    aa_ = false;
                }
                else
                {
                    CodeableConcept ak_ = D?.OnAdmission;
                    CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                    bool? am_ = (bool?)(al_ is null);
                    bool? an_;
                    // CQL 'or' (310:15-312:11): right operand skipped when left is true
                    if (am_ is true)
                    {
                        an_ = true;
                    }
                    else
                    {
                        CodeableConcept ao_ = D?.OnAdmission;
                        CqlConcept ap_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ao_);
                        CqlValueSet aq_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                        bool? ar_ = context.Operators.ConceptInValueSet(ap_, aq_);
                        an_ = am_ | ar_;
                    }
                    aa_ = z_ & an_;
                }
                // CQL 'and' (306:9-313:46): right operand skipped when left is false
                if (aa_ is false)
                {
                    return false;
                }
                else
                {
                    DataType as_ = D?.Diagnosis;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool? au_ = context.Operators.ConceptInValueSet(at_ as CqlConcept, diagnosisValueSet);
                    return aa_ & au_;
                }
            }

            IEnumerable<Claim.DiagnosisComponent> w_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)u_, v_);
            return w_;
        }

        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> d_ = context.Operators.WhereSelect<Claim, IEnumerable<Claim.DiagnosisComponent>>(a_, b_, c_);
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> e_ = context.Operators.Distinct<IEnumerable<Claim.DiagnosisComponent>>(d_);
        bool? f_ = context.Operators.Exists<IEnumerable<Claim.DiagnosisComponent>>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Encounter With A Fall Not Present On Admission")]
    public IEnumerable<Encounter> Encounter_With_A_Fall_Not_Present_On_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_A_Fall_Not_Present_On_Admission, Encounter_With_A_Fall_Not_Present_On_Admission_Compute);

    private const long _cacheIndex_Encounter_With_A_Fall_Not_Present_On_Admission = -6325763340603139774L;

    private IEnumerable<Encounter> Encounter_With_A_Fall_Not_Present_On_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_Where_A_Fall_Occurred(context);

        bool? b_(Encounter EncounterFallDiagnosis) {
            CqlValueSet d_ = this.Inpatient_Falls(context);
            bool? e_ = this.hasDiagnosisNotPresentOnAdmissionOrNull(context, EncounterFallDiagnosis, d_);
            return e_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter Where A Fall And Major Injury Occurred Not POA")]
    public IEnumerable<Encounter> Encounter_Where_A_Fall_And_Major_Injury_Occurred_Not_POA(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_Where_A_Fall_And_Major_Injury_Occurred_Not_POA, Encounter_Where_A_Fall_And_Major_Injury_Occurred_Not_POA_Compute);

    private const long _cacheIndex_Encounter_Where_A_Fall_And_Major_Injury_Occurred_Not_POA = 4813225188493827856L;

    private IEnumerable<Encounter> Encounter_Where_A_Fall_And_Major_Injury_Occurred_Not_POA_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_A_Fall_Not_Present_On_Admission(context);

        bool? b_(Encounter FallOccurred) {
            IEnumerable<Claim.DiagnosisComponent> d_ = CQMCommon_4_1_000.Instance.claimDiagnosis(context, FallOccurred);

            bool? e_(Claim.DiagnosisComponent MajorFallOccurred) {
                CodeableConcept g_ = MajorFallOccurred?.OnAdmission;
                CqlConcept h_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, g_);
                bool? i_ = (bool?)(h_ is null);
                bool? j_;
                // CQL 'or' (76:15-78:9): right operand skipped when left is true
                if (i_ is true)
                {
                    j_ = true;
                }
                else
                {
                    CodeableConcept k_ = MajorFallOccurred?.OnAdmission;
                    CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                    CqlValueSet m_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                    bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
                    j_ = i_ | n_;
                }
                // CQL 'and' (76:9-81:11): right operand skipped when left is false
                if (j_ is false)
                {
                    return false;
                }
                else
                {
                    DataType o_ = MajorFallOccurred?.Diagnosis;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    CqlValueSet q_ = this.Major_Injuries(context);
                    bool? r_ = context.Operators.ConceptInValueSet(p_ as CqlConcept, q_);
                    bool? s_;
                    // CQL 'or' (79:15-81:11): right operand skipped when left is true
                    if (r_ is true)
                    {
                        s_ = true;
                    }
                    else
                    {
                        DataType t_ = MajorFallOccurred?.Diagnosis;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        Condition v_ = CQMCommon_4_1_000.Instance.getCondition(context, u_ as ResourceReference);
                        CodeableConcept w_ = v_?.Code;
                        CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                        CqlValueSet y_ = this.Major_Injuries(context);
                        bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                        s_ = r_ | z_;
                    }
                    return j_ & s_;
                }
            }

            bool? f_ = context.Operators.WhereAny<Claim.DiagnosisComponent>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter Where A Fall And Moderate Injury Occurred Not POA")]
    public IEnumerable<Encounter> Encounter_Where_A_Fall_And_Moderate_Injury_Occurred_Not_POA(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_Where_A_Fall_And_Moderate_Injury_Occurred_Not_POA, Encounter_Where_A_Fall_And_Moderate_Injury_Occurred_Not_POA_Compute);

    private const long _cacheIndex_Encounter_Where_A_Fall_And_Moderate_Injury_Occurred_Not_POA = 9037820097058256858L;

    private IEnumerable<Encounter> Encounter_Where_A_Fall_And_Moderate_Injury_Occurred_Not_POA_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_A_Fall_Not_Present_On_Admission(context);

        bool? b_(Encounter FallOccurred) {
            IEnumerable<Claim.DiagnosisComponent> d_ = CQMCommon_4_1_000.Instance.claimDiagnosis(context, FallOccurred);

            bool? e_(Claim.DiagnosisComponent ModerateFallOccurred) {
                CodeableConcept g_ = ModerateFallOccurred?.OnAdmission;
                CqlConcept h_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, g_);
                bool? i_ = (bool?)(h_ is null);
                bool? j_;
                // CQL 'or' (65:15-67:9): right operand skipped when left is true
                if (i_ is true)
                {
                    j_ = true;
                }
                else
                {
                    CodeableConcept k_ = ModerateFallOccurred?.OnAdmission;
                    CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                    CqlValueSet m_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                    bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
                    j_ = i_ | n_;
                }
                // CQL 'and' (65:9-70:11): right operand skipped when left is false
                if (j_ is false)
                {
                    return false;
                }
                else
                {
                    DataType o_ = ModerateFallOccurred?.Diagnosis;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    CqlValueSet q_ = this.Moderate_Injuries(context);
                    bool? r_ = context.Operators.ConceptInValueSet(p_ as CqlConcept, q_);
                    bool? s_;
                    // CQL 'or' (68:15-70:11): right operand skipped when left is true
                    if (r_ is true)
                    {
                        s_ = true;
                    }
                    else
                    {
                        DataType t_ = ModerateFallOccurred?.Diagnosis;
                        object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                        Condition v_ = CQMCommon_4_1_000.Instance.getCondition(context, u_ as ResourceReference);
                        CodeableConcept w_ = v_?.Code;
                        CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                        CqlValueSet y_ = this.Moderate_Injuries(context);
                        bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                        s_ = r_ | z_;
                    }
                    return j_ & s_;
                }
            }

            bool? f_ = context.Operators.WhereAny<Claim.DiagnosisComponent>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = 75500722536813452L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_Where_A_Fall_And_Major_Injury_Occurred_Not_POA(context);
        IEnumerable<Encounter> b_ = this.Encounter_Where_A_Fall_And_Moderate_Injury_Occurred_Not_POA(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With A Fall Present On Admission")]
    public IEnumerable<Encounter> Encounter_With_A_Fall_Present_On_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_A_Fall_Present_On_Admission, Encounter_With_A_Fall_Present_On_Admission_Compute);

    private const long _cacheIndex_Encounter_With_A_Fall_Present_On_Admission = -6633124270615127096L;

    private IEnumerable<Encounter> Encounter_With_A_Fall_Present_On_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Inpatient_Falls(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 9090268816274383848L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_A_Fall_Present_On_Admission(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator Exclusions")]
    public IEnumerable<Encounter> Numerator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_Exclusions, Numerator_Exclusions_Compute);

    private const long _cacheIndex_Numerator_Exclusions = 7919091718784135074L;

    private IEnumerable<Encounter> Numerator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_A_Fall_Present_On_Admission(context);
        return a_;
    }


    [CqlExpressionDefinition("Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Body_Mass_Index__BMI_, Risk_Variable_Body_Mass_Index__BMI__Compute);

    private const long _cacheIndex_Risk_Variable_Body_Mass_Index__BMI_ = -8832772703149002861L;

    private IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI__Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));

        bool? b_(Observation BMI) {
            IEnumerable<Encounter> f_ = this.Qualifying_Encounter(context);

            bool? g_(Encounter InpatientEncounter) {
                DataType i_ = BMI?.Effective;
                object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, (string)default);
                bool? o_;
                // CQL 'and' (116:17-117:33): right operand skipped when left is false
                if (n_ is false)
                {
                    o_ = false;
                }
                else
                {
                    DataType p_ = BMI?.Value;
                    CqlQuantity q_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, p_ as Quantity);
                    o_ = n_ & (!((bool?)(q_ is null)));
                }
                // CQL 'and' (116:17-118:61): right operand skipped when left is false
                if (o_ is false)
                {
                    return false;
                }
                else
                {
                    Code<ObservationStatus> r_ = BMI?.StatusElement;
                    ObservationStatus? s_ = r_?.Value;
                    string t_ = context.Operators.Convert<string>(s_);
                    string[] u_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
                    return o_ & v_;
                }
            }

            bool? h_ = context.Operators.WhereAny<Encounter>(f_, g_);
            return h_;
        }


        CqlQuantity c_(Observation BMI) {
            DataType w_ = BMI?.Value;
            CqlQuantity x_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, w_ as Quantity);
            return x_ as CqlQuantity;
        }

        IEnumerable<CqlQuantity> d_ = context.Operators.WhereSelect<Observation, CqlQuantity>(a_, b_, c_);
        IEnumerable<CqlQuantity> e_ = context.Operators.Distinct<CqlQuantity>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses with Rank and POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?> Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication, Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication_Compute);

    private const long _cacheIndex_Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication = 7202944664208919231L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?> Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)? b_(Encounter InpatientEncounter) {
            Id d_ = InpatientEncounter?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Claim> f_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? g_(Claim C) {
                Code<FinancialResourceStatusCodes> ae_ = C?.StatusElement;
                FinancialResourceStatusCodes? af_ = ae_?.Value;
                Code<FinancialResourceStatusCodes> ag_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(af_);
                bool? ah_ = context.Operators.Equal(ag_, "active");
                bool? ai_;
                // CQL 'and' (125:15-126:29): right operand skipped when left is false
                if (ah_ is false)
                {
                    ai_ = false;
                }
                else
                {
                    Code<ClaimUseCode> aj_ = C?.UseElement;
                    ClaimUseCode? ak_ = aj_?.Value;
                    Code<ClaimUseCode> al_ = context.Operators.Convert<Code<ClaimUseCode>>(ak_);
                    bool? am_ = context.Operators.Equal(al_, "claim");
                    ai_ = ah_ & am_;
                }
                // CQL 'and' (125:9-129:11): right operand skipped when left is false
                if (ai_ is false)
                {
                    return false;
                }
                else
                {
                    List<Claim.ItemComponent> an_ = C?.Item;

                    bool? ao_(Claim.ItemComponent ClaimItem) {
                        List<ResourceReference> aq_ = ClaimItem?.Encounter;
                        bool? ar_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)aq_, InpatientEncounter);
                        return ar_;
                    }

                    bool? ap_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)an_, ao_);
                    return ai_ & ap_;
                }
            }

            IEnumerable<Claim> h_ = context.Operators.Where<Claim>(f_, g_);

            bool? i_(Claim @this) {
                List<Claim.DiagnosisComponent> as_ = @this?.Diagnosis;
                return !((bool?)(as_ is null));
            }


            List<Claim.DiagnosisComponent> j_(Claim @this) {
                List<Claim.DiagnosisComponent> at_ = @this?.Diagnosis;
                return at_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> k_ = context.Operators.WhereSelect<Claim, List<Claim.DiagnosisComponent>>(h_, i_, j_);
            IEnumerable<Claim.DiagnosisComponent> l_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)k_);

            bool? m_(Claim C) {
                Code<FinancialResourceStatusCodes> au_ = C?.StatusElement;
                FinancialResourceStatusCodes? av_ = au_?.Value;
                Code<FinancialResourceStatusCodes> aw_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(av_);
                bool? ax_ = context.Operators.Equal(aw_, "active");
                bool? ay_;
                // CQL 'and' (125:15-126:29): right operand skipped when left is false
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
                // CQL 'and' (125:9-129:11): right operand skipped when left is false
                if (ay_ is false)
                {
                    return false;
                }
                else
                {
                    List<Claim.ItemComponent> bd_ = C?.Item;

                    bool? be_(Claim.ItemComponent ClaimItem) {
                        List<ResourceReference> bg_ = ClaimItem?.Encounter;
                        bool? bh_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bg_, InpatientEncounter);
                        return bh_;
                    }

                    bool? bf_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bd_, be_);
                    return ay_ & bf_;
                }
            }

            IEnumerable<Claim> n_ = context.Operators.Where<Claim>(f_, m_);

            bool? o_(Claim @this) {
                List<Claim.DiagnosisComponent> bi_ = @this?.Diagnosis;
                return !((bool?)(bi_ is null));
            }


            List<Claim.DiagnosisComponent> p_(Claim @this) {
                List<Claim.DiagnosisComponent> bj_ = @this?.Diagnosis;
                return bj_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> q_ = context.Operators.WhereSelect<Claim, List<Claim.DiagnosisComponent>>(n_, o_, p_);
            IEnumerable<Claim.DiagnosisComponent> r_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)q_);

            bool? s_(Claim.DiagnosisComponent @this) {
                PositiveInt bk_ = @this?.SequenceElement;
                int? bl_ = bk_?.Value;
                return !((bool?)(bl_ is null));
            }


            int? t_(Claim.DiagnosisComponent @this) {
                PositiveInt bm_ = @this?.SequenceElement;
                int? bn_ = bm_?.Value;
                return bn_;
            }

            IEnumerable<int?> u_ = context.Operators.WhereSelect<Claim.DiagnosisComponent, int?>(r_, s_, t_);

            bool? v_(Claim C) {
                Code<FinancialResourceStatusCodes> bo_ = C?.StatusElement;
                FinancialResourceStatusCodes? bp_ = bo_?.Value;
                Code<FinancialResourceStatusCodes> bq_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bp_);
                bool? br_ = context.Operators.Equal(bq_, "active");
                bool? bs_;
                // CQL 'and' (125:15-126:29): right operand skipped when left is false
                if (br_ is false)
                {
                    bs_ = false;
                }
                else
                {
                    Code<ClaimUseCode> bt_ = C?.UseElement;
                    ClaimUseCode? bu_ = bt_?.Value;
                    Code<ClaimUseCode> bv_ = context.Operators.Convert<Code<ClaimUseCode>>(bu_);
                    bool? bw_ = context.Operators.Equal(bv_, "claim");
                    bs_ = br_ & bw_;
                }
                // CQL 'and' (125:9-129:11): right operand skipped when left is false
                if (bs_ is false)
                {
                    return false;
                }
                else
                {
                    List<Claim.ItemComponent> bx_ = C?.Item;

                    bool? by_(Claim.ItemComponent ClaimItem) {
                        List<ResourceReference> ca_ = ClaimItem?.Encounter;
                        bool? cb_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ca_, InpatientEncounter);
                        return cb_;
                    }

                    bool? bz_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bx_, by_);
                    return bs_ & bz_;
                }
            }

            IEnumerable<Claim> w_ = context.Operators.Where<Claim>(f_, v_);

            bool? x_(Claim @this) {
                List<Claim.DiagnosisComponent> cc_ = @this?.Diagnosis;
                return !((bool?)(cc_ is null));
            }


            List<Claim.DiagnosisComponent> y_(Claim @this) {
                List<Claim.DiagnosisComponent> cd_ = @this?.Diagnosis;
                return cd_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> z_ = context.Operators.WhereSelect<Claim, List<Claim.DiagnosisComponent>>(w_, x_, y_);
            IEnumerable<Claim.DiagnosisComponent> aa_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)z_);

            bool? ab_(Claim.DiagnosisComponent Diag) {
                CodeableConcept ce_ = Diag?.OnAdmission;
                CqlConcept cf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ce_);
                CqlValueSet cg_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? ch_ = context.Operators.ConceptInValueSet(cf_, cg_);
                // CQL 'or' (139:9-140:102): right operand skipped when left is true
                if (ch_ is true)
                {
                    return true;
                }
                else
                {
                    CodeableConcept ci_ = Diag?.OnAdmission;
                    CqlConcept cj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ci_);
                    CqlValueSet ck_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                    bool? cl_ = context.Operators.ConceptInValueSet(cj_, ck_);
                    return ch_ | cl_;
                }
            }

            IEnumerable<Claim.DiagnosisComponent> ac_ = context.Operators.Where<Claim.DiagnosisComponent>(aa_, ab_);
            (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)? ad_ = (CqlTupleMetadata_DSSBhUTbQjBZiPCFMDNfdCQVg, e_, l_, u_, ac_);
            return ad_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Abnormal Weight Loss or Malnutrition Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission, Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission = 1687786406611411202L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Abnormal_Weight_Loss(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            // CQL 'or' (145:5-146:127): right operand skipped when left is true
            if (f_ is true)
            {
                return true;
            }
            else
            {
                CqlValueSet g_ = this.Malnutrition(context);
                CqlValueSet h_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? i_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, g_, h_);
                return f_ | i_;
            }
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission, Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission = 2537708922668979649L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? e_(MedicationRequest MR) {
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Anticoagulants_for_All_Indications(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest Anticoagulants) {
                Code<MedicationRequest.MedicationrequestStatus> x_ = Anticoagulants?.StatusElement;
                MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "active",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_;
                // CQL 'and' (151:17-156:9): right operand skipped when left is false
                if (ab_ is false)
                {
                    ac_ = false;
                }
                else
                {
                    Code<MedicationRequest.MedicationRequestIntent> ae_ = Anticoagulants?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
                    string ag_ = context.Operators.Convert<string>(af_);
                    bool? ah_ = context.Operators.Equal(ag_, "order");
                    bool? ai_;
                    // CQL 'or' (152:13-156:9): right operand skipped when left is true
                    if (ah_ is true)
                    {
                        ai_ = true;
                    }
                    else
                    {
                        Code<MedicationRequest.MedicationRequestIntent> aj_ = Anticoagulants?.IntentElement;
                        MedicationRequest.MedicationRequestIntent? ak_ = aj_?.Value;
                        string al_ = context.Operators.Convert<string>(ak_);
                        bool? am_ = context.Operators.Equal(al_, "plan");
                        bool? an_;
                        // CQL 'and' (153:16-155:13): right operand skipped when left is false
                        if (am_ is false)
                        {
                            an_ = false;
                        }
                        else
                        {
                            ResourceReference ao_ = Anticoagulants?.Subject;
                            FhirString ap_ = ao_?.ReferenceElement;
                            string aq_ = ap_?.Value;
                            string ar_ = QICoreCommon_4_0_000.Instance.getId(context, aq_);
                            Id as_;
                            Patient av_ = this.Patient(context);
                            bool aw_ = av_ is Resource;
                            if (aw_)
                            {
                                Patient ax_ = this.Patient(context);
                                as_ = (ax_ as Resource).IdElement;
                            }
                            else
                            {
                                as_ = default;
                            }
                            string at_ = as_?.Value;
                            bool? au_ = context.Operators.Equal(ar_, at_);
                            an_ = am_ & au_;
                        }
                        ai_ = ah_ | an_;
                    }
                    ac_ = ab_ & ai_;
                }
                bool? ad_;
                // CQL 'and' (151:17-157:42): right operand skipped when left is false
                if (ac_ is false)
                {
                    ad_ = false;
                }
                else
                {
                    bool? ay_ = QICoreCommon_4_0_000.Instance.isCommunity(context, Anticoagulants as MedicationRequest);
                    ad_ = ac_ & ay_;
                }
                // CQL 'and' (151:17-158:103): right operand skipped when left is false
                if (ad_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDate> az_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, Anticoagulants);
                    CqlDate ba_ = az_?.low;
                    CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(ba_);
                    CqlDate bc_ = az_?.high;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    bool? be_ = az_?.lowClosed;
                    bool? bf_ = az_?.highClosed;
                    CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bb_, bd_, be_, bf_);
                    Period bh_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                    bool? bj_ = context.Operators.OverlapsBefore(bg_, bi_, "day");
                    return ad_ & bj_;
                }
            }

            bool? k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Administration During Encounter")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter, Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter = -5616865709202141790L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

            bool? e_(MedicationAdministration MR) {
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Anticoagulants_for_All_Indications(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            CqlValueSet g_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationAdministration> h_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(f_, h_);

            bool? j_(MedicationAdministration Anticoagulants) {
                DataType x_ = Anticoagulants?.Effective;
                object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                CqlDateTime aa_ = context.Operators.Start(z_);
                CqlInterval<CqlDateTime> ab_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, (string)default);
                // CQL 'and' (163:17-164:67): right operand skipped when left is false
                if (ac_ is false)
                {
                    return false;
                }
                else
                {
                    Code<MedicationAdministration.MedicationAdministrationStatusCodes> ad_ = Anticoagulants?.StatusElement;
                    MedicationAdministration.MedicationAdministrationStatusCodes? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "in-progress",
                        "completed",
                    ];
                    bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    return ac_ & ah_;
                }
            }

            bool? k_ = context.Operators.WhereAny<MedicationAdministration>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Antidepressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission, Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission = -3270489974385968258L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? e_(MedicationRequest MR) {
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Antidepressants(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Antidepressants(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest AntidepressantMed) {
                Code<MedicationRequest.MedicationrequestStatus> x_ = AntidepressantMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "active",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_;
                // CQL 'and' (169:17-174:9): right operand skipped when left is false
                if (ab_ is false)
                {
                    ac_ = false;
                }
                else
                {
                    Code<MedicationRequest.MedicationRequestIntent> ae_ = AntidepressantMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
                    string ag_ = context.Operators.Convert<string>(af_);
                    bool? ah_ = context.Operators.Equal(ag_, "order");
                    bool? ai_;
                    // CQL 'or' (170:13-174:9): right operand skipped when left is true
                    if (ah_ is true)
                    {
                        ai_ = true;
                    }
                    else
                    {
                        Code<MedicationRequest.MedicationRequestIntent> aj_ = AntidepressantMed?.IntentElement;
                        MedicationRequest.MedicationRequestIntent? ak_ = aj_?.Value;
                        string al_ = context.Operators.Convert<string>(ak_);
                        bool? am_ = context.Operators.Equal(al_, "plan");
                        bool? an_;
                        // CQL 'and' (171:16-173:13): right operand skipped when left is false
                        if (am_ is false)
                        {
                            an_ = false;
                        }
                        else
                        {
                            ResourceReference ao_ = AntidepressantMed?.Subject;
                            FhirString ap_ = ao_?.ReferenceElement;
                            string aq_ = ap_?.Value;
                            string ar_ = QICoreCommon_4_0_000.Instance.getId(context, aq_);
                            Id as_;
                            Patient av_ = this.Patient(context);
                            bool aw_ = av_ is Resource;
                            if (aw_)
                            {
                                Patient ax_ = this.Patient(context);
                                as_ = (ax_ as Resource).IdElement;
                            }
                            else
                            {
                                as_ = default;
                            }
                            string at_ = as_?.Value;
                            bool? au_ = context.Operators.Equal(ar_, at_);
                            an_ = am_ & au_;
                        }
                        ai_ = ah_ | an_;
                    }
                    ac_ = ab_ & ai_;
                }
                bool? ad_;
                // CQL 'and' (169:17-175:45): right operand skipped when left is false
                if (ac_ is false)
                {
                    ad_ = false;
                }
                else
                {
                    bool? ay_ = QICoreCommon_4_0_000.Instance.isCommunity(context, AntidepressantMed as MedicationRequest);
                    ad_ = ac_ & ay_;
                }
                // CQL 'and' (169:17-176:106): right operand skipped when left is false
                if (ad_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDate> az_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AntidepressantMed);
                    CqlDate ba_ = az_?.low;
                    CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(ba_);
                    CqlDate bc_ = az_?.high;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    bool? be_ = az_?.lowClosed;
                    bool? bf_ = az_?.highClosed;
                    CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bb_, bd_, be_, bf_);
                    Period bh_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                    bool? bj_ = context.Operators.OverlapsBefore(bg_, bi_, "day");
                    return ad_ & bj_;
                }
            }

            bool? k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Antihypertensive Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission, Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission = 77730647164612247L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? e_(MedicationRequest MR) {
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Antihypertensives(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Antihypertensives(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest BPMed) {
                Code<MedicationRequest.MedicationrequestStatus> x_ = BPMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "active",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_;
                // CQL 'and' (181:17-186:9): right operand skipped when left is false
                if (ab_ is false)
                {
                    ac_ = false;
                }
                else
                {
                    Code<MedicationRequest.MedicationRequestIntent> ae_ = BPMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
                    string ag_ = context.Operators.Convert<string>(af_);
                    bool? ah_ = context.Operators.Equal(ag_, "order");
                    bool? ai_;
                    // CQL 'or' (182:13-186:9): right operand skipped when left is true
                    if (ah_ is true)
                    {
                        ai_ = true;
                    }
                    else
                    {
                        Code<MedicationRequest.MedicationRequestIntent> aj_ = BPMed?.IntentElement;
                        MedicationRequest.MedicationRequestIntent? ak_ = aj_?.Value;
                        string al_ = context.Operators.Convert<string>(ak_);
                        bool? am_ = context.Operators.Equal(al_, "plan");
                        bool? an_;
                        // CQL 'and' (183:16-185:13): right operand skipped when left is false
                        if (am_ is false)
                        {
                            an_ = false;
                        }
                        else
                        {
                            ResourceReference ao_ = BPMed?.Subject;
                            FhirString ap_ = ao_?.ReferenceElement;
                            string aq_ = ap_?.Value;
                            string ar_ = QICoreCommon_4_0_000.Instance.getId(context, aq_);
                            Id as_;
                            Patient av_ = this.Patient(context);
                            bool aw_ = av_ is Resource;
                            if (aw_)
                            {
                                Patient ax_ = this.Patient(context);
                                as_ = (ax_ as Resource).IdElement;
                            }
                            else
                            {
                                as_ = default;
                            }
                            string at_ = as_?.Value;
                            bool? au_ = context.Operators.Equal(ar_, at_);
                            an_ = am_ & au_;
                        }
                        ai_ = ah_ | an_;
                    }
                    ac_ = ab_ & ai_;
                }
                bool? ad_;
                // CQL 'and' (181:17-187:33): right operand skipped when left is false
                if (ac_ is false)
                {
                    ad_ = false;
                }
                else
                {
                    bool? ay_ = QICoreCommon_4_0_000.Instance.isCommunity(context, BPMed as MedicationRequest);
                    ad_ = ac_ & ay_;
                }
                // CQL 'and' (181:17-188:94): right operand skipped when left is false
                if (ad_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDate> az_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, BPMed);
                    CqlDate ba_ = az_?.low;
                    CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(ba_);
                    CqlDate bc_ = az_?.high;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    bool? be_ = az_?.lowClosed;
                    bool? bf_ = az_?.highClosed;
                    CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bb_, bd_, be_, bf_);
                    Period bh_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                    bool? bj_ = context.Operators.OverlapsBefore(bg_, bi_, "day");
                    return ad_ & bj_;
                }
            }

            bool? k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with CNS Depressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission, Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission = 5774110077431550078L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? e_(MedicationRequest MR) {
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Central_Nervous_System_Depressants(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Central_Nervous_System_Depressants(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest CNSMed) {
                Code<MedicationRequest.MedicationrequestStatus> x_ = CNSMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "active",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_;
                // CQL 'and' (193:17-198:9): right operand skipped when left is false
                if (ab_ is false)
                {
                    ac_ = false;
                }
                else
                {
                    Code<MedicationRequest.MedicationRequestIntent> ae_ = CNSMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
                    string ag_ = context.Operators.Convert<string>(af_);
                    bool? ah_ = context.Operators.Equal(ag_, "order");
                    bool? ai_;
                    // CQL 'or' (194:13-198:9): right operand skipped when left is true
                    if (ah_ is true)
                    {
                        ai_ = true;
                    }
                    else
                    {
                        Code<MedicationRequest.MedicationRequestIntent> aj_ = CNSMed?.IntentElement;
                        MedicationRequest.MedicationRequestIntent? ak_ = aj_?.Value;
                        string al_ = context.Operators.Convert<string>(ak_);
                        bool? am_ = context.Operators.Equal(al_, "plan");
                        bool? an_;
                        // CQL 'and' (195:16-197:13): right operand skipped when left is false
                        if (am_ is false)
                        {
                            an_ = false;
                        }
                        else
                        {
                            ResourceReference ao_ = CNSMed?.Subject;
                            FhirString ap_ = ao_?.ReferenceElement;
                            string aq_ = ap_?.Value;
                            string ar_ = QICoreCommon_4_0_000.Instance.getId(context, aq_);
                            Id as_;
                            Patient av_ = this.Patient(context);
                            bool aw_ = av_ is Resource;
                            if (aw_)
                            {
                                Patient ax_ = this.Patient(context);
                                as_ = (ax_ as Resource).IdElement;
                            }
                            else
                            {
                                as_ = default;
                            }
                            string at_ = as_?.Value;
                            bool? au_ = context.Operators.Equal(ar_, at_);
                            an_ = am_ & au_;
                        }
                        ai_ = ah_ | an_;
                    }
                    ac_ = ab_ & ai_;
                }
                bool? ad_;
                // CQL 'and' (193:17-199:34): right operand skipped when left is false
                if (ac_ is false)
                {
                    ad_ = false;
                }
                else
                {
                    bool? ay_ = QICoreCommon_4_0_000.Instance.isCommunity(context, CNSMed as MedicationRequest);
                    ad_ = ac_ & ay_;
                }
                // CQL 'and' (193:17-200:95): right operand skipped when left is false
                if (ad_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDate> az_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, CNSMed);
                    CqlDate ba_ = az_?.low;
                    CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(ba_);
                    CqlDate bc_ = az_?.high;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    bool? be_ = az_?.lowClosed;
                    bool? bf_ = az_?.highClosed;
                    CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bb_, bd_, be_, bf_);
                    Period bh_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                    bool? bj_ = context.Operators.OverlapsBefore(bg_, bi_, "day");
                    return ad_ & bj_;
                }
            }

            bool? k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Diuretic Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Diuretic_Active_at_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Diuretic_Active_at_Admission, Risk_Variable_Encounter_with_Diuretic_Active_at_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Diuretic_Active_at_Admission = -101143292205297395L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Diuretic_Active_at_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? e_(MedicationRequest MR) {
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Diuretics(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Diuretics(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest DiureticMed) {
                Code<MedicationRequest.MedicationrequestStatus> x_ = DiureticMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "active",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_;
                // CQL 'and' (205:17-210:9): right operand skipped when left is false
                if (ab_ is false)
                {
                    ac_ = false;
                }
                else
                {
                    Code<MedicationRequest.MedicationRequestIntent> ae_ = DiureticMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
                    string ag_ = context.Operators.Convert<string>(af_);
                    bool? ah_ = context.Operators.Equal(ag_, "order");
                    bool? ai_;
                    // CQL 'or' (206:13-210:9): right operand skipped when left is true
                    if (ah_ is true)
                    {
                        ai_ = true;
                    }
                    else
                    {
                        Code<MedicationRequest.MedicationRequestIntent> aj_ = DiureticMed?.IntentElement;
                        MedicationRequest.MedicationRequestIntent? ak_ = aj_?.Value;
                        string al_ = context.Operators.Convert<string>(ak_);
                        bool? am_ = context.Operators.Equal(al_, "plan");
                        bool? an_;
                        // CQL 'and' (207:16-209:13): right operand skipped when left is false
                        if (am_ is false)
                        {
                            an_ = false;
                        }
                        else
                        {
                            ResourceReference ao_ = DiureticMed?.Subject;
                            FhirString ap_ = ao_?.ReferenceElement;
                            string aq_ = ap_?.Value;
                            string ar_ = QICoreCommon_4_0_000.Instance.getId(context, aq_);
                            Id as_;
                            Patient av_ = this.Patient(context);
                            bool aw_ = av_ is Resource;
                            if (aw_)
                            {
                                Patient ax_ = this.Patient(context);
                                as_ = (ax_ as Resource).IdElement;
                            }
                            else
                            {
                                as_ = default;
                            }
                            string at_ = as_?.Value;
                            bool? au_ = context.Operators.Equal(ar_, at_);
                            an_ = am_ & au_;
                        }
                        ai_ = ah_ | an_;
                    }
                    ac_ = ab_ & ai_;
                }
                bool? ad_;
                // CQL 'and' (205:17-211:39): right operand skipped when left is false
                if (ac_ is false)
                {
                    ad_ = false;
                }
                else
                {
                    bool? ay_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DiureticMed as MedicationRequest);
                    ad_ = ac_ & ay_;
                }
                // CQL 'and' (205:17-212:100): right operand skipped when left is false
                if (ad_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDate> az_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DiureticMed);
                    CqlDate ba_ = az_?.low;
                    CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(ba_);
                    CqlDate bc_ = az_?.high;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    bool? be_ = az_?.lowClosed;
                    bool? bf_ = az_?.highClosed;
                    CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bb_, bd_, be_, bf_);
                    Period bh_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                    bool? bj_ = context.Operators.OverlapsBefore(bg_, bi_, "day");
                    return ad_ & bj_;
                }
            }

            bool? k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Opioid Medication Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission, Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission = 2482244248561422898L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            IEnumerable<MedicationRequest> d_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? e_(MedicationRequest MR) {
                IEnumerable<Medication> l_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? m_(Medication M) {
                    object o_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> q_ = context.Operators.Split((string)p_, "/");
                    string r_ = context.Operators.Last<string>(q_);
                    bool? s_ = context.Operators.Equal(o_, r_);
                    // CQL 'and': right operand skipped when left is false
                    if (s_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        CodeableConcept t_ = M?.Code;
                        CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                        CqlValueSet v_ = this.Opioids(context);
                        bool? w_ = context.Operators.ConceptInValueSet(u_, v_);
                        return s_ & w_;
                    }
                }

                bool? n_ = context.Operators.WhereAny<Medication>(l_, m_);
                return n_;
            }

            IEnumerable<MedicationRequest> f_ = context.Operators.Where<MedicationRequest>(d_, e_);
            CqlValueSet g_ = this.Opioids(context);
            IEnumerable<MedicationRequest> h_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(f_, h_);

            bool? j_(MedicationRequest OpioidMed) {
                Code<MedicationRequest.MedicationrequestStatus> x_ = OpioidMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? y_ = x_?.Value;
                string z_ = context.Operators.Convert<string>(y_);
                string[] aa_ = [
                    "active",
                    "completed",
                ];
                bool? ab_ = context.Operators.In<string>(z_, (IEnumerable<string>)aa_);
                bool? ac_;
                // CQL 'and' (217:17-222:9): right operand skipped when left is false
                if (ab_ is false)
                {
                    ac_ = false;
                }
                else
                {
                    Code<MedicationRequest.MedicationRequestIntent> ae_ = OpioidMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? af_ = ae_?.Value;
                    string ag_ = context.Operators.Convert<string>(af_);
                    bool? ah_ = context.Operators.Equal(ag_, "order");
                    bool? ai_;
                    // CQL 'or' (218:13-222:9): right operand skipped when left is true
                    if (ah_ is true)
                    {
                        ai_ = true;
                    }
                    else
                    {
                        Code<MedicationRequest.MedicationRequestIntent> aj_ = OpioidMed?.IntentElement;
                        MedicationRequest.MedicationRequestIntent? ak_ = aj_?.Value;
                        string al_ = context.Operators.Convert<string>(ak_);
                        bool? am_ = context.Operators.Equal(al_, "plan");
                        bool? an_;
                        // CQL 'and' (219:16-221:13): right operand skipped when left is false
                        if (am_ is false)
                        {
                            an_ = false;
                        }
                        else
                        {
                            ResourceReference ao_ = OpioidMed?.Subject;
                            FhirString ap_ = ao_?.ReferenceElement;
                            string aq_ = ap_?.Value;
                            string ar_ = QICoreCommon_4_0_000.Instance.getId(context, aq_);
                            Id as_;
                            Patient av_ = this.Patient(context);
                            bool aw_ = av_ is Resource;
                            if (aw_)
                            {
                                Patient ax_ = this.Patient(context);
                                as_ = (ax_ as Resource).IdElement;
                            }
                            else
                            {
                                as_ = default;
                            }
                            string at_ = as_?.Value;
                            bool? au_ = context.Operators.Equal(ar_, at_);
                            an_ = am_ & au_;
                        }
                        ai_ = ah_ | an_;
                    }
                    ac_ = ab_ & ai_;
                }
                bool? ad_;
                // CQL 'and' (217:17-223:37): right operand skipped when left is false
                if (ac_ is false)
                {
                    ad_ = false;
                }
                else
                {
                    bool? ay_ = QICoreCommon_4_0_000.Instance.isCommunity(context, OpioidMed as MedicationRequest);
                    ad_ = ac_ & ay_;
                }
                // CQL 'and' (217:17-224:98): right operand skipped when left is false
                if (ad_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDate> az_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OpioidMed);
                    CqlDate ba_ = az_?.low;
                    CqlDateTime bb_ = context.Operators.ConvertDateToDateTime(ba_);
                    CqlDate bc_ = az_?.high;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    bool? be_ = az_?.lowClosed;
                    bool? bf_ = az_?.highClosed;
                    CqlInterval<CqlDateTime> bg_ = context.Operators.Interval(bb_, bd_, be_, bf_);
                    Period bh_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bi_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bh_);
                    bool? bj_ = context.Operators.OverlapsBefore(bg_, bi_, "day");
                    return ad_ & bj_;
                }
            }

            bool? k_ = context.Operators.WhereAny<MedicationRequest>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Coagulation Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission, Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission = 1980631045349188772L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Coagulation_Disorders(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Delirium or Dementia or Other Psychosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Delirium_or_Dementia_or_Other_Psychosis_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Delirium_or_Dementia_or_Other_Psychosis_Present_on_Admission, Risk_Variable_Encounter_with_Delirium_or_Dementia_or_Other_Psychosis_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Delirium_or_Dementia_or_Other_Psychosis_Present_on_Admission = 3816316150793516446L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Delirium_or_Dementia_or_Other_Psychosis_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Delirium__Dementia__and_Other_Psychoses(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Depression Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Depression_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Depression_Present_on_Admission, Risk_Variable_Encounter_with_Depression_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Depression_Present_on_Admission = 4214772090319590937L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Depression_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Depression(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Epilepsy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission, Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission = 7000000165091156417L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Epilepsy(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Leukemia or Lymphoma Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission, Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission = 7398759844787738930L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Leukemia_or_Lymphoma(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Liver Disease Moderate to Severe Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission, Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission = -3901620165660556613L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Liver_Disease_Moderate_to_Severe(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Malignant Bone Disease Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission, Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission = -6519893641608176887L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Malignant_Bone_Disease(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Neurologic Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission, Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission = -7749071699323752421L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Neurologic_Movement_and_Related_Disorders(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Obesity Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Obesity_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Obesity_Present_on_Admission, Risk_Variable_Encounter_with_Obesity_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Obesity_Present_on_Admission = 1111109168538456667L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Obesity_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Obesity(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Osteoporosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission, Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission = -1864719601187372501L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Osteoporosis(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Peripheral Neuropathy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission, Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission = -8941770802708293932L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Peripheral_Neuropathy(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Stroke Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Stroke_Present_on_Admission(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Stroke_Present_on_Admission, Risk_Variable_Encounter_with_Stroke_Present_on_Admission_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Stroke_Present_on_Admission = 7549789774069722028L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Stroke_Present_on_Admission_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            CqlValueSet d_ = this.Stroke(context);
            CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
            bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Risk Variable Encounter with Suicide Attempt")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Suicide_Attempt(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_Encounter_with_Suicide_Attempt, Risk_Variable_Encounter_with_Suicide_Attempt_Compute);

    private const long _cacheIndex_Risk_Variable_Encounter_with_Suicide_Attempt = -9085156353756314203L;

    private IEnumerable<Encounter> Risk_Variable_Encounter_with_Suicide_Attempt_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            IEnumerable<Condition> d_ = this.encountersDiagnosis(context, InpatientEncounter);

            bool? e_(Condition @this) {
                CodeableConcept j_ = @this?.Code;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                return !((bool?)(k_ is null));
            }


            CqlConcept f_(Condition @this) {
                CodeableConcept l_ = @this?.Code;
                CqlConcept m_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, l_);
                return m_;
            }

            IEnumerable<CqlConcept> g_ = context.Operators.WhereSelect<Condition, CqlConcept>(d_, e_, f_);
            CqlValueSet h_ = this.Suicide_Attempt(context);
            bool? i_ = context.Operators.ConceptsInValueSet(g_, h_);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -7188146491602681279L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -6065141591157605130L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -2041073189866593713L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -8546165489307990724L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlFunctionDefinition("Denominator Observation")]
    public int? Denominator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlInterval<CqlDateTime> a_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
        CqlDateTime b_ = context.Operators.Start(a_);
        CqlDateTime c_ = context.Operators.End(a_);
        int? d_ = context.Operators.DurationBetween(b_, c_, "day");
        return d_;
    }


    [CqlFunctionDefinition("Numerator Observation")]
    public int? Numerator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        IEnumerable<Encounter> a_ = this.Numerator(context);

        bool? b_(Encounter FallsEncounter) {
            Period e_ = FallsEncounter?.Period;
            CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, e_);
            CqlDateTime g_ = context.Operators.End(f_);
            CqlInterval<CqlDateTime> h_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, (string)default);
            return i_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        int? d_ = context.Operators.Count<Encounter>(c_);
        return d_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS1017FHIRHHFI_1_0_000() {}

    public static CMS1017FHIRHHFI_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS1017FHIRHHFI";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, CumulativeMedicationDuration_6_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DSSBhUTbQjBZiPCFMDNfdCQVg = new(
       [typeof(string), typeof(IEnumerable<Claim.DiagnosisComponent>), typeof(IEnumerable<int?>), typeof(IEnumerable<Claim.DiagnosisComponent>)],
       ["encounterId", "diagnosis", "rank", "POA"]);

    #endregion CqlTupleMetadata Properties

}
