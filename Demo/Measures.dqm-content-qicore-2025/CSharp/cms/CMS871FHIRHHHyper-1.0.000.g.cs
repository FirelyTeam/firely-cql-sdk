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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.1.0")]
[CqlLibrary("CMS871FHIRHHHyper", "1.0.000")]
public partial class CMS871FHIRHHHyper_1_0_000 : ILibrary, ISingleton<CMS871FHIRHHHyper_1_0_000>
{
    #region ValueSets (7)

    [CqlValueSetDefinition("Comfort Measures", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", valueSetVersion: null)]
    public CqlValueSet Comfort_Measures(CqlContext _) => _Comfort_Measures;
    private static readonly CqlValueSet _Comfort_Measures = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45", null);

    [CqlValueSetDefinition("Diabetes", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", valueSetVersion: null)]
    public CqlValueSet Diabetes(CqlContext _) => _Diabetes;
    private static readonly CqlValueSet _Diabetes = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.103.12.1001", null);

    [CqlValueSetDefinition("Discharged to Health Care Facility for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Health_Care_Facility_for_Hospice_Care(CqlContext _) => _Discharged_to_Health_Care_Facility_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Health_Care_Facility_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.207", null);

    [CqlValueSetDefinition("Discharged to Home for Hospice Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", valueSetVersion: null)]
    public CqlValueSet Discharged_to_Home_for_Hospice_Care(CqlContext _) => _Discharged_to_Home_for_Hospice_Care;
    private static readonly CqlValueSet _Discharged_to_Home_for_Hospice_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.209", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Glucose Lab Test Mass Per Volume", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", valueSetVersion: null)]
    public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume(CqlContext _) => _Glucose_Lab_Test_Mass_Per_Volume;
    private static readonly CqlValueSet _Glucose_Lab_Test_Mass_Per_Volume = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", null);

    [CqlValueSetDefinition("Hypoglycemics Treatment Medications", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", valueSetVersion: null)]
    public CqlValueSet Hypoglycemics_Treatment_Medications(CqlContext _) => _Hypoglycemics_Treatment_Medications;
    private static readonly CqlValueSet _Hypoglycemics_Treatment_Medications = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.394", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -8564347952415020027L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS871FHIRHHHyper-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (31)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -6545368659874762456L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Comfort Measures Care")]
    public IEnumerable<object> Comfort_Measures_Care(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Comfort_Measures_Care, Comfort_Measures_Care_Compute);

    private const long _cacheIndex_Comfort_Measures_Care = -3618584013199035287L;

    private IEnumerable<object> Comfort_Measures_Care_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Comfort_Measures(context);
        IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));

        bool? c_(Procedure ProcedureCM) {
            Code<EventStatus> j_ = ProcedureCM?.StatusElement;
            EventStatus? k_ = j_?.Value;
            string l_ = context.Operators.Convert<string>(k_);
            bool? m_ = context.Operators.Equal(l_, "completed");
            return m_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        IEnumerable<ServiceRequest> f_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? g_(ServiceRequest ServiceReq) {
            Code<RequestStatus> n_ = ServiceReq?.StatusElement;
            RequestStatus? o_ = n_?.Value;
            Code<RequestStatus> p_ = context.Operators.Convert<Code<RequestStatus>>(o_);
            string q_ = context.Operators.Convert<string>(p_);
            string[] r_ = [
                "active",
                "completed",
            ];
            bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
            return s_;
        }

        IEnumerable<ServiceRequest> h_ = context.Operators.Where<ServiceRequest>(f_, g_);
        IEnumerable<object> i_ = context.Operators.Union<object>(d_ as IEnumerable<object>, h_ as IEnumerable<object>);
        return i_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter, Qualifying_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Encounter = 7222190575615637065L;

    private IEnumerable<Encounter> Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter InpatientEncounter) {
            Patient e_ = this.Patient(context);
            Date f_ = e_?.BirthDateElement;
            string g_ = f_?.Value;
            CqlDate h_ = context.Operators.ConvertStringToDate(g_);
            Period i_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime> j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime k_ = context.Operators.Start(j_);
            CqlDate l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 18);
            CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime q_ = context.Operators.End(p_);
            CqlInterval<CqlDateTime> r_ = this.Measurement_Period(context);
            bool? s_ = context.Operators.In<CqlDateTime>(q_, r_, "day");
            bool? t_ = context.Operators.And(n_, s_);
            Code<Encounter.EncounterStatus> u_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? v_ = u_?.Value;
            Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
            bool? x_ = context.Operators.Equal(w_, "finished");
            bool? y_ = context.Operators.And(t_, x_);
            return y_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Encounter with Hospitalization Period")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Encounter_with_Hospitalization_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Hospitalization_Period, Encounter_with_Hospitalization_Period_Compute);

    private const long _cacheIndex_Encounter_with_Hospitalization_Period = 8207631391904946457L;

    private IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> Encounter_with_Hospitalization_Period_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? b_(Encounter QualifyingHospitalization) {
            CqlInterval<CqlDateTime> e_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingHospitalization);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? f_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingHospitalization, e_);
            return f_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Encounter with Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Existing_Diabetes_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Existing_Diabetes_Diagnosis, Encounter_with_Existing_Diabetes_Diagnosis_Compute);

    private const long _cacheIndex_Encounter_with_Existing_Diabetes_Diagnosis = 8371829728228279353L;

    private IEnumerable<Encounter> Encounter_with_Existing_Diabetes_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Encounter_with_Hospitalization_Period(context);

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization) {
            CqlValueSet g_ = this.Diabetes(context);
            IEnumerable<Condition> h_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? i_(Condition DiabetesEncounter) {
                Encounter t_ = Hospitalization?.encounter;
                List<ResourceReference> u_ = t_?.ReasonReference;
                bool? v_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)u_, DiabetesEncounter);
                List<CodeableConcept> x_ = t_?.ReasonCode;

                CqlConcept y_(CodeableConcept @this) {
                    CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return aj_;
                }

