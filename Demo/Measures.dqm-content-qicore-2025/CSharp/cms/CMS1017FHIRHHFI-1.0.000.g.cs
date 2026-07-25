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
            bool? q_ = context.Operators.And(f_, p_);
            return q_;
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
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<Condition> g_ = context.Operators.Union<Condition>(e_ as IEnumerable<Condition>, f_ as IEnumerable<Condition>);

            bool? h_(Condition Cond) {
                Id k_ = Cond?.IdElement;
                string l_ = k_?.Value;
                bool? m_ = QICoreCommon_4_0_000.Instance.references(context, EncDiag, l_);
                return m_;
            }

            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            Condition j_ = context.Operators.SingletonFrom<Condition>(i_);
            return j_;
        }

        IEnumerable<Condition> c_ = context.Operators.Select<ResourceReference, Condition>((IEnumerable<ResourceReference>)a_, b_);
        IEnumerable<Condition> d_ = context.Operators.Distinct<Condition>(c_);
        return d_;
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
                CqlConcept p_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                return p_;
            }

            IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
            CqlValueSet g_ = this.Inpatient_Falls(context);
            bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
            IEnumerable<Condition> i_ = this.encountersDiagnosis(context, QualifyingFall);

            bool? j_(Condition @this) {
                CodeableConcept q_ = @this?.Code;
                CqlConcept r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                return s_;
            }

            IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);

            CqlConcept l_(Condition @this) {
                CodeableConcept t_ = @this?.Code;
                CqlConcept u_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, t_);
                return u_;
            }

            IEnumerable<CqlConcept> m_ = context.Operators.Select<Condition, CqlConcept>(k_, l_);
            bool? n_ = context.Operators.ConceptsInValueSet(m_, g_);
            bool? o_ = context.Operators.Or(h_, n_);
            return o_;
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
                FhirDateTime i_ = FallsDocumentation?.DateElement;
                CqlDateTime j_ = context.Operators.Convert<CqlDateTime>(i_);
                FhirDateTime k_ = FallsDocumentation?.RecordedDateElement;
                CqlDateTime l_ = context.Operators.Convert<CqlDateTime>(k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? n_ = context.Operators.In<CqlDateTime>(j_ ?? l_, m_, (string)default);
                return n_;
            }

            IEnumerable<AdverseEvent> g_ = context.Operators.Where<AdverseEvent>(e_, f_);
            bool? h_ = context.Operators.Exists<AdverseEvent>(g_);
            return h_;
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
            Code<FinancialResourceStatusCodes> h_ = C?.StatusElement;
            FinancialResourceStatusCodes? i_ = h_?.Value;
            Code<FinancialResourceStatusCodes> j_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(i_);
            bool? k_ = context.Operators.Equal(j_, "active");
            Code<ClaimUseCode> l_ = C?.UseElement;
            ClaimUseCode? m_ = l_?.Value;
            Code<ClaimUseCode> n_ = context.Operators.Convert<Code<ClaimUseCode>>(m_);
            bool? o_ = context.Operators.Equal(n_, "claim");
            bool? p_ = context.Operators.And(k_, o_);
            List<Claim.ItemComponent> q_ = C?.Item;

            bool? r_(Claim.ItemComponent I) {
                List<ResourceReference> v_ = I?.Encounter;
                bool? w_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)v_, encounter);
                return w_;
            }

            IEnumerable<Claim.ItemComponent> s_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)q_, r_);
            bool? t_ = context.Operators.Exists<Claim.ItemComponent>(s_);
            bool? u_ = context.Operators.And(p_, t_);
            return u_;
        }

        IEnumerable<Claim> c_ = context.Operators.Where<Claim>(a_, b_);

        IEnumerable<Claim.DiagnosisComponent> d_(Claim C) {
            List<Claim.DiagnosisComponent> x_ = C?.Diagnosis;

            bool? y_(Claim.DiagnosisComponent D) {
                List<Claim.ItemComponent> aa_ = C?.Item;

                bool? ab_(Claim.ItemComponent I) {
                    List<ResourceReference> ao_ = I?.Encounter;
                    bool? ap_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ao_, encounter);
                    PositiveInt aq_ = D?.SequenceElement;
                    int? ar_ = aq_?.Value;
                    List<PositiveInt> as_ = I?.DiagnosisSequenceElement;

                    int? at_(PositiveInt @this) {
                        int? ax_ = @this?.Value;
                        return ax_;
                    }

                    IEnumerable<int?> au_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)as_, at_);
                    bool? av_ = context.Operators.In<int?>(ar_, au_);
                    bool? aw_ = context.Operators.And(ap_, av_);
                    return aw_;
                }

                IEnumerable<Claim.ItemComponent> ac_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)aa_, ab_);
                bool? ad_ = context.Operators.Exists<Claim.ItemComponent>(ac_);
                CodeableConcept ae_ = D?.OnAdmission;
                CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_);
                CqlValueSet ag_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? ah_ = context.Operators.ConceptInValueSet(af_, ag_);
                bool? ai_ = context.Operators.Or((bool?)(af_ is null), ah_);
                bool? aj_ = context.Operators.And(ad_, ai_);
                DataType ak_ = D?.Diagnosis;
                object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                bool? am_ = context.Operators.ConceptInValueSet(al_ as CqlConcept, diagnosisValueSet);
                bool? an_ = context.Operators.And(aj_, am_);
                return an_;
            }

            IEnumerable<Claim.DiagnosisComponent> z_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)x_, y_);
            return z_;
        }

        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> e_ = context.Operators.Select<Claim, IEnumerable<Claim.DiagnosisComponent>>(c_, d_);
        IEnumerable<IEnumerable<Claim.DiagnosisComponent>> f_ = context.Operators.Distinct<IEnumerable<Claim.DiagnosisComponent>>(e_);
        bool? g_ = context.Operators.Exists<IEnumerable<Claim.DiagnosisComponent>>(f_);
        return g_;
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
                CodeableConcept h_ = MajorFallOccurred?.OnAdmission;
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
                CqlValueSet j_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? k_ = context.Operators.ConceptInValueSet(i_, j_);
                bool? l_ = context.Operators.Or((bool?)(i_ is null), k_);
                DataType m_ = MajorFallOccurred?.Diagnosis;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlValueSet o_ = this.Major_Injuries(context);
                bool? p_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, o_);
                Condition q_ = CQMCommon_4_1_000.Instance.getCondition(context, n_ as ResourceReference);
                CodeableConcept r_ = q_?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                bool? t_ = context.Operators.ConceptInValueSet(s_, o_);
                bool? u_ = context.Operators.Or(p_, t_);
                bool? v_ = context.Operators.And(l_, u_);
                return v_;
            }

            IEnumerable<Claim.DiagnosisComponent> f_ = context.Operators.Where<Claim.DiagnosisComponent>(d_, e_);
            bool? g_ = context.Operators.Exists<Claim.DiagnosisComponent>(f_);
            return g_;
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
                CodeableConcept h_ = ModerateFallOccurred?.OnAdmission;
                CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
                CqlValueSet j_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? k_ = context.Operators.ConceptInValueSet(i_, j_);
                bool? l_ = context.Operators.Or((bool?)(i_ is null), k_);
                DataType m_ = ModerateFallOccurred?.Diagnosis;
                object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
                CqlValueSet o_ = this.Moderate_Injuries(context);
                bool? p_ = context.Operators.ConceptInValueSet(n_ as CqlConcept, o_);
                Condition q_ = CQMCommon_4_1_000.Instance.getCondition(context, n_ as ResourceReference);
                CodeableConcept r_ = q_?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                bool? t_ = context.Operators.ConceptInValueSet(s_, o_);
                bool? u_ = context.Operators.Or(p_, t_);
                bool? v_ = context.Operators.And(l_, u_);
                return v_;
            }

            IEnumerable<Claim.DiagnosisComponent> f_ = context.Operators.Where<Claim.DiagnosisComponent>(d_, e_);
            bool? g_ = context.Operators.Exists<Claim.DiagnosisComponent>(f_);
            return g_;
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
            IEnumerable<Encounter> g_ = this.Qualifying_Encounter(context);

            bool? h_(Encounter InpatientEncounter) {
                DataType k_ = BMI?.Effective;
                object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_);
                CqlDateTime n_ = context.Operators.Start(m_);
                CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                DataType q_ = BMI?.Value;
                CqlQuantity r_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, q_ as Quantity);
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                bool? t_ = context.Operators.And(p_, s_);
                Code<ObservationStatus> u_ = BMI?.StatusElement;
                ObservationStatus? v_ = u_?.Value;
                string w_ = context.Operators.Convert<string>(v_);
                string[] x_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
                bool? z_ = context.Operators.And(t_, y_);
                return z_;
            }

            IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
            bool? j_ = context.Operators.Exists<Encounter>(i_);
            return j_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);

        CqlQuantity d_(Observation BMI) {
            DataType aa_ = BMI?.Value;
            CqlQuantity ab_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, aa_ as Quantity);
            return ab_ as CqlQuantity;
        }

        IEnumerable<CqlQuantity> e_ = context.Operators.Select<Observation, CqlQuantity>(c_, d_);
        IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses with Rank and POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?> Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication, Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication_Compute);

    private const long _cacheIndex_Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication = 7202944664208919231L;

    private IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?> Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)? b_(Encounter InpatientEncounter) {
            Id e_ = InpatientEncounter?.IdElement;
            string f_ = e_?.Value;
            IEnumerable<Claim> g_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

            bool? h_(Claim C) {
                Code<FinancialResourceStatusCodes> aj_ = C?.StatusElement;
                FinancialResourceStatusCodes? ak_ = aj_?.Value;
                Code<FinancialResourceStatusCodes> al_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(ak_);
                bool? am_ = context.Operators.Equal(al_, "active");
                Code<ClaimUseCode> an_ = C?.UseElement;
                ClaimUseCode? ao_ = an_?.Value;
                Code<ClaimUseCode> ap_ = context.Operators.Convert<Code<ClaimUseCode>>(ao_);
                bool? aq_ = context.Operators.Equal(ap_, "claim");
                bool? ar_ = context.Operators.And(am_, aq_);
                List<Claim.ItemComponent> as_ = C?.Item;

                bool? at_(Claim.ItemComponent ClaimItem) {
                    List<ResourceReference> ax_ = ClaimItem?.Encounter;
                    bool? ay_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)ax_, InpatientEncounter);
                    return ay_;
                }

                IEnumerable<Claim.ItemComponent> au_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)as_, at_);
                bool? av_ = context.Operators.Exists<Claim.ItemComponent>(au_);
                bool? aw_ = context.Operators.And(ar_, av_);
                return aw_;
            }

            IEnumerable<Claim> i_ = context.Operators.Where<Claim>(g_, h_);

            bool? j_(Claim @this) {
                List<Claim.DiagnosisComponent> az_ = @this?.Diagnosis;
                bool? ba_ = context.Operators.Not((bool?)(az_ is null));
                return ba_;
            }

            IEnumerable<Claim> k_ = context.Operators.Where<Claim>(i_, j_);

            List<Claim.DiagnosisComponent> l_(Claim @this) {
                List<Claim.DiagnosisComponent> bb_ = @this?.Diagnosis;
                return bb_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> m_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(k_, l_);
            IEnumerable<Claim.DiagnosisComponent> n_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)m_);

            bool? o_(Claim C) {
                Code<FinancialResourceStatusCodes> bc_ = C?.StatusElement;
                FinancialResourceStatusCodes? bd_ = bc_?.Value;
                Code<FinancialResourceStatusCodes> be_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bd_);
                bool? bf_ = context.Operators.Equal(be_, "active");
                Code<ClaimUseCode> bg_ = C?.UseElement;
                ClaimUseCode? bh_ = bg_?.Value;
                Code<ClaimUseCode> bi_ = context.Operators.Convert<Code<ClaimUseCode>>(bh_);
                bool? bj_ = context.Operators.Equal(bi_, "claim");
                bool? bk_ = context.Operators.And(bf_, bj_);
                List<Claim.ItemComponent> bl_ = C?.Item;

                bool? bm_(Claim.ItemComponent ClaimItem) {
                    List<ResourceReference> bq_ = ClaimItem?.Encounter;
                    bool? br_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bq_, InpatientEncounter);
                    return br_;
                }

                IEnumerable<Claim.ItemComponent> bn_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bl_, bm_);
                bool? bo_ = context.Operators.Exists<Claim.ItemComponent>(bn_);
                bool? bp_ = context.Operators.And(bk_, bo_);
                return bp_;
            }

            IEnumerable<Claim> p_ = context.Operators.Where<Claim>(g_, o_);

            bool? q_(Claim @this) {
                List<Claim.DiagnosisComponent> bs_ = @this?.Diagnosis;
                bool? bt_ = context.Operators.Not((bool?)(bs_ is null));
                return bt_;
            }

            IEnumerable<Claim> r_ = context.Operators.Where<Claim>(p_, q_);

            List<Claim.DiagnosisComponent> s_(Claim @this) {
                List<Claim.DiagnosisComponent> bu_ = @this?.Diagnosis;
                return bu_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> t_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(r_, s_);
            IEnumerable<Claim.DiagnosisComponent> u_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)t_);

            bool? v_(Claim.DiagnosisComponent @this) {
                PositiveInt bv_ = @this?.SequenceElement;
                int? bw_ = bv_?.Value;
                bool? bx_ = context.Operators.Not((bool?)(bw_ is null));
                return bx_;
            }

            IEnumerable<Claim.DiagnosisComponent> w_ = context.Operators.Where<Claim.DiagnosisComponent>(u_, v_);

            int? x_(Claim.DiagnosisComponent @this) {
                PositiveInt by_ = @this?.SequenceElement;
                int? bz_ = by_?.Value;
                return bz_;
            }

            IEnumerable<int?> y_ = context.Operators.Select<Claim.DiagnosisComponent, int?>(w_, x_);

            bool? z_(Claim C) {
                Code<FinancialResourceStatusCodes> ca_ = C?.StatusElement;
                FinancialResourceStatusCodes? cb_ = ca_?.Value;
                Code<FinancialResourceStatusCodes> cc_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(cb_);
                bool? cd_ = context.Operators.Equal(cc_, "active");
                Code<ClaimUseCode> ce_ = C?.UseElement;
                ClaimUseCode? cf_ = ce_?.Value;
                Code<ClaimUseCode> cg_ = context.Operators.Convert<Code<ClaimUseCode>>(cf_);
                bool? ch_ = context.Operators.Equal(cg_, "claim");
                bool? ci_ = context.Operators.And(cd_, ch_);
                List<Claim.ItemComponent> cj_ = C?.Item;

                bool? ck_(Claim.ItemComponent ClaimItem) {
                    List<ResourceReference> co_ = ClaimItem?.Encounter;
                    bool? cp_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)co_, InpatientEncounter);
                    return cp_;
                }

                IEnumerable<Claim.ItemComponent> cl_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)cj_, ck_);
                bool? cm_ = context.Operators.Exists<Claim.ItemComponent>(cl_);
                bool? cn_ = context.Operators.And(ci_, cm_);
                return cn_;
            }

            IEnumerable<Claim> aa_ = context.Operators.Where<Claim>(g_, z_);

            bool? ab_(Claim @this) {
                List<Claim.DiagnosisComponent> cq_ = @this?.Diagnosis;
                bool? cr_ = context.Operators.Not((bool?)(cq_ is null));
                return cr_;
            }

            IEnumerable<Claim> ac_ = context.Operators.Where<Claim>(aa_, ab_);

            List<Claim.DiagnosisComponent> ad_(Claim @this) {
                List<Claim.DiagnosisComponent> cs_ = @this?.Diagnosis;
                return cs_;
            }

            IEnumerable<List<Claim.DiagnosisComponent>> ae_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(ac_, ad_);
            IEnumerable<Claim.DiagnosisComponent> af_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)ae_);

            bool? ag_(Claim.DiagnosisComponent Diag) {
                CodeableConcept ct_ = Diag?.OnAdmission;
                CqlConcept cu_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ct_);
                CqlValueSet cv_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? cw_ = context.Operators.ConceptInValueSet(cu_, cv_);
                CqlValueSet cx_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? cy_ = context.Operators.ConceptInValueSet(cu_, cx_);
                bool? cz_ = context.Operators.Or(cw_, cy_);
                return cz_;
            }

            IEnumerable<Claim.DiagnosisComponent> ah_ = context.Operators.Where<Claim.DiagnosisComponent>(af_, ag_);
            (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)? ai_ = (CqlTupleMetadata_DSSBhUTbQjBZiPCFMDNfdCQVg, f_, n_, y_, ah_);
            return ai_;
        }

        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?>(c_);
        return d_;
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
            CqlValueSet g_ = this.Malnutrition(context);
            bool? h_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, g_, e_);
            bool? i_ = context.Operators.Or(f_, h_);
            return i_;
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
            CqlValueSet d_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? g_(MedicationRequest MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Anticoagulants_for_All_Indications(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

            bool? j_(MedicationRequest Anticoagulants) {
                Code<MedicationRequest.MedicationrequestStatus> aa_ = Anticoagulants?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "active",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                Code<MedicationRequest.MedicationRequestIntent> af_ = Anticoagulants?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                bool? ai_ = context.Operators.Equal(ah_, "order");
                bool? aj_ = context.Operators.Equal(ah_, "plan");
                ResourceReference ak_ = Anticoagulants?.Subject;
                FhirString al_ = ak_?.ReferenceElement;
                string am_ = al_?.Value;
                string an_ = QICoreCommon_4_0_000.Instance.getId(context, am_);
                Id ao_;
                Patient bi_ = this.Patient(context);
                bool bj_ = bi_ is Resource;
                if (bj_)
                {
                    Patient bk_ = this.Patient(context);
                    ao_ = (bk_ as Resource).IdElement;
                }
                else
                {
                    ao_ = default;
                }
                string ap_ = ao_?.Value;
                bool? aq_ = context.Operators.Equal(an_, ap_);
                bool? ar_ = context.Operators.And(aj_, aq_);
                bool? as_ = context.Operators.Or(ai_, ar_);
                bool? at_ = context.Operators.And(ae_, as_);
                bool? au_ = QICoreCommon_4_0_000.Instance.isCommunity(context, Anticoagulants as MedicationRequest);
                bool? av_ = context.Operators.And(at_, au_);
                CqlInterval<CqlDate> aw_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, Anticoagulants);
                CqlDate ax_ = aw_?.low;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate az_ = aw_?.high;
                CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
                bool? bb_ = aw_?.lowClosed;
                bool? bc_ = aw_?.highClosed;
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ay_, ba_, bb_, bc_);
                Period be_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                bool? bg_ = context.Operators.OverlapsBefore(bd_, bf_, "day");
                bool? bh_ = context.Operators.And(av_, bg_);
                return bh_;
            }

            IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationRequest>(k_);
            return l_;
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
            CqlValueSet d_ = this.Anticoagulants_for_All_Indications(context);
            IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
            IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

            bool? g_(MedicationAdministration MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Anticoagulants_for_All_Indications(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
            IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(e_, h_);

            bool? j_(MedicationAdministration Anticoagulants) {
                DataType aa_ = Anticoagulants?.Effective;
                object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                CqlInterval<CqlDateTime> ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
                CqlDateTime ad_ = context.Operators.Start(ac_);
                CqlInterval<CqlDateTime> ae_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? af_ = context.Operators.In<CqlDateTime>(ad_, ae_, (string)default);
                Code<MedicationAdministration.MedicationAdministrationStatusCodes> ag_ = Anticoagulants?.StatusElement;
                MedicationAdministration.MedicationAdministrationStatusCodes? ah_ = ag_?.Value;
                string ai_ = context.Operators.Convert<string>(ah_);
                string[] aj_ = [
                    "in-progress",
                    "completed",
                ];
                bool? ak_ = context.Operators.In<string>(ai_, (IEnumerable<string>)aj_);
                bool? al_ = context.Operators.And(af_, ak_);
                return al_;
            }

            IEnumerable<MedicationAdministration> k_ = context.Operators.Where<MedicationAdministration>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationAdministration>(k_);
            return l_;
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
            CqlValueSet d_ = this.Antidepressants(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? g_(MedicationRequest MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Antidepressants(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

            bool? j_(MedicationRequest AntidepressantMed) {
                Code<MedicationRequest.MedicationrequestStatus> aa_ = AntidepressantMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "active",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                Code<MedicationRequest.MedicationRequestIntent> af_ = AntidepressantMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                bool? ai_ = context.Operators.Equal(ah_, "order");
                bool? aj_ = context.Operators.Equal(ah_, "plan");
                ResourceReference ak_ = AntidepressantMed?.Subject;
                FhirString al_ = ak_?.ReferenceElement;
                string am_ = al_?.Value;
                string an_ = QICoreCommon_4_0_000.Instance.getId(context, am_);
                Id ao_;
                Patient bi_ = this.Patient(context);
                bool bj_ = bi_ is Resource;
                if (bj_)
                {
                    Patient bk_ = this.Patient(context);
                    ao_ = (bk_ as Resource).IdElement;
                }
                else
                {
                    ao_ = default;
                }
                string ap_ = ao_?.Value;
                bool? aq_ = context.Operators.Equal(an_, ap_);
                bool? ar_ = context.Operators.And(aj_, aq_);
                bool? as_ = context.Operators.Or(ai_, ar_);
                bool? at_ = context.Operators.And(ae_, as_);
                bool? au_ = QICoreCommon_4_0_000.Instance.isCommunity(context, AntidepressantMed as MedicationRequest);
                bool? av_ = context.Operators.And(at_, au_);
                CqlInterval<CqlDate> aw_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AntidepressantMed);
                CqlDate ax_ = aw_?.low;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate az_ = aw_?.high;
                CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
                bool? bb_ = aw_?.lowClosed;
                bool? bc_ = aw_?.highClosed;
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ay_, ba_, bb_, bc_);
                Period be_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                bool? bg_ = context.Operators.OverlapsBefore(bd_, bf_, "day");
                bool? bh_ = context.Operators.And(av_, bg_);
                return bh_;
            }

            IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationRequest>(k_);
            return l_;
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
            CqlValueSet d_ = this.Antihypertensives(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? g_(MedicationRequest MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Antihypertensives(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

            bool? j_(MedicationRequest BPMed) {
                Code<MedicationRequest.MedicationrequestStatus> aa_ = BPMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "active",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                Code<MedicationRequest.MedicationRequestIntent> af_ = BPMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                bool? ai_ = context.Operators.Equal(ah_, "order");
                bool? aj_ = context.Operators.Equal(ah_, "plan");
                ResourceReference ak_ = BPMed?.Subject;
                FhirString al_ = ak_?.ReferenceElement;
                string am_ = al_?.Value;
                string an_ = QICoreCommon_4_0_000.Instance.getId(context, am_);
                Id ao_;
                Patient bi_ = this.Patient(context);
                bool bj_ = bi_ is Resource;
                if (bj_)
                {
                    Patient bk_ = this.Patient(context);
                    ao_ = (bk_ as Resource).IdElement;
                }
                else
                {
                    ao_ = default;
                }
                string ap_ = ao_?.Value;
                bool? aq_ = context.Operators.Equal(an_, ap_);
                bool? ar_ = context.Operators.And(aj_, aq_);
                bool? as_ = context.Operators.Or(ai_, ar_);
                bool? at_ = context.Operators.And(ae_, as_);
                bool? au_ = QICoreCommon_4_0_000.Instance.isCommunity(context, BPMed as MedicationRequest);
                bool? av_ = context.Operators.And(at_, au_);
                CqlInterval<CqlDate> aw_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, BPMed);
                CqlDate ax_ = aw_?.low;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate az_ = aw_?.high;
                CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
                bool? bb_ = aw_?.lowClosed;
                bool? bc_ = aw_?.highClosed;
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ay_, ba_, bb_, bc_);
                Period be_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                bool? bg_ = context.Operators.OverlapsBefore(bd_, bf_, "day");
                bool? bh_ = context.Operators.And(av_, bg_);
                return bh_;
            }

            IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationRequest>(k_);
            return l_;
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
            CqlValueSet d_ = this.Central_Nervous_System_Depressants(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? g_(MedicationRequest MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Central_Nervous_System_Depressants(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

            bool? j_(MedicationRequest CNSMed) {
                Code<MedicationRequest.MedicationrequestStatus> aa_ = CNSMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "active",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                Code<MedicationRequest.MedicationRequestIntent> af_ = CNSMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                bool? ai_ = context.Operators.Equal(ah_, "order");
                bool? aj_ = context.Operators.Equal(ah_, "plan");
                ResourceReference ak_ = CNSMed?.Subject;
                FhirString al_ = ak_?.ReferenceElement;
                string am_ = al_?.Value;
                string an_ = QICoreCommon_4_0_000.Instance.getId(context, am_);
                Id ao_;
                Patient bi_ = this.Patient(context);
                bool bj_ = bi_ is Resource;
                if (bj_)
                {
                    Patient bk_ = this.Patient(context);
                    ao_ = (bk_ as Resource).IdElement;
                }
                else
                {
                    ao_ = default;
                }
                string ap_ = ao_?.Value;
                bool? aq_ = context.Operators.Equal(an_, ap_);
                bool? ar_ = context.Operators.And(aj_, aq_);
                bool? as_ = context.Operators.Or(ai_, ar_);
                bool? at_ = context.Operators.And(ae_, as_);
                bool? au_ = QICoreCommon_4_0_000.Instance.isCommunity(context, CNSMed as MedicationRequest);
                bool? av_ = context.Operators.And(at_, au_);
                CqlInterval<CqlDate> aw_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, CNSMed);
                CqlDate ax_ = aw_?.low;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate az_ = aw_?.high;
                CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
                bool? bb_ = aw_?.lowClosed;
                bool? bc_ = aw_?.highClosed;
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ay_, ba_, bb_, bc_);
                Period be_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                bool? bg_ = context.Operators.OverlapsBefore(bd_, bf_, "day");
                bool? bh_ = context.Operators.And(av_, bg_);
                return bh_;
            }

            IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationRequest>(k_);
            return l_;
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
            CqlValueSet d_ = this.Diuretics(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? g_(MedicationRequest MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Diuretics(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

            bool? j_(MedicationRequest DiureticMed) {
                Code<MedicationRequest.MedicationrequestStatus> aa_ = DiureticMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "active",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                Code<MedicationRequest.MedicationRequestIntent> af_ = DiureticMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                bool? ai_ = context.Operators.Equal(ah_, "order");
                bool? aj_ = context.Operators.Equal(ah_, "plan");
                ResourceReference ak_ = DiureticMed?.Subject;
                FhirString al_ = ak_?.ReferenceElement;
                string am_ = al_?.Value;
                string an_ = QICoreCommon_4_0_000.Instance.getId(context, am_);
                Id ao_;
                Patient bi_ = this.Patient(context);
                bool bj_ = bi_ is Resource;
                if (bj_)
                {
                    Patient bk_ = this.Patient(context);
                    ao_ = (bk_ as Resource).IdElement;
                }
                else
                {
                    ao_ = default;
                }
                string ap_ = ao_?.Value;
                bool? aq_ = context.Operators.Equal(an_, ap_);
                bool? ar_ = context.Operators.And(aj_, aq_);
                bool? as_ = context.Operators.Or(ai_, ar_);
                bool? at_ = context.Operators.And(ae_, as_);
                bool? au_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DiureticMed as MedicationRequest);
                bool? av_ = context.Operators.And(at_, au_);
                CqlInterval<CqlDate> aw_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DiureticMed);
                CqlDate ax_ = aw_?.low;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate az_ = aw_?.high;
                CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
                bool? bb_ = aw_?.lowClosed;
                bool? bc_ = aw_?.highClosed;
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ay_, ba_, bb_, bc_);
                Period be_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                bool? bg_ = context.Operators.OverlapsBefore(bd_, bf_, "day");
                bool? bh_ = context.Operators.And(av_, bg_);
                return bh_;
            }

            IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationRequest>(k_);
            return l_;
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
            CqlValueSet d_ = this.Opioids(context);
            IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
            IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

            bool? g_(MedicationRequest MR) {
                IEnumerable<Medication> m_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                bool? n_(Medication M) {
                    object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                    object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                    IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                    string t_ = context.Operators.Last<string>(s_);
                    bool? u_ = context.Operators.Equal(q_, t_);
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Opioids(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    bool? z_ = context.Operators.And(u_, y_);
                    return z_;
                }

                IEnumerable<Medication> o_ = context.Operators.Where<Medication>(m_, n_);
                bool? p_ = context.Operators.Exists<Medication>(o_);
                return p_;
            }

            IEnumerable<MedicationRequest> h_ = context.Operators.Where<MedicationRequest>(f_, g_);
            IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

            bool? j_(MedicationRequest OpioidMed) {
                Code<MedicationRequest.MedicationrequestStatus> aa_ = OpioidMed?.StatusElement;
                MedicationRequest.MedicationrequestStatus? ab_ = aa_?.Value;
                string ac_ = context.Operators.Convert<string>(ab_);
                string[] ad_ = [
                    "active",
                    "completed",
                ];
                bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
                Code<MedicationRequest.MedicationRequestIntent> af_ = OpioidMed?.IntentElement;
                MedicationRequest.MedicationRequestIntent? ag_ = af_?.Value;
                string ah_ = context.Operators.Convert<string>(ag_);
                bool? ai_ = context.Operators.Equal(ah_, "order");
                bool? aj_ = context.Operators.Equal(ah_, "plan");
                ResourceReference ak_ = OpioidMed?.Subject;
                FhirString al_ = ak_?.ReferenceElement;
                string am_ = al_?.Value;
                string an_ = QICoreCommon_4_0_000.Instance.getId(context, am_);
                Id ao_;
                Patient bi_ = this.Patient(context);
                bool bj_ = bi_ is Resource;
                if (bj_)
                {
                    Patient bk_ = this.Patient(context);
                    ao_ = (bk_ as Resource).IdElement;
                }
                else
                {
                    ao_ = default;
                }
                string ap_ = ao_?.Value;
                bool? aq_ = context.Operators.Equal(an_, ap_);
                bool? ar_ = context.Operators.And(aj_, aq_);
                bool? as_ = context.Operators.Or(ai_, ar_);
                bool? at_ = context.Operators.And(ae_, as_);
                bool? au_ = QICoreCommon_4_0_000.Instance.isCommunity(context, OpioidMed as MedicationRequest);
                bool? av_ = context.Operators.And(at_, au_);
                CqlInterval<CqlDate> aw_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OpioidMed);
                CqlDate ax_ = aw_?.low;
                CqlDateTime ay_ = context.Operators.ConvertDateToDateTime(ax_);
                CqlDate az_ = aw_?.high;
                CqlDateTime ba_ = context.Operators.ConvertDateToDateTime(az_);
                bool? bb_ = aw_?.lowClosed;
                bool? bc_ = aw_?.highClosed;
                CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(ay_, ba_, bb_, bc_);
                Period be_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> bf_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, be_);
                bool? bg_ = context.Operators.OverlapsBefore(bd_, bf_, "day");
                bool? bh_ = context.Operators.And(av_, bg_);
                return bh_;
            }

            IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
            bool? l_ = context.Operators.Exists<MedicationRequest>(k_);
            return l_;
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
                CodeableConcept k_ = @this?.Code;
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                bool? m_ = context.Operators.Not((bool?)(l_ is null));
                return m_;
            }

            IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);

            CqlConcept g_(Condition @this) {
                CodeableConcept n_ = @this?.Code;
                CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_);
                return o_;
            }

            IEnumerable<CqlConcept> h_ = context.Operators.Select<Condition, CqlConcept>(f_, g_);
            CqlValueSet i_ = this.Suicide_Attempt(context);
            bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);
            return j_;
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
