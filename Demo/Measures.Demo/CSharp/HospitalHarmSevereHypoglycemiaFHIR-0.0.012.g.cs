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
[CqlLibrary("HospitalHarmSevereHypoglycemiaFHIR", "0.0.012")]
public partial class HospitalHarmSevereHypoglycemiaFHIR_0_0_012 : ILibrary, ISingleton<HospitalHarmSevereHypoglycemiaFHIR_0_0_012>
{
    #region ValueSets (7)

    [CqlValueSetDefinition("birth date", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", valueSetVersion: null)]
    public CqlValueSet birth_date(CqlContext _) => _birth_date;
    private static readonly CqlValueSet _birth_date = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

    [CqlValueSetDefinition("Emergency Department Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", valueSetVersion: null)]
    public CqlValueSet Emergency_Department_Visit(CqlContext _) => _Emergency_Department_Visit;
    private static readonly CqlValueSet _Emergency_Department_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Glucose lab test", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", valueSetVersion: null)]
    public CqlValueSet Glucose_lab_test(CqlContext _) => _Glucose_lab_test;
    private static readonly CqlValueSet _Glucose_lab_test = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.134", null);

    [CqlValueSetDefinition("Hypoglycemics", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3", valueSetVersion: null)]
    public CqlValueSet Hypoglycemics(CqlContext _) => _Hypoglycemics;
    private static readonly CqlValueSet _Hypoglycemics = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1179.3", null);

    [CqlValueSetDefinition("Hypoglycemics Severe Hypoglycemia", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", valueSetVersion: null)]
    public CqlValueSet Hypoglycemics_Severe_Hypoglycemia(CqlContext _) => _Hypoglycemics_Severe_Hypoglycemia;
    private static readonly CqlValueSet _Hypoglycemics_Severe_Hypoglycemia = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", null);

    [CqlValueSetDefinition("Observation Services", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", valueSetVersion: null)]
    public CqlValueSet Observation_Services(CqlContext _) => _Observation_Services;
    private static readonly CqlValueSet _Observation_Services = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    #endregion ValueSets

    #region Codes (1)

    [CqlCodeDefinition("Birth date", codeId: "21112-8", codeSystem: "http://loinc.org")]
    public CqlCode Birth_date(CqlContext _) => _Birth_date;
    private static readonly CqlCode _Birth_date = new CqlCode("21112-8", "http://loinc.org");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("LOINC", codeSystemId: "http://loinc.org", codeSystemVersion: null)]
    public CqlCodeSystem LOINC(CqlContext _) => _LOINC;
    private static readonly CqlCodeSystem _LOINC =
      new CqlCodeSystem("http://loinc.org", null, [
          _Birth_date]);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = 8711657917987574517L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlDateTime? b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, (decimal?)default);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (13)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 7709480296934025770L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept? code, Period? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 5954463937489644418L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept? code, Period? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept? code, Period? period)?>? a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding?>? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -1271471911845668063L;

    private IEnumerable<Coding?>? SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding?>? a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = 1712791761748354914L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter?>? Inpatient_Encounter_During_Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Inpatient_Encounter_During_Measurement_Period, Inpatient_Encounter_During_Measurement_Period_Compute);

    private const long _cacheIndex_Inpatient_Encounter_During_Measurement_Period = 7119230769913456010L;

    private IEnumerable<Encounter?>? Inpatient_Encounter_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter?>? b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? c_(Encounter? EncounterInpatient) {
            Code<Encounter.EncounterStatus>? e_ = EncounterInpatient?.StatusElement;
            string? f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "finished");
            Period? h_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime?>? i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);
            CqlDateTime? j_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime?>? k_ = this.Measurement_Period(context);
            bool? l_ = context.Operators.In<CqlDateTime?>(j_, k_, (string?)default);
            bool? m_ = context.Operators.And(g_, l_);
            return m_;
        }

        IEnumerable<Encounter?>? d_ = context.Operators.Where<Encounter?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter?>? Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter, Qualifying_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Encounter = -6318677756698785293L;

    private IEnumerable<Encounter?>? Qualifying_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Inpatient_Encounter_During_Measurement_Period(context);

        bool? b_(Encounter? InpatientEncounter) {
            Patient? d_ = this.Patient(context);
            Date? e_ = d_?.BirthDateElement;
            string? f_ = e_?.Value;
            CqlDateTime? g_ = context.Operators.ConvertStringToDateTime(f_);
            CqlInterval<CqlDateTime?>? h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime? i_ = context.Operators.Start(h_);
            int? j_ = context.Operators.CalculateAgeAt(g_, i_, "year");
            bool? k_ = context.Operators.GreaterOrEqual(j_, 18);
            return k_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration?>? Hypoglycemic_Medication_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Hypoglycemic_Medication_Administration, Hypoglycemic_Medication_Administration_Compute);

