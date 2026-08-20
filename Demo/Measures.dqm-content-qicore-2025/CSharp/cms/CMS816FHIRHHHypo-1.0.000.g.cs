#nullable enable annotations

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
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -30370437313442716L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS816FHIRHHHypo-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (15)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 3721271333023754874L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter?>? Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter, Qualifying_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Encounter = 5387382680659324825L;

    private IEnumerable<Encounter?>? Qualifying_Encounter_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));

        bool? c_(Encounter? InpatientEncounter) {
            Patient? e_ = this.Patient(context);
            Date? f_ = e_?.BirthDateElement;
            string? g_ = f_?.Value;
            CqlDate? h_ = context.Operators.ConvertStringToDate(g_);
            Period? i_ = InpatientEncounter?.Period;
            CqlInterval<CqlDateTime?>? j_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, i_);
            CqlDateTime? k_ = context.Operators.Start(j_);
            CqlDate? l_ = context.Operators.DateFrom(k_);
            int? m_ = context.Operators.CalculateAgeAt(h_, l_, "year");
            bool? n_ = context.Operators.GreaterOrEqual(m_, 18);
            CqlDateTime? o_ = context.Operators.End(j_);
            CqlInterval<CqlDateTime?>? p_ = this.Measurement_Period(context);
            bool? q_ = context.Operators.In<CqlDateTime?>(o_, p_, "day");
            bool? r_ = context.Operators.And(n_, q_);
            Code<Encounter.EncounterStatus>? s_ = InpatientEncounter?.StatusElement;
            Encounter.EncounterStatus? t_ = s_?.Value;
            Code<Encounter.EncounterStatus>? u_ = context.Operators.Convert<Code<Encounter.EncounterStatus>?>(t_);
            bool? v_ = context.Operators.Equal(u_, "finished");
            bool? w_ = context.Operators.And(r_, v_);
            return w_;
        }

        IEnumerable<Encounter?>? d_ = context.Operators.Where<Encounter?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration?>? Hypoglycemic_Medication_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hypoglycemic_Medication_Administration, Hypoglycemic_Medication_Administration_Compute);

    private const long _cacheIndex_Hypoglycemic_Medication_Administration = 617262154471677908L;

    private IEnumerable<MedicationAdministration?>? Hypoglycemic_Medication_Administration_Compute(CqlContext context)
    {
        IEnumerable<MedicationAdministration?>? a_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? b_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication? M) {
                object? l_ = context.Operators.LateBoundProperty<object?>(M, "id.value");
                object? m_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value");
                IEnumerable<string?>? n_ = context.Operators.Split((string?)m_, "/");
                string? o_ = context.Operators.Last<string?>(n_);
                bool? p_ = context.Operators.Equal(l_, o_);
                CodeableConcept? q_ = M?.Code;
                CqlConcept? r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlValueSet? s_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
                bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                bool? u_ = context.Operators.And(p_, t_);
                return u_;
            }

            bool? k_ = context.Operators.WhereAny<Medication?>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationAdministration?>? c_ = context.Operators.Where<MedicationAdministration?>(a_, b_);
        CqlValueSet? d_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration?>? e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? f_ = context.Operators.Union<MedicationAdministration?>(c_, e_);

        bool? g_(MedicationAdministration? HypoMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? v_ = HypoMedication?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? w_ = v_?.Value;
            string? x_ = context.Operators.Convert<string?>(w_);
            bool? y_ = context.Operators.Equal(x_, "completed");
            return y_;
        }

        IEnumerable<MedicationAdministration?>? h_ = context.Operators.Where<MedicationAdministration?>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter With Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter?>? Encounter_With_Hypoglycemic_Medication_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Hypoglycemic_Medication_Administration, Encounter_With_Hypoglycemic_Medication_Administration_Compute);

    private const long _cacheIndex_Encounter_With_Hypoglycemic_Medication_Administration = 8534030923976848893L;

    private IEnumerable<Encounter?>? Encounter_With_Hypoglycemic_Medication_Administration_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter? InpatientHospitalization) {
            IEnumerable<MedicationAdministration?>? d_ = this.Hypoglycemic_Medication_Administration(context);

            bool? e_(MedicationAdministration? HypoglycemicMedication) {
                DataType? g_ = HypoglycemicMedication?.Effective;
                object? h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime? j_ = context.Operators.Start(i_);
                CqlInterval<CqlDateTime?>? k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientHospitalization);
                bool? l_ = context.Operators.In<CqlDateTime?>(j_, k_, (string?)default);
                return l_;
            }

            bool? f_ = context.Operators.WhereAny<MedicationAdministration?>(d_, e_);
            return f_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter?>? Initial_Population(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute);

    private const long _cacheIndex_Initial_Population = -1931642883968411427L;

    private IEnumerable<Encounter?>? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_With_Hypoglycemic_Medication_Administration(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter?>? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = 2819473113825001791L;

    private IEnumerable<Encounter?>? Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Glucose Test With Result Less Than 40")]
    public IEnumerable<Observation?>? Glucose_Test_With_Result_Less_Than_40(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Glucose_Test_With_Result_Less_Than_40, Glucose_Test_With_Result_Less_Than_40_Compute);

    private const long _cacheIndex_Glucose_Test_With_Result_Less_Than_40 = 8244496803727797683L;

    private IEnumerable<Observation?>? Glucose_Test_With_Result_Less_Than_40_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Denominator(context);
        IEnumerable<MedicationAdministration?>? b_ = this.Hypoglycemic_Medication_Administration(context);
        CqlValueSet? c_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation?>? d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter?, MedicationAdministration?, Observation?>>? e_ = context.Operators.CrossJoin<Encounter?, MedicationAdministration?, Observation?>(a_, b_, d_);

        (CqlTupleMetadata, Encounter? InpatientHospitalization, MedicationAdministration? HypoglycemicMedication, Observation? GlucoseTest)? f_(ValueTuple<Encounter?, MedicationAdministration?, Observation?> _valueTuple) {
            (CqlTupleMetadata, Encounter? InpatientHospitalization, MedicationAdministration? HypoglycemicMedication, Observation? GlucoseTest)? k_ = (CqlTupleMetadata_iDQJARAEbNWFbbeChQZIVMic, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter? InpatientHospitalization, MedicationAdministration? HypoglycemicMedication, Observation? GlucoseTest)? tuple_fadhmfgiduzpspclbhmqonodh) {
            object? l_;
            DataType? ar_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
            object? as_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ar_);
            bool at_ = as_ is CqlDateTime;
            if (at_)
            {
                DataType? au_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                object? av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, au_);
                l_ = av_ as CqlDateTime;
            }
            else
            {
                DataType? aw_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                object? ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                bool ay_ = ax_ is CqlDateTime;
                if (ay_)
                {
                    DataType? az_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object? ba_ = FHIRHelpers_4_4_000.Instance.ToValue(context, az_);
                    l_ = ba_ as CqlDateTime;
                }
                else
                {
                    DataType? bb_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object? bc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bb_);
                    bool bd_ = bc_ is CqlInterval<CqlDateTime>;
                    if (bd_)
                    {
                        DataType? be_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                        object? bf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, be_);
                        l_ = bf_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        l_ = null;
                    }
                }
            }
            CqlDateTime? m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            CqlInterval<CqlDateTime?>? n_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_fadhmfgiduzpspclbhmqonodh?.InpatientHospitalization);
            bool? o_ = context.Operators.In<CqlDateTime?>(m_, n_, (string?)default);
            Code<ObservationStatus>? p_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.StatusElement;
            ObservationStatus? q_ = p_?.Value;
            string? r_ = context.Operators.Convert<string?>(q_);
            string?[]? s_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? t_ = context.Operators.In<string?>(r_, (IEnumerable<string?>?)s_);
            bool? u_ = context.Operators.And(o_, t_);
            DataType? v_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Value;
            object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
            CqlQuantity? x_ = context.Operators.Quantity(40m, "mg/dL");
            bool? y_ = context.Operators.Less(w_ as CqlQuantity, x_);
            bool? z_ = context.Operators.And(u_, y_);
            DataType? aa_ = tuple_fadhmfgiduzpspclbhmqonodh?.HypoglycemicMedication?.Effective;
            object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
            CqlInterval<CqlDateTime?>? ac_ = QICoreCommon_4_0_000.Instance.toInterval(context, ab_);
            CqlDateTime? ad_ = context.Operators.Start(ac_);
            object? ae_;
            DataType? bg_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
            object? bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
            bool bi_ = bh_ is CqlDateTime;
            if (bi_)
            {
                DataType? bj_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                object? bk_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bj_);
                ae_ = bk_ as CqlDateTime;
            }
            else
            {
                DataType? bl_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                object? bm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bl_);
                bool bn_ = bm_ is CqlDateTime;
                if (bn_)
                {
                    DataType? bo_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object? bp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bo_);
                    ae_ = bp_ as CqlDateTime;
                }
                else
                {
                    DataType? bq_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object? br_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bq_);
                    bool bs_ = br_ is CqlInterval<CqlDateTime>;
                    if (bs_)
                    {
                        DataType? bt_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                        object? bu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bt_);
                        ae_ = bu_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        ae_ = null;
                    }
                }
            }
            CqlDateTime? af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
            CqlQuantity? ag_ = context.Operators.Quantity(24m, "hours");
            CqlDateTime? ah_ = context.Operators.Subtract(af_, ag_);
            object? ai_;
            DataType? bv_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
            object? bw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bv_);
            bool bx_ = bw_ is CqlDateTime;
            if (bx_)
            {
                DataType? by_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                object? bz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, by_);
                ai_ = bz_ as CqlDateTime;
            }
            else
            {
                DataType? ca_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                object? cb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ca_);
                bool cc_ = cb_ is CqlDateTime;
                if (cc_)
                {
                    DataType? cd_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object? ce_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cd_);
                    ai_ = ce_ as CqlDateTime;
                }
                else
                {
                    DataType? cf_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object? cg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cf_);
                    bool ch_ = cg_ is CqlInterval<CqlDateTime>;
                    if (ch_)
                    {
                        DataType? ci_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                        object? cj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ci_);
                        ai_ = cj_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        ai_ = null;
                    }
                }
            }
            CqlDateTime? aj_ = QICoreCommon_4_0_000.Instance.earliest(context, ai_);
            CqlInterval<CqlDateTime?>? ak_ = context.Operators.Interval(ah_, aj_, true, true);
            bool? al_ = context.Operators.In<CqlDateTime?>(ad_, ak_, (string?)default);
            object? am_;
            DataType? ck_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
            object? cl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ck_);
            bool cm_ = cl_ is CqlDateTime;
            if (cm_)
            {
                DataType? cn_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                object? co_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cn_);
                am_ = co_ as CqlDateTime;
            }
            else
            {
                DataType? cp_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                object? cq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cp_);
                bool cr_ = cq_ is CqlDateTime;
                if (cr_)
                {
                    DataType? cs_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object? ct_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cs_);
                    am_ = ct_ as CqlDateTime;
                }
                else
                {
                    DataType? cu_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                    object? cv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cu_);
                    bool cw_ = cv_ is CqlInterval<CqlDateTime>;
                    if (cw_)
                    {
                        DataType? cx_ = tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest?.Effective;
                        object? cy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cx_);
                        am_ = cy_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        am_ = null;
                    }
                }
            }
            CqlDateTime? an_ = QICoreCommon_4_0_000.Instance.earliest(context, am_);
            bool? ao_ = context.Operators.Not((bool?)(an_ is null));
            bool? ap_ = context.Operators.And(al_, ao_);
            bool? aq_ = context.Operators.And(z_, ap_);
            return aq_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? InpatientHospitalization, MedicationAdministration? HypoglycemicMedication, Observation? GlucoseTest)?>? h_ = context.Operators.SelectWhere<ValueTuple<Encounter?, MedicationAdministration?, Observation?>, (CqlTupleMetadata, Encounter? InpatientHospitalization, MedicationAdministration? HypoglycemicMedication, Observation? GlucoseTest)?>(e_, f_, g_);
        Observation? i_((CqlTupleMetadata, Encounter? InpatientHospitalization, MedicationAdministration? HypoglycemicMedication, Observation? GlucoseTest)? tuple_fadhmfgiduzpspclbhmqonodh) => tuple_fadhmfgiduzpspclbhmqonodh?.GlucoseTest;
        IEnumerable<Observation?>? j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? InpatientHospitalization, MedicationAdministration? HypoglycemicMedication, Observation? GlucoseTest)?, Observation?>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Low Glucose Test Followed By Glucose Test Result Greater Than 80")]
    public IEnumerable<Observation?>? Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80, Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80_Compute);

    private const long _cacheIndex_Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80 = 8421351106002975650L;

    private IEnumerable<Observation?>? Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Denominator(context);
        IEnumerable<Observation?>? b_ = this.Glucose_Test_With_Result_Less_Than_40(context);
        CqlValueSet? c_ = this.Glucose_Lab_Test_Mass_Per_Volume(context);
        IEnumerable<Observation?>? d_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation-lab"));
        IEnumerable<ValueTuple<Encounter?, Observation?, Observation?>>? e_ = context.Operators.CrossJoin<Encounter?, Observation?, Observation?>(a_, b_, d_);

        (CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? LowGlucoseTest, Observation? FollowupGlucoseTest)? f_(ValueTuple<Encounter?, Observation?, Observation?> _valueTuple) {
            (CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? LowGlucoseTest, Observation? FollowupGlucoseTest)? k_ = (CqlTupleMetadata_CEOMCLiKCTbHOFFWhDaJdQbjX, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return k_;
        }


        bool? g_((CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? LowGlucoseTest, Observation? FollowupGlucoseTest)? tuple_fcmdncyhjlqsajxzjwdiopqvk) {
            object? l_;
            DataType? ba_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
            object? bb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ba_);
            bool bc_ = bb_ is CqlDateTime;
            if (bc_)
            {
                DataType? bd_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                object? be_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bd_);
                l_ = be_ as CqlDateTime;
            }
            else
            {
                DataType? bf_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                object? bg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bf_);
                bool bh_ = bg_ is CqlDateTime;
                if (bh_)
                {
                    DataType? bi_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object? bj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bi_);
                    l_ = bj_ as CqlDateTime;
                }
                else
                {
                    DataType? bk_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object? bl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bk_);
                    bool bm_ = bl_ is CqlInterval<CqlDateTime>;
                    if (bm_)
                    {
                        DataType? bn_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                        object? bo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bn_);
                        l_ = bo_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        l_ = null;
                    }
                }
            }
            CqlDateTime? m_ = QICoreCommon_4_0_000.Instance.earliest(context, l_);
            object? n_;
            DataType? bp_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
            object? bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
            bool br_ = bq_ is CqlDateTime;
            if (br_)
            {
                DataType? bs_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                object? bt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bs_);
                n_ = bt_ as CqlDateTime;
            }
            else
            {
                DataType? bu_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                object? bv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bu_);
                bool bw_ = bv_ is CqlDateTime;
                if (bw_)
                {
                    DataType? bx_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object? by_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bx_);
                    n_ = by_ as CqlDateTime;
                }
                else
                {
                    DataType? bz_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object? ca_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bz_);
                    bool cb_ = ca_ is CqlInterval<CqlDateTime>;
                    if (cb_)
                    {
                        DataType? cc_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                        object? cd_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cc_);
                        n_ = cd_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        n_ = null;
                    }
                }
            }
            CqlDateTime? o_ = QICoreCommon_4_0_000.Instance.earliest(context, n_);
            object? p_;
            DataType? ce_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
            object? cf_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ce_);
            bool cg_ = cf_ is CqlDateTime;
            if (cg_)
            {
                DataType? ch_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                object? ci_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ch_);
                p_ = ci_ as CqlDateTime;
            }
            else
            {
                DataType? cj_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                object? ck_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cj_);
                bool cl_ = ck_ is CqlDateTime;
                if (cl_)
                {
                    DataType? cm_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object? cn_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cm_);
                    p_ = cn_ as CqlDateTime;
                }
                else
                {
                    DataType? co_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object? cp_ = FHIRHelpers_4_4_000.Instance.ToValue(context, co_);
                    bool cq_ = cp_ is CqlInterval<CqlDateTime>;
                    if (cq_)
                    {
                        DataType? cr_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                        object? cs_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cr_);
                        p_ = cs_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        p_ = null;
                    }
                }
            }
            CqlDateTime? q_ = QICoreCommon_4_0_000.Instance.earliest(context, p_);
            CqlQuantity? r_ = context.Operators.Quantity(5m, "minutes");
            CqlDateTime? s_ = context.Operators.Add(q_, r_);
            CqlInterval<CqlDateTime?>? t_ = context.Operators.Interval(o_, s_, false, true);
            bool? u_ = context.Operators.In<CqlDateTime?>(m_, t_, (string?)default);
            object? v_;
            DataType? ct_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
            object? cu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ct_);
            bool cv_ = cu_ is CqlDateTime;
            if (cv_)
            {
                DataType? cw_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                object? cx_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cw_);
                v_ = cx_ as CqlDateTime;
            }
            else
            {
                DataType? cy_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                object? cz_ = FHIRHelpers_4_4_000.Instance.ToValue(context, cy_);
                bool da_ = cz_ is CqlDateTime;
                if (da_)
                {
                    DataType? db_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object? dc_ = FHIRHelpers_4_4_000.Instance.ToValue(context, db_);
                    v_ = dc_ as CqlDateTime;
                }
                else
                {
                    DataType? dd_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object? de_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dd_);
                    bool df_ = de_ is CqlInterval<CqlDateTime>;
                    if (df_)
                    {
                        DataType? dg_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                        object? dh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dg_);
                        v_ = dh_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        v_ = null;
                    }
                }
            }
            CqlDateTime? w_ = QICoreCommon_4_0_000.Instance.earliest(context, v_);
            bool? x_ = context.Operators.Not((bool?)(w_ is null));
            bool? y_ = context.Operators.And(u_, x_);
            object? z_;
            DataType? di_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
            object? dj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, di_);
            bool dk_ = dj_ is CqlDateTime;
            if (dk_)
            {
                DataType? dl_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                object? dm_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dl_);
                z_ = dm_ as CqlDateTime;
            }
            else
            {
                DataType? dn_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                object? do_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dn_);
                bool dp_ = do_ is CqlDateTime;
                if (dp_)
                {
                    DataType? dq_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object? dr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dq_);
                    z_ = dr_ as CqlDateTime;
                }
                else
                {
                    DataType? ds_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                    object? dt_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ds_);
                    bool du_ = dt_ is CqlInterval<CqlDateTime>;
                    if (du_)
                    {
                        DataType? dv_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.Effective;
                        object? dw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dv_);
                        z_ = dw_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        z_ = null;
                    }
                }
            }
            CqlDateTime? aa_ = QICoreCommon_4_0_000.Instance.earliest(context, z_);
            CqlInterval<CqlDateTime?>? ab_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_fcmdncyhjlqsajxzjwdiopqvk?.InpatientHospitalization);
            bool? ac_ = context.Operators.In<CqlDateTime?>(aa_, ab_, (string?)default);
            bool? ad_ = context.Operators.And(y_, ac_);
            object? ae_;
            DataType? dx_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
            object? dy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, dx_);
            bool dz_ = dy_ is CqlDateTime;
            if (dz_)
            {
                DataType? ea_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                object? eb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ea_);
                ae_ = eb_ as CqlDateTime;
            }
            else
            {
                DataType? ec_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                object? ed_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ec_);
                bool ee_ = ed_ is CqlDateTime;
                if (ee_)
                {
                    DataType? ef_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object? eg_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ef_);
                    ae_ = eg_ as CqlDateTime;
                }
                else
                {
                    DataType? eh_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                    object? ei_ = FHIRHelpers_4_4_000.Instance.ToValue(context, eh_);
                    bool ej_ = ei_ is CqlInterval<CqlDateTime>;
                    if (ej_)
                    {
                        DataType? ek_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Effective;
                        object? el_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ek_);
                        ae_ = el_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        ae_ = null;
                    }
                }
            }
            CqlDateTime? af_ = QICoreCommon_4_0_000.Instance.earliest(context, ae_);
            bool? ag_ = context.Operators.In<CqlDateTime?>(af_, ab_, (string?)default);
            bool? ah_ = context.Operators.And(ad_, ag_);
            Id? ai_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.IdElement;
            string? aj_ = ai_?.Value;
            Id? ak_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest?.IdElement;
            string? al_ = ak_?.Value;
            bool? am_ = context.Operators.Equivalent(aj_, al_);
            bool? an_ = context.Operators.Not(am_);
            bool? ao_ = context.Operators.And(ah_, an_);
            Code<ObservationStatus>? ap_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.StatusElement;
            ObservationStatus? aq_ = ap_?.Value;
            string? ar_ = context.Operators.Convert<string?>(aq_);
            string?[]? as_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? at_ = context.Operators.In<string?>(ar_, (IEnumerable<string?>?)as_);
            bool? au_ = context.Operators.And(ao_, at_);
            DataType? av_ = tuple_fcmdncyhjlqsajxzjwdiopqvk?.FollowupGlucoseTest?.Value;
            object? aw_ = FHIRHelpers_4_4_000.Instance.ToValue(context, av_);
            CqlQuantity? ax_ = context.Operators.Quantity(80m, "mg/dL");
            bool? ay_ = context.Operators.Greater(aw_ as CqlQuantity, ax_);
            bool? az_ = context.Operators.And(au_, ay_);
            return az_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? LowGlucoseTest, Observation? FollowupGlucoseTest)?>? h_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Observation?, Observation?>, (CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? LowGlucoseTest, Observation? FollowupGlucoseTest)?>(e_, f_, g_);
        Observation? i_((CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? LowGlucoseTest, Observation? FollowupGlucoseTest)? tuple_fcmdncyhjlqsajxzjwdiopqvk) => tuple_fcmdncyhjlqsajxzjwdiopqvk?.LowGlucoseTest;
        IEnumerable<Observation?>? j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? LowGlucoseTest, Observation? FollowupGlucoseTest)?, Observation?>(h_, i_);
        return j_;
    }


    [CqlExpressionDefinition("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Observation?>? Severe_Hypoglycemic_Harm_Event(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Severe_Hypoglycemic_Harm_Event, Severe_Hypoglycemic_Harm_Event_Compute);

    private const long _cacheIndex_Severe_Hypoglycemic_Harm_Event = 8409537978980512486L;

    private IEnumerable<Observation?>? Severe_Hypoglycemic_Harm_Event_Compute(CqlContext context)
    {
        IEnumerable<Observation?>? a_ = this.Glucose_Test_With_Result_Less_Than_40(context);

        bool? b_(Observation? LowGlucoseTest) {
            Id? d_ = LowGlucoseTest?.IdElement;
            string? e_ = d_?.Value;
            IEnumerable<Observation?>? f_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80(context);

            bool? g_(Observation? @this) {
                string? l_ = (@this is Resource
                    ? (@this as Resource).IdElement
                    : default)?.Value;
                bool? m_ = context.Operators.Not((bool?)(l_ is null));
                return m_;
            }


            string? h_(Observation? @this) {
                string? n_ = (@this is Resource
                    ? (@this as Resource).IdElement
                    : default)?.Value;
                return n_;
            }

            IEnumerable<string?>? i_ = context.Operators.WhereSelect<Observation?, string?>(f_, g_, h_);
            bool? j_ = context.Operators.In<string?>(e_, i_);
            bool? k_ = context.Operators.Not(j_);
            return k_;
        }

        IEnumerable<Observation?>? c_ = context.Operators.Where<Observation?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Encounter With Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter?>? Encounter_With_Severe_Hypoglycemic_Harm_Event(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Severe_Hypoglycemic_Harm_Event, Encounter_With_Severe_Hypoglycemic_Harm_Event_Compute);

    private const long _cacheIndex_Encounter_With_Severe_Hypoglycemic_Harm_Event = -4606868389057612456L;

    private IEnumerable<Encounter?>? Encounter_With_Severe_Hypoglycemic_Harm_Event_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Denominator(context);
        IEnumerable<Observation?>? b_ = this.Severe_Hypoglycemic_Harm_Event(context);
        IEnumerable<ValueTuple<Encounter?, Observation?>>? c_ = context.Operators.CrossJoin<Encounter?, Observation?>(a_, b_);

        (CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? HypoglycemicEvent)? d_(ValueTuple<Encounter?, Observation?> _valueTuple) {
            (CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? HypoglycemicEvent)? i_ = (CqlTupleMetadata_EUfjfKOXQBfhUJjAfTWLWTbNB, _valueTuple.Item1, _valueTuple.Item2);
            return i_;
        }


        bool? e_((CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? HypoglycemicEvent)? tuple_hqaveihellnsvbjqtehcabtjc) {
            object? j_;
            DataType? n_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
            object? o_ = FHIRHelpers_4_4_000.Instance.ToValue(context, n_);
            bool p_ = o_ is CqlDateTime;
            if (p_)
            {
                DataType? q_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
                object? r_ = FHIRHelpers_4_4_000.Instance.ToValue(context, q_);
                j_ = r_ as CqlDateTime;
            }
            else
            {
                DataType? s_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
                object? t_ = FHIRHelpers_4_4_000.Instance.ToValue(context, s_);
                bool u_ = t_ is CqlDateTime;
                if (u_)
                {
                    DataType? v_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
                    object? w_ = FHIRHelpers_4_4_000.Instance.ToValue(context, v_);
                    j_ = w_ as CqlDateTime;
                }
                else
                {
                    DataType? x_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
                    object? y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    bool z_ = y_ is CqlInterval<CqlDateTime>;
                    if (z_)
                    {
                        DataType? aa_ = tuple_hqaveihellnsvbjqtehcabtjc?.HypoglycemicEvent?.Effective;
                        object? ab_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aa_);
                        j_ = ab_ as CqlInterval<CqlDateTime?>;
                    }
                    else
                    {
                        j_ = null;
                    }
                }
            }
            CqlDateTime? k_ = QICoreCommon_4_0_000.Instance.earliest(context, j_);
            CqlInterval<CqlDateTime?>? l_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_hqaveihellnsvbjqtehcabtjc?.InpatientHospitalization);
            bool? m_ = context.Operators.In<CqlDateTime?>(k_, l_, (string?)default);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? HypoglycemicEvent)?>? f_ = context.Operators.SelectWhere<ValueTuple<Encounter?, Observation?>, (CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? HypoglycemicEvent)?>(c_, d_, e_);
        Encounter? g_((CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? HypoglycemicEvent)? tuple_hqaveihellnsvbjqtehcabtjc) => tuple_hqaveihellnsvbjqtehcabtjc?.InpatientHospitalization;
        IEnumerable<Encounter?>? h_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Encounter? InpatientHospitalization, Observation? HypoglycemicEvent)?, Encounter?>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter?>? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -573871386757981486L;

    private IEnumerable<Encounter?>? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_With_Severe_Hypoglycemic_Harm_Event(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -5075599977893582226L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 8003583007331791521L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -4550559775519135247L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 7055837076345808661L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
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
