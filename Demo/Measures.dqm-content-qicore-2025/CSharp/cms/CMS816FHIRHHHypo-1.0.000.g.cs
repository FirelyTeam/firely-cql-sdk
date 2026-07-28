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
[CqlLibrary("CMS816FHIRHHHypo", "1.0.000")]
public partial class CMS816FHIRHHHypo_1_0_000 : ILibrary, ISingleton<CMS816FHIRHHHypo_1_0_000>
{
    #region ValueSets (4)

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Glucose Lab Test Mass Per Volume", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", valueSetVersion: null)]
    public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume(CqlContext _) => _Glucose_Lab_Test_Mass_Per_Volume;
    private static readonly CqlValueSet _Glucose_Lab_Test_Mass_Per_Volume = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", null);

    [CqlValueSetDefinition("Hypoglycemics Severe Hypoglycemia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", valueSetVersion: null)]
    public CqlValueSet Hypoglycemics_Severe_Hypoglycemia(CqlContext _) => _Hypoglycemics_Severe_Hypoglycemia;
    private static readonly CqlValueSet _Hypoglycemics_Severe_Hypoglycemia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", null);

    [CqlValueSetDefinition("Positive Pregnancy Status", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1099.24", valueSetVersion: null)]
    public CqlValueSet Positive_Pregnancy_Status(CqlContext _) => _Positive_Pregnancy_Status;
    private static readonly CqlValueSet _Positive_Pregnancy_Status = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1099.24", null);

    #endregion ValueSets

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -30370437313442716L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS816FHIRHHHypo-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (15)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 3721271333023754874L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter, Qualifying_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Encounter = 5387382680659324825L;

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
            CqlDateTime o_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime> p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, "day");
            bool? r_ = context.Operators.And(n_, q_);
            Code<Encounter.EncounterStatus> s_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? t_ = s_?.Value;
            Code<Encounter.EncounterStatus> u_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(t_);
            bool? v_ = context.Operators.Equal(u_, "finished");
            bool? w_ = context.Operators.And(r_, v_);
            return w_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hypoglycemic_Medication_Administration, Hypoglycemic_Medication_Administration_Compute);

    private const long _cacheIndex_Hypoglycemic_Medication_Administration = 617262154471677908L;

    private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Compute(CqlContext context)
    {
        IEnumerable<MedicationAdministration> a_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? b_(MedicationAdministration MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication M) {
                object m_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object n_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> o_ = context.Operators.Split((string)n_, "/");
                string p_ = context.Operators.Last<string>(o_);
                bool? q_ = context.Operators.Equal(m_, p_);
                CodeableConcept r_ = M?.Code;
                CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                CqlValueSet t_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
                bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                bool? v_ = context.Operators.And(q_, u_);
                return v_;
            }

            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            bool? l_ = context.Operators.Exists<Medication>(k_);
            return l_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration HypoMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> w_ = HypoMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? x_ = w_?.Value;
            string y_ = context.Operators.Convert<string>(x_);
            bool? z_ = context.Operators.Equal(y_, "completed");
            return z_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter With Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Encounter_With_Hypoglycemic_Medication_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Hypoglycemic_Medication_Administration, Encounter_With_Hypoglycemic_Medication_Administration_Compute);

    private const long _cacheIndex_Encounter_With_Hypoglycemic_Medication_Administration = 8534030923976848893L;

    private IEnumerable<Encounter> Encounter_With_Hypoglycemic_Medication_Administration_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientHospitalization) {
            IEnumerable<MedicationAdministration> d_ = this.Hypoglycemic_Medication_Administration(context);

            bool? e_(MedicationAdministration HypoglycemicMedication) {
                DataType h_ = HypoglycemicMedication?.Effective;
                object i_ = FHIRHelpers_4_4_000.Instance.ToValue(context, h_);
                CqlInterval<CqlDateTime> j_ = QICoreCommon_4_0_000.Instance.toInterval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientHospitalization);
                bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, (string)default);
                return m_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            bool? g_ = context.Operators.Exists<MedicationAdministration>(f_);
            return g_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -1931642883968411427L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Hypoglycemic_Medication_Administration(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 2819473113825001791L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Glucose Test With Result Less Than 40")]
    public IEnumerable<Observation> Glucose_Test_With_Result_Less_Than_40(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Glucose_Test_With_Result_Less_Than_40, Glucose_Test_With_Result_Less_Than_40_Compute);

    private const long _cacheIndex_Glucose_Test_With_Result_Less_Than_40 = 8244496803727797683L;

    private IEnumerable<Observation> Glucose_Test_With_Result_Less_Than_40_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        IEnumerable<MedicationAdministration> b_ = this.Hypoglycemic_Medication_Administration(context);
        CqlValueSet c_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, MedicationAdministration, Observation>> e_ = context.Operators.CrossJoin<Encounter, MedicationAdministration, Observation>(a_, b_, d_);

        (CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? f_(ValueTuple<Encounter, MedicationAdministration, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? m_ = (CqlTupleMetadata_iDQJARAEbNWFbbeChQZIVMic, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> g_ = context.Operators.Select<ValueTuple<Encounter, MedicationAdministration, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_fadhmfgiduzpspclbhmqonodh) {

            object n_() {

                bool at_() {
                    DataType aw_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                    bool ay_ = ax_ is CqlDateTime;
                    return ay_;
                }


                bool au_() {
                    DataType az_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    bool bb_ = ba_ is CqlDateTime;
                    return bb_;
                }


                bool av_() {
                    DataType bc_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlInterval<CqlDateTime>;
                    return be_;
                }

                if (at_())
                {
                    DataType bf_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    return bg_ as CqlDateTime;
                }
                else if (au_())
                {
                    DataType bh_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object bi_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bh_);
                    return bi_ as CqlDateTime;
                }
                else if (av_())
                {
                    DataType bj_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                    return bk_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_());
            CqlInterval<CqlDateTime> p_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_fadhmfgiduzpspclbhmqonodh?.InpatientHospitalization);
            bool? q_ = context.Operators.In<CqlDateTime>(o_, p_, (string)default);
            Code<ObservationStatus> r_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.StatusElement;
            ObservationStatus? s_ = r_?.Value;
            string t_ = context.Operators.Convert<string>(s_);
            string[] u_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? v_ = context.Operators.In<string>(t_, (IEnumerable<string>)u_);
            bool? w_ = context.Operators.And(q_, v_);
            DataType x_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Value;
            object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
            CqlQuantity z_ = context.Operators.Quantity(40m, "mg/dL");
            bool? aa_ = context.Operators.Less(y_ as CqlQuantity, z_);
            bool? ab_ = context.Operators.And(w_, aa_);
            DataType ac_ = tuple_fadhmfgiduzpspclbhmqonodh?.HypoglycemicMedication?.Effective;
            object ad_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ac_);
            CqlInterval<CqlDateTime> ae_ = QICoreCommon_4_0_000.Instance.toInterval(context, ad_);
            CqlDateTime af_ = context.Operators.Start(ae_);

            object ag_() {

                bool bl_() {
                    DataType bo_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    bool bq_ = bp_ is CqlDateTime;
                    return bq_;
                }


                bool bm_() {
                    DataType br_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object bs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, br_);
                    bool bt_ = bs_ is CqlDateTime;
                    return bt_;
                }


                bool bn_() {
                    DataType bu_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                    bool bw_ = bv_ is CqlInterval<CqlDateTime>;
                    return bw_;
                }

                if (bl_())
                {
                    DataType bx_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    return by_ as CqlDateTime;
                }
                else if (bm_())
                {
                    DataType bz_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    return ca_ as CqlDateTime;
                }
                else if (bn_())
                {
                    DataType cb_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object cc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cb_);
                    return cc_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_());
            CqlQuantity ai_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime aj_ = context.Operators.Subtract(ah_, ai_);

            object ak_() {

                bool cd_() {
                    DataType cg_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    bool ci_ = ch_ is CqlDateTime;
                    return ci_;
                }


                bool ce_() {
                    DataType cj_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                    bool cl_ = ck_ is CqlDateTime;
                    return cl_;
                }


                bool cf_() {
                    DataType cm_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    bool co_ = cn_ is CqlInterval<CqlDateTime>;
                    return co_;
                }

                if (cd_())
                {
                    DataType cp_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    return cq_ as CqlDateTime;
                }
                else if (ce_())
                {
                    DataType cr_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                    return cs_ as CqlDateTime;
                }
                else if (cf_())
                {
                    DataType ct_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
                    return cu_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime al_ = QICoreCommon_4_0_000.Instance.earliest(context, ak_());
            CqlInterval<CqlDateTime> am_ = context.Operators.Interval(aj_, al_, true, true);
            bool? an_ = context.Operators.In<CqlDateTime>(af_, am_, (string)default);

            object ao_() {

                bool cv_() {
                    DataType cy_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    bool da_ = cz_ is CqlDateTime;
                    return da_;
                }


                bool cw_() {
                    DataType db_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    bool dd_ = dc_ is CqlDateTime;
                    return dd_;
                }


                bool cx_() {
                    DataType de_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object df_ = FHIRHelpers_4_4_000.Instance.ToValue(context, de_);
                    bool dg_ = df_ is CqlInterval<CqlDateTime>;
                    return dg_;
                }

                if (cv_())
                {
                    DataType dh_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    return di_ as CqlDateTime;
                }
                else if (cw_())
                {
                    DataType dj_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object dk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dj_);
                    return dk_ as CqlDateTime;
                }
                else if (cx_())
                {
                    DataType dl_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                    return dm_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ap_ = QICoreCommon_4_0_000.Instance.earliest(context, ao_());
            bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
            bool? ar_ = context.Operators.And(an_, aq_);
            bool? as_ = context.Operators.And(ab_, ar_);
            return as_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(g_, h_);
        Observation j_((CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_fadhmfgiduzpspclbhmqonodh) => tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest;
        IEnumerable<Observation> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?, Observation>(i_, j_);
        IEnumerable<Observation> l_ = context.Operators.Distinct<Observation>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Low Glucose Test Followed By Glucose Test Result Greater Than 80")]
    public IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80, Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80_Compute);

    private const long _cacheIndex_Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80 = 8421351106002975650L;

    private IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        IEnumerable<Observation> b_ = this.Glucose_Test_With_Result_Less_Than_40(context);
        CqlValueSet c_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation> d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter, Observation, Observation>> e_ = context.Operators.CrossJoin<Encounter, Observation, Observation>(a_, b_, d_);

        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? f_(ValueTuple<Encounter, Observation, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? m_ = (CqlTupleMetadata_CEOMCLiKCTbHOFFWhDaJdQbjX, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> g_ = context.Operators.Select<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(e_, f_);

        bool? h_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_fcmdncyhjlqsajxzjwdiopqvk) {

            object n_() {

                bool bc_() {
                    DataType bf_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                    bool bh_ = bg_ is CqlDateTime;
                    return bh_;
                }


                bool bd_() {
                    DataType bi_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    bool bk_ = bj_ is CqlDateTime;
                    return bk_;
                }


                bool be_() {
                    DataType bl_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                    bool bn_ = bm_ is CqlInterval<CqlDateTime>;
                    return bn_;
                }

                if (bc_())
                {
                    DataType bo_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    return bp_ as CqlDateTime;
                }
                else if (bd_())
                {
                    DataType bq_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    return br_ as CqlDateTime;
                }
                else if (be_())
                {
                    DataType bs_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                    return bt_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_());

            object p_() {

                bool bu_() {
                    DataType bx_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    bool bz_ = by_ is CqlDateTime;
                    return bz_;
                }


                bool bv_() {
                    DataType ca_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                    bool cc_ = cb_ is CqlDateTime;
                    return cc_;
                }


                bool bw_() {
                    DataType cd_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    bool cf_ = ce_ is CqlInterval<CqlDateTime>;
                    return cf_;
                }

                if (bu_())
                {
                    DataType cg_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object ch_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cg_);
                    return ch_ as CqlDateTime;
                }
                else if (bv_())
                {
                    DataType ci_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                    return cj_ as CqlDateTime;
                }
                else if (bw_())
                {
                    DataType ck_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
                    return cl_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_());

            object r_() {

                bool cm_() {
                    DataType cp_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                    bool cr_ = cq_ is CqlDateTime;
                    return cr_;
                }


                bool cn_() {
                    DataType cs_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                    bool cu_ = ct_ is CqlDateTime;
                    return cu_;
                }


                bool co_() {
                    DataType cv_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object cw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cv_);
                    bool cx_ = cw_ is CqlInterval<CqlDateTime>;
                    return cx_;
                }

                if (cm_())
                {
                    DataType cy_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                    return cz_ as CqlDateTime;
                }
                else if (cn_())
                {
                    DataType da_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object db_ = FHIRHelpers_4_4_000.Instance.ToValue(context, da_);
                    return db_ as CqlDateTime;
                }
                else if (co_())
                {
                    DataType dc_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object dd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dc_);
                    return dd_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime s_ = QICoreCommon_4_0_000.Instance.earliest(context, r_());
            CqlQuantity t_ = context.Operators.Quantity(5m, "minutes");
            CqlDateTime u_ = context.Operators.Add(s_, t_);
            CqlInterval<CqlDateTime> v_ = context.Operators.Interval(q_, u_, false, true);
            bool? w_ = context.Operators.In<CqlDateTime>(o_, v_, (string)default);

            object x_() {

                bool de_() {
                    DataType dh_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object di_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dh_);
                    bool dj_ = di_ is CqlDateTime;
                    return dj_;
                }


                bool df_() {
                    DataType dk_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object dl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dk_);
                    bool dm_ = dl_ is CqlDateTime;
                    return dm_;
                }


                bool dg_() {
                    DataType dn_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                    bool dp_ = do_ is CqlInterval<CqlDateTime>;
                    return dp_;
                }

                if (de_())
                {
                    DataType dq_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                    return dr_ as CqlDateTime;
                }
                else if (df_())
                {
                    DataType ds_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    return dt_ as CqlDateTime;
                }
                else if (dg_())
                {
                    DataType du_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object dv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, du_);
                    return dv_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime y_ = QICoreCommon_4_0_000.Instance.earliest(context, x_());
            bool? z_ = context.Operators.Not((bool?)(y_ is null));
            bool? aa_ = context.Operators.And(w_, z_);

            object ab_() {

                bool dw_() {
                    DataType dz_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object ea_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dz_);
                    bool eb_ = ea_ is CqlDateTime;
                    return eb_;
                }


                bool dx_() {
                    DataType ec_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                    bool ee_ = ed_ is CqlDateTime;
                    return ee_;
                }


                bool dy_() {
                    DataType ef_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                    bool eh_ = eg_ is CqlInterval<CqlDateTime>;
                    return eh_;
                }

                if (dw_())
                {
                    DataType ei_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object ej_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ei_);
                    return ej_ as CqlDateTime;
                }
                else if (dx_())
                {
                    DataType ek_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                    return el_ as CqlDateTime;
                }
                else if (dy_())
                {
                    DataType em_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object en_ = FHIRHelpers_4_4_000.Instance.ToValue(context, em_);
                    return en_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ac_ = QICoreCommon_4_0_000.Instance.earliest(context, ab_());
            CqlInterval<CqlDateTime> ad_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_fcmdncyhjlqsajxzjwdiopqvk?.InpatientHospitalization);
            bool? ae_ = context.Operators.In<CqlDateTime>(ac_, ad_, (string)default);
            bool? af_ = context.Operators.And(aa_, ae_);

            object ag_() {

                bool eo_() {
                    DataType er_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object es_ = FHIRHelpers_4_4_000.Instance.ToValue(context, er_);
                    bool et_ = es_ is CqlDateTime;
                    return et_;
                }


                bool ep_() {
                    DataType eu_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object ev_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eu_);
                    bool ew_ = ev_ is CqlDateTime;
                    return ew_;
                }


                bool eq_() {
                    DataType ex_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object ey_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ex_);
                    bool ez_ = ey_ is CqlInterval<CqlDateTime>;
                    return ez_;
                }

                if (eo_())
                {
                    DataType fa_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object fb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fa_);
                    return fb_ as CqlDateTime;
                }
                else if (ep_())
                {
                    DataType fc_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object fd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fc_);
                    return fd_ as CqlDateTime;
                }
                else if (eq_())
                {
                    DataType fe_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object ff_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fe_);
                    return ff_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime ah_ = QICoreCommon_4_0_000.Instance.earliest(context, ag_());
            bool? ai_ = context.Operators.In<CqlDateTime>(ah_, ad_, (string)default);
            bool? aj_ = context.Operators.And(af_, ai_);
            Id ak_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.IdElement;
            string al_ = ak_?.Value;
            Id am_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.IdElement;
            string an_ = am_?.Value;
            bool? ao_ = context.Operators.Equivalent(al_, an_);
            bool? ap_ = context.Operators.Not(ao_);
            bool? aq_ = context.Operators.And(aj_, ap_);
            Code<ObservationStatus> ar_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.StatusElement;
            ObservationStatus? as_ = ar_?.Value;
            string at_ = context.Operators.Convert<string>(as_);
            string[] au_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? av_ = context.Operators.In<string>(at_, (IEnumerable<string>)au_);
            bool? aw_ = context.Operators.And(aq_, av_);
            DataType ax_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Value;
            object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
            CqlQuantity az_ = context.Operators.Quantity(80m, "mg/dL");
            bool? ba_ = context.Operators.Greater(ay_ as CqlQuantity, az_);
            bool? bb_ = context.Operators.And(aw_, ba_);
            return bb_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> i_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(g_, h_);
        Observation j_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_fcmdncyhjlqsajxzjwdiopqvk) => tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest;
        IEnumerable<Observation> k_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?, Observation>(i_, j_);
        IEnumerable<Observation> l_ = context.Operators.Distinct<Observation>(k_);
        return l_;
    }


    [CqlExpressionDefinition("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Severe_Hypoglycemic_Harm_Event, Severe_Hypoglycemic_Harm_Event_Compute);

    private const long _cacheIndex_Severe_Hypoglycemic_Harm_Event = 8409537978980512486L;

    private IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event_Compute(CqlContext context)
    {
        IEnumerable<Observation> a_ = this.Glucose_Test_With_Result_Less_Than_40(context);

        bool? b_(Observation LowGlucoseTest) {
            Id d_ = LowGlucoseTest?.IdElement;
            string e_ = d_?.Value;
            IEnumerable<Observation> f_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(context);

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


    [CqlExpressionDefinition("Encounter With Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Encounter_With_Severe_Hypoglycemic_Harm_Event(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Severe_Hypoglycemic_Harm_Event, Encounter_With_Severe_Hypoglycemic_Harm_Event_Compute);

    private const long _cacheIndex_Encounter_With_Severe_Hypoglycemic_Harm_Event = -4606868389057612456L;

    private IEnumerable<Encounter> Encounter_With_Severe_Hypoglycemic_Harm_Event_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);
        IEnumerable<Observation> b_ = this.Severe_Hypoglycemic_Harm_Event(context);
        IEnumerable<ValueTuple<Encounter, Observation>> c_ = context.Operators.CrossJoin<Encounter, Observation>(a_, b_);

        (CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)? d_(ValueTuple<Encounter, Observation> _valueTuple) {
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)? k_ = (CqlTupleMetadata_EUfjfKOXQBfhUJjAfTWLWTbNB, _valueTuple.Item1, _valueTuple.Item2);
            return k_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)?> e_ = context.Operators.Select<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)?>(c_, d_);

        bool? f_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)? tuple_hqaveihellnsvbjqtehcabtjc) {

            object l_() {

                bool p_() {
                    DataType s_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
                    object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                    bool u_ = t_ is CqlDateTime;
                    return u_;
                }


                bool q_() {
                    DataType v_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
                    object w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    bool x_ = w_ is CqlDateTime;
                    return x_;
                }


                bool r_() {
                    DataType y_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
                    object z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    bool aa_ = z_ is CqlInterval<CqlDateTime>;
                    return aa_;
                }

                if (p_())
                {
                    DataType ab_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
                    object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                    return ac_ as CqlDateTime;
                }
                else if (q_())
                {
                    DataType ad_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
                    object ae_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ad_);
                    return ae_ as CqlDateTime;
                }
                else if (r_())
                {
                    DataType af_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
                    object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                    return ag_ as CqlInterval<CqlDateTime>;
                }
                else
                {
                    return null;
                }
            }

            CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_());
            CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hqaveihellnsvbjqtehcabtjc?.InpatientHospitalization);
            bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, (string)default);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)?> g_ = context.Operators.Where<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)?>(e_, f_);
        Encounter h_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)? tuple_hqaveihellnsvbjqtehcabtjc) => tuple_hqaveihellnsvbjqtehcabtjc?.InpatientHospitalization;
        IEnumerable<Encounter> i_ = context.Operators.Select<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)?, Encounter>(g_, h_);
        IEnumerable<Encounter> j_ = context.Operators.Distinct<Encounter>(i_);
        return j_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -573871386757981486L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Severe_Hypoglycemic_Harm_Event(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -5075599977893582226L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 8003583007331791521L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -4550559775519135247L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 7055837076345808661L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS816FHIRHHHypo_1_0_000() {}

    public static CMS816FHIRHHHypo_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS816FHIRHHHypo";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CEOMCLiKCTbHOFFWhDaJdQbjX = new(
       [typeof(Encounter), typeof(Observation), typeof(Observation)],
       ["InpatientHospitalization", "LowGlucoseTest", "FollowupGlucoseTest"]);

    private static CqlTupleMetadata CqlTupleMetadata_EUfjfKOXQBfhUJjAfTWLWTbNB = new(
       [typeof(Encounter), typeof(Observation)],
       ["InpatientHospitalization", "HypoglycemicEvent"]);

    private static CqlTupleMetadata CqlTupleMetadata_iDQJARAEbNWFbbeChQZIVMic = new(
       [typeof(Encounter), typeof(MedicationAdministration), typeof(Observation)],
       ["InpatientHospitalization", "HypoglycemicMedication", "GlucoseTest"]);

    #endregion CqlTupleMetadata Properties

}
