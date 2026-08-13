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
            Code<EventStatus> i_ = ProcedureCM?.StatusElement;
            EventStatus? j_ = i_?.Value;
            string k_ = context.Operators.Convert<string>(j_);
            bool? l_ = context.Operators.Equal(k_, "completed");
            return l_;
        }

        IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
        IEnumerable<ServiceRequest> e_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));

        bool? f_(ServiceRequest ServiceReq) {
            Code<RequestStatus> m_ = ServiceReq?.StatusElement;
            RequestStatus? n_ = m_?.Value;
            Code<RequestStatus> o_ = context.Operators.Convert<Code<RequestStatus>>(n_);
            string p_ = context.Operators.Convert<string>(o_);
            string[] q_ = [
                "active",
                "completed",
            ];
            bool? r_ = context.Operators.In<string>(p_, (IEnumerable<string>)q_);
            return r_;
        }

        IEnumerable<ServiceRequest> g_ = context.Operators.Where<ServiceRequest>(e_, f_);
        IEnumerable<object> h_ = context.Operators.Union<object>(d_ as IEnumerable<object>, g_ as IEnumerable<object>);
        return h_;
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
            bool? o_;
            // CQL 'and' (212:11-213:75): right operand skipped when left is false
            if (n_ is false)
            {
                o_ = false;
            }
            else
            {
                Period p_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> q_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, p_);
                CqlDateTime r_ = context.Operators.End(q_);
                CqlInterval<CqlDateTime> s_ = this.Measurement_Period(context);
                bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, "day");
                o_ = n_ & t_;
            }
            // CQL 'and' (212:5-214:48): right operand skipped when left is false
            if (o_ is false)
            {
                return false;
            }
            else
            {
                Code<Encounter.EncounterStatus> u_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? v_ = u_?.Value;
                Code<Encounter.EncounterStatus> w_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(v_);
                bool? x_ = context.Operators.Equal(w_, "finished");
                return o_ & x_;
            }
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
            CqlInterval<CqlDateTime> d_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, QualifyingHospitalization);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? e_ = (CqlTupleMetadata_GPLfQTPONQabPZigKbYFERDVQ, QualifyingHospitalization, d_);
            return e_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter with Existing Diabetes Diagnosis")]
    public IEnumerable<Encounter> Encounter_with_Existing_Diabetes_Diagnosis(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Existing_Diabetes_Diagnosis, Encounter_with_Existing_Diabetes_Diagnosis_Compute);

    private const long _cacheIndex_Encounter_with_Existing_Diabetes_Diagnosis = 8371829728228279353L;

    private IEnumerable<Encounter> Encounter_with_Existing_Diabetes_Diagnosis_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Encounter_with_Hospitalization_Period(context);

        bool? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization) {
            CqlValueSet f_ = this.Diabetes(context);
            IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-encounter-diagnosis"));

            bool? h_(Condition DiabetesEncounter) {
                Encounter p_ = Hospitalization?.encounter;
                List<ResourceReference> q_ = p_?.ReasonReference;
                bool? r_ = QICoreCommon_4_0_000.Instance.references(context, (IEnumerable<ResourceReference>)q_, DiabetesEncounter);
                bool? s_;
                // CQL 'or' (121:15-123:9): right operand skipped when left is true
                if (r_ is true)
                {
                    s_ = true;
                }
                else
                {
                    Encounter t_ = Hospitalization?.encounter;
                    List<CodeableConcept> u_ = t_?.ReasonCode;

                    CqlConcept v_(CodeableConcept @this) {
                        CqlConcept z_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return z_;
                    }

                    IEnumerable<CqlConcept> w_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)u_, v_);
                    CqlValueSet x_ = this.Diabetes(context);
                    bool? y_ = context.Operators.ConceptsInValueSet(w_, x_);
                    s_ = r_ | y_;
                }
                // CQL 'and' (121:9-124:113): right operand skipped when left is false
                if (s_ is false)
                {
                    return false;
                }
                else
                {
                    CqlInterval<CqlDateTime> aa_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesEncounter as Condition);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    CqlInterval<CqlDateTime> ac_ = Hospitalization?.hospitalizationPeriod;
                    CqlDateTime ad_ = context.Operators.End(ac_);
                    bool? ae_ = context.Operators.Before(ab_, ad_, (string)default);
                    return s_ & ae_;
                }
            }

            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? k_(Condition DiabetesProblem) {
                CodeableConcept af_ = DiabetesProblem?.VerificationStatus;
                CqlConcept ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, af_);
                CqlCode ah_ = QICoreCommon_4_0_000.Instance.confirmed(context);
                CqlConcept ai_ = context.Operators.ConvertCodeToConcept(ah_);
                bool? aj_ = context.Operators.Equivalent(ag_, ai_);
                bool? ak_;
                // CQL 'or' (127:74-128:80): right operand skipped when left is true
                if (aj_ is true)
                {
                    ak_ = true;
                }
                else
                {
                    CodeableConcept ap_ = DiabetesProblem?.VerificationStatus;
                    CqlConcept aq_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ap_);
                    CqlCode ar_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                    CqlConcept as_ = context.Operators.ConvertCodeToConcept(ar_);
                    bool? at_ = context.Operators.Equivalent(aq_, as_);
                    ak_ = aj_ | at_;
                }
                bool? al_;
                // CQL 'or' (127:74-129:80): right operand skipped when left is true
                if (ak_ is true)
                {
                    al_ = true;
                }
                else
                {
                    CodeableConcept au_ = DiabetesProblem?.VerificationStatus;
                    CqlConcept av_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, au_);
                    CqlCode aw_ = QICoreCommon_4_0_000.Instance.provisional(context);
                    CqlConcept ax_ = context.Operators.ConvertCodeToConcept(aw_);
                    bool? ay_ = context.Operators.Equivalent(av_, ax_);
                    al_ = ak_ | ay_;
                }
                bool? am_;
                // CQL 'or' (127:72-131:11): right operand skipped when left is true
                if (al_ is true)
                {
                    am_ = true;
                }
                else
                {
                    CodeableConcept az_ = DiabetesProblem?.VerificationStatus;
                    CqlConcept ba_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, az_);
                    CqlCode bb_ = QICoreCommon_4_0_000.Instance.differential(context);
                    CqlConcept bc_ = context.Operators.ConvertCodeToConcept(bb_);
                    bool? bd_ = context.Operators.Equivalent(ba_, bc_);
                    am_ = al_ | bd_;
                }
                bool? an_;
                // CQL 'and' (127:72-132:113): right operand skipped when left is false
                if (am_ is false)
                {
                    an_ = false;
                }
                else
                {
                    CqlInterval<CqlDateTime> be_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesProblem as Condition);
                    CqlDateTime bf_ = context.Operators.Start(be_);
                    CqlInterval<CqlDateTime> bg_ = Hospitalization?.hospitalizationPeriod;
                    CqlDateTime bh_ = context.Operators.End(bg_);
                    bool? bi_ = context.Operators.Before(bf_, bh_, (string)default);
                    an_ = am_ & bi_;
                }
                bool? ao_ = context.Operators.Implies(!((bool?)(ag_ is null)), an_);
                return ao_;
            }

            IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
            IEnumerable<Condition> m_ = context.Operators.Union<Condition>(i_ as IEnumerable<Condition>, l_ as IEnumerable<Condition>);

            bool? n_(Condition DiabetesCondition) {
                ResourceReference bj_ = DiabetesCondition?.Subject;
                FhirString bk_ = bj_?.ReferenceElement;
                string bl_ = bk_?.Value;
                Encounter bm_ = Hospitalization?.encounter;
                ResourceReference bn_ = bm_?.Subject;
                FhirString bo_ = bn_?.ReferenceElement;
                string bp_ = bo_?.Value;
                bool? bq_ = context.Operators.Equal(bl_, bp_);
                return bq_;
            }

            bool? o_ = context.Operators.WhereAny<Condition>(m_, n_);
            return o_;
        }


        Encounter c_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization) {
            Encounter br_ = Hospitalization?.encounter;
            return br_;
        }

        IEnumerable<Encounter> d_ = context.Operators.WhereSelect<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(a_, b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
    }


    [CqlExpressionDefinition("Encounter with Hypoglycemic Medication")]
    public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Hypoglycemic_Medication, Encounter_with_Hypoglycemic_Medication_Compute);

    private const long _cacheIndex_Encounter_with_Hypoglycemic_Medication = -6862387996649634919L;

    private IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Encounter_with_Hospitalization_Period(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? c_(MedicationAdministration MR) {
            IEnumerable<Medication> n_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? o_(Medication M) {
                object q_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object r_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> s_ = context.Operators.Split((string)r_, "/");
                string t_ = context.Operators.Last<string>(s_);
                bool? u_ = context.Operators.Equal(q_, t_);
                // CQL 'and': right operand skipped when left is false
                if (u_ is false)
                {
                    return false;
                }
                else
                {
                    CodeableConcept v_ = M?.Code;
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, v_);
                    CqlValueSet x_ = this.Hypoglycemics_Treatment_Medications(context);
                    bool? y_ = context.Operators.ConceptInValueSet(w_, x_);
                    return u_ & y_;
                }
            }

            bool? p_ = context.Operators.WhereAny<Medication>(n_, o_);
            return p_;
        }

        IEnumerable<MedicationAdministration> d_ = context.Operators.Where<MedicationAdministration>(b_, c_);
        CqlValueSet e_ = this.Hypoglycemics_Treatment_Medications(context);
        IEnumerable<MedicationAdministration> f_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, e_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> g_ = context.Operators.Union<MedicationAdministration>(d_, f_);
        IEnumerable<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>> h_ = context.Operators.CrossJoin<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>(a_, g_);

        (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? i_(ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration> _valueTuple) {
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? z_ = (CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG, _valueTuple.Item1, _valueTuple.Item2);
            return z_;
        }


        bool? j_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> aa_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ab_ = aa_?.Value;
            string ac_ = context.Operators.Convert<string>(ab_);
            string[] ad_ = [
                "completed",
                "in-progress",
            ];
            bool? ae_ = context.Operators.In<string>(ac_, (IEnumerable<string>)ad_);
            // CQL 'and' (164:5-165:95): right operand skipped when left is false
            if (ae_ is false)
            {
                return false;
            }
            else
            {
                CqlInterval<CqlDateTime> af_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.hospitalizationPeriod;
                DataType ag_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.Effective;
                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                CqlInterval<CqlDateTime> ai_ = QICoreCommon_4_0_000.Instance.toInterval(context, ah_);
                bool? aj_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(af_, ai_, (string)default);
                return ae_ & aj_;
            }
        }

        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> k_ = context.Operators.SelectWhere<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(h_, i_, j_);

        Encounter l_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig) {
            Encounter ak_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.encounter;
            return ak_;
        }

        IEnumerable<Encounter> m_ = context.Operators.SelectDistinct<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?, Encounter>(k_, l_);
        return m_;
    }


    [CqlExpressionDefinition("Encounter with Elevated Glucose Greater Than or Equal to 200")]
    public IEnumerable<Encounter> Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200, Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200_Compute);

    private const long _cacheIndex_Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200 = 5212261220385973189L;

    private IEnumerable<Encounter> Encounter_with_Elevated_Glucose_Greater_Than_or_Equal_to_200_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?> a_ = this.Encounter_with_Hospitalization_Period(context);

        bool? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization) {
            CqlValueSet f_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
            IEnumerable<Observation> g_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

            bool? h_(Observation GlucoseTest) {
                object j_;
                DataType o_ = GlucoseTest?.Effective;
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlDateTime;
                if (q_)
                {
                    DataType r_ = GlucoseTest?.Effective;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    j_ = s_ as CqlDateTime;
                }
                else
                {
                    DataType t_ = GlucoseTest?.Effective;
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlDateTime;
                    if (v_)
                    {
                        DataType w_ = GlucoseTest?.Effective;
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        j_ = x_ as CqlDateTime;
                    }
                    else
                    {
                        DataType y_ = GlucoseTest?.Effective;
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlInterval<CqlDateTime>;
                        if (aa_)
                        {
                            DataType ab_ = GlucoseTest?.Effective;
                            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            j_ = ac_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            j_ = null;
                        }
                    }
                }
                CqlDateTime k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_);
                CqlInterval<CqlDateTime> l_ = Hospitalization?.hospitalizationPeriod;
                bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, (string)default);
                bool? n_;
                // CQL 'and' (113:17-114:69): right operand skipped when left is false
                if (m_ is false)
                {
                    n_ = false;
                }
                else
                {
                    Code<ObservationStatus> ad_ = GlucoseTest?.StatusElement;
                    ObservationStatus? ae_ = ad_?.Value;
                    string af_ = context.Operators.Convert<string>(ae_);
                    string[] ag_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ah_ = context.Operators.In<string>(af_, (IEnumerable<string>)ag_);
                    n_ = m_ & ah_;
                }
                // CQL 'and' (113:17-115:44): right operand skipped when left is false
                if (n_ is false)
                {
                    return false;
                }
                else
                {
                    DataType ai_ = GlucoseTest?.Value;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    CqlQuantity ak_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? al_ = context.Operators.GreaterOrEqual(aj_ as CqlQuantity, ak_);
                    return n_ & al_;
                }
            }

            bool? i_ = context.Operators.WhereAny<Observation>(g_, h_);
            return i_;
        }


        Encounter c_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization) {
            Encounter am_ = Hospitalization?.encounter;
            return am_;
        }

        IEnumerable<Encounter> d_ = context.Operators.WhereSelect<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, Encounter>(a_, b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
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
        CqlQuantity c_ = context.Operators.Quantity(10m, "days");
        CqlDateTime d_ = context.Operators.Add(a_, c_);
        CqlDateTime[] e_ = [
            b_,
            d_,
        ];
        CqlDateTime f_ = context.Operators.Min<CqlDateTime>((IEnumerable<CqlDateTime>)e_);
        CqlInterval<CqlDateTime> g_ = context.Operators.Interval(a_, f_, true, true);
        return g_;
    }


    [CqlExpressionDefinition("Days in Hospitalization")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Days_in_Hospitalization(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Days_in_Hospitalization, Days_in_Hospitalization_Compute);

    private const long _cacheIndex_Days_in_Hospitalization = -5552137013729529852L;

    private IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> Days_in_Hospitalization_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Measurement_Population(context);

        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? b_(Encounter EligibleInpatientHospitalization) {
            CqlInterval<CqlDateTime> d_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, EligibleInpatientHospitalization);
            CqlInterval<CqlDateTime> e_ = this.hospitalDaysMax10(context, d_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> f_ = QICoreCommon_4_0_000.Instance.daysInPeriod(context, e_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? g_ = (CqlTupleMetadata_GPAhHPfDKIJRYDEIWbaMLZGHU, EligibleInpatientHospitalization, d_, e_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> c_ = context.Operators.SelectDistinct<Encounter, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Days with Glucose Results")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> Days_with_Glucose_Results(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Days_with_Glucose_Results, Days_with_Glucose_Results_Compute);

    private const long _cacheIndex_Days_with_Glucose_Results = -1534215195981936569L;

    private IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> Days_with_Glucose_Results_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?> a_ = this.Days_in_Hospitalization(context);

        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)? InpatientHospitalDays) {
            Encounter d_ = InpatientHospitalDays?.encounter;
            CqlInterval<CqlDateTime> e_ = InpatientHospitalDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> f_ = InpatientHospitalDays?.relevantDays;

            (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? g_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)? EncounterDay) {
                int? j_ = EncounterDay?.dayIndex;
                CqlInterval<CqlDateTime> k_ = EncounterDay?.dayPeriod;
                CqlValueSet l_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
                IEnumerable<Observation> m_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));

                bool? n_(Observation GlucoseTest) {
                    Code<ObservationStatus> u_ = GlucoseTest?.StatusElement;
                    ObservationStatus? v_ = u_?.Value;
                    string w_ = context.Operators.Convert<string>(v_);
                    string[] x_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? y_ = context.Operators.In<string>(w_, (IEnumerable<string>)x_);
                    bool? z_;
                    // CQL 'and' (52:23-53:53): right operand skipped when left is false
                    if (y_ is false)
                    {
                        z_ = false;
                    }
                    else
                    {
                        DataType aa_ = GlucoseTest?.Value;
                        object ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        CqlQuantity ac_ = context.Operators.Quantity(300m, "mg/dL");
                        bool? ad_ = context.Operators.Greater(ab_ as CqlQuantity, ac_);
                        z_ = y_ & ad_;
                    }
                    // CQL 'and' (52:17-54:86): right operand skipped when left is false
                    if (z_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        object ae_;
                        DataType ai_ = GlucoseTest?.Effective;
                        object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                        bool ak_ = aj_ is CqlDateTime;
                        if (ak_)
                        {
                            DataType al_ = GlucoseTest?.Effective;
                            object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                            ae_ = am_ as CqlDateTime;
                        }
                        else
                        {
                            DataType an_ = GlucoseTest?.Effective;
                            object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                            bool ap_ = ao_ is CqlDateTime;
                            if (ap_)
                            {
                                DataType aq_ = GlucoseTest?.Effective;
                                object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                                ae_ = ar_ as CqlDateTime;
                            }
                            else
                            {
                                DataType as_ = GlucoseTest?.Effective;
                                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                                bool au_ = at_ is CqlInterval<CqlDateTime>;
                                if (au_)
                                {
                                    DataType av_ = GlucoseTest?.Effective;
                                    object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                                    ae_ = aw_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    ae_ = null;
                                }
                            }
                        }
                        CqlDateTime af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
                        CqlInterval<CqlDateTime> ag_ = EncounterDay?.dayPeriod;
                        bool? ah_ = context.Operators.In<CqlDateTime>(af_, ag_, (string)default);
                        return z_ & ah_;
                    }
                }

                bool? o_ = context.Operators.WhereAny<Observation>(m_, n_);

                bool? p_(Observation GlucoseTest) {
                    Code<ObservationStatus> ax_ = GlucoseTest?.StatusElement;
                    ObservationStatus? ay_ = ax_?.Value;
                    string az_ = context.Operators.Convert<string>(ay_);
                    string[] ba_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bb_ = context.Operators.In<string>(az_, (IEnumerable<string>)ba_);
                    bool? bc_;
                    // CQL 'and' (57:23-58:54): right operand skipped when left is false
                    if (bb_ is false)
                    {
                        bc_ = false;
                    }
                    else
                    {
                        DataType bd_ = GlucoseTest?.Value;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        CqlQuantity bf_ = context.Operators.Quantity(200m, "mg/dL");
                        bool? bg_ = context.Operators.GreaterOrEqual(be_ as CqlQuantity, bf_);
                        bc_ = bb_ & bg_;
                    }
                    // CQL 'and' (57:17-59:86): right operand skipped when left is false
                    if (bc_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        object bh_;
                        DataType bl_ = GlucoseTest?.Effective;
                        object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                        bool bn_ = bm_ is CqlDateTime;
                        if (bn_)
                        {
                            DataType bo_ = GlucoseTest?.Effective;
                            object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                            bh_ = bp_ as CqlDateTime;
                        }
                        else
                        {
                            DataType bq_ = GlucoseTest?.Effective;
                            object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                            bool bs_ = br_ is CqlDateTime;
                            if (bs_)
                            {
                                DataType bt_ = GlucoseTest?.Effective;
                                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                                bh_ = bu_ as CqlDateTime;
                            }
                            else
                            {
                                DataType bv_ = GlucoseTest?.Effective;
                                object bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
                                bool bx_ = bw_ is CqlInterval<CqlDateTime>;
                                if (bx_)
                                {
                                    DataType by_ = GlucoseTest?.Effective;
                                    object bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                                    bh_ = bz_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bh_ = null;
                                }
                            }
                        }
                        CqlDateTime bi_ = QICoreCommon_4_0_000.Instance.earliest(context, bh_);
                        CqlInterval<CqlDateTime> bj_ = EncounterDay?.dayPeriod;
                        bool? bk_ = context.Operators.In<CqlDateTime>(bi_, bj_, (string)default);
                        return bc_ & bk_;
                    }
                }

                bool? q_ = context.Operators.WhereAny<Observation>(m_, p_);

                bool? r_(Observation GlucoseTest) {
                    Code<ObservationStatus> ca_ = GlucoseTest?.StatusElement;
                    ObservationStatus? cb_ = ca_?.Value;
                    string cc_ = context.Operators.Convert<string>(cb_);
                    string[] cd_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ce_ = context.Operators.In<string>(cc_, (IEnumerable<string>)cd_);
                    // CQL 'and' (62:17-63:86): right operand skipped when left is false
                    if (ce_ is false)
                    {
                        return false;
                    }
                    else
                    {
                        object cf_;
                        DataType cj_ = GlucoseTest?.Effective;
                        object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                        bool cl_ = ck_ is CqlDateTime;
                        if (cl_)
                        {
                            DataType cm_ = GlucoseTest?.Effective;
                            object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                            cf_ = cn_ as CqlDateTime;
                        }
                        else
                        {
                            DataType co_ = GlucoseTest?.Effective;
                            object cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                            bool cq_ = cp_ is CqlDateTime;
                            if (cq_)
                            {
                                DataType cr_ = GlucoseTest?.Effective;
                                object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                                cf_ = cs_ as CqlDateTime;
                            }
                            else
                            {
                                DataType ct_ = GlucoseTest?.Effective;
                                object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                                bool cv_ = cu_ is CqlInterval<CqlDateTime>;
                                if (cv_)
                                {
                                    DataType cw_ = GlucoseTest?.Effective;
                                    object cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                                    cf_ = cx_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    cf_ = null;
                                }
                            }
                        }
                        CqlDateTime cg_ = QICoreCommon_4_0_000.Instance.earliest(context, cf_);
                        CqlInterval<CqlDateTime> ch_ = EncounterDay?.dayPeriod;
                        bool? ci_ = context.Operators.In<CqlDateTime>(cg_, ch_, (string)default);
                        return ce_ & ci_;
                    }
                }

                bool? s_ = context.Operators.WhereAny<Observation>(m_, r_);
                (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? t_ = (CqlTupleMetadata_BbhMZNJZUhELHSIeBfBEVUQGO, j_, k_, o_, q_, !s_);
                return t_;
            }

            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?, (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(f_, g_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? i_ = (CqlTupleMetadata_FhADCCAGbeXAiadgccRECiPBd, d_, e_, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> c_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Days with Hyperglycemic Events")]
    public IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Days_with_Hyperglycemic_Events(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Days_with_Hyperglycemic_Events, Days_with_Hyperglycemic_Events_Compute);

    private const long _cacheIndex_Days_with_Hyperglycemic_Events = 5078852559922539511L;

    private IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> Days_with_Hyperglycemic_Events_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?> a_ = this.Days_with_Glucose_Results(context);

        (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? b_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)? EncounterWithResultDays) {
            Encounter d_ = EncounterWithResultDays?.encounter;
            CqlInterval<CqlDateTime> e_ = EncounterWithResultDays?.relevantPeriod;
            IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> f_ = EncounterWithResultDays?.relevantDays;

            bool? g_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay) {
                int? l_ = EncounterDay?.dayNumber;
                bool? m_ = context.Operators.Greater(l_, 1);
                return m_;
            }


            (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? h_((CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? EncounterDay) {
                int? n_ = EncounterDay?.dayNumber;
                CqlInterval<CqlDateTime> o_ = EncounterDay?.dayPeriod;
                bool? p_ = EncounterDay?.hasSevereResult;
                bool? q_;
                // CQL 'or' (76:32-81:9): right operand skipped when left is true
                if (p_ is true)
                {
                    q_ = true;
                }
                else
                {
                    bool? s_ = EncounterDay?.hasNoGlucoseTest;
                    bool? t_;
                    // CQL 'and' (77:18-78:102): right operand skipped when left is false
                    if (s_ is false)
                    {
                        t_ = false;
                    }
                    else
                    {
                        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> v_ = EncounterWithResultDays?.relevantDays;
                        int? w_ = EncounterDay?.dayNumber;
                        int? x_ = context.Operators.Subtract(w_, 2);
                        (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? y_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(v_, x_);
                        bool? z_ = y_?.hasElevatedResult;
                        t_ = s_ & z_;
                    }
                    bool? u_;
                    // CQL 'and' (77:16-80:13): right operand skipped when left is false
                    if (t_ is false)
                    {
                        u_ = false;
                    }
                    else
                    {
                        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> aa_ = EncounterWithResultDays?.relevantDays;
                        int? ab_ = EncounterDay?.dayNumber;
                        int? ac_ = context.Operators.Subtract(ab_, 3);
                        (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? ad_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(aa_, ac_);
                        bool? ae_ = ad_?.hasElevatedResult;
                        u_ = t_ & ae_;
                    }
                    q_ = p_ | u_;
                }
                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? r_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, n_, o_, q_);
                return r_;
            }

            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> i_ = context.Operators.WhereSelect<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?, (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(f_, g_, h_);
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> j_ = context.Operators.Distinct<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(i_);
            (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? k_ = (CqlTupleMetadata_GJFejXJaZWjRVYgMbQUZgIPjK, d_, e_, j_);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> c_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> relevantDays)?, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?>(a_, b_);
        return c_;
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
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? j_ = (CqlTupleMetadata_CLZgggJGDQVFHPIfbiSZOiXTH, _valueTuple.Item1, _valueTuple.Item2);
            return j_;
        }


        bool? f_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh) {
            DataType k_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Value;
            object l_ = FHIRHelpers_4_4_000.Instance.ToValue(context, k_);
            CqlQuantity m_ = context.Operators.Quantity(600m, "mg/dL");
            bool? n_ = context.Operators.Greater(l_ as CqlQuantity, m_);
            bool? o_;
            // CQL 'and' (174:11-175:67): right operand skipped when left is false
            if (n_ is false)
            {
                o_ = false;
            }
            else
            {
                Code<ObservationStatus> p_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.StatusElement;
                ObservationStatus? q_ = p_?.Value;
                string r_ = context.Operators.Convert<string>(q_);
                string[] s_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
                o_ = n_ & t_;
            }
            // CQL 'and' (174:5-176:136): right operand skipped when left is false
            if (o_ is false)
            {
                return false;
            }
            else
            {
                object u_;
                DataType ae_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                bool ag_ = af_ is CqlDateTime;
                if (ag_)
                {
                    DataType ah_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object ai_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ah_);
                    u_ = ai_ as CqlDateTime;
                }
                else
                {
                    DataType aj_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                    object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                    bool al_ = ak_ is CqlDateTime;
                    if (al_)
                    {
                        DataType am_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                        object an_ = FHIRHelpers_4_4_000.Instance.ToValue(context, am_);
                        u_ = an_ as CqlDateTime;
                    }
                    else
                    {
                        DataType ao_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                        object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ao_);
                        bool aq_ = ap_ is CqlInterval<CqlDateTime>;
                        if (aq_)
                        {
                            DataType ar_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                            object as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
                            u_ = as_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            u_ = null;
                        }
                    }
                }
                CqlDateTime v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_);
                CqlInterval<CqlDateTime> w_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gldtpgaqprrprerabeflfanwh?.InpatientHospitalization);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlQuantity y_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime z_ = context.Operators.Subtract(x_, y_);
                CqlQuantity aa_ = context.Operators.Quantity(6m, "hours");
                CqlDateTime ab_ = context.Operators.Add(x_, aa_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(z_, ab_, true, true);
                bool? ad_ = context.Operators.In<CqlDateTime>(v_, ac_, (string)default);
                return o_ & ad_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?> g_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?>(d_, e_, f_);
        Observation h_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)? tuple_gldtpgaqprrprerabeflfanwh) => tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest;
        IEnumerable<Observation> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseTest)?, Observation>(g_, h_);
        return i_;
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
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)? k_ = (CqlTupleMetadata_GABJOQOeJbjRSJMaADeBWVJQa, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)? tuple_ghpnfyjsiaqamntcrzhgtgped) {
            object l_;
            DataType w_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
            object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
            bool y_ = x_ is CqlDateTime;
            if (y_)
            {
                DataType z_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                l_ = aa_ as CqlDateTime;
            }
            else
            {
                DataType ab_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                bool ad_ = ac_ is CqlDateTime;
                if (ad_)
                {
                    DataType ae_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                    l_ = af_ as CqlDateTime;
                }
                else
                {
                    DataType ag_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    bool ai_ = ah_ is CqlInterval<CqlDateTime>;
                    if (ai_)
                    {
                        DataType aj_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        l_ = ak_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        l_ = null;
                    }
                }
            }
            CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ghpnfyjsiaqamntcrzhgtgped?.InpatientHospitalization);
            CqlDateTime o_ = context.Operators.Start(n_);
            CqlQuantity p_ = context.Operators.Quantity(1m, "hour");
            CqlDateTime q_ = context.Operators.Subtract(o_, p_);
            CqlQuantity r_ = context.Operators.Quantity(6m, "hour");
            CqlDateTime s_ = context.Operators.Add(o_, r_);
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(q_, s_, true, true);
            bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, (string)default);
            bool? v_;
            // CQL 'and' (187:11-188:116): right operand skipped when left is false
            if (u_ is false)
            {
                v_ = false;
            }
            else
            {
                object al_;
                DataType av_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                object aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
                bool ax_ = aw_ is CqlDateTime;
                if (ax_)
                {
                    DataType ay_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                    object az_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ay_);
                    al_ = az_ as CqlDateTime;
                }
                else
                {
                    DataType ba_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                    object bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
                    bool bc_ = bb_ is CqlDateTime;
                    if (bc_)
                    {
                        DataType bd_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                        object be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                        al_ = be_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bf_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                        object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                        bool bh_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bh_)
                        {
                            DataType bi_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                            object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                            al_ = bj_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            al_ = null;
                        }
                    }
                }
                CqlDateTime am_ = QICoreCommon_4_0_000.Instance.earliest(context, al_);
                CqlInterval<CqlDateTime> an_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ghpnfyjsiaqamntcrzhgtgped?.InpatientHospitalization);
                CqlDateTime ao_ = context.Operators.Start(an_);
                CqlQuantity ap_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime aq_ = context.Operators.Subtract(ao_, ap_);
                object ar_;
                DataType bk_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                object bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                bool bm_ = bl_ is CqlDateTime;
                if (bm_)
                {
                    DataType bn_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                    ar_ = bo_ as CqlDateTime;
                }
                else
                {
                    DataType bp_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                    object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                    bool br_ = bq_ is CqlDateTime;
                    if (br_)
                    {
                        DataType bs_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                        object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                        ar_ = bt_ as CqlDateTime;
                    }
                    else
                    {
                        DataType bu_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                        object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                        bool bw_ = bv_ is CqlInterval<CqlDateTime>;
                        if (bw_)
                        {
                            DataType bx_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                            object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                            ar_ = by_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ar_ = null;
                        }
                    }
                }
                CqlDateTime as_ = QICoreCommon_4_0_000.Instance.earliest(context, ar_);
                CqlInterval<CqlDateTime> at_ = context.Operators.Interval(aq_, as_, true, false);
                bool? au_ = context.Operators.In<CqlDateTime>(am_, at_, (string)default);
                v_ = u_ & au_;
            }
            // CQL 'and' (187:5-189:54): right operand skipped when left is false
            if (v_ is false)
            {
                return false;
            }
            else
            {
                Id bz_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.IdElement;
                string ca_ = bz_?.Value;
                Id cb_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.IdElement;
                string cc_ = cb_?.Value;
                bool? cd_ = context.Operators.Equivalent(ca_, cc_);
                return v_ & !cd_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)?>(e_, f_, g_);
        Observation i_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)? tuple_ghpnfyjsiaqamntcrzhgtgped) => tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600;
        IEnumerable<Observation> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation GlucoseResult600, Observation EarlierGlucoseTest)?, Observation>(h_, i_);
        return j_;
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
                string k_ = (@this is Resource
                    ? (@this as Resource).IdElement
                    : default)?.Value;
                return !((bool?)(k_ is null));
            }


            string h_(Observation @this) {
                string l_ = (@this is Resource
                    ? (@this as Resource).IdElement
                    : default)?.Value;
                return l_;
            }

            IEnumerable<string> i_ = context.Operators.WhereSelect<Observation, string>(f_, g_, h_);
            bool? j_ = context.Operators.In<string>(e_, i_);
            return !j_;
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
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)? i_ = (CqlTupleMetadata_FKMcFMaULYFKDORcVDcXWYTVb, _valueTuple.Item1, _valueTuple.Item2);
            return i_;
        }


        bool? e_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)? tuple_olaiqtwvfyenjplsytlpsbjd) {
            DataType j_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Value;
            object k_ = FHIRHelpers_4_4_000.Instance.ToValue(context, j_);
            CqlQuantity l_ = context.Operators.Quantity(600m, "mg/dL");
            bool? m_ = context.Operators.Greater(k_ as CqlQuantity, l_);
            bool? n_;
            // CQL 'and' (141:11-142:74): right operand skipped when left is false
            if (m_ is false)
            {
                n_ = false;
            }
            else
            {
                Code<ObservationStatus> o_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.StatusElement;
                ObservationStatus? p_ = o_?.Value;
                string q_ = context.Operators.Convert<string>(p_);
                string[] r_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? s_ = context.Operators.In<string>(q_, (IEnumerable<string>)r_);
                n_ = m_ & s_;
            }
            // CQL 'and' (141:5-143:234): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                object t_;
                DataType ad_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                bool af_ = ae_ is CqlDateTime;
                if (af_)
                {
                    DataType ag_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                    object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                    t_ = ah_ as CqlDateTime;
                }
                else
                {
                    DataType ai_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                    bool ak_ = aj_ is CqlDateTime;
                    if (ak_)
                    {
                        DataType al_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                        object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                        t_ = am_ as CqlDateTime;
                    }
                    else
                    {
                        DataType an_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                        object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                        bool ap_ = ao_ is CqlInterval<CqlDateTime>;
                        if (ap_)
                        {
                            DataType aq_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                            object ar_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aq_);
                            t_ = ar_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            t_ = null;
                        }
                    }
                }
                CqlDateTime u_ = QICoreCommon_4_0_000.Instance.earliest(context, t_);
                CqlInterval<CqlDateTime> v_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_olaiqtwvfyenjplsytlpsbjd?.InpatientHospitalization);
                CqlDateTime w_ = context.Operators.Start(v_);
                CqlQuantity x_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime y_ = context.Operators.Subtract(w_, x_);
                CqlQuantity z_ = context.Operators.Quantity(6m, "hours");
                CqlDateTime aa_ = context.Operators.Add(w_, z_);
                CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(y_, aa_, true, true);
                bool? ac_ = context.Operators.In<CqlDateTime>(u_, ab_, (string)default);
                return n_ & ac_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)? tuple_olaiqtwvfyenjplsytlpsbjd) => tuple_olaiqtwvfyenjplsytlpsbjd?.InpatientHospitalization;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation EarlyGlucoseResult)?, Encounter>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter with Comfort Measures during Hospitalization")]
    public IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_with_Comfort_Measures_during_Hospitalization, Encounter_with_Comfort_Measures_during_Hospitalization_Compute);

    private const long _cacheIndex_Encounter_with_Comfort_Measures_during_Hospitalization = 303491686886077261L;

    private IEnumerable<Encounter> Encounter_with_Comfort_Measures_during_Hospitalization_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);

        bool? b_(Encounter InpatientHospitalization) {
            IEnumerable<object> d_ = this.Comfort_Measures_Care(context);

            bool? e_(object ComfortCare) {
                object g_;
                object o_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                object p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
                bool q_ = p_ is CqlDateTime;
                if (q_)
                {
                    object r_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    g_ = s_ as CqlDateTime;
                }
                else
                {
                    object t_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                    object u_ = FHIRHelpers_4_4_000.Instance.ToValue(context, t_);
                    bool v_ = u_ is CqlQuantity;
                    if (v_)
                    {
                        object w_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                        object x_ = FHIRHelpers_4_4_000.Instance.ToValue(context, w_);
                        g_ = x_ as CqlQuantity;
                    }
                    else
                    {
                        object y_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                        object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                        bool aa_ = z_ is CqlInterval<CqlDateTime>;
                        if (aa_)
                        {
                            object ab_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            g_ = ac_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            object ad_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                            object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                            bool af_ = ae_ is CqlInterval<CqlQuantity>;
                            if (af_)
                            {
                                object ag_ = context.Operators.LateBoundProperty<object>(ComfortCare, "performed");
                                object ah_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ag_);
                                g_ = ah_ as CqlInterval<CqlQuantity>;
                            }
                            else
                            {
                                g_ = null;
                            }
                        }
                    }
                }
                CqlInterval<CqlDateTime> h_ = QICoreCommon_4_0_000.Instance.toInterval(context, g_);
                object i_ = context.Operators.LateBoundProperty<object>(ComfortCare, "authoredOn");
                CqlDateTime j_ = context.Operators.LateBoundProperty<CqlDateTime>(i_, "value");
                CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                CqlDateTime l_ = context.Operators.Start(h_ ?? k_);
                CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientHospitalization);
                bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, (string)default);
                return n_;
            }

            bool? f_ = context.Operators.WhereAny<object>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
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
            // CQL 'or' (102:5-103:127): right operand skipped when left is true
            if (h_ is true)
            {
                return true;
            }
            else
            {
                Encounter.HospitalizationComponent i_ = InpatientHospitalization?.Hospitalization;
                CodeableConcept j_ = i_?.DischargeDisposition;
                CqlConcept k_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, j_);
                CqlValueSet l_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
                bool? m_ = context.Operators.ConceptInValueSet(k_, l_);
                return h_ | m_;
            }
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
            IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> f_ = HyperglycemicEventDays?.eligibleEventDays;

            bool? g_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay) {
                bool? i_ = EligibleEventDay?.hasHyperglycemicEvent;
                return i_;
            }

            bool? h_ = context.Operators.WhereAny<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(f_, g_);
            return h_;
        }


        Encounter c_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? HyperglycemicEventDays) {
            Encounter j_ = HyperglycemicEventDays?.encounter;
            return j_;
        }

        IEnumerable<Encounter> d_ = context.Operators.WhereSelect<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, Encounter>(a_, b_, c_);
        IEnumerable<Encounter> e_ = context.Operators.Distinct<Encounter>(d_);
        return e_;
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
        string a_ = (QualifyingEncounter is Resource
            ? (QualifyingEncounter as Resource).IdElement
            : default)?.Value;
        IEnumerable<Encounter> b_ = this.Denominator_Exclusions(context);

        bool? c_(Encounter @this) {
            string g_ = (@this is Resource
                ? (@this as Resource).IdElement
                : default)?.Value;
            return !((bool?)(g_ is null));
        }


        string d_(Encounter @this) {
            string h_ = (@this is Resource
                ? (@this as Resource).IdElement
                : default)?.Value;
            return h_;
        }

        IEnumerable<string> e_ = context.Operators.WhereSelect<Encounter, string>(b_, c_, d_);
        bool? f_ = context.Operators.In<string>(a_, e_);
        if (f_ ?? false)
        {
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> i_ = this.Days_with_Hyperglycemic_Events(context);

            bool? j_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                Encounter o_ = EncounterWithEventDays?.encounter;
                bool? p_ = context.Operators.Equal(o_, QualifyingEncounter);
                return p_;
            }

            int? k_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) => 0;
            IEnumerable<int?> l_ = context.Operators.WhereSelect<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(i_, j_, k_);
            IEnumerable<int?> m_ = context.Operators.Distinct<int?>(l_);
            int? n_ = context.Operators.SingletonFrom<int?>(m_);
            return n_;
        }
        else
        {
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> q_ = this.Days_with_Hyperglycemic_Events(context);

            bool? r_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                Encounter w_ = EncounterWithEventDays?.encounter;
                bool? x_ = context.Operators.Equal(w_, QualifyingEncounter);
                return x_;
            }


            int? s_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> y_ = EncounterWithEventDays?.eligibleEventDays;
                int? z_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(y_);
                return z_;
            }

            IEnumerable<int?> t_ = context.Operators.WhereSelect<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(q_, r_, s_);
            IEnumerable<int?> u_ = context.Operators.Distinct<int?>(t_);
            int? v_ = context.Operators.SingletonFrom<int?>(u_);
            return v_;
        }
    }


    [CqlFunctionDefinition("Numerator Observations")]
    public int? Numerator_Observations(CqlContext context, Encounter QualifyingEncounter)
    {
        string a_ = (QualifyingEncounter is Resource
            ? (QualifyingEncounter as Resource).IdElement
            : default)?.Value;
        IEnumerable<Encounter> b_ = this.Denominator_Exclusions(context);

        bool? c_(Encounter @this) {
            string g_ = (@this is Resource
                ? (@this as Resource).IdElement
                : default)?.Value;
            return !((bool?)(g_ is null));
        }


        string d_(Encounter @this) {
            string h_ = (@this is Resource
                ? (@this as Resource).IdElement
                : default)?.Value;
            return h_;
        }

        IEnumerable<string> e_ = context.Operators.WhereSelect<Encounter, string>(b_, c_, d_);
        bool? f_ = context.Operators.In<string>(a_, e_);
        if (f_ ?? false)
        {
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> i_ = this.Days_with_Hyperglycemic_Events(context);

            bool? j_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                Encounter o_ = EncounterWithEventDays?.encounter;
                bool? p_ = context.Operators.Equal(o_, QualifyingEncounter);
                return p_;
            }

            int? k_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) => 0;
            IEnumerable<int?> l_ = context.Operators.WhereSelect<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(i_, j_, k_);
            IEnumerable<int?> m_ = context.Operators.Distinct<int?>(l_);
            int? n_ = context.Operators.SingletonFrom<int?>(m_);
            return n_;
        }
        else
        {
            IEnumerable<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?> q_ = this.Days_with_Hyperglycemic_Events(context);

            bool? r_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                Encounter w_ = EncounterWithEventDays?.encounter;
                bool? x_ = context.Operators.Equal(w_, QualifyingEncounter);
                return x_;
            }


            int? s_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)? EncounterWithEventDays) {
                IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> y_ = EncounterWithEventDays?.eligibleEventDays;

                bool? z_((CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? EligibleEventDay) {
                    bool? ac_ = EligibleEventDay?.hasHyperglycemicEvent;
                    return ac_;
                }

                IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> aa_ = context.Operators.Where<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(y_, z_);
                int? ab_ = context.Operators.Count<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?>(aa_);
                return ab_;
            }

            IEnumerable<int?> t_ = context.Operators.WhereSelect<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> relevantPeriod, IEnumerable<(CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)?> eligibleEventDays)?, int?>(q_, r_, s_);
            IEnumerable<int?> u_ = context.Operators.Distinct<int?>(t_);
            int? v_ = context.Operators.SingletonFrom<int?>(u_);
            return v_;
        }
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
