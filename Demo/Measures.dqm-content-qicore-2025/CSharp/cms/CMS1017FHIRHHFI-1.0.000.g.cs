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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("CMS1017FHIRHHFI", "1.0.000")]
public partial class CMS1017FHIRHHFI_1_0_000 : ILibrary, ISingleton<CMS1017FHIRHHFI_1_0_000>
{
    #region ValueSets

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

    #region CodeSystems

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, []);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlInterval<CqlDateTime>>(7239015735015004398L, () => {
            CqlDateTime a_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, (decimal?)0.0m);
            CqlDateTime b_ = context.Operators.DateTime((int?)2027, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, (decimal?)0.0m);
            CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, (bool?)true, (bool?)false);
            object d_ = context.ResolveParameter("CMS1017FHIRHHFI-1.0.000", "Measurement Period", c_);
            return (CqlInterval<CqlDateTime>)d_;
        });


    #endregion Parameters

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(-2859982306975276846L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(6631354683532865594L, () => {
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
        });


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(8909640820178408265L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);
            return a_;
        });


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(8325884910617275031L, () => {
            IEnumerable<Encounter> a_ = this.Initial_Population(context);
            return a_;
        });


    [CqlFunctionDefinition("encountersDiagnosis")]
    public IEnumerable<object> encountersDiagnosis(CqlContext context, Encounter Encounter)
    {
        List<ResourceReference> a_ = Encounter?.ReasonReference;

        object b_(ResourceReference EncDiag) {
            IEnumerable<Condition> e_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));
            IEnumerable<Condition> f_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));
            IEnumerable<object> g_ = context.Operators.Union<object>(e_ as IEnumerable<object>, f_ as IEnumerable<object>);

            bool? h_(object Cond) {
                object k_ = context.Operators.LateBoundProperty<object>(Cond, "id");
                string l_ = context.Operators.LateBoundProperty<string>(k_, "value");
                bool? m_ = QICoreCommon_4_0_000.Instance.references(context, EncDiag, l_);
                return m_;
            }

            IEnumerable<object> i_ = context.Operators.Where<object>(g_, h_);
            object j_ = context.Operators.SingletonFrom<object>(i_);
            return j_;
        }

        IEnumerable<object> c_ = context.Operators.Select<ResourceReference, object>((IEnumerable<ResourceReference>)a_, b_);
        IEnumerable<object> d_ = context.Operators.Distinct<object>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Encounter With A Fall Diagnosis")]
    public IEnumerable<Encounter> Encounter_With_A_Fall_Diagnosis(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-4260035697956895772L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter QualifyingFall) {
                List<CodeableConcept> d_ = QualifyingFall?.ReasonCode;

                CqlConcept e_(CodeableConcept @this) {
                    CqlConcept q_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return q_;
                }

                IEnumerable<CqlConcept> f_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)d_, e_);
                CqlValueSet g_ = this.Inpatient_Falls(context);
                bool? h_ = context.Operators.ConceptsInValueSet(f_, g_);
                IEnumerable<object> i_ = this.encountersDiagnosis(context, QualifyingFall);

                bool? j_(object @this) {
                    object r_ = context.Operators.LateBoundProperty<object>(@this, "code");
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_ as CodeableConcept);
                    bool? t_ = context.Operators.Not((bool?)(s_ is null));
                    return t_;
                }

                IEnumerable<object> k_ = context.Operators.Where<object>(i_, j_);

                CqlConcept l_(object @this) {
                    object u_ = context.Operators.LateBoundProperty<object>(@this, "code");
                    CqlConcept v_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, u_ as CodeableConcept);
                    return v_;
                }

                IEnumerable<CqlConcept> m_ = context.Operators.Select<object, CqlConcept>(k_, l_);
                bool? o_ = context.Operators.ConceptsInValueSet(m_, g_);
                bool? p_ = context.Operators.Or(h_, o_);
                return p_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Encounter With A Fall Event")]
    public IEnumerable<Encounter> Encounter_With_A_Fall_Event(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(867772196484577946L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            IEnumerable<Encounter> b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Inpatient_Falls(context);
                IEnumerable<AdverseEvent> e_ = context.Operators.Retrieve<AdverseEvent>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-adverseevent"));

                bool? f_(AdverseEvent FallsDocumentation) {
                    FhirDateTime j_ = FallsDocumentation?.DateElement;
                    CqlDateTime k_ = context.Operators.Convert<CqlDateTime>(j_);
                    FhirDateTime l_ = FallsDocumentation?.RecordedDateElement;
                    CqlDateTime m_ = context.Operators.Convert<CqlDateTime>(l_);
                    CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                    bool? o_ = context.Operators.In<CqlDateTime>(k_ ?? m_, n_, default);
                    return o_;
                }

                IEnumerable<AdverseEvent> g_ = context.Operators.Where<AdverseEvent>(e_, f_);
                Encounter h_(AdverseEvent FallsDocumentation) => InpatientEncounter;
                IEnumerable<Encounter> i_ = context.Operators.Select<AdverseEvent, Encounter>(g_, h_);
                return i_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Encounter Where A Fall Occurred")]
    public IEnumerable<Encounter> Encounter_Where_A_Fall_Occurred(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(795907075661115072L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_With_A_Fall_Diagnosis(context);
            IEnumerable<Encounter> b_ = this.Encounter_With_A_Fall_Event(context);
            IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
            return c_;
        });


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
                    List<ResourceReference> aq_ = I?.Encounter;
                    bool? ar_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)aq_, encounter);
                    PositiveInt as_ = D?.SequenceElement;
                    int? at_ = as_?.Value;
                    List<PositiveInt> au_ = I?.DiagnosisSequenceElement;

                    int? av_(PositiveInt @this) {
                        int? az_ = @this?.Value;
                        return az_;
                    }

                    IEnumerable<int?> aw_ = context.Operators.Select<PositiveInt, int?>((IEnumerable<PositiveInt>)au_, av_);
                    bool? ax_ = context.Operators.In<int?>(at_, aw_);
                    bool? ay_ = context.Operators.And(ar_, ax_);
                    return ay_;
                }

                IEnumerable<Claim.ItemComponent> ac_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)aa_, ab_);
                bool? ad_ = context.Operators.Exists<Claim.ItemComponent>(ac_);
                CodeableConcept ae_ = D?.OnAdmission;
                CqlConcept af_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_);
                CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ae_);
                CqlValueSet ai_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                bool? aj_ = context.Operators.ConceptInValueSet(ah_, ai_);
                bool? ak_ = context.Operators.Or((bool?)(af_ is null), aj_);
                bool? al_ = context.Operators.And(ad_, ak_);
                DataType am_ = D?.Diagnosis;
                object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                bool? ao_ = context.Operators.ConceptInValueSet(an_ as CqlConcept, diagnosisValueSet);
                bool? ap_ = context.Operators.And(al_, ao_);
                return ap_;
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
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-6325763340603139774L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_Where_A_Fall_Occurred(context);

            bool? b_(Encounter EncounterFallDiagnosis) {
                CqlValueSet d_ = this.Inpatient_Falls(context);
                bool? e_ = this.hasDiagnosisNotPresentOnAdmissionOrNull(context, EncounterFallDiagnosis, d_);
                return e_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Encounter Where A Fall And Major Injury Occurred Not POA")]
    public IEnumerable<Encounter> Encounter_Where_A_Fall_And_Major_Injury_Occurred_Not_POA(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(4813225188493827856L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_With_A_Fall_Not_Present_On_Admission(context);

            bool? b_(Encounter FallOccurred) {
                IEnumerable<Claim.DiagnosisComponent> d_ = CQMCommon_4_1_000.Instance.claimDiagnosis(context, FallOccurred);

                bool? e_(Claim.DiagnosisComponent MajorFallOccurred) {
                    CodeableConcept h_ = MajorFallOccurred?.OnAdmission;
                    CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
                    CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
                    CqlValueSet l_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                    bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                    bool? n_ = context.Operators.Or((bool?)(i_ is null), m_);
                    DataType o_ = MajorFallOccurred?.Diagnosis;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    CqlValueSet q_ = this.Major_Injuries(context);
                    bool? r_ = context.Operators.ConceptInValueSet(p_ as CqlConcept, q_);
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    object u_ = CQMCommon_4_1_000.Instance.getCondition(context, t_ as ResourceReference);
                    object v_ = context.Operators.LateBoundProperty<object>(u_, "code");
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, q_);
                    bool? z_ = context.Operators.Or(r_, y_);
                    bool? aa_ = context.Operators.And(n_, z_);
                    return aa_;
                }

                IEnumerable<Claim.DiagnosisComponent> f_ = context.Operators.Where<Claim.DiagnosisComponent>(d_, e_);
                bool? g_ = context.Operators.Exists<Claim.DiagnosisComponent>(f_);
                return g_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Encounter Where A Fall And Moderate Injury Occurred Not POA")]
    public IEnumerable<Encounter> Encounter_Where_A_Fall_And_Moderate_Injury_Occurred_Not_POA(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(9037820097058256858L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_With_A_Fall_Not_Present_On_Admission(context);

            bool? b_(Encounter FallOccurred) {
                IEnumerable<Claim.DiagnosisComponent> d_ = CQMCommon_4_1_000.Instance.claimDiagnosis(context, FallOccurred);

                bool? e_(Claim.DiagnosisComponent ModerateFallOccurred) {
                    CodeableConcept h_ = ModerateFallOccurred?.OnAdmission;
                    CqlConcept i_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
                    CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, h_);
                    CqlValueSet l_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                    bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                    bool? n_ = context.Operators.Or((bool?)(i_ is null), m_);
                    DataType o_ = ModerateFallOccurred?.Diagnosis;
                    object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    CqlValueSet q_ = this.Moderate_Injuries(context);
                    bool? r_ = context.Operators.ConceptInValueSet(p_ as CqlConcept, q_);
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                    object u_ = CQMCommon_4_1_000.Instance.getCondition(context, t_ as ResourceReference);
                    object v_ = context.Operators.LateBoundProperty<object>(u_, "code");
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_ as CodeableConcept);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, q_);
                    bool? z_ = context.Operators.Or(r_, y_);
                    bool? aa_ = context.Operators.And(n_, z_);
                    return aa_;
                }

                IEnumerable<Claim.DiagnosisComponent> f_ = context.Operators.Where<Claim.DiagnosisComponent>(d_, e_);
                bool? g_ = context.Operators.Exists<Claim.DiagnosisComponent>(f_);
                return g_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(75500722536813452L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_Where_A_Fall_And_Major_Injury_Occurred_Not_POA(context);
            IEnumerable<Encounter> b_ = this.Encounter_Where_A_Fall_And_Moderate_Injury_Occurred_Not_POA(context);
            IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Encounter With A Fall Present On Admission")]
    public IEnumerable<Encounter> Encounter_With_A_Fall_Present_On_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-6633124270615127096L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Inpatient_Falls(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(9090268816274383848L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_With_A_Fall_Present_On_Admission(context);
            return a_;
        });


    [CqlExpressionDefinition("Numerator Exclusions")]
    public IEnumerable<Encounter> Numerator_Exclusions(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(7919091718784135074L, () => {
            IEnumerable<Encounter> a_ = this.Encounter_With_A_Fall_Present_On_Admission(context);
            return a_;
        });


    [CqlExpressionDefinition("Risk Variable Body Mass Index (BMI)")]
    public IEnumerable<CqlQuantity> Risk_Variable_Body_Mass_Index__BMI_(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<CqlQuantity>>(-8832772703149002861L, () => {
            IEnumerable<Observation> a_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-bmi"));

            IEnumerable<Observation> b_(Observation BMI) {
                IEnumerable<Encounter> g_ = this.Qualifying_Encounter(context);

                bool? h_(Encounter InpatientEncounter) {
                    DataType l_ = BMI?.Effective;
                    object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
                    CqlInterval<CqlDateTime> n_ = QICoreCommon_4_0_000.Instance.toInterval(context, m_);
                    CqlDateTime o_ = context.Operators.Start(n_);
                    CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                    bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, default);
                    DataType r_ = BMI?.Value;
                    CqlQuantity s_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, r_ as Quantity);
                    bool? t_ = context.Operators.Not((bool?)(s_ is null));
                    bool? u_ = context.Operators.And(q_, t_);
                    Code<ObservationStatus> v_ = BMI?.StatusElement;
                    ObservationStatus? w_ = v_?.Value;
                    string x_ = context.Operators.Convert<string>(w_);
                    string[] y_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? z_ = context.Operators.In<string>(x_, (IEnumerable<string>)y_);
                    bool? aa_ = context.Operators.And(u_, z_);
                    return aa_;
                }

                IEnumerable<Encounter> i_ = context.Operators.Where<Encounter>(g_, h_);
                Observation j_(Encounter InpatientEncounter) => BMI;
                IEnumerable<Observation> k_ = context.Operators.Select<Encounter, Observation>(i_, j_);
                return k_;
            }

            IEnumerable<Observation> c_ = context.Operators.SelectMany<Observation, Observation>(a_, b_);

            CqlQuantity d_(Observation BMI) {
                DataType ab_ = BMI?.Value;
                CqlQuantity ac_ = FHIRHelpers_4_4_000.Instance.ToQuantity(context, ab_ as Quantity);
                return ac_ as CqlQuantity;
            }

            IEnumerable<CqlQuantity> e_ = context.Operators.Select<Observation, CqlQuantity>(c_, d_);
            IEnumerable<CqlQuantity> f_ = context.Operators.Distinct<CqlQuantity>(e_);
            return f_;
        });


    [CqlExpressionDefinition("Risk Variable All Encounter Diagnoses with Rank and POA Indication")]
    public IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?> Risk_Variable_All_Encounter_Diagnoses_with_Rank_and_POA_Indication(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?>>(7202944664208919231L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)? b_(Encounter InpatientEncounter) {
                Id e_ = InpatientEncounter?.IdElement;
                string f_ = e_?.Value;
                IEnumerable<Claim> g_ = context.Operators.Retrieve<Claim>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-claim"));

                bool? h_(Claim C) {
                    Code<FinancialResourceStatusCodes> al_ = C?.StatusElement;
                    FinancialResourceStatusCodes? am_ = al_?.Value;
                    Code<FinancialResourceStatusCodes> an_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(am_);
                    bool? ao_ = context.Operators.Equal(an_, "active");
                    Code<ClaimUseCode> ap_ = C?.UseElement;
                    ClaimUseCode? aq_ = ap_?.Value;
                    Code<ClaimUseCode> ar_ = context.Operators.Convert<Code<ClaimUseCode>>(aq_);
                    bool? as_ = context.Operators.Equal(ar_, "claim");
                    bool? at_ = context.Operators.And(ao_, as_);
                    List<Claim.ItemComponent> au_ = C?.Item;

                    bool? av_(Claim.ItemComponent ClaimItem) {
                        List<ResourceReference> az_ = ClaimItem?.Encounter;
                        bool? ba_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)az_, InpatientEncounter);
                        return ba_;
                    }

                    IEnumerable<Claim.ItemComponent> aw_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)au_, av_);
                    bool? ax_ = context.Operators.Exists<Claim.ItemComponent>(aw_);
                    bool? ay_ = context.Operators.And(at_, ax_);
                    return ay_;
                }

                IEnumerable<Claim> i_ = context.Operators.Where<Claim>(g_, h_);

                bool? j_(Claim @this) {
                    List<Claim.DiagnosisComponent> bb_ = @this?.Diagnosis;
                    bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                    return bc_;
                }

                IEnumerable<Claim> k_ = context.Operators.Where<Claim>(i_, j_);

                List<Claim.DiagnosisComponent> l_(Claim @this) {
                    List<Claim.DiagnosisComponent> bd_ = @this?.Diagnosis;
                    return bd_;
                }

                IEnumerable<List<Claim.DiagnosisComponent>> m_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(k_, l_);
                IEnumerable<Claim.DiagnosisComponent> n_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)m_);

                bool? p_(Claim C) {
                    Code<FinancialResourceStatusCodes> be_ = C?.StatusElement;
                    FinancialResourceStatusCodes? bf_ = be_?.Value;
                    Code<FinancialResourceStatusCodes> bg_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(bf_);
                    bool? bh_ = context.Operators.Equal(bg_, "active");
                    Code<ClaimUseCode> bi_ = C?.UseElement;
                    ClaimUseCode? bj_ = bi_?.Value;
                    Code<ClaimUseCode> bk_ = context.Operators.Convert<Code<ClaimUseCode>>(bj_);
                    bool? bl_ = context.Operators.Equal(bk_, "claim");
                    bool? bm_ = context.Operators.And(bh_, bl_);
                    List<Claim.ItemComponent> bn_ = C?.Item;

                    bool? bo_(Claim.ItemComponent ClaimItem) {
                        List<ResourceReference> bs_ = ClaimItem?.Encounter;
                        bool? bt_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)bs_, InpatientEncounter);
                        return bt_;
                    }

                    IEnumerable<Claim.ItemComponent> bp_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bn_, bo_);
                    bool? bq_ = context.Operators.Exists<Claim.ItemComponent>(bp_);
                    bool? br_ = context.Operators.And(bm_, bq_);
                    return br_;
                }

                IEnumerable<Claim> q_ = context.Operators.Where<Claim>(g_, p_);

                bool? r_(Claim @this) {
                    List<Claim.DiagnosisComponent> bu_ = @this?.Diagnosis;
                    bool? bv_ = context.Operators.Not((bool?)(bu_ is null));
                    return bv_;
                }

                IEnumerable<Claim> s_ = context.Operators.Where<Claim>(q_, r_);

                List<Claim.DiagnosisComponent> t_(Claim @this) {
                    List<Claim.DiagnosisComponent> bw_ = @this?.Diagnosis;
                    return bw_;
                }

                IEnumerable<List<Claim.DiagnosisComponent>> u_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(s_, t_);
                IEnumerable<Claim.DiagnosisComponent> v_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)u_);

                bool? w_(Claim.DiagnosisComponent @this) {
                    PositiveInt bx_ = @this?.SequenceElement;
                    int? by_ = bx_?.Value;
                    bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                    return bz_;
                }

                IEnumerable<Claim.DiagnosisComponent> x_ = context.Operators.Where<Claim.DiagnosisComponent>(v_, w_);

                int? y_(Claim.DiagnosisComponent @this) {
                    PositiveInt ca_ = @this?.SequenceElement;
                    int? cb_ = ca_?.Value;
                    return cb_;
                }

                IEnumerable<int?> z_ = context.Operators.Select<Claim.DiagnosisComponent, int?>(x_, y_);

                bool? ab_(Claim C) {
                    Code<FinancialResourceStatusCodes> cc_ = C?.StatusElement;
                    FinancialResourceStatusCodes? cd_ = cc_?.Value;
                    Code<FinancialResourceStatusCodes> ce_ = context.Operators.Convert<Code<FinancialResourceStatusCodes>>(cd_);
                    bool? cf_ = context.Operators.Equal(ce_, "active");
                    Code<ClaimUseCode> cg_ = C?.UseElement;
                    ClaimUseCode? ch_ = cg_?.Value;
                    Code<ClaimUseCode> ci_ = context.Operators.Convert<Code<ClaimUseCode>>(ch_);
                    bool? cj_ = context.Operators.Equal(ci_, "claim");
                    bool? ck_ = context.Operators.And(cf_, cj_);
                    List<Claim.ItemComponent> cl_ = C?.Item;

                    bool? cm_(Claim.ItemComponent ClaimItem) {
                        List<ResourceReference> cq_ = ClaimItem?.Encounter;
                        bool? cr_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)cq_, InpatientEncounter);
                        return cr_;
                    }

                    IEnumerable<Claim.ItemComponent> cn_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)cl_, cm_);
                    bool? co_ = context.Operators.Exists<Claim.ItemComponent>(cn_);
                    bool? cp_ = context.Operators.And(ck_, co_);
                    return cp_;
                }

                IEnumerable<Claim> ac_ = context.Operators.Where<Claim>(g_, ab_);

                bool? ad_(Claim @this) {
                    List<Claim.DiagnosisComponent> cs_ = @this?.Diagnosis;
                    bool? ct_ = context.Operators.Not((bool?)(cs_ is null));
                    return ct_;
                }

                IEnumerable<Claim> ae_ = context.Operators.Where<Claim>(ac_, ad_);

                List<Claim.DiagnosisComponent> af_(Claim @this) {
                    List<Claim.DiagnosisComponent> cu_ = @this?.Diagnosis;
                    return cu_;
                }

                IEnumerable<List<Claim.DiagnosisComponent>> ag_ = context.Operators.Select<Claim, List<Claim.DiagnosisComponent>>(ae_, af_);
                IEnumerable<Claim.DiagnosisComponent> ah_ = context.Operators.Flatten<Claim.DiagnosisComponent>((IEnumerable<IEnumerable<Claim.DiagnosisComponent>>)ag_);

                bool? ai_(Claim.DiagnosisComponent Diag) {
                    CodeableConcept cv_ = Diag?.OnAdmission;
                    CqlConcept cw_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cv_);
                    CqlValueSet cx_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                    bool? cy_ = context.Operators.ConceptInValueSet(cw_, cx_);
                    CqlConcept da_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, cv_);
                    CqlValueSet db_ = this.Not_Present_On_Admission_or_Documentation_Insufficient_to_Determine(context);
                    bool? dc_ = context.Operators.ConceptInValueSet(da_, db_);
                    bool? dd_ = context.Operators.Or(cy_, dc_);
                    return dd_;
                }

                IEnumerable<Claim.DiagnosisComponent> aj_ = context.Operators.Where<Claim.DiagnosisComponent>(ah_, ai_);
                (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)? ak_ = (CqlTupleMetadata_DSSBhUTbQjBZiPCFMDNfdCQVg, f_, n_, z_, aj_);
                return ak_;
            }

            IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?>(a_, b_);
            IEnumerable<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, string encounterId, IEnumerable<Claim.DiagnosisComponent> diagnosis, IEnumerable<int?> rank, IEnumerable<Claim.DiagnosisComponent> POA)?>(c_);
            return d_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Abnormal Weight Loss or Malnutrition Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Abnormal_Weight_Loss_or_Malnutrition_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(1687786406611411202L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Abnormal_Weight_Loss(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                CqlValueSet g_ = this.Malnutrition(context);
                bool? i_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, g_, e_);
                bool? j_ = context.Operators.Or(f_, i_);
                return j_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Active_at_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(2537708922668979649L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            IEnumerable<Encounter> b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Anticoagulants_for_All_Indications(context);
                IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> g_(MedicationRequest MR) {
                    IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? o_(Medication M) {
                        object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                        string v_ = context.Operators.Last<string>(u_);
                        bool? w_ = context.Operators.Equal(s_, v_);
                        CodeableConcept x_ = M?.Code;
                        CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                        CqlValueSet z_ = this.Anticoagulants_for_All_Indications(context);
                        bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                        bool? ab_ = context.Operators.And(w_, aa_);
                        return ab_;
                    }

                    IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                    MedicationRequest q_(Medication M) => MR;
                    IEnumerable<MedicationRequest> r_ = context.Operators.Select<Medication, MedicationRequest>(p_, q_);
                    return r_;
                }

                IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
                IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

                bool? j_(MedicationRequest Anticoagulants) {
                    Code<MedicationRequest.MedicationrequestStatus> ac_ = Anticoagulants?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "active",
                        "completed",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    Code<MedicationRequest.MedicationRequestIntent> ah_ = Anticoagulants?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    bool? ak_ = context.Operators.Equal(aj_, "order");
                    MedicationRequest.MedicationRequestIntent? am_ = ah_?.Value;
                    string an_ = context.Operators.Convert<string>(am_);
                    bool? ao_ = context.Operators.Equal(an_, "plan");
                    ResourceReference ap_ = Anticoagulants?.Subject;
                    FhirString aq_ = ap_?.ReferenceElement;
                    string ar_ = aq_?.Value;
                    string as_ = QICoreCommon_4_0_000.Instance.getId(context, ar_);

                    Id at_() {

                        bool bq_() {
                            Patient br_ = this.Patient(context);
                            bool bs_ = br_ is Resource;
                            return bs_;
                        }

                        if (bq_())
                        {
                            Patient bt_ = this.Patient(context);
                            return (bt_ as Resource).IdElement;
                        }
                        else
                        {
                            return default;
                        };
                    }

                    string au_ = (at_())?.Value;
                    bool? av_ = context.Operators.Equal(as_, au_);
                    bool? aw_ = context.Operators.And(ao_, av_);
                    bool? ax_ = context.Operators.Or(ak_, aw_);
                    bool? ay_ = context.Operators.And(ag_, ax_);
                    bool? az_ = QICoreCommon_4_0_000.Instance.isCommunity(context, Anticoagulants as object);
                    bool? ba_ = context.Operators.And(ay_, az_);
                    CqlInterval<CqlDate> bb_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, Anticoagulants);
                    CqlDate bc_ = bb_?.low;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    CqlDate bf_ = bb_?.high;
                    CqlDateTime bg_ = context.Operators.ConvertDateToDateTime(bf_);
                    bool? bi_ = bb_?.lowClosed;
                    bool? bk_ = bb_?.highClosed;
                    CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bd_, bg_, bi_, bk_);
                    Period bm_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                    bool? bo_ = context.Operators.OverlapsBefore(bl_, bn_, "day");
                    bool? bp_ = context.Operators.And(ba_, bo_);
                    return bp_;
                }

                IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
                Encounter l_(MedicationRequest Anticoagulants) => InpatientEncounter;
                IEnumerable<Encounter> m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);
                return m_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Anticoagulant Administration During Encounter")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Anticoagulant_Administration_During_Encounter(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-5616865709202141790L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            IEnumerable<Encounter> b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Anticoagulants_for_All_Indications(context);
                IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
                IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

                IEnumerable<MedicationAdministration> g_(MedicationAdministration MR) {
                    IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? o_(Medication M) {
                        object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                        string v_ = context.Operators.Last<string>(u_);
                        bool? w_ = context.Operators.Equal(s_, v_);
                        CodeableConcept x_ = M?.Code;
                        CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                        CqlValueSet z_ = this.Anticoagulants_for_All_Indications(context);
                        bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                        bool? ab_ = context.Operators.And(w_, aa_);
                        return ab_;
                    }

                    IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                    MedicationAdministration q_(Medication M) => MR;
                    IEnumerable<MedicationAdministration> r_ = context.Operators.Select<Medication, MedicationAdministration>(p_, q_);
                    return r_;
                }

                IEnumerable<MedicationAdministration> h_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(f_, g_);
                IEnumerable<MedicationAdministration> i_ = context.Operators.Union<MedicationAdministration>(e_, h_);

                bool? j_(MedicationAdministration Anticoagulants) {
                    DataType ac_ = Anticoagulants?.Effective;
                    object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
                    CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
                    CqlDateTime af_ = context.Operators.Start(ae_);
                    CqlInterval<CqlDateTime> ag_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                    bool? ah_ = context.Operators.In<CqlDateTime>(af_, ag_, default);
                    Code<MedicationAdministration.MedicationAdministrationStatusCodes> ai_ = Anticoagulants?.StatusElement;
                    MedicationAdministration.MedicationAdministrationStatusCodes? aj_ = ai_?.Value;
                    string ak_ = context.Operators.Convert<string>(aj_);
                    string[] al_ = [
                        "in-progress",
                        "completed",
                    ];
                    bool? am_ = context.Operators.In<string>(ak_, (IEnumerable<string>)al_);
                    bool? an_ = context.Operators.And(ah_, am_);
                    return an_;
                }

                IEnumerable<MedicationAdministration> k_ = context.Operators.Where<MedicationAdministration>(i_, j_);
                Encounter l_(MedicationAdministration Anticoagulants) => InpatientEncounter;
                IEnumerable<Encounter> m_ = context.Operators.Select<MedicationAdministration, Encounter>(k_, l_);
                return m_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Antidepressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antidepressant_Active_at_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-3270489974385968258L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            IEnumerable<Encounter> b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Antidepressants(context);
                IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> g_(MedicationRequest MR) {
                    IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? o_(Medication M) {
                        object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                        string v_ = context.Operators.Last<string>(u_);
                        bool? w_ = context.Operators.Equal(s_, v_);
                        CodeableConcept x_ = M?.Code;
                        CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                        CqlValueSet z_ = this.Antidepressants(context);
                        bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                        bool? ab_ = context.Operators.And(w_, aa_);
                        return ab_;
                    }

                    IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                    MedicationRequest q_(Medication M) => MR;
                    IEnumerable<MedicationRequest> r_ = context.Operators.Select<Medication, MedicationRequest>(p_, q_);
                    return r_;
                }

                IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
                IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

                bool? j_(MedicationRequest AntidepressantMed) {
                    Code<MedicationRequest.MedicationrequestStatus> ac_ = AntidepressantMed?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "active",
                        "completed",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    Code<MedicationRequest.MedicationRequestIntent> ah_ = AntidepressantMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    bool? ak_ = context.Operators.Equal(aj_, "order");
                    MedicationRequest.MedicationRequestIntent? am_ = ah_?.Value;
                    string an_ = context.Operators.Convert<string>(am_);
                    bool? ao_ = context.Operators.Equal(an_, "plan");
                    ResourceReference ap_ = AntidepressantMed?.Subject;
                    FhirString aq_ = ap_?.ReferenceElement;
                    string ar_ = aq_?.Value;
                    string as_ = QICoreCommon_4_0_000.Instance.getId(context, ar_);

                    Id at_() {

                        bool bq_() {
                            Patient br_ = this.Patient(context);
                            bool bs_ = br_ is Resource;
                            return bs_;
                        }

                        if (bq_())
                        {
                            Patient bt_ = this.Patient(context);
                            return (bt_ as Resource).IdElement;
                        }
                        else
                        {
                            return default;
                        };
                    }

                    string au_ = (at_())?.Value;
                    bool? av_ = context.Operators.Equal(as_, au_);
                    bool? aw_ = context.Operators.And(ao_, av_);
                    bool? ax_ = context.Operators.Or(ak_, aw_);
                    bool? ay_ = context.Operators.And(ag_, ax_);
                    bool? az_ = QICoreCommon_4_0_000.Instance.isCommunity(context, AntidepressantMed as object);
                    bool? ba_ = context.Operators.And(ay_, az_);
                    CqlInterval<CqlDate> bb_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, AntidepressantMed);
                    CqlDate bc_ = bb_?.low;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    CqlDate bf_ = bb_?.high;
                    CqlDateTime bg_ = context.Operators.ConvertDateToDateTime(bf_);
                    bool? bi_ = bb_?.lowClosed;
                    bool? bk_ = bb_?.highClosed;
                    CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bd_, bg_, bi_, bk_);
                    Period bm_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                    bool? bo_ = context.Operators.OverlapsBefore(bl_, bn_, "day");
                    bool? bp_ = context.Operators.And(ba_, bo_);
                    return bp_;
                }

                IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
                Encounter l_(MedicationRequest AntidepressantMed) => InpatientEncounter;
                IEnumerable<Encounter> m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);
                return m_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Antihypertensive Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Antihypertensive_Active_at_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(77730647164612247L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            IEnumerable<Encounter> b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Antihypertensives(context);
                IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> g_(MedicationRequest MR) {
                    IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? o_(Medication M) {
                        object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                        string v_ = context.Operators.Last<string>(u_);
                        bool? w_ = context.Operators.Equal(s_, v_);
                        CodeableConcept x_ = M?.Code;
                        CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                        CqlValueSet z_ = this.Antihypertensives(context);
                        bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                        bool? ab_ = context.Operators.And(w_, aa_);
                        return ab_;
                    }

                    IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                    MedicationRequest q_(Medication M) => MR;
                    IEnumerable<MedicationRequest> r_ = context.Operators.Select<Medication, MedicationRequest>(p_, q_);
                    return r_;
                }

                IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
                IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

                bool? j_(MedicationRequest BPMed) {
                    Code<MedicationRequest.MedicationrequestStatus> ac_ = BPMed?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "active",
                        "completed",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    Code<MedicationRequest.MedicationRequestIntent> ah_ = BPMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    bool? ak_ = context.Operators.Equal(aj_, "order");
                    MedicationRequest.MedicationRequestIntent? am_ = ah_?.Value;
                    string an_ = context.Operators.Convert<string>(am_);
                    bool? ao_ = context.Operators.Equal(an_, "plan");
                    ResourceReference ap_ = BPMed?.Subject;
                    FhirString aq_ = ap_?.ReferenceElement;
                    string ar_ = aq_?.Value;
                    string as_ = QICoreCommon_4_0_000.Instance.getId(context, ar_);

                    Id at_() {

                        bool bq_() {
                            Patient br_ = this.Patient(context);
                            bool bs_ = br_ is Resource;
                            return bs_;
                        }

                        if (bq_())
                        {
                            Patient bt_ = this.Patient(context);
                            return (bt_ as Resource).IdElement;
                        }
                        else
                        {
                            return default;
                        };
                    }

                    string au_ = (at_())?.Value;
                    bool? av_ = context.Operators.Equal(as_, au_);
                    bool? aw_ = context.Operators.And(ao_, av_);
                    bool? ax_ = context.Operators.Or(ak_, aw_);
                    bool? ay_ = context.Operators.And(ag_, ax_);
                    bool? az_ = QICoreCommon_4_0_000.Instance.isCommunity(context, BPMed as object);
                    bool? ba_ = context.Operators.And(ay_, az_);
                    CqlInterval<CqlDate> bb_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, BPMed);
                    CqlDate bc_ = bb_?.low;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    CqlDate bf_ = bb_?.high;
                    CqlDateTime bg_ = context.Operators.ConvertDateToDateTime(bf_);
                    bool? bi_ = bb_?.lowClosed;
                    bool? bk_ = bb_?.highClosed;
                    CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bd_, bg_, bi_, bk_);
                    Period bm_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                    bool? bo_ = context.Operators.OverlapsBefore(bl_, bn_, "day");
                    bool? bp_ = context.Operators.And(ba_, bo_);
                    return bp_;
                }

                IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
                Encounter l_(MedicationRequest BPMed) => InpatientEncounter;
                IEnumerable<Encounter> m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);
                return m_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with CNS Depressant Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_CNS_Depressant_Active_at_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(5774110077431550078L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            IEnumerable<Encounter> b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Central_Nervous_System_Depressants(context);
                IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> g_(MedicationRequest MR) {
                    IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? o_(Medication M) {
                        object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                        string v_ = context.Operators.Last<string>(u_);
                        bool? w_ = context.Operators.Equal(s_, v_);
                        CodeableConcept x_ = M?.Code;
                        CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                        CqlValueSet z_ = this.Central_Nervous_System_Depressants(context);
                        bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                        bool? ab_ = context.Operators.And(w_, aa_);
                        return ab_;
                    }

                    IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                    MedicationRequest q_(Medication M) => MR;
                    IEnumerable<MedicationRequest> r_ = context.Operators.Select<Medication, MedicationRequest>(p_, q_);
                    return r_;
                }

                IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
                IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

                bool? j_(MedicationRequest CNSMed) {
                    Code<MedicationRequest.MedicationrequestStatus> ac_ = CNSMed?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "active",
                        "completed",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    Code<MedicationRequest.MedicationRequestIntent> ah_ = CNSMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    bool? ak_ = context.Operators.Equal(aj_, "order");
                    MedicationRequest.MedicationRequestIntent? am_ = ah_?.Value;
                    string an_ = context.Operators.Convert<string>(am_);
                    bool? ao_ = context.Operators.Equal(an_, "plan");
                    ResourceReference ap_ = CNSMed?.Subject;
                    FhirString aq_ = ap_?.ReferenceElement;
                    string ar_ = aq_?.Value;
                    string as_ = QICoreCommon_4_0_000.Instance.getId(context, ar_);

                    Id at_() {

                        bool bq_() {
                            Patient br_ = this.Patient(context);
                            bool bs_ = br_ is Resource;
                            return bs_;
                        }

                        if (bq_())
                        {
                            Patient bt_ = this.Patient(context);
                            return (bt_ as Resource).IdElement;
                        }
                        else
                        {
                            return default;
                        };
                    }

                    string au_ = (at_())?.Value;
                    bool? av_ = context.Operators.Equal(as_, au_);
                    bool? aw_ = context.Operators.And(ao_, av_);
                    bool? ax_ = context.Operators.Or(ak_, aw_);
                    bool? ay_ = context.Operators.And(ag_, ax_);
                    bool? az_ = QICoreCommon_4_0_000.Instance.isCommunity(context, CNSMed as object);
                    bool? ba_ = context.Operators.And(ay_, az_);
                    CqlInterval<CqlDate> bb_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, CNSMed);
                    CqlDate bc_ = bb_?.low;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    CqlDate bf_ = bb_?.high;
                    CqlDateTime bg_ = context.Operators.ConvertDateToDateTime(bf_);
                    bool? bi_ = bb_?.lowClosed;
                    bool? bk_ = bb_?.highClosed;
                    CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bd_, bg_, bi_, bk_);
                    Period bm_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                    bool? bo_ = context.Operators.OverlapsBefore(bl_, bn_, "day");
                    bool? bp_ = context.Operators.And(ba_, bo_);
                    return bp_;
                }

                IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
                Encounter l_(MedicationRequest CNSMed) => InpatientEncounter;
                IEnumerable<Encounter> m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);
                return m_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Diuretic Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Diuretic_Active_at_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-101143292205297395L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            IEnumerable<Encounter> b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Diuretics(context);
                IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> g_(MedicationRequest MR) {
                    IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? o_(Medication M) {
                        object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                        string v_ = context.Operators.Last<string>(u_);
                        bool? w_ = context.Operators.Equal(s_, v_);
                        CodeableConcept x_ = M?.Code;
                        CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                        CqlValueSet z_ = this.Diuretics(context);
                        bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                        bool? ab_ = context.Operators.And(w_, aa_);
                        return ab_;
                    }

                    IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                    MedicationRequest q_(Medication M) => MR;
                    IEnumerable<MedicationRequest> r_ = context.Operators.Select<Medication, MedicationRequest>(p_, q_);
                    return r_;
                }

                IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
                IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

                bool? j_(MedicationRequest DiureticMed) {
                    Code<MedicationRequest.MedicationrequestStatus> ac_ = DiureticMed?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "active",
                        "completed",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    Code<MedicationRequest.MedicationRequestIntent> ah_ = DiureticMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    bool? ak_ = context.Operators.Equal(aj_, "order");
                    MedicationRequest.MedicationRequestIntent? am_ = ah_?.Value;
                    string an_ = context.Operators.Convert<string>(am_);
                    bool? ao_ = context.Operators.Equal(an_, "plan");
                    ResourceReference ap_ = DiureticMed?.Subject;
                    FhirString aq_ = ap_?.ReferenceElement;
                    string ar_ = aq_?.Value;
                    string as_ = QICoreCommon_4_0_000.Instance.getId(context, ar_);

                    Id at_() {

                        bool bq_() {
                            Patient br_ = this.Patient(context);
                            bool bs_ = br_ is Resource;
                            return bs_;
                        }

                        if (bq_())
                        {
                            Patient bt_ = this.Patient(context);
                            return (bt_ as Resource).IdElement;
                        }
                        else
                        {
                            return default;
                        };
                    }

                    string au_ = (at_())?.Value;
                    bool? av_ = context.Operators.Equal(as_, au_);
                    bool? aw_ = context.Operators.And(ao_, av_);
                    bool? ax_ = context.Operators.Or(ak_, aw_);
                    bool? ay_ = context.Operators.And(ag_, ax_);
                    bool? az_ = QICoreCommon_4_0_000.Instance.isCommunity(context, DiureticMed as object);
                    bool? ba_ = context.Operators.And(ay_, az_);
                    CqlInterval<CqlDate> bb_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, DiureticMed);
                    CqlDate bc_ = bb_?.low;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    CqlDate bf_ = bb_?.high;
                    CqlDateTime bg_ = context.Operators.ConvertDateToDateTime(bf_);
                    bool? bi_ = bb_?.lowClosed;
                    bool? bk_ = bb_?.highClosed;
                    CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bd_, bg_, bi_, bk_);
                    Period bm_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                    bool? bo_ = context.Operators.OverlapsBefore(bl_, bn_, "day");
                    bool? bp_ = context.Operators.And(ba_, bo_);
                    return bp_;
                }

                IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
                Encounter l_(MedicationRequest DiureticMed) => InpatientEncounter;
                IEnumerable<Encounter> m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);
                return m_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Opioid Medication Active at Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Opioid_Medication_Active_at_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(2482244248561422898L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            IEnumerable<Encounter> b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Opioids(context);
                IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
                IEnumerable<MedicationRequest> f_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));

                IEnumerable<MedicationRequest> g_(MedicationRequest MR) {
                    IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? o_(Medication M) {
                        object s_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object t_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> u_ = context.Operators.Split((string)t_, "/");
                        string v_ = context.Operators.Last<string>(u_);
                        bool? w_ = context.Operators.Equal(s_, v_);
                        CodeableConcept x_ = M?.Code;
                        CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, x_);
                        CqlValueSet z_ = this.Opioids(context);
                        bool? aa_ = context.Operators.ConceptInValueSet(y_, z_);
                        bool? ab_ = context.Operators.And(w_, aa_);
                        return ab_;
                    }

                    IEnumerable<Medication> p_ = context.Operators.Where<Medication>(n_, o_);
                    MedicationRequest q_(Medication M) => MR;
                    IEnumerable<MedicationRequest> r_ = context.Operators.Select<Medication, MedicationRequest>(p_, q_);
                    return r_;
                }

                IEnumerable<MedicationRequest> h_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(f_, g_);
                IEnumerable<MedicationRequest> i_ = context.Operators.Union<MedicationRequest>(e_, h_);

                bool? j_(MedicationRequest OpioidMed) {
                    Code<MedicationRequest.MedicationrequestStatus> ac_ = OpioidMed?.StatusElement;
                    MedicationRequest.MedicationrequestStatus? ad_ = ac_?.Value;
                    string ae_ = context.Operators.Convert<string>(ad_);
                    string[] af_ = [
                        "active",
                        "completed",
                    ];
                    bool? ag_ = context.Operators.In<string>(ae_, (IEnumerable<string>)af_);
                    Code<MedicationRequest.MedicationRequestIntent> ah_ = OpioidMed?.IntentElement;
                    MedicationRequest.MedicationRequestIntent? ai_ = ah_?.Value;
                    string aj_ = context.Operators.Convert<string>(ai_);
                    bool? ak_ = context.Operators.Equal(aj_, "order");
                    MedicationRequest.MedicationRequestIntent? am_ = ah_?.Value;
                    string an_ = context.Operators.Convert<string>(am_);
                    bool? ao_ = context.Operators.Equal(an_, "plan");
                    ResourceReference ap_ = OpioidMed?.Subject;
                    FhirString aq_ = ap_?.ReferenceElement;
                    string ar_ = aq_?.Value;
                    string as_ = QICoreCommon_4_0_000.Instance.getId(context, ar_);

                    Id at_() {

                        bool bq_() {
                            Patient br_ = this.Patient(context);
                            bool bs_ = br_ is Resource;
                            return bs_;
                        }

                        if (bq_())
                        {
                            Patient bt_ = this.Patient(context);
                            return (bt_ as Resource).IdElement;
                        }
                        else
                        {
                            return default;
                        };
                    }

                    string au_ = (at_())?.Value;
                    bool? av_ = context.Operators.Equal(as_, au_);
                    bool? aw_ = context.Operators.And(ao_, av_);
                    bool? ax_ = context.Operators.Or(ak_, aw_);
                    bool? ay_ = context.Operators.And(ag_, ax_);
                    bool? az_ = QICoreCommon_4_0_000.Instance.isCommunity(context, OpioidMed as object);
                    bool? ba_ = context.Operators.And(ay_, az_);
                    CqlInterval<CqlDate> bb_ = CumulativeMedicationDuration_6_0_000.Instance.medicationRequestPeriod(context, OpioidMed);
                    CqlDate bc_ = bb_?.low;
                    CqlDateTime bd_ = context.Operators.ConvertDateToDateTime(bc_);
                    CqlDate bf_ = bb_?.high;
                    CqlDateTime bg_ = context.Operators.ConvertDateToDateTime(bf_);
                    bool? bi_ = bb_?.lowClosed;
                    bool? bk_ = bb_?.highClosed;
                    CqlInterval<CqlDateTime> bl_ = context.Operators.Interval(bd_, bg_, bi_, bk_);
                    Period bm_ = InpatientEncounter?.Period;
                    CqlInterval<CqlDateTime> bn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bm_);
                    bool? bo_ = context.Operators.OverlapsBefore(bl_, bn_, "day");
                    bool? bp_ = context.Operators.And(ba_, bo_);
                    return bp_;
                }

                IEnumerable<MedicationRequest> k_ = context.Operators.Where<MedicationRequest>(i_, j_);
                Encounter l_(MedicationRequest OpioidMed) => InpatientEncounter;
                IEnumerable<Encounter> m_ = context.Operators.Select<MedicationRequest, Encounter>(k_, l_);
                return m_;
            }

            IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Coagulation Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Coagulation_Disorder_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(1980631045349188772L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Coagulation_Disorders(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Delirium or Dementia or Other Psychosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Delirium_or_Dementia_or_Other_Psychosis_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(3816316150793516446L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Delirium__Dementia__and_Other_Psychoses(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Depression Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Depression_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(4214772090319590937L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Depression(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Epilepsy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Epilepsy_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(7000000165091156417L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Epilepsy(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Leukemia or Lymphoma Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Leukemia_or_Lymphoma_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(7398759844787738930L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Leukemia_or_Lymphoma(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Liver Disease Moderate to Severe Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Liver_Disease_Moderate_to_Severe_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-3901620165660556613L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Liver_Disease_Moderate_to_Severe(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Malignant Bone Disease Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Malignant_Bone_Disease_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-6519893641608176887L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Malignant_Bone_Disease(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Neurologic Disorder Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Neurologic_Disorder_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-7749071699323752421L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Neurologic_Movement_and_Related_Disorders(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Obesity Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Obesity_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(1111109168538456667L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Obesity(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Osteoporosis Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Osteoporosis_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-1864719601187372501L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Osteoporosis(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Peripheral Neuropathy Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Peripheral_Neuropathy_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-8941770802708293932L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Peripheral_Neuropathy(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Stroke Present on Admission")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Stroke_Present_on_Admission(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(7549789774069722028L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                CqlValueSet d_ = this.Stroke(context);
                CqlValueSet e_ = this.Present_on_Admission_or_Clinically_Undetermined(context);
                bool? f_ = CQMCommon_4_1_000.Instance.isDiagnosisPresentOnAdmission(context, InpatientEncounter, d_, e_);
                return f_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("Risk Variable Encounter with Suicide Attempt")]
    public IEnumerable<Encounter> Risk_Variable_Encounter_with_Suicide_Attempt(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Encounter>>(-9085156353756314203L, () => {
            IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

            bool? b_(Encounter InpatientEncounter) {
                IEnumerable<object> d_ = this.encountersDiagnosis(context, InpatientEncounter);

                bool? e_(object @this) {
                    object k_ = context.Operators.LateBoundProperty<object>(@this, "code");
                    CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_ as CodeableConcept);
                    bool? m_ = context.Operators.Not((bool?)(l_ is null));
                    return m_;
                }

                IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);

                CqlConcept g_(object @this) {
                    object n_ = context.Operators.LateBoundProperty<object>(@this, "code");
                    CqlConcept o_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, n_ as CodeableConcept);
                    return o_;
                }

                IEnumerable<CqlConcept> h_ = context.Operators.Select<object, CqlConcept>(f_, g_);
                CqlValueSet i_ = this.Suicide_Attempt(context);
                bool? j_ = context.Operators.ConceptsInValueSet(h_, i_);
                return j_;
            }

            IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
            return c_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-7188146491602681279L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>>(-6065141591157605130L, () => {
            IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(-2041073189866593713L, () => {
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
            return a_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(-8546165489307990724L, () => {
            CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
            return a_;
        });


    [CqlFunctionDefinition("Denominator Observation")]
    public int? Denominator_Observation(CqlContext context, Encounter QualifyingEncounter)
    {
        CqlInterval<CqlDateTime> a_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingEncounter);
        CqlDateTime b_ = context.Operators.Start(a_);
        CqlDateTime d_ = context.Operators.End(a_);
        int? e_ = context.Operators.DurationBetween(b_, d_, "day");
        return e_;
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
            bool? i_ = context.Operators.In<CqlDateTime>(g_, h_, default);
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