                IEnumerable<CqlConcept> z_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)x_, y_);
                CqlValueSet aa_ = this.Diabetes(context);
                bool? ab_ = context.Operators.ConceptsInValueSet(z_, aa_);
                bool? ac_ = context.Operators.Or(v_, ab_);
                CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesEncounter as object);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlInterval<CqlDateTime> af_ = Hospitalization?.hospitalizationPeriod;
                CqlDateTime ag_ = context.Operators.End(af_);
                bool? ah_ = context.Operators.Before(ae_, ag_, (string)default);
                bool? ai_ = context.Operators.And(ac_, ah_);
                return ai_;
            }

            IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
            IEnumerable<Condition> l_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? m_(Condition DiabetesProblem) {
                CodeableConcept ak_ = DiabetesProblem?.VerificationStatus;
                CqlConcept al_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                bool? am_ = context.Operators.Not((bool?)(al_ is null));
                CqlConcept ao_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                CqlCode ap_ = QICoreCommon_4_0_000.Instance.confirmed(context);
                CqlConcept aq_ = context.Operators.ConvertCodeToConcept(ap_);
                bool? ar_ = context.Operators.Equivalent(ao_, aq_);
                CqlConcept at_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                CqlCode au_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
                bool? aw_ = context.Operators.Equivalent(at_, av_);
                bool? ax_ = context.Operators.Or(ar_, aw_);
                CqlConcept az_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                CqlCode ba_ = QICoreCommon_4_0_000.Instance.provisional(context);
                CqlConcept bb_ = context.Operators.ConvertCodeToConcept(ba_);
                bool? bc_ = context.Operators.Equivalent(az_, bb_);
                bool? bd_ = context.Operators.Or(ax_, bc_);
                CqlConcept bf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ak_);
                CqlCode bg_ = QICoreCommon_4_0_000.Instance.differential(context);
                CqlConcept bh_ = context.Operators.ConvertCodeToConcept(bg_);
                bool? bi_ = context.Operators.Equivalent(bf_, bh_);
                bool? bj_ = context.Operators.Or(bd_, bi_);
                CqlInterval<CqlDateTime> bk_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesProblem as object);
                CqlDateTime bl_ = context.Operators.Start(bk_);
                CqlInterval<CqlDateTime> bm_ = Hospitalization?.hospitalizationPeriod;
                CqlDateTime bn_ = context.Operators.End(bm_);
                bool? bo_ = context.Operators.Before(bl_, bn_, (string)default);
                bool? bp_ = context.Operators.And(bj_, bo_);
                bool? bq_ = context.Operators.Implies(am_, bp_);
                return bq_;
            }

            IEnumerable<Condition> n_ = context.Operators.Where<Condition>(l_, m_);
            IEnumerable<object> o_ = context.Operators.Union<object>(j_ as IEnumerable<object>, n_ as IEnumerable<object>);

            bool? p_(object DiabetesCondition) {
                ResourceReference br_ = context.Operators.LateBoundProperty<ResourceReference>(DiabetesCondition, "subject");
                FhirString bs_ = br_?.ReferenceElement;
                string bt_ = bs_?.Value;
                Encounter bu_ = Hospitalization?.encounter;
                ResourceReference bv_ = bu_?.Subject;
                FhirString bw_ = bv_?.ReferenceElement;
                string bx_ = bw_?.Value;
                bool? by_ = context.Operators.Equal(bt_, bx_);
                return by_;
            }

            IEnumerable<object> q_ = context.Operators.Where<object>(o_, p_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? r_(object DiabetesCondition) => Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> s_ = context.Operators.Select<object, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(q_, r_);
            return s_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);

        Encounter d_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization) {
            Encounter bz_ = Hospitalization?.encounter;
            return bz_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Encounter with Hypoglycemic Medication")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Hypoglycemic_Medication, Encounter_with_Hypoglycemic_Medication_Compute);

    private const long _cacheIndex_Encounter_with_Hypoglycemic_Medication = -6862387996649634919L;

    private IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Encounter_with_Hospitalization_Period(context);
        CqlValueSet b_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> d_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        IEnumerable<MedicationAdministration> e_(MedicationAdministration MR) {
            IEnumerable<Medication> p_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? q_(Medication M) {
                object u_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object v_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> w_ = context.Operators.Split((string)v_, "/");
                string x_ = context.Operators.Last<string>(w_);
                bool? y_ = context.Operators.Equal(u_, x_);
                CodeableConcept z_ = M?.Code;
                CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, z_);
                CqlValueSet ab_ = this.Hypoglycemics_Treatment_Medications(context);
                bool? ac_ = context.Operators.ConceptInValueSet(aa_, ab_);
                bool? ad_ = context.Operators.And(y_, ac_);
                return ad_;
            }

            IEnumerable<Medication> r_ = context.Operators.Where<Medication>(p_, q_);
            MedicationAdministration s_(Medication M) => MR;
            IEnumerable<MedicationAdministration> t_ = context.Operators.Select<Medication, MedicationAdministration>(r_, s_);
            return t_;
        }

        IEnumerable<MedicationAdministration> f_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(d_, e_);
        IEnumerable<MedicationAdministration> g_ = context.Operators.Union<MedicationAdministration>(c_, f_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> h_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(a_, g_);

        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? i_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? ae_ = (CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG, _valueTuple.Item1, _valueTuple.Item2);
            return ae_;
        }

        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> j_ = context.Operators.Select<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(h_, i_);

        bool? k_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> af_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ag_ = af_?.Value;
            string ah_ = context.Operators.Convert<string>(ag_);
            string[] ai_ = [
                "completed",
                "in-progress",
            ];
            bool? aj_ = context.Operators.In<string>(ah_, (IEnumerable<string>)ai_);
            CqlInterval<CqlDateTime> ak_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.hospitalizationPeriod;
            DataType al_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.Effective;
            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
            CqlInterval<CqlDateTime> an_ = QICoreCommon_4_0_000.Instance.toInterval(context, am_);
            bool? ao_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ak_, an_, (string)default);
            bool? ap_ = context.Operators.And(aj_, ao_);
            return ap_;
        }

        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> l_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(j_, k_);

        Encounter m_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig) {
            Encounter aq_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.encounter;
            return aq_;
        }

        IEnumerable<Encounter> n_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?, Encounter>(l_, m_);
        IEnumerable<Encounter> o_ = context.Operators.Distinct<Encounter>(n_);
        return o_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Glucose Greater Than or Equal to 200")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200, Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200_Compute);

    private const long _cacheIndex_Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200 = 5212261220385973189L;

    private IEnumerable<Encounter> Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Encounter_with_Hospitalization_Period(context);

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization) {
            CqlValueSet g_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
            IEnumerable<Observation> h_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, g_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? i_(Observation GlucoseTest) {

                object m_() {

                    bool ab_() {
                        DataType ae_ = GlucoseTest?.Effective;
                        object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                        bool ag_ = af_ is CqlDateTime;
                        return ag_;
                    }


                    bool ac_() {
                        DataType ah_ = GlucoseTest?.Effective;
                        object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                        bool aj_ = ai_ is CqlInterval<CqlDateTime>;
                        return aj_;
                    }


                    bool ad_() {
                        DataType ak_ = GlucoseTest?.Effective;
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        bool am_ = al_ is CqlDateTime;
                        return am_;
                    }

                    if (ab_())
                    {
                        DataType an_ = GlucoseTest?.Effective;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        return (ao_ as CqlDateTime) as object;
                    }
                    else if (ac_())
                    {
                        DataType ap_ = GlucoseTest?.Effective;
                        object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                        return (aq_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (ad_())
                    {
                        DataType ar_ = GlucoseTest?.Effective;
                        object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                        return (as_ as CqlDateTime) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlDateTime n_ = QICoreCommon_4_0_000.Instance.earliest(context, m_());
                CqlInterval<CqlDateTime> o_ = Hospitalization?.hospitalizationPeriod;
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                Code<ObservationStatus> q_ = GlucoseTest?.StatusElement;
                ObservationStatus? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                string[] t_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
                bool? v_ = context.Operators.And(p_, u_);
                DataType w_ = GlucoseTest?.Value;
                object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                CqlQuantity y_ = context.Operators.Quantity(200m, "mg/dL");
                bool? z_ = context.Operators.GreaterOrEqual(x_ as CqlQuantity, y_);
                bool? aa_ = context.Operators.And(v_, z_);
                return aa_;
            }

            IEnumerable<Observation> j_ = context.Operators.Where<Observation>(h_, i_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? k_(Observation GlucoseTest) => Hospitalization;
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> l_ = context.Operators.Select<Observation, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(j_, k_);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.SelectMany<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);

        Encounter d_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization) {
            Encounter at_ = Hospitalization?.encounter;
            return at_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -6071045710406264559L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Existing_Diabetes_Diagnosis(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Hypoglycemic_Medication(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 779086147109314210L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Measurement Population")]
    public IEnumerable<Encounter> Measurement_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Population, Measurement_Population_Compute);

    private const long _cacheIndex_Measurement_Population = 7476660147351885504L;

    private IEnumerable<Encounter> Measurement_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        return a_;
    }


    [CqlFunctionDefinition("hospitalDaysMax10")]
    public CqlInterval<CqlDateTime> hospitalDaysMax10(CqlContext context, CqlInterval<CqlDateTime> Period)
    {
        CqlDateTime a_ = context.Operators.Start(Period);
        CqlDateTime b_ = context.Operators.End(Period);
        CqlQuantity d_ = context.Operators.Quantity(10m, "days");
        CqlDateTime e_ = context.Operators.Add(a_, d_);
        CqlDateTime[] f_ = [
            b_,
            e_,
        ];
        CqlDateTime g_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)f_);
        CqlInterval<CqlDateTime> h_ = context.Operators.Interval(a_, g_, true, true);
        return h_;
    }


    [CqlExpressionDefinition("Days in Hospitalization")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Days_in_Hospitalization(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Days_in_Hospitalization, Days_in_Hospitalization_Compute);

    private const long _cacheIndex_Days_in_Hospitalization = -5552137013729529852L;

    private IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Days_in_Hospitalization_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measurement_Population(context);

        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? b_(Encounter EligibleInpatientHospitalization) {
            CqlInterval<CqlDateTime> e_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, EligibleInpatientHospitalization);
            CqlInterval<CqlDateTime> g_ = this.hospitalDaysMax10(context, e_);
            CqlInterval<CqlDateTime> i_ = this.hospitalDaysMax10(context, e_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> j_ = QICoreCommon_4_0_000.Instance.daysInPeriod(context, i_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? k_ = (CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU, EligibleInpatientHospitalization, e_, g_, j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> c_ = context.Operators.Select<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Days with Glucose Results")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> Days_with_Glucose_Results(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Days_with_Glucose_Results, Days_with_Glucose_Results_Compute);

    private const long _cacheIndex_Days_with_Glucose_Results = -1534215195981936569L;

    private IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> Days_with_Glucose_Results_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> a_ = this.Days_in_Hospitalization(context);

        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? InpatientHospitalDays) {
            Encounter e_ = InpatientHospitalDays?.encounter;
            CqlInterval<CqlDateTime> f_ = InpatientHospitalDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> g_ = InpatientHospitalDays?.relevantDays;

            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? h_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay) {
                int? l_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> m_ = EncounterDay?.dayPeriod;
                CqlValueSet n_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
                IEnumerable<Observation> o_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

                bool? p_(Observation GlucoseTest) {
                    Code<ObservationStatus> ae_ = GlucoseTest?.StatusElement;
                    ObservationStatus? af_ = ae_?.Value;
                    string ag_ = context.Operators.Convert<string>(af_);
                    string[] ah_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ai_ = context.Operators.In<string>(ag_, (IEnumerable<string>)ah_);
                    DataType aj_ = GlucoseTest?.Value;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    CqlQuantity al_ = context.Operators.Quantity(300m, "mg/dL");
                    bool? am_ = context.Operators.Greater(ak_ as CqlQuantity, al_);
                    bool? an_ = context.Operators.And(ai_, am_);

                    object ao_() {

                        bool at_() {
                            DataType aw_ = GlucoseTest?.Effective;
                            object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                            bool ay_ = ax_ is CqlDateTime;
                            return ay_;
                        }


                        bool au_() {
                            DataType az_ = GlucoseTest?.Effective;
                            object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                            bool bb_ = ba_ is CqlInterval<CqlDateTime>;
                            return bb_;
                        }


                        bool av_() {
                            DataType bc_ = GlucoseTest?.Effective;
                            object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                            bool be_ = bd_ is CqlDateTime;
                            return be_;
                        }

                        if (at_())
                        {
                            DataType bf_ = GlucoseTest?.Effective;
                            object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                            return (bg_ as CqlDateTime) as object;
                        }
                        else if (au_())
                        {
                            DataType bh_ = GlucoseTest?.Effective;
                            object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                            return (bi_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (av_())
                        {
                            DataType bj_ = GlucoseTest?.Effective;
                            object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                            return (bk_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_());
                    CqlInterval<CqlDateTime> aq_ = EncounterDay?.dayPeriod;
                    bool? ar_ = context.Operators.In<CqlDateTime>(ap_, aq_, (string)default);
                    bool? as_ = context.Operators.And(an_, ar_);
                    return as_;
                }

                IEnumerable<Observation> q_ = context.Operators.Where<Observation>(o_, p_);
                bool? r_ = context.Operators.Exists<Observation>(q_);
                IEnumerable<Observation> t_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

                bool? u_(Observation GlucoseTest) {
                    Code<ObservationStatus> bl_ = GlucoseTest?.StatusElement;
                    ObservationStatus? bm_ = bl_?.Value;
                    string bn_ = context.Operators.Convert<string>(bm_);
                    string[] bo_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bp_ = context.Operators.In<string>(bn_, (IEnumerable<string>)bo_);
                    DataType bq_ = GlucoseTest?.Value;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    CqlQuantity bs_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? bt_ = context.Operators.GreaterOrEqual(br_ as CqlQuantity, bs_);
                    bool? bu_ = context.Operators.And(bp_, bt_);

                    object bv_() {

                        bool ca_() {
                            DataType cd_ = GlucoseTest?.Effective;
                            object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                            bool cf_ = ce_ is CqlDateTime;
                            return cf_;
                        }


                        bool cb_() {
                            DataType cg_ = GlucoseTest?.Effective;
                            object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                            bool ci_ = ch_ is CqlInterval<CqlDateTime>;
                            return ci_;
                        }


                        bool cc_() {
                            DataType cj_ = GlucoseTest?.Effective;
                            object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                            bool cl_ = ck_ is CqlDateTime;
                            return cl_;
                        }

                        if (ca_())
                        {
                            DataType cm_ = GlucoseTest?.Effective;
                            object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                            return (cn_ as CqlDateTime) as object;
                        }
                        else if (cb_())
                        {
                            DataType co_ = GlucoseTest?.Effective;
                            object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                            return (cp_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (cc_())
                        {
                            DataType cq_ = GlucoseTest?.Effective;
                            object cr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cq_);
                            return (cr_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlDateTime bw_ = QICoreCommon_4_0_000.Instance.earliest(context, bv_());
                    CqlInterval<CqlDateTime> bx_ = EncounterDay?.dayPeriod;
                    bool? by_ = context.Operators.In<CqlDateTime>(bw_, bx_, (string)default);
                    bool? bz_ = context.Operators.And(bu_, by_);
                    return bz_;
                }

                IEnumerable<Observation> v_ = context.Operators.Where<Observation>(t_, u_);
                bool? w_ = context.Operators.Exists<Observation>(v_);
                IEnumerable<Observation> y_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

                bool? z_(Observation GlucoseTest) {
                    Code<ObservationStatus> cs_ = GlucoseTest?.StatusElement;
                    ObservationStatus? ct_ = cs_?.Value;
                    string cu_ = context.Operators.Convert<string>(ct_);
                    string[] cv_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? cw_ = context.Operators.In<string>(cu_, (IEnumerable<string>)cv_);

                    object cx_() {

                        bool dc_() {
                            DataType df_ = GlucoseTest?.Effective;
                            object dg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, df_);
                            bool dh_ = dg_ is CqlDateTime;
                            return dh_;
                        }


                        bool dd_() {
                            DataType di_ = GlucoseTest?.Effective;
                            object dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
                            bool dk_ = dj_ is CqlInterval<CqlDateTime>;
                            return dk_;
                        }


                        bool de_() {
                            DataType dl_ = GlucoseTest?.Effective;
                            object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                            bool dn_ = dm_ is CqlDateTime;
                            return dn_;
                        }

                        if (dc_())
                        {
                            DataType do_ = GlucoseTest?.Effective;
                            object dp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, do_);
                            return (dp_ as CqlDateTime) as object;
                        }
                        else if (dd_())
                        {
                            DataType dq_ = GlucoseTest?.Effective;
                            object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                            return (dr_ as CqlInterval<CqlDateTime>) as object;
                        }
                        else if (de_())
                        {
                            DataType ds_ = GlucoseTest?.Effective;
                            object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                            return (dt_ as CqlDateTime) as object;
                        }
                        else
                        {
                            return null;
                        };
                    }

                    CqlDateTime cy_ = QICoreCommon_4_0_000.Instance.earliest(context, cx_());
                    CqlInterval<CqlDateTime> cz_ = EncounterDay?.dayPeriod;
                    bool? da_ = context.Operators.In<CqlDateTime>(cy_, cz_, (string)default);
                    bool? db_ = context.Operators.And(cw_, da_);
                    return db_;
                }

                IEnumerable<Observation> aa_ = context.Operators.Where<Observation>(y_, z_);
                bool? ab_ = context.Operators.Exists<Observation>(aa_);
                bool? ac_ = context.Operators.Not(ab_);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? ad_ = (CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO, l_, m_, r_, w_, ac_);
                return ad_;
            }

            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> i_ = context.Operators.Select<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(g_, h_);
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(i_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? k_ = (CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd, e_, f_, j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> c_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Days with Hyperglycemic Events")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Days_with_Hyperglycemic_Events(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Days_with_Hyperglycemic_Events, Days_with_Hyperglycemic_Events_Compute);

    private const long _cacheIndex_Days_with_Hyperglycemic_Events = 5078852559922539511L;

    private IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Days_with_Hyperglycemic_Events_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> a_ = this.Days_with_Glucose_Results(context);

        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? EncounterWithResultDays) {
            Encounter e_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> f_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> g_ = EncounterWithResultDays?.relevantDays;

            bool? h_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay) {
                int? n_ = EncounterDay?.dayNumber;
                bool? o_ = context.Operators.Greater(n_, 1);
                return o_;
            }

            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> i_ = context.Operators.Where<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(g_, h_);

            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? j_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay) {
                int? p_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> q_ = EncounterDay?.dayPeriod;
                bool? r_ = EncounterDay?.hasSevereResult;
                bool? s_ = EncounterDay?.hasNoGlucoseTest;
                IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> t_ = EncounterWithResultDays?.relevantDays;
                int? v_ = context.Operators.Subtract(p_, 2);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? w_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(t_, v_);
                bool? x_ = w_?.hasElevatedResult;
                bool? y_ = context.Operators.And(s_, x_);
                int? ab_ = context.Operators.Subtract(p_, 3);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? ac_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(t_, ab_);
                bool? ad_ = ac_?.hasElevatedResult;
                bool? ae_ = context.Operators.And(y_, ad_);
                bool? af_ = context.Operators.Or(r_, ae_);
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? ag_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, p_, q_, af_);
                return ag_;
            }

            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> k_ = context.Operators.Select<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(k_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? m_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, e_, f_, l_);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(c_);
        return d_;
    }


    [CqlExpressionDefinition("Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start, Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start_Compute);

    private const long _cacheIndex_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start = 1518745136569016494L;

    private IEnumerable<Observation> Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        CqlValueSet b_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, b_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation>> d_ = context.Operators.CrossJoin<Encounter, Observation>(a_, c_);

        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? e_(ValueTuple<Encounter, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? l_ = (CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH, _valueTuple.Item1, _valueTuple.Item2);
            return l_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> f_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(d_, e_);

        bool? g_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh) {
            DataType m_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Value;
            object n_ = FHIRHelpers_4_4_000.Instance.ToValue(context, m_);
            CqlQuantity o_ = context.Operators.Quantity(600m, "mg/dL");
            bool? p_ = context.Operators.Greater(n_ as CqlQuantity, o_);
            Code<ObservationStatus> q_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.StatusElement;
            ObservationStatus? r_ = q_?.Value;
            string s_ = context.Operators.Convert<string>(r_);
            string[] t_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
            bool? v_ = context.Operators.And(p_, u_);

            object w_() {

                bool aj_() {
                    DataType am_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                    bool ao_ = an_ is CqlDateTime;
                    return ao_;
                }


                bool ak_() {
                    DataType ap_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                    bool ar_ = aq_ is CqlInterval<CqlDateTime>;
                    return ar_;
                }


                bool al_() {
                    DataType as_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                    bool au_ = at_ is CqlDateTime;
                    return au_;
                }

                if (aj_())
                {
                    DataType av_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                    return (aw_ as CqlDateTime) as object;
                }
                else if (ak_())
                {
                    DataType ax_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    return (ay_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (al_())
                {
                    DataType az_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    return (ba_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime x_ = QICoreCommon_4_0_000.Instance.earliest(context, w_());
            CqlInterval<CqlDateTime> y_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gldtpgaqprrprerabeflfanwh?.InpatientHospitalization);
            CqlDateTime z_ = context.Operators.Start(y_);
            CqlQuantity aa_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime ab_ = context.Operators.Subtract(z_, aa_);
            CqlDateTime ad_ = context.Operators.Start(y_);
            CqlQuantity ae_ = context.Operators.Quantity(6m, "hours");
            CqlDateTime af_ = context.Operators.Add(ad_, ae_);
            CqlInterval<CqlDateTime> ag_ = context.Operators.Interval(ab_, af_, true, true);
            bool? ah_ = context.Operators.In<CqlDateTime>(x_, ag_, (string)default);
            bool? ai_ = context.Operators.And(v_, ah_);
            return ai_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> h_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(f_, g_);
        Observation i_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh) => tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest;
        IEnumerable<Observation> j_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?, Observation>(h_, i_);
        IEnumerable<Observation> k_ = context.Operators.Distinct<Observation>(j_);
        return k_;
    }


    [CqlExpressionDefinition("Glucose Tests Earlier Than Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Glucose_Tests_Earlier_Than_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Glucose_Tests_Earlier_Than_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start, Glucose_Tests_Earlier_Than_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start_Compute);

    private const long _cacheIndex_Glucose_Tests_Earlier_Than_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start = -1259410611206168739L;

    private IEnumerable<Observation> Glucose_Tests_Earlier_Than_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        IEnumerable<Observation> b_ = this.Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        CqlValueSet c_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> e_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, b_, d_);

        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)? f_(ValueTuple<Encounter, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)? m_ = (CqlTupleMetadata_GABJOQOeJbjRSJMaADeBWVJQa, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)?> g_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)? tuple_ghpnfyjsiaqamntcrzhgtgped) {

            object n_() {

                bool ar_() {
                    DataType au_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    bool aw_ = av_ is CqlDateTime;
                    return aw_;
                }


                bool as_() {
                    DataType ax_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    bool az_ = ay_ is CqlInterval<CqlDateTime>;
                    return az_;
                }


                bool at_() {
                    DataType ba_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlDateTime;
                    return bc_;
                }

                if (ar_())
                {
                    DataType bd_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                    return (be_ as CqlDateTime) as object;
                }
                else if (as_())
                {
                    DataType bf_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    return (bg_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (at_())
                {
                    DataType bh_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return (bi_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_());
            CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ghpnfyjsiaqamntcrzhgtgped?.InpatientHospitalization);
            CqlDateTime q_ = context.Operators.Start(p_);
            CqlQuantity r_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime s_ = context.Operators.Subtract(q_, r_);
            CqlDateTime u_ = context.Operators.Start(p_);
            CqlQuantity v_ = context.Operators.Quantity(6m, "hour");
            CqlDateTime w_ = context.Operators.Add(u_, v_);
            CqlInterval<CqlDateTime> x_ = context.Operators.Interval(s_, w_, true, true);
            bool? y_ = context.Operators.In<CqlDateTime>(o_, x_, (string)default);

            object z_() {

                bool bj_() {
                    DataType bm_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                    object bn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bm_);
                    bool bo_ = bn_ is CqlDateTime;
                    return bo_;
                }


                bool bk_() {
                    DataType bp_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlInterval<CqlDateTime>;
                    return br_;
                }


                bool bl_() {
                    DataType bs_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    bool bu_ = bt_ is CqlDateTime;
                    return bu_;
                }

                if (bj_())
                {
                    DataType bv_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                    object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                    return (bw_ as CqlDateTime) as object;
                }
                else if (bk_())
                {
                    DataType bx_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return (by_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (bl_())
                {
                    DataType bz_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    return (ca_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_());
            CqlDateTime ac_ = context.Operators.Start(p_);
            CqlDateTime ae_ = context.Operators.Subtract(ac_, r_);

            object af_() {

                bool cb_() {
                    DataType ce_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
                    bool cg_ = cf_ is CqlDateTime;
                    return cg_;
                }


                bool cc_() {
                    DataType ch_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                    bool cj_ = ci_ is CqlInterval<CqlDateTime>;
                    return cj_;
                }


                bool cd_() {
                    DataType ck_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    bool cm_ = cl_ is CqlDateTime;
                    return cm_;
                }

                if (cb_())
                {
                    DataType cn_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                    return (co_ as CqlDateTime) as object;
                }
                else if (cc_())
                {
                    DataType cp_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    return (cq_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (cd_())
                {
                    DataType cr_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    return (cs_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_());
            CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ae_, ag_, true, false);
            bool? ai_ = context.Operators.In<CqlDateTime>(aa_, ah_, (string)default);
            bool? aj_ = context.Operators.And(y_, ai_);
            Id ak_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.IdElement;
            string al_ = ak_?.Value;
            Id am_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.IdElement;
            string an_ = am_?.Value;
            bool? ao_ = context.Operators.Equivalent(al_, an_);
            bool? ap_ = context.Operators.Not(ao_);
            bool? aq_ = context.Operators.And(aj_, ap_);
            return aq_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)?>(g_, h_);
        Observation j_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)? tuple_ghpnfyjsiaqamntcrzhgtgped) => tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600;
        IEnumerable<Observation> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)?, Observation>(i_, j_);
        IEnumerable<Observation> l_ = context.Operators.Distinct<Observation>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Initial Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Observation> Initial_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start, Initial_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start_Compute);

    private const long _cacheIndex_Initial_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start = 5795587303891125365L;

    private IEnumerable<Observation> Initial_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);

        bool? b_(Observation GlucoseResult600) {
            Id d_ = GlucoseResult600?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Observation> f_ = this.Glucose_Tests_Earlier_Than_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);

            bool? g_(Observation @this) {
                string m_ = (@this is Resource
                    ? (@this as Resource).IdElement
                    : default)?.Value;
                bool? n_ = context.Operators.Not((bool?)(m_ is null));
                return n_;
            }

            IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);

            string i_(Observation @this) {
                string o_ = (@this is Resource
                    ? (@this as Resource).IdElement
                    : default)?.Value;
                return o_;
            }

            IEnumerable<string> j_ = context.Operators.Select<Observation, string>(h_, i_);
            bool? k_ = context.Operators.In<string>(e_, j_);
            bool? l_ = context.Operators.Not(k_);
            return l_;
        }

        IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter with Glucose Greater Than 600 within 1 Hour Prior To and 6 Hours After Encounter Start")]
    public IEnumerable<Encounter> Encounter_with_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start, Encounter_with_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start_Compute);

    private const long _cacheIndex_Encounter_with_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start = -1965379167146218943L;

    private IEnumerable<Encounter> Encounter_with_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        IEnumerable<Observation> b_ = this.Initial_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        IEnumerable<ValueTuple<Encounter, Observation>> c_ = context.Operators.CrossJoin<Encounter, Observation>(a_, b_);

        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)? d_(ValueTuple<Encounter, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)? k_ = (CqlTupleMetadata_FKMcFMaULYFKDORcVDcXWYTVb, _valueTuple.Item1, _valueTuple.Item2);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)?> e_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)?>(c_, d_);

        bool? f_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)? tuple_olaiqtwvfyenjplsytlpsbjd) {
            DataType l_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Value;
            object m_ = FHIRHelpers_4_4_000.Instance.ToValue(context, l_);
            CqlQuantity n_ = context.Operators.Quantity(600m, "mg/dL");
            bool? o_ = context.Operators.Greater(m_ as CqlQuantity, n_);
            Code<ObservationStatus> p_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.StatusElement;
            ObservationStatus? q_ = p_?.Value;
            string r_ = context.Operators.Convert<string>(q_);
            string[] s_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
            bool? u_ = context.Operators.And(o_, t_);

            object v_() {

                bool ai_() {
                    DataType al_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                    object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                    bool an_ = am_ is CqlDateTime;
                    return an_;
                }


                bool aj_() {
                    DataType ao_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                    bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                    return aq_;
                }


                bool ak_() {
                    DataType ar_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                    object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                    bool at_ = as_ is CqlDateTime;
                    return at_;
                }

                if (ai_())
                {
                    DataType au_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                    return (av_ as CqlDateTime) as object;
                }
                else if (aj_())
                {
                    DataType aw_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    return (ax_ as CqlInterval<CqlDateTime>) as object;
                }
                else if (ak_())
                {
                    DataType ay_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    return (az_ as CqlDateTime) as object;
                }
                else
                {
                    return null;
                };
            }

            CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_());
            CqlInterval<CqlDateTime> x_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_olaiqtwvfyenjplsytlpsbjd?.InpatientHospitalization);
            CqlDateTime y_ = context.Operators.Start(x_);
            CqlQuantity z_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
            CqlDateTime ac_ = context.Operators.Start(x_);
            CqlQuantity ad_ = context.Operators.Quantity(6m, "hours");
            CqlDateTime ae_ = context.Operators.Add(ac_, ad_);
            CqlInterval<CqlDateTime> af_ = context.Operators.Interval(aa_, ae_, true, true);
            bool? ag_ = context.Operators.In<CqlDateTime>(w_, af_, (string)default);
            bool? ah_ = context.Operators.And(u_, ag_);
            return ah_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)? tuple_olaiqtwvfyenjplsytlpsbjd) => tuple_olaiqtwvfyenjplsytlpsbjd?.InpatientHospitalization;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)?, Encounter>(g_, h_);
        IEnumerable<Encounter> j_ = context.Operators.Distinct<Encounter>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Comfort_Measures_during_Hospitalization, Encounter_with_Comfort_Measures_during_Hospitalization_Compute);

    private const long _cacheIndex_Encounter_with_Comfort_Measures_during_Hospitalization = 303491686886077261L;

    private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        IEnumerable<Encounter> b_(Encounter InpatientHospitalization) {
            IEnumerable<object> d_ = this.Comfort_Measures_Care(context);

            bool? e_(object ComfortCare) {

                object i_() {

                    bool q_() {
                        object u_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                        object v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
                        bool w_ = v_ is CqlDateTime;
                        return w_;
                    }


                    bool r_() {
                        object x_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                        object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                        bool z_ = y_ is CqlInterval<CqlDateTime>;
                        return z_;
                    }


                    bool s_() {
                        object aa_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        bool ac_ = ab_ is CqlQuantity;
                        return ac_;
                    }


                    bool t_() {
                        object ad_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                        object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                        bool af_ = ae_ is CqlInterval<CqlQuantity>;
                        return af_;
                    }

                    if (q_())
                    {
                        object ag_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                        object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                        return (ah_ as CqlDateTime) as object;
                    }
                    else if (r_())
                    {
                        object ai_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        return (aj_ as CqlInterval<CqlDateTime>) as object;
                    }
                    else if (s_())
                    {
                        object ak_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                        object al_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ak_);
                        return (al_ as CqlQuantity) as object;
                    }
                    else if (t_())
                    {
                        object am_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        return (an_ as CqlInterval<CqlQuantity>) as object;
                    }
                    else
                    {
                        return null;
                    };
                }

                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_());
                object k_ = context.Operators.LateBoundProperty<object>(ComfortCare, "authoredOn");
                CqlDateTime l_ = context.Operators.LateBoundProperty<CqlDateTime>(k_, "value");
                CqlInterval<CqlDateTime> m_ = QICoreCommon_4_0_000.Instance.toInterval(context, l_ as object);
                CqlDateTime n_ = context.Operators.Start(j_ ?? m_);
                CqlInterval<CqlDateTime> o_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientHospitalization);
                bool? p_ = context.Operators.In<CqlDateTime>(n_, o_, (string)default);
                return p_;
            }

            IEnumerable<object> f_ = context.Operators.Where<object>(d_, e_);
            Encounter g_(object ComfortCare) => InpatientHospitalization;
            IEnumerable<Encounter> h_ = context.Operators.Select<object, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter with Discharge for Hospice Care")]
    public IEnumerable<Encounter> Encounter_with_Discharge_for_Hospice_Care(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Discharge_for_Hospice_Care, Encounter_with_Discharge_for_Hospice_Care_Compute);

    private const long _cacheIndex_Encounter_with_Discharge_for_Hospice_Care = -7774025309467910766L;

    private IEnumerable<Encounter> Encounter_with_Discharge_for_Hospice_Care_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        bool? b_(Encounter InpatientHospitalization) {
            Encounter.HospitalizationComponent d_ = InpatientHospitalization?.Hospitalization;
            CodeableConcept e_ = d_?.DischargeDisposition;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            CqlValueSet g_ = this.Discharged_to_Home_for_Hospice_Care(context);
            bool? h_ = context.Operators.ConceptInValueSet(f_, g_);
            CodeableConcept j_ = d_?.DischargeDisposition;
            CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
            CqlValueSet l_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
            bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
            bool? n_ = context.Operators.Or(h_, m_);
            return n_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter with Early Glucose Greater Than 600 or with Comfort or Hospice Care")]
    public IEnumerable<Encounter> Encounter_with_Early_Glucose_Greater_Than_600_or_with_Comfort_or_Hospice_Care(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Early_Glucose_Greater_Than_600_or_with_Comfort_or_Hospice_Care, Encounter_with_Early_Glucose_Greater_Than_600_or_with_Comfort_or_Hospice_Care_Compute);

    private const long _cacheIndex_Encounter_with_Early_Glucose_Greater_Than_600_or_with_Comfort_or_Hospice_Care = 416002231575984364L;

    private IEnumerable<Encounter> Encounter_with_Early_Glucose_Greater_Than_600_or_with_Comfort_or_Hospice_Care_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Glucose_Greater_Than_600_within_1_Hour_Prior_To_and_6_Hours_After_Encounter_Start(context);
        IEnumerable<Encounter> b_ = this.Encounter_with_Comfort_Measures_during_Hospitalization(context);
        IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
        IEnumerable<Encounter> d_ = this.Encounter_with_Discharge_for_Hospice_Care(context);
        IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);
        return e_;
    }


    [CqlExpressionDefinition("Denominator Exclusions")]
    public IEnumerable<Encounter> Denominator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator_Exclusions, Denominator_Exclusions_Compute);

    private const long _cacheIndex_Denominator_Exclusions = 4022143406255911612L;

    private IEnumerable<Encounter> Denominator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Early_Glucose_Greater_Than_600_or_with_Comfort_or_Hospice_Care(context);
        return a_;
    }


    [CqlExpressionDefinition("Encounter with Hyperglycemic Events")]
    public IEnumerable<Encounter> Encounter_with_Hyperglycemic_Events(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Hyperglycemic_Events, Encounter_with_Hyperglycemic_Events_Compute);

    private const long _cacheIndex_Encounter_with_Hyperglycemic_Events = 1289983699327402958L;

    private IEnumerable<Encounter> Encounter_with_Hyperglycemic_Events_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> a_ = this.Days_with_Hyperglycemic_Events(context);

        bool? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays) {
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> g_ = HyperglycemicEventDays?.eligibleEventDays;

            bool? h_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay) {
                bool? k_ = EligibleEventDay?.hasHyperglycemicEvent;
                return k_;
            }

            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> i_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(g_, h_);
            bool? j_ = context.Operators.Exists<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);

        Encounter d_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays) {
            Encounter l_ = HyperglycemicEventDays?.encounter;
            return l_;
        }

        IEnumerable<Encounter> e_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(c_, d_);
        IEnumerable<Encounter> f_ = context.Operators.Distinct<Encounter>(e_);
        return f_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -2970454508190221261L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Hyperglycemic_Events(context);
        return a_;
    }


    [CqlExpressionDefinition("Numerator Exclusions")]
    public IEnumerable<Encounter> Numerator_Exclusions(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator_Exclusions, Numerator_Exclusions_Compute);

    private const long _cacheIndex_Numerator_Exclusions = 6365718929205200928L;

    private IEnumerable<Encounter> Numerator_Exclusions_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_with_Early_Glucose_Greater_Than_600_or_with_Comfort_or_Hospice_Care(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 3041832537513526980L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -7627385374798725450L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 10806095760957209L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -2186118687028508057L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlFunctionDefinition("Denominator Observations")]
    public int? Denominator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {

        int? a_() {

            bool b_() {
                string c_ = (QualifyingEncounter is Resource
                    ? (QualifyingEncounter as Resource).IdElement
                    : default)?.Value;
                IEnumerable<Encounter> d_ = this.Denominator_Exclusions(context);

                bool? e_(Encounter @this) {
                    string j_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? k_ = context.Operators.Not((bool?)(j_ is null));
                    return k_;
                }

                IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);

                string g_(Encounter @this) {
                    string l_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return l_;
                }

                IEnumerable<string> h_ = context.Operators.Select<Encounter, string>(f_, g_);
                bool? i_ = context.Operators.In<string>(c_, h_);
                return i_ ?? false;
            }

            if (b_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> m_ = this.Days_with_Hyperglycemic_Events(context);

                bool? n_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                    Encounter t_ = EncounterWithEventDays?.encounter;
                    bool? u_ = context.Operators.Equal(t_, QualifyingEncounter);
                    return u_;
                }

                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> o_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(m_, n_);
                int? p_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) => 0;
                IEnumerable<int?> q_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(o_, p_);
                IEnumerable<int?> r_ = context.Operators.Distinct<int?>(q_);
                int? s_ = context.Operators.SingletonFrom<int?>(r_);
                return s_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> v_ = this.Days_with_Hyperglycemic_Events(context);

                bool? w_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                    Encounter ac_ = EncounterWithEventDays?.encounter;
                    bool? ad_ = context.Operators.Equal(ac_, QualifyingEncounter);
                    return ad_;
                }

                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> x_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(v_, w_);

                int? y_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> ae_ = EncounterWithEventDays?.eligibleEventDays;
                    int? af_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(ae_);
                    return af_;
                }

                IEnumerable<int?> z_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(x_, y_);
                IEnumerable<int?> aa_ = context.Operators.Distinct<int?>(z_);
                int? ab_ = context.Operators.SingletonFrom<int?>(aa_);
                return ab_;
            };
        }

        return a_();
    }


    [CqlFunctionDefinition("Numerator Observations")]
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {

        int? a_() {

            bool b_() {
                string c_ = (QualifyingEncounter is Resource
                    ? (QualifyingEncounter as Resource).IdElement
                    : default)?.Value;
                IEnumerable<Encounter> d_ = this.Denominator_Exclusions(context);

                bool? e_(Encounter @this) {
                    string j_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    bool? k_ = context.Operators.Not((bool?)(j_ is null));
                    return k_;
                }

                IEnumerable<Encounter> f_ = context.Operators.Where<Encounter>(d_, e_);

                string g_(Encounter @this) {
                    string l_ = (@this is Resource
                        ? (@this as Resource).IdElement
                        : default)?.Value;
                    return l_;
                }

                IEnumerable<string> h_ = context.Operators.Select<Encounter, string>(f_, g_);
                bool? i_ = context.Operators.In<string>(c_, h_);
                return i_ ?? false;
            }

            if (b_())
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> m_ = this.Days_with_Hyperglycemic_Events(context);

                bool? n_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                    Encounter t_ = EncounterWithEventDays?.encounter;
                    bool? u_ = context.Operators.Equal(t_, QualifyingEncounter);
                    return u_;
                }

                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> o_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(m_, n_);
                int? p_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) => 0;
                IEnumerable<int?> q_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(o_, p_);
                IEnumerable<int?> r_ = context.Operators.Distinct<int?>(q_);
                int? s_ = context.Operators.SingletonFrom<int?>(r_);
                return s_;
            }
            else
            {
                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> v_ = this.Days_with_Hyperglycemic_Events(context);

                bool? w_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                    Encounter ac_ = EncounterWithEventDays?.encounter;
                    bool? ad_ = context.Operators.Equal(ac_, QualifyingEncounter);
                    return ad_;
                }

                IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> x_ = context.Operators.Where<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(v_, w_);

                int? y_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> ae_ = EncounterWithEventDays?.eligibleEventDays;

                    bool? af_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay) {
                        bool? ai_ = EligibleEventDay?.hasHyperglycemicEvent;
                        return ai_;
                    }

                    IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> ag_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(ae_, af_);
                    int? ah_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(ag_);
                    return ah_;
                }

                IEnumerable<int?> z_ = context.Operators.Select<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(x_, y_);
                IEnumerable<int?> aa_ = context.Operators.Distinct<int?>(z_);
                int? ab_ = context.Operators.SingletonFrom<int?>(aa_);
                return ab_;
            };
        }

        return a_();
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS871FHIRHHHyper_1_0_000() {}

    public static CMS871FHIRHHHyper_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS871FHIRHHHyper";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO = new(
       [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?), typeof(bool?), typeof(bool?)],
       ["dayNumber", "dayPeriod", "hasSevereResult", "hasElevatedResult", "hasNoGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG = new(
       [typeof((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?), typeof(MedicationAdministration)],
       ["Hospitalization", "HypoglycemicMed"]);

    private static CqlTupleMetadata CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH = new(
       [typeof(Encounter), typeof(Observation)],
       ["InpatientHospitalization", "GlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd = new(
       [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>)],
       ["encounter", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_FKMcFMaULYFKDORcVDcXWYTVb = new(
       [typeof(Encounter), typeof(Observation)],
       ["InpatientHospitalization", "EarlyGlucoseResult"]);

    private static CqlTupleMetadata CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY = new(
       [typeof(int?), typeof(CqlInterval<CqlDateTime>), typeof(bool?)],
       ["dayIndex", "dayPeriod", "hasHyperglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_GABJOQOeJbjRSJMaADeBWVJQa = new(
       [typeof(Encounter), typeof(Observation), typeof(Observation)],
       ["InpatientHospitalization", "GlucoseResult600", "EarlierGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK = new(
       [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>)],
       ["encounter", "relevantPeriod", "eligibleEventDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU = new(
       [typeof(Encounter), typeof(CqlInterval<CqlDateTime>), typeof(CqlInterval<CqlDateTime>), typeof(IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?>)],
       ["encounter", "hospitalizationPeriod", "relevantPeriod", "relevantDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ = new(
       [typeof(Encounter), typeof(CqlInterval<CqlDateTime>)],
       ["encounter", "hospitalizationPeriod"]);

    #endregion CqlTupleMetadata Properties

}