    private const long _cacheIndex_Hypoglycemic_Medication_Administration = -1419347126236055493L;

    private IEnumerable<MedicationAdministration?>? Hypoglycemic_Medication_Administration_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration?>? b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration?>? c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));

        bool? d_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? j_(Medication? M) {
                Id? l_ = M?.IdElement;
                string? m_ = FHIRHelpers_4_0_001.Instance.ToString(context, l_);
                object? n_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference");
                string? o_ = FHIRHelpers_4_0_001.Instance.ToString(context, n_ as FhirString);
                IEnumerable<string?>? p_ = context.Operators.Split(o_, "/");
                string? q_ = context.Operators.Last<string?>(p_);
                bool? r_ = context.Operators.Equal(m_, q_);
                CodeableConcept? s_ = M?.Code;
                CqlConcept? t_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, s_);
                CqlValueSet? u_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
                bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                bool? w_ = context.Operators.And(r_, v_);
                return w_;
            }

            bool? k_ = context.Operators.WhereAny<Medication?>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationAdministration?>? e_ = context.Operators.Where<MedicationAdministration?>(c_, d_);
        IEnumerable<MedicationAdministration?>? f_ = context.Operators.Union<MedicationAdministration?>(b_, e_);

        bool? g_(MedicationAdministration? HypoMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? x_ = HypoMedication?.StatusElement;
            string? y_ = FHIRHelpers_4_0_001.Instance.ToString(context, x_);
            bool? z_ = context.Operators.Equal(y_, "completed");
            bool? aa_ = context.Operators.Equal(y_, "not-done");
            bool? ab_ = context.Operators.Not(aa_);
            bool? ac_ = context.Operators.And(z_, ab_);
            return ac_;
        }

        IEnumerable<MedicationAdministration?>? h_ = context.Operators.Where<MedicationAdministration?>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Qualifying Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter?>? Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter_with_Hypoglycemic_Medication_Administration, Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Compute);

    private const long _cacheIndex_Qualifying_Encounter_with_Hypoglycemic_Medication_Administration = -2889112349305435855L;

    private IEnumerable<Encounter?>? Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter? QualifyingEncounter) {
            IEnumerable<MedicationAdministration?>? d_ = this.Hypoglycemic_Medication_Administration(context);

            bool? e_(MedicationAdministration? HypoglycemicMedication) {
                DataType? g_ = HypoglycemicMedication?.Effective;
                CqlInterval<CqlDateTime?>? h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, g_);
                CqlDateTime? i_ = context.Operators.Start(h_);
                CqlInterval<CqlDateTime?>? j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? k_ = context.Operators.In<CqlDateTime?>(i_, j_, (string?)default);
                return k_;
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

    private const long _cacheIndex_Initial_Population = -8827280791602122766L;

    private IEnumerable<Encounter?>? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter?>? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -934546296167487755L;

    private IEnumerable<Encounter?>? Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter?>? Severe_Hypoglycemic_Harm_Event(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Severe_Hypoglycemic_Harm_Event, Severe_Hypoglycemic_Harm_Event_Compute);

    private const long _cacheIndex_Severe_Hypoglycemic_Harm_Event = 3959577614040153490L;

    private IEnumerable<Encounter?>? Severe_Hypoglycemic_Harm_Event_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Denominator(context);

        bool? b_(Encounter? QualifyingEncounter) {
            CqlValueSet? d_ = this.Glucose_lab_test(context);
            IEnumerable<Observation?>? e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

            bool? f_(Observation? BloodGlucoseLab) {
                IEnumerable<MedicationAdministration?>? l_ = this.Hypoglycemic_Medication_Administration(context);

                bool? m_(MedicationAdministration? HypoglycemicMeds) {
                    DataType? o_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime?>? p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, o_);
                    CqlDateTime? q_ = context.Operators.Start(p_);
                    DataType? r_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime?>? s_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, r_);
                    CqlDateTime? t_ = context.Operators.Start(s_);
                    CqlQuantity? u_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime? v_ = context.Operators.Subtract(t_, u_);
                    CqlInterval<CqlDateTime?>? w_ = context.Operators.Interval(v_, t_, true, true);
                    bool? x_ = context.Operators.In<CqlDateTime?>(q_, w_, (string?)default);
                    bool? y_ = context.Operators.Not((bool?)(t_ is null));
                    bool? z_ = context.Operators.And(x_, y_);
                    Code<ObservationStatus>? aa_ = BloodGlucoseLab?.StatusElement;
                    string? ab_ = FHIRHelpers_4_0_001.Instance.ToString(context, aa_);
                    bool? ac_ = context.Operators.Equal(ab_, "final");
                    bool? ad_ = context.Operators.And(z_, ac_);
                    bool? ae_ = context.Operators.Equal(ab_, "cancelled");
                    bool? af_ = context.Operators.Not(ae_);
                    bool? ag_ = context.Operators.And(ad_, af_);
                    CqlInterval<CqlDateTime?>? ah_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? ai_ = context.Operators.In<CqlDateTime?>(q_, ah_, (string?)default);
                    bool? aj_ = context.Operators.And(ag_, ai_);
                    return aj_;
                }

                bool? n_ = context.Operators.WhereAny<MedicationAdministration?>(l_, m_);
                return n_;
            }

            IEnumerable<Observation?>? g_ = context.Operators.Where<Observation?>(e_, f_);

            bool? h_(Observation? BloodGlucoseLab) {
                CqlValueSet? ak_ = this.Glucose_lab_test(context);
                IEnumerable<Observation?>? al_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ak_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

                bool? am_(Observation? FollowupBloodGlucoseLab) {
                    DataType? ap_ = FollowupBloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime?>? aq_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, ap_);
                    CqlDateTime? ar_ = context.Operators.Start(aq_);
                    CqlInterval<CqlDateTime?>? as_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? at_ = context.Operators.In<CqlDateTime?>(ar_, as_, (string?)default);
                    DataType? au_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime?>? av_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, au_);
                    CqlDateTime? aw_ = context.Operators.Start(av_);
                    CqlQuantity? ax_ = context.Operators.Quantity(5m, "minutes");
                    CqlDateTime? ay_ = context.Operators.Add(aw_, ax_);
                    CqlInterval<CqlDateTime?>? az_ = context.Operators.Interval(aw_, ay_, false, true);
                    bool? ba_ = context.Operators.In<CqlDateTime?>(ar_, az_, (string?)default);
                    bool? bb_ = context.Operators.Not((bool?)(aw_ is null));
                    bool? bc_ = context.Operators.And(ba_, bb_);
                    bool? bd_ = context.Operators.And(at_, bc_);
                    Code<ObservationStatus>? be_ = FollowupBloodGlucoseLab?.StatusElement;
                    string? bf_ = FHIRHelpers_4_0_001.Instance.ToString(context, be_);
                    bool? bg_ = context.Operators.Equal(bf_, "final");
                    bool? bh_ = context.Operators.And(bd_, bg_);
                    bool? bi_ = context.Operators.Equal(bf_, "cancelled");
                    bool? bj_ = context.Operators.Not(bi_);
                    bool? bk_ = context.Operators.And(bh_, bj_);
                    DataType? bl_ = FollowupBloodGlucoseLab?.Value;
                    CqlQuantity? bm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bl_ as Quantity);
                    CqlQuantity? bn_ = context.Operators.Quantity(80m, "mg/dL");
                    bool? bo_ = context.Operators.Greater(bm_, bn_);
                    bool? bp_ = context.Operators.And(bk_, bo_);
                    return bp_;
                }

                bool? an_ = context.Operators.WhereAny<Observation?>(al_, am_);
                bool? ao_ = context.Operators.Not(an_);
                return ao_;
            }

            IEnumerable<Observation?>? i_ = context.Operators.Where<Observation?>(g_, h_);

            bool? j_(Observation? BloodGlucoseLab) {
                DataType? bq_ = BloodGlucoseLab?.Effective;
                CqlInterval<CqlDateTime?>? br_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bq_);
                CqlDateTime? bs_ = context.Operators.Start(br_);
                CqlInterval<CqlDateTime?>? bt_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? bu_ = context.Operators.In<CqlDateTime?>(bs_, bt_, (string?)default);
                DataType? bv_ = BloodGlucoseLab?.Value;
                CqlQuantity? bw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bv_ as Quantity);
                CqlQuantity? bx_ = context.Operators.Quantity(40m, "mg/dL");
                bool? by_ = context.Operators.Less(bw_, bx_);
                bool? bz_ = context.Operators.And(bu_, by_);
                return bz_;
            }

            bool? k_ = context.Operators.WhereAny<Observation?>(i_, j_);
            return k_;
        }

        IEnumerable<Encounter?>? c_ = context.Operators.Where<Encounter?>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter?>? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -7641061183783562118L;

    private IEnumerable<Encounter?>? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Severe_Hypoglycemic_Harm_Event(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding?>? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -3471174387060058517L;

    private IEnumerable<Coding?>? SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding?>? a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private HospitalHarmSevereHypoglycemiaFHIR_0_0_012() {}

    public static HospitalHarmSevereHypoglycemiaFHIR_0_0_012 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "HospitalHarmSevereHypoglycemiaFHIR";
    public string Version => "0.0.012";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, SupplementalDataElementsFHIR4_2_0_000.Instance, MATGlobalCommonFunctionsFHIR4_6_1_000.Instance];

    #endregion ILibrary Implementation

}
