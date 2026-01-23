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
using Hl7.Cql.Runtime.Internal;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "6.0.0.0")]
[CqlLibrary("HospitalHarmSevereHypoglycemiaFHIR", "0.0.012")]
public partial class HospitalHarmSevereHypoglycemiaFHIR_0_0_012 : ILibrary, ILibraryInternals, ISingleton<HospitalHarmSevereHypoglycemiaFHIR_0_0_012>
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
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute, context) ?? Measurement_Period_Compute(context);

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2019, 1, 1, 0, 0, 0, 0, default);
        CqlDateTime b_ = context.Operators.DateTime(2020, 1, 1, 0, 0, 0, 0, default);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.0.012", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (13)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Patient, Patient_Compute, context) ?? Patient_Compute(context);

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute, context) ?? SDE_Payer_Compute(context);

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute, context) ?? SDE_Race_Compute(context);

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute, context) ?? SDE_Sex_Compute(context);

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Sex(context);
        return a_;
    }


    [CqlExpressionDefinition("Inpatient Encounter During Measurement Period")]
    public IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Inpatient_Encounter_During_Measurement_Period, Inpatient_Encounter_During_Measurement_Period_Compute, context) ?? Inpatient_Encounter_During_Measurement_Period_Compute(context);

    private IEnumerable<Encounter> Inpatient_Encounter_During_Measurement_Period_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Encounter_Inpatient(context);
        IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Encounter"));

        bool? c_(Encounter EncounterInpatient) {
            Code<Encounter.EncounterStatus> e_ = EncounterInpatient?.StatusElement;
            string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
            bool? g_ = context.Operators.Equal(f_, "finished");
            Period h_ = EncounterInpatient?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.Instance.ToInterval(context, h_);
            CqlDateTime j_ = context.Operators.End(i_);
            CqlInterval<CqlDateTime> k_ = this.Measurement_Period(context);
            bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, default);
            bool? m_ = context.Operators.And(g_, l_);
            return m_;
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Qualifying_Encounter, Qualifying_Encounter_Compute, context) ?? Qualifying_Encounter_Compute(context);

    private IEnumerable<Encounter> Qualifying_Encounter_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Inpatient_Encounter_During_Measurement_Period(context);

        bool? b_(Encounter InpatientEncounter) {
            Patient d_ = this.Patient(context);
            Date e_ = d_?.BirthDateElement;
            string f_ = e_?.Value;
            CqlDateTime g_ = context.Operators.ConvertStringToDateTime(f_);
            CqlInterval<CqlDateTime> h_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, InpatientEncounter);
            CqlDateTime i_ = context.Operators.Start(h_);
            int? j_ = context.Operators.CalculateAgeAt(g_, i_, "year");
            bool? k_ = context.Operators.GreaterOrEqual(j_, 18);
            return k_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Hypoglycemic Medication Administration")]
    public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Hypoglycemic_Medication_Administration, Hypoglycemic_Medication_Administration_Compute, context) ?? Hypoglycemic_Medication_Administration_Compute(context);

    private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
        IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));
        IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/MedicationAdministration"));

        IEnumerable<MedicationAdministration> d_(MedicationAdministration MR) {
            IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Medication"));

            bool? j_(Medication M) {
                Id n_ = M?.IdElement;
                string o_ = FHIRHelpers_4_0_001.Instance.ToString(context, n_);
                object p_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference");
                string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_ as FhirString);
                IEnumerable<string> r_ = context.Operators.Split(q_, "/");
                string s_ = context.Operators.Last<string>(r_);
                bool? t_ = context.Operators.Equal(o_, s_);
                CodeableConcept u_ = M?.Code;
                CqlConcept v_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, u_);
                CqlValueSet w_ = this.Hypoglycemics_Severe_Hypoglycemia(context);
                bool? x_ = context.Operators.ConceptInValueSet(v_, w_);
                bool? y_ = context.Operators.And(t_, x_);
                return y_;
            }

            IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
            MedicationAdministration l_(Medication M) => MR;
            IEnumerable<MedicationAdministration> m_ = context.Operators.Select<Medication, MedicationAdministration>(k_, l_);
            return m_;
        }

        IEnumerable<MedicationAdministration> e_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(c_, d_);
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(b_, e_);

        bool? g_(MedicationAdministration HypoMedication) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> z_ = HypoMedication?.StatusElement;
            string aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
            bool? ab_ = context.Operators.Equal(aa_, "completed");
            string ad_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
            bool? ae_ = context.Operators.Equal(ad_, "not-done");
            bool? af_ = context.Operators.Not(ae_);
            bool? ag_ = context.Operators.And(ab_, af_);
            return ag_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Qualifying Encounter with Hypoglycemic Medication Administration")]
    public IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Qualifying_Encounter_with_Hypoglycemic_Medication_Administration, Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Compute, context) ?? Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Compute(context);

    private IEnumerable<Encounter> Qualifying_Encounter_with_Hypoglycemic_Medication_Administration_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        IEnumerable<Encounter> b_(Encounter QualifyingEncounter) {
            IEnumerable<MedicationAdministration> d_ = this.Hypoglycemic_Medication_Administration(context);

            bool? e_(MedicationAdministration HypoglycemicMedication) {
                DataType i_ = HypoglycemicMedication?.Effective;
                CqlInterval<CqlDateTime> j_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, i_);
                CqlDateTime k_ = context.Operators.Start(j_);
                CqlInterval<CqlDateTime> l_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, default);
                return m_;
            }

            IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
            Encounter g_(MedicationAdministration HypoglycemicMedication) => QualifyingEncounter;
            IEnumerable<Encounter> h_ = context.Operators.Select<MedicationAdministration, Encounter>(f_, g_);
            return h_;
        }

        IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Initial_Population, Initial_Population_Compute, context) ?? Initial_Population_Compute(context);

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter_with_Hypoglycemic_Medication_Administration(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute, context) ?? Denominator_Compute(context);

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Severe Hypoglycemic Harm Event")]
    public IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Severe_Hypoglycemic_Harm_Event, Severe_Hypoglycemic_Harm_Event_Compute, context) ?? Severe_Hypoglycemic_Harm_Event_Compute(context);

    private IEnumerable<Encounter> Severe_Hypoglycemic_Harm_Event_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Denominator(context);

        bool? b_(Encounter QualifyingEncounter) {
            CqlValueSet d_ = this.Glucose_lab_test(context);
            IEnumerable<Observation> e_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

            IEnumerable<Observation> f_(Observation BloodGlucoseLab) {
                IEnumerable<MedicationAdministration> r_ = this.Hypoglycemic_Medication_Administration(context);

                bool? s_(MedicationAdministration HypoglycemicMeds) {
                    DataType w_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> x_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, w_);
                    CqlDateTime y_ = context.Operators.Start(x_);
                    DataType z_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> aa_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, z_);
                    CqlDateTime ab_ = context.Operators.Start(aa_);
                    CqlQuantity ac_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime ad_ = context.Operators.Subtract(ab_, ac_);
                    CqlInterval<CqlDateTime> af_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, z_);
                    CqlDateTime ag_ = context.Operators.Start(af_);
                    CqlInterval<CqlDateTime> ah_ = context.Operators.Interval(ad_, ag_, true, true);
                    bool? ai_ = context.Operators.In<CqlDateTime>(y_, ah_, default);
                    CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, z_);
                    CqlDateTime al_ = context.Operators.Start(ak_);
                    bool? am_ = context.Operators.Not((bool?)(al_ is null));
                    bool? an_ = context.Operators.And(ai_, am_);
                    Code<ObservationStatus> ao_ = BloodGlucoseLab?.StatusElement;
                    string ap_ = FHIRHelpers_4_0_001.Instance.ToString(context, ao_);
                    bool? aq_ = context.Operators.Equal(ap_, "final");
                    bool? ar_ = context.Operators.And(an_, aq_);
                    string at_ = FHIRHelpers_4_0_001.Instance.ToString(context, ao_);
                    bool? au_ = context.Operators.Equal(at_, "cancelled");
                    bool? av_ = context.Operators.Not(au_);
                    bool? aw_ = context.Operators.And(ar_, av_);
                    CqlInterval<CqlDateTime> ay_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, w_);
                    CqlDateTime az_ = context.Operators.Start(ay_);
                    CqlInterval<CqlDateTime> ba_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? bb_ = context.Operators.In<CqlDateTime>(az_, ba_, default);
                    bool? bc_ = context.Operators.And(aw_, bb_);
                    return bc_;
                }

                IEnumerable<MedicationAdministration> t_ = context.Operators.Where<MedicationAdministration>(r_, s_);
                Observation u_(MedicationAdministration HypoglycemicMeds) => BloodGlucoseLab;
                IEnumerable<Observation> v_ = context.Operators.Select<MedicationAdministration, Observation>(t_, u_);
                return v_;
            }

            IEnumerable<Observation> g_ = context.Operators.SelectMany<Observation, Observation>(e_, f_);
            IEnumerable<Observation> i_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

            IEnumerable<Observation> j_(Observation BloodGlucoseLab) {
                IEnumerable<MedicationAdministration> bd_ = this.Hypoglycemic_Medication_Administration(context);

                bool? be_(MedicationAdministration HypoglycemicMeds) {
                    DataType bi_ = HypoglycemicMeds?.Effective;
                    CqlInterval<CqlDateTime> bj_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bi_);
                    CqlDateTime bk_ = context.Operators.Start(bj_);
                    DataType bl_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> bm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bl_);
                    CqlDateTime bn_ = context.Operators.Start(bm_);
                    CqlQuantity bo_ = context.Operators.Quantity(24m, "hours");
                    CqlDateTime bp_ = context.Operators.Subtract(bn_, bo_);
                    CqlInterval<CqlDateTime> br_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bl_);
                    CqlDateTime bs_ = context.Operators.Start(br_);
                    CqlInterval<CqlDateTime> bt_ = context.Operators.Interval(bp_, bs_, true, true);
                    bool? bu_ = context.Operators.In<CqlDateTime>(bk_, bt_, default);
                    CqlInterval<CqlDateTime> bw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bl_);
                    CqlDateTime bx_ = context.Operators.Start(bw_);
                    bool? by_ = context.Operators.Not((bool?)(bx_ is null));
                    bool? bz_ = context.Operators.And(bu_, by_);
                    Code<ObservationStatus> ca_ = BloodGlucoseLab?.StatusElement;
                    string cb_ = FHIRHelpers_4_0_001.Instance.ToString(context, ca_);
                    bool? cc_ = context.Operators.Equal(cb_, "final");
                    bool? cd_ = context.Operators.And(bz_, cc_);
                    string cf_ = FHIRHelpers_4_0_001.Instance.ToString(context, ca_);
                    bool? cg_ = context.Operators.Equal(cf_, "cancelled");
                    bool? ch_ = context.Operators.Not(cg_);
                    bool? ci_ = context.Operators.And(cd_, ch_);
                    CqlInterval<CqlDateTime> ck_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, bi_);
                    CqlDateTime cl_ = context.Operators.Start(ck_);
                    CqlInterval<CqlDateTime> cm_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? cn_ = context.Operators.In<CqlDateTime>(cl_, cm_, default);
                    bool? co_ = context.Operators.And(ci_, cn_);
                    return co_;
                }

                IEnumerable<MedicationAdministration> bf_ = context.Operators.Where<MedicationAdministration>(bd_, be_);
                Observation bg_(MedicationAdministration HypoglycemicMeds) => BloodGlucoseLab;
                IEnumerable<Observation> bh_ = context.Operators.Select<MedicationAdministration, Observation>(bf_, bg_);
                return bh_;
            }

            IEnumerable<Observation> k_ = context.Operators.SelectMany<Observation, Observation>(i_, j_);

            IEnumerable<Observation> l_(Observation BloodGlucoseLab) {
                CqlValueSet cp_ = this.Glucose_lab_test(context);
                IEnumerable<Observation> cq_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, cp_, default, "http://hl7.org/fhir/StructureDefinition/Observation"));

                bool? cr_(Observation FollowupBloodGlucoseLab) {
                    DataType cv_ = FollowupBloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> cw_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, cv_);
                    CqlDateTime cx_ = context.Operators.Start(cw_);
                    CqlInterval<CqlDateTime> cy_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                    bool? cz_ = context.Operators.In<CqlDateTime>(cx_, cy_, default);
                    CqlInterval<CqlDateTime> db_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, cv_);
                    CqlDateTime dc_ = context.Operators.Start(db_);
                    DataType dd_ = BloodGlucoseLab?.Effective;
                    CqlInterval<CqlDateTime> de_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dd_);
                    CqlDateTime df_ = context.Operators.Start(de_);
                    CqlInterval<CqlDateTime> dh_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dd_);
                    CqlDateTime di_ = context.Operators.Start(dh_);
                    CqlQuantity dj_ = context.Operators.Quantity(5m, "minutes");
                    CqlDateTime dk_ = context.Operators.Add(di_, dj_);
                    CqlInterval<CqlDateTime> dl_ = context.Operators.Interval(df_, dk_, false, true);
                    bool? dm_ = context.Operators.In<CqlDateTime>(dc_, dl_, default);
                    CqlInterval<CqlDateTime> do_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, dd_);
                    CqlDateTime dp_ = context.Operators.Start(do_);
                    bool? dq_ = context.Operators.Not((bool?)(dp_ is null));
                    bool? dr_ = context.Operators.And(dm_, dq_);
                    bool? ds_ = context.Operators.And(cz_, dr_);
                    Code<ObservationStatus> dt_ = FollowupBloodGlucoseLab?.StatusElement;
                    string du_ = FHIRHelpers_4_0_001.Instance.ToString(context, dt_);
                    bool? dv_ = context.Operators.Equal(du_, "final");
                    bool? dw_ = context.Operators.And(ds_, dv_);
                    string dy_ = FHIRHelpers_4_0_001.Instance.ToString(context, dt_);
                    bool? dz_ = context.Operators.Equal(dy_, "cancelled");
                    bool? ea_ = context.Operators.Not(dz_);
                    bool? eb_ = context.Operators.And(dw_, ea_);
                    DataType ec_ = FollowupBloodGlucoseLab?.Value;
                    CqlQuantity ed_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ec_ as Quantity);
                    CqlQuantity ee_ = context.Operators.Quantity(80m, "mg/dL");
                    bool? ef_ = context.Operators.Greater(ed_, ee_);
                    bool? eg_ = context.Operators.And(eb_, ef_);
                    return eg_;
                }

                IEnumerable<Observation> cs_ = context.Operators.Where<Observation>(cq_, cr_);
                Observation ct_(Observation FollowupBloodGlucoseLab) => BloodGlucoseLab;
                IEnumerable<Observation> cu_ = context.Operators.Select<Observation, Observation>(cs_, ct_);
                return cu_;
            }

            IEnumerable<Observation> m_ = context.Operators.SelectMany<Observation, Observation>(k_, l_);
            IEnumerable<Observation> n_ = context.Operators.Except<Observation>(g_, m_);

            bool? o_(Observation BloodGlucoseLab) {
                DataType eh_ = BloodGlucoseLab?.Effective;
                CqlInterval<CqlDateTime> ei_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.Normalize_Interval(context, eh_);
                CqlDateTime ej_ = context.Operators.Start(ei_);
                CqlInterval<CqlDateTime> ek_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Instance.HospitalizationWithObservation(context, QualifyingEncounter);
                bool? el_ = context.Operators.In<CqlDateTime>(ej_, ek_, default);
                DataType em_ = BloodGlucoseLab?.Value;
                CqlQuantity en_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, em_ as Quantity);
                CqlQuantity eo_ = context.Operators.Quantity(40m, "mg/dL");
                bool? ep_ = context.Operators.Less(en_, eo_);
                bool? eq_ = context.Operators.And(el_, ep_);
                return eq_;
            }

            IEnumerable<Observation> p_ = context.Operators.Where<Observation>(n_, o_);
            bool? q_ = context.Operators.Exists<Observation>(p_);
            return q_;
        }

        IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
        return c_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute, context) ?? Numerator_Compute(context);

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Severe_Hypoglycemic_Harm_Event(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        _cache?.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute, context) ?? SDE_Ethnicity_Compute(context);

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Cache Index Fields (14)

    private int _cacheIndex_Measurement_Period = -1;
    private int _cacheIndex_Patient = -1;
    private int _cacheIndex_SDE_Payer = -1;
    private int _cacheIndex_SDE_Race = -1;
    private int _cacheIndex_SDE_Sex = -1;
    private int _cacheIndex_Inpatient_Encounter_During_Measurement_Period = -1;
    private int _cacheIndex_Qualifying_Encounter = -1;
    private int _cacheIndex_Hypoglycemic_Medication_Administration = -1;
    private int _cacheIndex_Qualifying_Encounter_with_Hypoglycemic_Medication_Administration = -1;
    private int _cacheIndex_Initial_Population = -1;
    private int _cacheIndex_Denominator = -1;
    private int _cacheIndex_Severe_Hypoglycemic_Harm_Event = -1;
    private int _cacheIndex_Numerator = -1;
    private int _cacheIndex_SDE_Ethnicity = -1;

    #endregion Cache Index Fields

    #region ILibraryInternals Implementation

    // Reference to the execution cache instance that initialized this library
    private CqlLibrarySetInvocationCache _cache;

    /// <summary>
    /// Initializes cache indices for this library's cached expressions.
    /// </summary>
    /// <param name="cache">The execution cache instance performing initialization.</param>
    /// <param name="startIndex">The starting index for cache field assignment.</param>
    /// <returns>The number of cache indices initialized (number of cached expressions in this library).</returns>
    int ILibraryInternals.InitializeCacheIndices(
        CqlLibrarySetInvocationCache cache,
        int startIndex)
    {
        // Skip if already initialized by this cache instance (allows re-initialization with different cache)
        if (_cache == cache)
            return 0;

        _cache = cache;

        var index = startIndex;
        _cacheIndex_Measurement_Period = index++;
        _cacheIndex_Patient = index++;
        _cacheIndex_SDE_Payer = index++;
        _cacheIndex_SDE_Race = index++;
        _cacheIndex_SDE_Sex = index++;
        _cacheIndex_Inpatient_Encounter_During_Measurement_Period = index++;
        _cacheIndex_Qualifying_Encounter = index++;
        _cacheIndex_Hypoglycemic_Medication_Administration = index++;
        _cacheIndex_Qualifying_Encounter_with_Hypoglycemic_Medication_Administration = index++;
        _cacheIndex_Initial_Population = index++;
        _cacheIndex_Denominator = index++;
        _cacheIndex_Severe_Hypoglycemic_Harm_Event = index++;
        _cacheIndex_Numerator = index++;
        _cacheIndex_SDE_Ethnicity = index++;
        return index - startIndex;
    }

    #endregion ILibraryInternals Implementation

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
