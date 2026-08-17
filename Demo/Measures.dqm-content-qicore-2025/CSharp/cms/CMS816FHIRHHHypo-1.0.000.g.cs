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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.1.0")]
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

            return /* CQL 'and' (58:5-60:48) */ (/* CQL 'and' (58:11-59:75) */ ((CqlBoolean)n_
                && o_())
                && p_());
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
                object l_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                object m_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                IEnumerable<string> n_ = context.Operators.Split((string)m_, "/");
                string o_ = context.Operators.Last<string>(n_);
                bool? p_ = context.Operators.Equal(l_, o_);

                CqlBoolean q_() {
                    CodeableConcept r_ = M?.Code;
                    CqlConcept s_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, r_);
                    CqlValueSet t_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
                    bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                    return u_;
                }

                return /* CQL 'and' */ ((CqlBoolean)p_
                    && q_());
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration HypoMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> v_ = HypoMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            bool? y_ = context.Operators.Equal(x_, "completed");
            return y_;
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
                DataType g_ = HypoglycemicMedication?.Effective;
                object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlInterval<CqlDateTime> k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientHospitalization);
                bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, (string)default);
                return l_;
            }

            bool? f_ = context.Operators.WhereAny<MedicationAdministration>(d_, e_);
            return f_;
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
            (CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? k_ = (CqlTupleMetadata_iDQJARAEbNWFbbeChQZIVMic, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_fadhmfgiduzpspclbhmqonodh) {
            object l_;
            DataType s_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
            object t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
            bool u_ = t_ is CqlDateTime;
            if (u_)
            {
                l_ = t_ as CqlDateTime;
            }
            else
            {
                if (u_)
                {
                    l_ = t_ as CqlDateTime;
                }
                else
                {
                    bool v_ = t_ is CqlInterval<CqlDateTime>;
                    if (v_)
                    {
                        l_ = t_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        l_ = null;
                    }
                }
            }
            CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            CqlInterval<CqlDateTime> n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_fadhmfgiduzpspclbhmqonodh?.InpatientHospitalization);
            bool? o_ = context.Operators.In<CqlDateTime>(m_, n_, (string)default);

            CqlBoolean p_() {
                Code<ObservationStatus> w_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.StatusElement;
                ObservationStatus? x_ = w_?.Value;
                string y_ = context.Operators.Convert<string>(x_);
                string[] z_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? aa_ = context.Operators.In<string>(y_, (IEnumerable<string>)z_);
                return aa_;
            }


            CqlBoolean q_() {
                DataType ab_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Value;
                object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                CqlQuantity ad_ = context.Operators.Quantity(40m, "mg/dL");
                bool? ae_ = context.Operators.Less(ac_ as CqlQuantity, ad_);
                return ae_;
            }


            CqlBoolean r_() {
                DataType af_ = tuple_fadhmfgiduzpspclbhmqonodh?.HypoglycemicMedication?.Effective;
                object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
                CqlInterval<CqlDateTime> ah_ = QICoreCommon_4_0_000.Instance.toInterval(context, ag_);
                CqlDateTime ai_ = context.Operators.Start(ah_);
                object aj_;
                DataType as_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                object at_ = FHIRHelpers_4_4_000.Instance.ToValue(context, as_);
                bool au_ = at_ is CqlDateTime;
                if (au_)
                {
                    aj_ = at_ as CqlDateTime;
                }
                else
                {
                    if (au_)
                    {
                        aj_ = at_ as CqlDateTime;
                    }
                    else
                    {
                        bool av_ = at_ is CqlInterval<CqlDateTime>;
                        if (av_)
                        {
                            aj_ = at_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            aj_ = null;
                        }
                    }
                }
                CqlDateTime ak_ = QICoreCommon_4_0_000.Instance.earliest(context, aj_);
                CqlQuantity al_ = context.Operators.Quantity(24m, "hours");
                CqlDateTime am_ = context.Operators.Subtract(ak_, al_);
                object an_;
                DataType aw_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                object ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    an_ = ax_ as CqlDateTime;
                }
                else
                {
                    if (ay_)
                    {
                        an_ = ax_ as CqlDateTime;
                    }
                    else
                    {
                        bool az_ = ax_ is CqlInterval<CqlDateTime>;
                        if (az_)
                        {
                            an_ = ax_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            an_ = null;
                        }
                    }
                }
                CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(am_, ao_, true, true);
                bool? aq_ = context.Operators.In<CqlDateTime>(ai_, ap_, (string)default);

                CqlBoolean ar_() {
                    object ba_;
                    DataType bc_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object bd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bc_);
                    bool be_ = bd_ is CqlDateTime;
                    if (be_)
                    {
                        ba_ = bd_ as CqlDateTime;
                    }
                    else
                    {
                        if (be_)
                        {
                            ba_ = bd_ as CqlDateTime;
                        }
                        else
                        {
                            bool bf_ = bd_ is CqlInterval<CqlDateTime>;
                            if (bf_)
                            {
                                ba_ = bd_ as CqlInterval<CqlDateTime>;
                            }
                            else
                            {
                                ba_ = null;
                            }
                        }
                    }
                    CqlDateTime bb_ = QICoreCommon_4_0_000.Instance.earliest(context, ba_);
                    return !((bool?)(bb_ is null));
                }

                return /* CQL 'and' (43:11-43:90) */ ((CqlBoolean)aq_
                    && ar_());
            }

            return /* CQL 'and' (40:5-43:90) */ (/* CQL 'and' (40:11-42:40) */ (/* CQL 'and' (40:11-41:67) */ ((CqlBoolean)o_
                && p_())
                && q_())
                && r_());
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, MedicationAdministration, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?>(e_, f_, g_);
        Observation i_((CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)? tuple_fadhmfgiduzpspclbhmqonodh) => tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest;
        IEnumerable<Observation> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter InpatientHospitalization, MedicationAdministration HypoglycemicMedication, Observation GlucoseTest)?, Observation>(h_, i_);
        return j_;
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
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? k_ = (CqlTupleMetadata_CEOMCLiKCTbHOFFWhDaJdQbjX, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_fcmdncyhjlqsajxzjwdiopqvk) {
            object l_;
            DataType ab_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
            bool ad_ = ac_ is CqlDateTime;
            if (ad_)
            {
                l_ = ac_ as CqlDateTime;
            }
            else
            {
                if (ad_)
                {
                    l_ = ac_ as CqlDateTime;
                }
                else
                {
                    bool ae_ = ac_ is CqlInterval<CqlDateTime>;
                    if (ae_)
                    {
                        l_ = ac_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        l_ = null;
                    }
                }
            }
            CqlDateTime m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            object n_;
            DataType af_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
            object ag_ = FHIRHelpers_4_4_000.Instance.ToValue(context, af_);
            bool ah_ = ag_ is CqlDateTime;
            if (ah_)
            {
                n_ = ag_ as CqlDateTime;
            }
            else
            {
                if (ah_)
                {
                    n_ = ag_ as CqlDateTime;
                }
                else
                {
                    bool ai_ = ag_ is CqlInterval<CqlDateTime>;
                    if (ai_)
                    {
                        n_ = ag_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        n_ = null;
                    }
                }
            }
            CqlDateTime o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
            object p_;
            DataType aj_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
            object ak_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aj_);
            bool al_ = ak_ is CqlDateTime;
            if (al_)
            {
                p_ = ak_ as CqlDateTime;
            }
            else
            {
                if (al_)
                {
                    p_ = ak_ as CqlDateTime;
                }
                else
                {
                    bool am_ = ak_ is CqlInterval<CqlDateTime>;
                    if (am_)
                    {
                        p_ = ak_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            CqlQuantity r_ = context.Operators.Quantity(5m, "minutes");
            CqlDateTime s_ = context.Operators.Add(q_, r_);
            CqlInterval<CqlDateTime> t_ = context.Operators.Interval(o_, s_, false, true);
            bool? u_ = context.Operators.In<CqlDateTime>(m_, t_, (string)default);

            CqlBoolean v_() {
                object an_;
                DataType ap_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                object aq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ap_);
                bool ar_ = aq_ is CqlDateTime;
                if (ar_)
                {
                    an_ = aq_ as CqlDateTime;
                }
                else
                {
                    if (ar_)
                    {
                        an_ = aq_ as CqlDateTime;
                    }
                    else
                    {
                        bool as_ = aq_ is CqlInterval<CqlDateTime>;
                        if (as_)
                        {
                            an_ = aq_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            an_ = null;
                        }
                    }
                }
                CqlDateTime ao_ = QICoreCommon_4_0_000.Instance.earliest(context, an_);
                return !((bool?)(ao_ is null));
            }


            CqlBoolean w_() {
                object at_;
                DataType ax_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                bool az_ = ay_ is CqlDateTime;
                if (az_)
                {
                    at_ = ay_ as CqlDateTime;
                }
                else
                {
                    if (az_)
                    {
                        at_ = ay_ as CqlDateTime;
                    }
                    else
                    {
                        bool ba_ = ay_ is CqlInterval<CqlDateTime>;
                        if (ba_)
                        {
                            at_ = ay_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            at_ = null;
                        }
                    }
                }
                CqlDateTime au_ = QICoreCommon_4_0_000.Instance.earliest(context, at_);
                CqlInterval<CqlDateTime> av_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_fcmdncyhjlqsajxzjwdiopqvk?.InpatientHospitalization);
                bool? aw_ = context.Operators.In<CqlDateTime>(au_, av_, (string)default);
                return aw_;
            }


            CqlBoolean x_() {
                object bb_;
                DataType bf_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                object bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    bb_ = bg_ as CqlDateTime;
                }
                else
                {
                    if (bh_)
                    {
                        bb_ = bg_ as CqlDateTime;
                    }
                    else
                    {
                        bool bi_ = bg_ is CqlInterval<CqlDateTime>;
                        if (bi_)
                        {
                            bb_ = bg_ as CqlInterval<CqlDateTime>;
                        }
                        else
                        {
                            bb_ = null;
                        }
                    }
                }
                CqlDateTime bc_ = QICoreCommon_4_0_000.Instance.earliest(context, bb_);
                CqlInterval<CqlDateTime> bd_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_fcmdncyhjlqsajxzjwdiopqvk?.InpatientHospitalization);
                bool? be_ = context.Operators.In<CqlDateTime>(bc_, bd_, (string)default);
                return be_;
            }


            CqlBoolean y_() {
                Id bj_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.IdElement;
                string bk_ = bj_?.Value;
                Id bl_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.IdElement;
                string bm_ = bl_?.Value;
                bool? bn_ = context.Operators.Equivalent(bk_, bm_);
                return !bn_;
            }


            CqlBoolean z_() {
                Code<ObservationStatus> bo_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.StatusElement;
                ObservationStatus? bp_ = bo_?.Value;
                string bq_ = context.Operators.Convert<string>(bp_);
                string[] br_ = [
                    "final",
                    "amended",
                    "corrected",
                ];
                bool? bs_ = context.Operators.In<string>(bq_, (IEnumerable<string>)br_);
                return bs_;
            }


            CqlBoolean aa_() {
                DataType bt_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Value;
                object bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                CqlQuantity bv_ = context.Operators.Quantity(80m, "mg/dL");
                bool? bw_ = context.Operators.Greater(bu_ as CqlQuantity, bv_);
                return bw_;
            }

            return /* CQL 'and' (86:5-91:48) */ (/* CQL 'and' (86:11-90:75) */ (/* CQL 'and' (86:11-89:53) */ (/* CQL 'and' (86:11-88:100) */ (/* CQL 'and' (86:11-87:92) */ (/* CQL 'and' (86:11-86:73) */ ((CqlBoolean)u_
                && v_())
                && w_())
                && x_())
                && y_())
                && z_())
                && aa_());
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?> h_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?>(e_, f_, g_);
        Observation i_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)? tuple_fcmdncyhjlqsajxzjwdiopqvk) => tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest;
        IEnumerable<Observation> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation LowGlucoseTest, Observation FollowupGlucoseTest)?, Observation>(h_, i_);
        return j_;
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
            (CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)? i_ = (CqlTupleMetadata_EUfjfKOXQBfhUJjAfTWLWTbNB, _valueTuple.Item1, _valueTuple.Item2);
            return i_;
        }


        bool? e_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)? tuple_hqaveihellnsvbjqtehcabtjc) {
            object j_;
            DataType n_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
            object o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            bool p_ = o_ is CqlDateTime;
            if (p_)
            {
                j_ = o_ as CqlDateTime;
            }
            else
            {
                if (p_)
                {
                    j_ = o_ as CqlDateTime;
                }
                else
                {
                    bool q_ = o_ is CqlInterval<CqlDateTime>;
                    if (q_)
                    {
                        j_ = o_ as CqlInterval<CqlDateTime>;
                    }
                    else
                    {
                        j_ = null;
                    }
                }
            }
            CqlDateTime k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_);
            CqlInterval<CqlDateTime> l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hqaveihellnsvbjqtehcabtjc?.InpatientHospitalization);
            bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, (string)default);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)?> f_ = context.Operators.SelectWhere<ValueTuple<Encounter, Observation>, (CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)?>(c_, d_, e_);
        Encounter g_((CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)? tuple_hqaveihellnsvbjqtehcabtjc) => tuple_hqaveihellnsvbjqtehcabtjc?.InpatientHospitalization;
        IEnumerable<Encounter> h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter InpatientHospitalization, Observation HypoglycemicEvent)?, Encounter>(f_, g_);
        return h_;
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
