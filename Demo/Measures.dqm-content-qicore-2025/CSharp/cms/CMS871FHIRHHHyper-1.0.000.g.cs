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

            CqlBoolean o_() {
                Period q_ = InpatientEncounter?.Period;
                CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, q_);
                CqlDateTime s_ = context.Operators.End(r_);
                CqlInterval<CqlDateTime> t_ = this.Measurement_Period(context);
                bool? u_ = context.Operators.In<CqlDateTime>(s_, t_, "day");
                return u_;
            }


            CqlBoolean p_() {
                Code<Encounter.EncounterStatus> v_ = InpatientEncounter?.StatusElement;
                Encounter.EncounterStatus? w_ = v_?.Value;
                Code<Encounter.EncounterStatus> x_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(w_);
                bool? y_ = context.Operators.Equal(x_, "finished");
                return y_;
            }

            return (bool?)(/* CQL 'and' (212:5-214:48) */ (/* CQL 'and' (212:11-213:75) */ ((CqlBoolean)n_
                && o_())
                && p_()));
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

                CqlBoolean s_() {
                    Encounter u_ = Hospitalization?.encounter;
                    List<CodeableConcept> v_ = u_?.ReasonCode;

                    CqlConcept w_(CodeableConcept @this) {
                        CqlConcept aa_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return aa_;
                    }

                    IEnumerable<CqlConcept> x_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)v_, w_);
                    CqlValueSet y_ = this.Diabetes(context);
                    bool? z_ = context.Operators.ConceptsInValueSet(x_, y_);
                    return z_;
                }


                CqlBoolean t_() {
                    CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesEncounter as Condition);
                    CqlDateTime ac_ = context.Operators.Start(ab_);
                    CqlInterval<CqlDateTime> ad_ = Hospitalization?.hospitalizationPeriod;
                    CqlDateTime ae_ = context.Operators.End(ad_);
                    bool? af_ = context.Operators.Before(ac_, ae_, (string)default);
                    return af_;
                }

                return (bool?)(/* CQL 'and' (121:9-124:113) */ (/* CQL 'or' (121:15-123:9) */ ((CqlBoolean)r_
                    || s_())
                    && t_()));
            }

            IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
            IEnumerable<Condition> j_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition-problems-health-concerns"));

            bool? k_(Condition DiabetesProblem) {
                CodeableConcept ag_ = DiabetesProblem?.VerificationStatus;
                CqlConcept ah_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ag_);

                CqlBoolean ai_() {
                    CodeableConcept aj_ = DiabetesProblem?.VerificationStatus;
                    CqlConcept ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_);
                    CqlCode al_ = QICoreCommon_4_0_000.Instance.confirmed(context);
                    CqlConcept am_ = context.Operators.ConvertCodeToConcept(al_);
                    bool? an_ = context.Operators.Equivalent(ak_, am_);

                    CqlBoolean ao_() {
                        CodeableConcept as_ = DiabetesProblem?.VerificationStatus;
                        CqlConcept at_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, as_);
                        CqlCode au_ = QICoreCommon_4_0_000.Instance.unconfirmed(context);
                        CqlConcept av_ = context.Operators.ConvertCodeToConcept(au_);
                        bool? aw_ = context.Operators.Equivalent(at_, av_);
                        return aw_;
                    }


                    CqlBoolean ap_() {
                        CodeableConcept ax_ = DiabetesProblem?.VerificationStatus;
                        CqlConcept ay_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ax_);
                        CqlCode az_ = QICoreCommon_4_0_000.Instance.provisional(context);
                        CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
                        bool? bb_ = context.Operators.Equivalent(ay_, ba_);
                        return bb_;
                    }


                    CqlBoolean aq_() {
                        CodeableConcept bc_ = DiabetesProblem?.VerificationStatus;
                        CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                        CqlCode be_ = QICoreCommon_4_0_000.Instance.differential(context);
                        CqlConcept bf_ = context.Operators.ConvertCodeToConcept(be_);
                        bool? bg_ = context.Operators.Equivalent(bd_, bf_);
                        return bg_;
                    }


                    CqlBoolean ar_() {
                        CqlInterval<CqlDateTime> bh_ = QICoreCommon_4_0_000.Instance.prevalenceInterval(context, DiabetesProblem as Condition);
                        CqlDateTime bi_ = context.Operators.Start(bh_);
                        CqlInterval<CqlDateTime> bj_ = Hospitalization?.hospitalizationPeriod;
                        CqlDateTime bk_ = context.Operators.End(bj_);
                        bool? bl_ = context.Operators.Before(bi_, bk_, (string)default);
                        return bl_;
                    }

                    return /* CQL 'and' (127:72-132:113) */ (/* CQL 'or' (127:72-131:11) */ (/* CQL 'or' (127:74-129:80) */ (/* CQL 'or' (127:74-128:80) */ ((CqlBoolean)an_
                        || ao_())
                        || ap_())
                        || aq_())
                        && ar_());
                }

                return (bool?)(/* CQL 'implies' (127:11-132:113) */ ((CqlBoolean)(!(!((bool?)(ah_ is null))))
                    || ai_()));
            }

            IEnumerable<Condition> l_ = context.Operators.Where<Condition>(j_, k_);
            IEnumerable<Condition> m_ = context.Operators.Union<Condition>(i_ as IEnumerable<Condition>, l_ as IEnumerable<Condition>);

            bool? n_(Condition DiabetesCondition) {
                ResourceReference bm_ = DiabetesCondition?.Subject;
                FhirString bn_ = bm_?.ReferenceElement;
                string bo_ = bn_?.Value;
                Encounter bp_ = Hospitalization?.encounter;
                ResourceReference bq_ = bp_?.Subject;
                FhirString br_ = bq_?.ReferenceElement;
                string bs_ = br_?.Value;
                bool? bt_ = context.Operators.Equal(bo_, bs_);
                return bt_;
            }

            bool? o_ = context.Operators.WhereAny<Condition>(m_, n_);
            return o_;
        }


        Encounter c_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization) {
            Encounter bu_ = Hospitalization?.encounter;
            return bu_;
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

                CqlBoolean v_() {
                    CodeableConcept w_ = M?.Code;
                    CqlConcept x_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, w_);
                    CqlValueSet y_ = this.Hypoglycemics_Treatment_Medications(context);
                    bool? z_ = context.Operators.ConceptInValueSet(x_, y_);
                    return z_;
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)u_
                    && v_()));
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
            (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? aa_ = (CqlTupleMetadata_BRDBXSUhdQiXBCfMGdSacWIG, _valueTuple.Item1, _valueTuple.Item2);
            return aa_;
        }


        bool? j_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> ab_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? ac_ = ab_?.Value;
            string ad_ = context.Operators.Convert<string>(ac_);
            string[] ae_ = [
                "completed",
                "in-progress",
            ];
            bool? af_ = context.Operators.In<string>(ad_, (IEnumerable<string>)ae_);

            CqlBoolean ag_() {
                CqlInterval<CqlDateTime> ah_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.hospitalizationPeriod;
                DataType ai_ = tuple_brdbxsuhdqixbcfmgdsacwig?.HypoglycemicMed?.Effective;
                object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ai_);
                CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                bool? al_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ah_, ak_, (string)default);
                return al_;
            }

            return (bool?)(/* CQL 'and' (164:5-165:95) */ ((CqlBoolean)af_
                && ag_()));
        }

        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?> k_ = context.Operators.SelectWhere<ValueTuple<(CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)?, MedicationAdministration>, (CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)?>(h_, i_, j_);

        Encounter l_((CqlTupleMetadata, (CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization, MedicationAdministration HypoglycemicMed)? tuple_brdbxsuhdqixbcfmgdsacwig) {
            Encounter am_ = tuple_brdbxsuhdqixbcfmgdsacwig?.Hospitalization?.encounter;
            return am_;
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
                DataType p_ = GlucoseTest?.Effective;
                object q_ = FHIRHelpers_4_4_000.Instance.ToValue(context, p_);
                bool r_ = q_ is CqlDateTime;
                if (r_)
                {
                    j_ = q_ as CqlDateTime;
                }
                else
                {
                    if (r_)
                    {
                        j_ = q_ as CqlDateTime;
                    }
                    else
                    {
                        bool s_ = q_ is CqlInterval<CqlDateTime>;
                        if (s_)
                        {
                            j_ = q_ as CqlInterval<CqlDateTime>;
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

                CqlBoolean n_() {
                    Code<ObservationStatus> t_ = GlucoseTest?.StatusElement;
                    ObservationStatus? u_ = t_?.Value;
                    string v_ = context.Operators.Convert<string>(u_);
                    string[] w_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? x_ = context.Operators.In<string>(v_, (IEnumerable<string>)w_);
                    return x_;
                }


                CqlBoolean o_() {
                    DataType y_ = GlucoseTest?.Value;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    CqlQuantity aa_ = context.Operators.Quantity(200m, "mg/dL");
                    bool? ab_ = context.Operators.GreaterOrEqual(z_ as CqlQuantity, aa_);
                    return ab_;
                }

                return (bool?)(/* CQL 'and' (113:17-115:44) */ (/* CQL 'and' (113:17-114:69) */ ((CqlBoolean)m_
                    && n_())
                    && o_()));
            }

            bool? i_ = context.Operators.WhereAny<Observation>(g_, h_);
            return i_;
        }


        Encounter c_((CqlTupleMetadata, Encounter encounter, CqlInterval<CqlDateTime> hospitalizationPeriod)? Hospitalization) {
            Encounter ac_ = Hospitalization?.encounter;
            return ac_;
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

                    CqlBoolean z_() {
                        DataType ab_ = GlucoseTest?.Value;
                        object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                        CqlQuantity ad_ = context.Operators.Quantity(300m, "mg/dL");
                        bool? ae_ = context.Operators.Greater(ac_ as CqlQuantity, ad_);
                        return ae_;
                    }


                    CqlBoolean aa_() {
                        object af_;
                        DataType aj_ = GlucoseTest?.Effective;
                        object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
                        bool al_ = ak_ is CqlDateTime;
                        if (al_)
                        {
                            af_ = ak_ as CqlDateTime;
                        }
                        else
                        {
                            if (al_)
                            {
                                af_ = ak_ as CqlDateTime;
                            }
                            else
                            {
                                bool am_ = ak_ is CqlInterval<CqlDateTime>;
                                if (am_)
                                {
                                    af_ = ak_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    af_ = null;
                                }
                            }
                        }
                        CqlDateTime ag_ = QICoreCommon_4_0_000.Instance.earliest(context, af_);
                        CqlInterval<CqlDateTime> ah_ = EncounterDay?.dayPeriod;
                        bool? ai_ = context.Operators.In<CqlDateTime>(ag_, ah_, (string)default);
                        return ai_;
                    }

                    return (bool?)(/* CQL 'and' (52:17-54:86) */ (/* CQL 'and' (52:23-53:53) */ ((CqlBoolean)y_
                        && z_())
                        && aa_()));
                }

                bool? o_ = context.Operators.WhereAny<Observation>(m_, n_);

                bool? p_(Observation GlucoseTest) {
                    Code<ObservationStatus> an_ = GlucoseTest?.StatusElement;
                    ObservationStatus? ao_ = an_?.Value;
                    string ap_ = context.Operators.Convert<string>(ao_);
                    string[] aq_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? ar_ = context.Operators.In<string>(ap_, (IEnumerable<string>)aq_);

                    CqlBoolean as_() {
                        DataType au_ = GlucoseTest?.Value;
                        object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                        CqlQuantity aw_ = context.Operators.Quantity(200m, "mg/dL");
                        bool? ax_ = context.Operators.GreaterOrEqual(av_ as CqlQuantity, aw_);
                        return ax_;
                    }


                    CqlBoolean at_() {
                        object ay_;
                        DataType bc_ = GlucoseTest?.Effective;
                        object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                        bool be_ = bd_ is CqlDateTime;
                        if (be_)
                        {
                            ay_ = bd_ as CqlDateTime;
                        }
                        else
                        {
                            if (be_)
                            {
                                ay_ = bd_ as CqlDateTime;
                            }
                            else
                            {
                                bool bf_ = bd_ is CqlInterval<CqlDateTime>;
                                if (bf_)
                                {
                                    ay_ = bd_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    ay_ = null;
                                }
                            }
                        }
                        CqlDateTime az_ = QICoreCommon_4_0_000.Instance.earliest(context, ay_);
                        CqlInterval<CqlDateTime> ba_ = EncounterDay?.dayPeriod;
                        bool? bb_ = context.Operators.In<CqlDateTime>(az_, ba_, (string)default);
                        return bb_;
                    }

                    return (bool?)(/* CQL 'and' (57:17-59:86) */ (/* CQL 'and' (57:23-58:54) */ ((CqlBoolean)ar_
                        && as_())
                        && at_()));
                }

                bool? q_ = context.Operators.WhereAny<Observation>(m_, p_);

                bool? r_(Observation GlucoseTest) {
                    Code<ObservationStatus> bg_ = GlucoseTest?.StatusElement;
                    ObservationStatus? bh_ = bg_?.Value;
                    string bi_ = context.Operators.Convert<string>(bh_);
                    string[] bj_ = [
                        "final",
                        "amended",
                        "corrected",
                    ];
                    bool? bk_ = context.Operators.In<string>(bi_, (IEnumerable<string>)bj_);

                    CqlBoolean bl_() {
                        object bm_;
                        DataType bq_ = GlucoseTest?.Effective;
                        object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                        bool bs_ = br_ is CqlDateTime;
                        if (bs_)
                        {
                            bm_ = br_ as CqlDateTime;
                        }
                        else
                        {
                            if (bs_)
                            {
                                bm_ = br_ as CqlDateTime;
                            }
                            else
                            {
                                bool bt_ = br_ is CqlInterval<CqlDateTime>;
                                if (bt_)
                                {
                                    bm_ = br_ as CqlInterval<CqlDateTime>;
                                }
                                else
                                {
                                    bm_ = null;
                                }
                            }
                        }
                        CqlDateTime bn_ = QICoreCommon_4_0_000.Instance.earliest(context, bm_);
                        CqlInterval<CqlDateTime> bo_ = EncounterDay?.dayPeriod;
                        bool? bp_ = context.Operators.In<CqlDateTime>(bn_, bo_, (string)default);
                        return bp_;
                    }

                    return (bool?)(/* CQL 'and' (62:17-63:86) */ ((CqlBoolean)bk_
                        && bl_()));
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

                CqlBoolean q_() {
                    bool? s_ = EncounterDay?.hasNoGlucoseTest;

                    CqlBoolean t_() {
                        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> v_ = EncounterWithResultDays?.relevantDays;
                        int? w_ = EncounterDay?.dayNumber;
                        int? x_ = context.Operators.Subtract(w_, 2);
                        (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? y_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(v_, x_);
                        bool? z_ = y_?.hasElevatedResult;
                        return z_;
                    }


                    CqlBoolean u_() {
                        IEnumerable<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?> aa_ = EncounterWithResultDays?.relevantDays;
                        int? ab_ = EncounterDay?.dayNumber;
                        int? ac_ = context.Operators.Subtract(ab_, 3);
                        (CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)? ad_ = context.Operators.Indexer<(CqlTupleMetadata, int? dayNumber, CqlInterval<CqlDateTime> dayPeriod, bool? hasSevereResult, bool? hasElevatedResult, bool? hasNoGlucoseTest)?>(aa_, ac_);
                        bool? ae_ = ad_?.hasElevatedResult;
                        return ae_;
                    }

                    return /* CQL 'and' (77:16-80:13) */ (/* CQL 'and' (77:18-78:102) */ ((CqlBoolean)s_
                        && t_())
                        && u_());
                }

                (CqlTupleMetadata, int? dayIndex, CqlInterval<CqlDateTime> dayPeriod, bool? hasHyperglycemicEvent)? r_ = (CqlTupleMetadata_FNeERNKXWKJeEjWXREHDLePdY, n_, o_, (bool?)(/* CQL 'or' (76:32-81:9) */ ((CqlBoolean)p_
                    || q_())));
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

            CqlBoolean o_() {
                Code<ObservationStatus> q_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.StatusElement;
                ObservationStatus? r_ = q_?.Value;
                string s_ = context.Operators.Convert<string>(r_);
                string[] t_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? u_ = context.Operators.In<string>(s_, (IEnumerable<string>)t_);
                return u_;
            }


            CqlBoolean p_() {
                object v_;
                DataType af_ = tuple_gldtpgaqprrprerabeflfanwh?.GlucoseTest?.Effective;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                bool ah_ = ag_ is CqlDateTime;
                if (ah_)
                {
                    v_ = ag_ as CqlDateTime;
                }
                else
                {
                    if (ah_)
                    {
                        v_ = ag_ as CqlDateTime;
                    }
                    else
                    {
                        bool ai_ = ag_ is CqlInterval<CqlDateTime>;
                        if (ai_)
                        {
                            v_ = ag_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            v_ = null;
                        }
                    }
                }
                CqlDateTime w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_);
                CqlInterval<CqlDateTime> x_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_gldtpgaqprrprerabeflfanwh?.InpatientHospitalization);
                CqlDateTime y_ = context.Operators.Start(x_);
                CqlQuantity z_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime aa_ = context.Operators.Subtract(y_, z_);
                CqlQuantity ab_ = context.Operators.Quantity(6m, "hours");
                CqlDateTime ac_ = context.Operators.Add(y_, ab_);
                CqlInterval<CqlDateTime> ad_ = context.Operators.Interval(aa_, ac_, true, true);
                bool? ae_ = context.Operators.In<CqlDateTime>(w_, ad_, (string)default);
                return ae_;
            }

            return (bool?)(/* CQL 'and' (174:5-176:136) */ (/* CQL 'and' (174:11-175:67) */ ((CqlBoolean)n_
                && o_())
                && p_()));
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
            DataType x_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            bool z_ = y_ is CqlDateTime;
            if (z_)
            {
                l_ = y_ as CqlDateTime;
            }
            else
            {
                if (z_)
                {
                    l_ = y_ as CqlDateTime;
                }
                else
                {
                    bool aa_ = y_ is CqlInterval<CqlDateTime>;
                    if (aa_)
                    {
                        l_ = y_ as CqlInterval<CqlDateTime>;
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

            CqlBoolean v_() {
                object ab_;
                DataType al_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.Effective;
                object am_ = FHIRHelpers_4_4_000.Instance.ToValue(context, al_);
                bool an_ = am_ is CqlDateTime;
                if (an_)
                {
                    ab_ = am_ as CqlDateTime;
                }
                else
                {
                    if (an_)
                    {
                        ab_ = am_ as CqlDateTime;
                    }
                    else
                    {
                        bool ao_ = am_ is CqlInterval<CqlDateTime>;
                        if (ao_)
                        {
                            ab_ = am_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ab_ = null;
                        }
                    }
                }
                CqlDateTime ac_ = QICoreCommon_4_0_000.Instance.earliest(context, ab_);
                CqlInterval<CqlDateTime> ad_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_ghpnfyjsiaqamntcrzhgtgped?.InpatientHospitalization);
                CqlDateTime ae_ = context.Operators.Start(ad_);
                CqlQuantity af_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime ag_ = context.Operators.Subtract(ae_, af_);
                object ah_;
                DataType ap_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.Effective;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                bool ar_ = aq_ is CqlDateTime;
                if (ar_)
                {
                    ah_ = aq_ as CqlDateTime;
                }
                else
                {
                    if (ar_)
                    {
                        ah_ = aq_ as CqlDateTime;
                    }
                    else
                    {
                        bool as_ = aq_ is CqlInterval<CqlDateTime>;
                        if (as_)
                        {
                            ah_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            ah_ = null;
                        }
                    }
                }
                CqlDateTime ai_ = QICoreCommon_4_0_000.Instance.earliest(context, ah_);
                CqlInterval<CqlDateTime> aj_ = context.Operators.Interval(ag_, ai_, true, false);
                bool? ak_ = context.Operators.In<CqlDateTime>(ac_, aj_, (string)default);
                return ak_;
            }


            CqlBoolean w_() {
                Id at_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.EarlierGlucoseTest?.IdElement;
                string au_ = at_?.Value;
                Id av_ = tuple_ghpnfyjsiaqamntcrzhgtgped?.GlucoseResult600?.IdElement;
                string aw_ = av_?.Value;
                bool? ax_ = context.Operators.Equivalent(au_, aw_);
                return !ax_;
            }

            return (bool?)(/* CQL 'and' (187:5-189:54) */ (/* CQL 'and' (187:11-188:116) */ ((CqlBoolean)u_
                && v_())
                && w_()));
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

            CqlBoolean n_() {
                Code<ObservationStatus> p_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.StatusElement;
                ObservationStatus? q_ = p_?.Value;
                string r_ = context.Operators.Convert<string>(q_);
                string[] s_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? t_ = context.Operators.In<string>(r_, (IEnumerable<string>)s_);
                return t_;
            }


            CqlBoolean o_() {
                object u_;
                DataType ae_ = tuple_olaiqtwvfyenjplsytlpsbjd?.EarlyGlucoseResult?.Effective;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                bool ag_ = af_ is CqlDateTime;
                if (ag_)
                {
                    u_ = af_ as CqlDateTime;
                }
                else
                {
                    if (ag_)
                    {
                        u_ = af_ as CqlDateTime;
                    }
                    else
                    {
                        bool ah_ = af_ is CqlInterval<CqlDateTime>;
                        if (ah_)
                        {
                            u_ = af_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            u_ = null;
                        }
                    }
                }
                CqlDateTime v_ = QICoreCommon_4_0_000.Instance.earliest(context, u_);
                CqlInterval<CqlDateTime> w_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_olaiqtwvfyenjplsytlpsbjd?.InpatientHospitalization);
                CqlDateTime x_ = context.Operators.Start(w_);
                CqlQuantity y_ = context.Operators.Quantity(1m, "hour");
                CqlDateTime z_ = context.Operators.Subtract(x_, y_);
                CqlQuantity aa_ = context.Operators.Quantity(6m, "hours");
                CqlDateTime ab_ = context.Operators.Add(x_, aa_);
                CqlInterval<CqlDateTime> ac_ = context.Operators.Interval(z_, ab_, true, true);
                bool? ad_ = context.Operators.In<CqlDateTime>(v_, ac_, (string)default);
                return ad_;
            }

            return (bool?)(/* CQL 'and' (141:5-143:234) */ (/* CQL 'and' (141:11-142:74) */ ((CqlBoolean)m_
                && n_())
                && o_()));
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
                    g_ = p_ as CqlDateTime;
                }
                else
                {
                    bool r_ = p_ is CqlQuantity;
                    if (r_)
                    {
                        g_ = p_ as CqlQuantity;
                    }
                    else
                    {
                        bool s_ = p_ is CqlInterval<CqlDateTime>;
                        if (s_)
                        {
                            g_ = p_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bool t_ = p_ is CqlInterval<CqlQuantity>;
                            if (t_)
                            {
                                g_ = p_ as CqlInterval<CqlQuantity>;
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

            CqlBoolean i_() {
                Encounter.HospitalizationComponent j_ = InpatientHospitalization?.Hospitalization;
                CodeableConcept k_ = j_?.DischargeDisposition;
                CqlConcept l_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, k_);
                CqlValueSet m_ = this.Discharged_to_Health_Care_Facility_for_Hospice_Care(context);
                bool? n_ = context.Operators.ConceptInValueSet(l_, m_);
                return n_;
            }

            return (bool?)(/* CQL 'or' (102:5-103:127) */ ((CqlBoolean)h_
                || i_()));
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
