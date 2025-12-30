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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.1.0.0")]
[CqlLibrary("CMS819FHIRHHORAE", "1.0.000")]
public partial class CMS819FHIRHHORAE_1_0_000 : ILibrary, ISingleton<CMS819FHIRHHORAE_1_0_000>
{
    private CMS819FHIRHHORAE_1_0_000() {}

    public static CMS819FHIRHHORAE_1_0_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "CMS819FHIRHHORAE";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region Nested Type - Cached<T>

    private struct Cached<T>(object CacheVersion, T CachedValue)
    {
        public T GetOrReplace(ICqlContextInternals cqlContext, Func<T> factory)
        {
            var cqlContextCacheVersion = cqlContext.CacheVersion;
            if (cqlContextCacheVersion is null)
            {
                // No caching, clear out previous values
                CacheVersion = null;
                CachedValue = default;
                var value = factory();
                return value;
            }

            if (ReferenceEquals(CacheVersion, cqlContextCacheVersion))
            {
                // Cache hit
                return CachedValue;
            }
            else
            {
                // Cache miss, refresh and store
                var value = factory();
                CachedValue = value;
                CacheVersion = cqlContextCacheVersion;
                return value;
            }
        }
    }

    #endregion

    #region ValueSets

    [CqlValueSetDefinition("Encounter Inpatient", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", valueSetVersion: null)]
    public CqlValueSet Encounter_Inpatient(CqlContext _) => _Encounter_Inpatient;
    private static readonly CqlValueSet _Encounter_Inpatient = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlValueSetDefinition("Operating Room Suite", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141", valueSetVersion: null)]
    public CqlValueSet Operating_Room_Suite(CqlContext _) => _Operating_Room_Suite;
    private static readonly CqlValueSet _Operating_Room_Suite = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141", null);

    [CqlValueSetDefinition("Opioid Antagonist", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119", valueSetVersion: null)]
    public CqlValueSet Opioid_Antagonist(CqlContext _) => _Opioid_Antagonist;
    private static readonly CqlValueSet _Opioid_Antagonist = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119", null);

    [CqlValueSetDefinition("Opioids, All", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226", valueSetVersion: null)]
    public CqlValueSet Opioids__All(CqlContext _) => _Opioids__All;
    private static readonly CqlValueSet _Opioids__All = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226", null);

    [CqlValueSetDefinition("Routes of Administration for Opioid Antagonists", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187", valueSetVersion: null)]
    public CqlValueSet Routes_of_Administration_for_Opioid_Antagonists(CqlContext _) => _Routes_of_Administration_for_Opioid_Antagonists;
    private static readonly CqlValueSet _Routes_of_Administration_for_Opioid_Antagonists = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187", null);

    #endregion ValueSets

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, []);

    #endregion CodeSystems

    #region Parameters

    private Cached<CqlInterval<CqlDateTime>> _Measurement_Period_Cached = new();

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        _Measurement_Period_Cached.GetOrReplace(
            context,
            () =>
            {
                object a_ = context.ResolveParameter("CMS819FHIRHHORAE-1.0.000", "Measurement Period", null);
                return (CqlInterval<CqlDateTime>)a_;
            });


    #endregion Parameters

    #region Functions and Expressions

    private Cached<Patient> _Patient_Cached = new();

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        _Patient_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
                Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
                return b_;
            });


    private Cached<IEnumerable<Encounter>> _Qualifying_Encounter_Cached = new();

    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context) =>
        _Qualifying_Encounter_Cached.GetOrReplace(
            context,
            () =>
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
            });


    private Cached<IEnumerable<MedicationAdministration>> _Opioid_Administration_Cached = new();

    [CqlExpressionDefinition("Opioid Administration")]
    public IEnumerable<MedicationAdministration> Opioid_Administration(CqlContext context) =>
        _Opioid_Administration_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Opioids__All(context);
                IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
                IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

                IEnumerable<MedicationAdministration> d_(MedicationAdministration MR) {
                    IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? j_(Medication M) {
                        object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                        string q_ = context.Operators.Last<string>(p_);
                        bool? r_ = context.Operators.Equal(n_, q_);
                        CodeableConcept s_ = M?.Code;
                        CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                        CqlValueSet u_ = this.Opioids__All(context);
                        bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                        bool? w_ = context.Operators.And(r_, v_);
                        return w_;
                    }

                    IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
                    MedicationAdministration l_(Medication M) => MR;
                    IEnumerable<MedicationAdministration> m_ = context.Operators.Select<Medication, MedicationAdministration>(k_, l_);
                    return m_;
                }

                IEnumerable<MedicationAdministration> e_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(c_, d_);
                IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(b_, e_);

                bool? g_(MedicationAdministration Opioids) {
                    Code<MedicationAdministration.MedicationAdministrationStatusCodes> x_ = Opioids?.StatusElement;
                    MedicationAdministration.MedicationAdministrationStatusCodes? y_ = x_?.Value;
                    string z_ = context.Operators.Convert<string>(y_);
                    bool? aa_ = context.Operators.Equal(z_, "completed");
                    return aa_;
                }

                IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
                return h_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_With_Opioid_Administration_Outside_Of_Operating_Room_Cached = new();

    [CqlExpressionDefinition("Encounter With Opioid Administration Outside Of Operating Room")]
    public IEnumerable<Encounter> Encounter_With_Opioid_Administration_Outside_Of_Operating_Room(CqlContext context) =>
        _Encounter_With_Opioid_Administration_Outside_Of_Operating_Room_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

                IEnumerable<Encounter> b_(Encounter InpatientEncounter) {
                    IEnumerable<MedicationAdministration> d_ = this.Opioid_Administration(context);

                    bool? e_(MedicationAdministration OpioidGiven) {
                        DataType i_ = OpioidGiven?.Effective;
                        object j_ = FHIRHelpers_4_4_000.Instance.ToValue(context, i_);
                        CqlInterval<CqlDateTime> k_ = QICoreCommon_4_0_000.Instance.toInterval(context, j_);
                        CqlDateTime l_ = context.Operators.Start(k_);
                        CqlInterval<CqlDateTime> m_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                        bool? n_ = context.Operators.In<CqlDateTime>(l_, m_, default);
                        List<Encounter.LocationComponent> o_ = InpatientEncounter?.Location;

                        bool? p_(Encounter.LocationComponent EncounterLocation) {
                            ResourceReference u_ = EncounterLocation?.Location;
                            Location v_ = CQMCommon_4_1_000.Instance.getLocation(context, u_);
                            List<CodeableConcept> w_ = v_?.Type;

                            CqlConcept x_(CodeableConcept @this) {
                                CqlConcept aj_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                                return aj_;
                            }

                            IEnumerable<CqlConcept> y_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)w_, x_);
                            CqlValueSet z_ = this.Operating_Room_Suite(context);
                            bool? aa_ = context.Operators.ConceptsInValueSet(y_, z_);
                            DataType ab_ = OpioidGiven?.Effective;
                            object ac_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ab_);
                            CqlInterval<CqlDateTime> ad_ = QICoreCommon_4_0_000.Instance.toInterval(context, ac_);
                            CqlDateTime ae_ = context.Operators.Start(ad_);
                            Period af_ = EncounterLocation?.Period;
                            CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, af_);
                            bool? ah_ = context.Operators.In<CqlDateTime>(ae_, ag_, default);
                            bool? ai_ = context.Operators.And(aa_, ah_);
                            return ai_;
                        }

                        IEnumerable<Encounter.LocationComponent> q_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)o_, p_);
                        bool? r_ = context.Operators.Exists<Encounter.LocationComponent>(q_);
                        bool? s_ = context.Operators.Not(r_);
                        bool? t_ = context.Operators.And(n_, s_);
                        return t_;
                    }

                    IEnumerable<MedicationAdministration> f_ = context.Operators.Where<MedicationAdministration>(d_, e_);
                    Encounter g_(MedicationAdministration OpioidGiven) => InpatientEncounter;
                    IEnumerable<Encounter> h_ = context.Operators.Select<MedicationAdministration, Encounter>(f_, g_);
                    return h_;
                }

                IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
                return c_;
            });


    private Cached<IEnumerable<Encounter>> _Initial_Population_Cached = new();

    [CqlExpressionDefinition("Initial Population")]
    public IEnumerable<Encounter> Initial_Population(CqlContext context) =>
        _Initial_Population_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Encounter_With_Opioid_Administration_Outside_Of_Operating_Room(context);
                return a_;
            });


    private Cached<IEnumerable<Encounter>> _Denominator_Cached = new();

    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        _Denominator_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Initial_Population(context);
                return a_;
            });


    private Cached<IEnumerable<MedicationAdministration>> _Non_Enteral_Opioid_Antagonist_Administration_Cached = new();

    [CqlExpressionDefinition("Non Enteral Opioid Antagonist Administration")]
    public IEnumerable<MedicationAdministration> Non_Enteral_Opioid_Antagonist_Administration(CqlContext context) =>
        _Non_Enteral_Opioid_Antagonist_Administration_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlValueSet a_ = this.Opioid_Antagonist(context);
                IEnumerable<MedicationAdministration> b_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
                IEnumerable<MedicationAdministration> c_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

                IEnumerable<MedicationAdministration> d_(MedicationAdministration MR) {
                    IEnumerable<Medication> i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

                    bool? j_(Medication M) {
                        object n_ = context.Operators.LateBoundProperty<object>(M, "id.value");
                        object o_ = context.Operators.LateBoundProperty<object>(MR, "medication.reference.value");
                        IEnumerable<string> p_ = context.Operators.Split((string)o_, "/");
                        string q_ = context.Operators.Last<string>(p_);
                        bool? r_ = context.Operators.Equal(n_, q_);
                        CodeableConcept s_ = M?.Code;
                        CqlConcept t_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, s_);
                        CqlValueSet u_ = this.Opioid_Antagonist(context);
                        bool? v_ = context.Operators.ConceptInValueSet(t_, u_);
                        bool? w_ = context.Operators.And(r_, v_);
                        return w_;
                    }

                    IEnumerable<Medication> k_ = context.Operators.Where<Medication>(i_, j_);
                    MedicationAdministration l_(Medication M) => MR;
                    IEnumerable<MedicationAdministration> m_ = context.Operators.Select<Medication, MedicationAdministration>(k_, l_);
                    return m_;
                }

                IEnumerable<MedicationAdministration> e_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(c_, d_);
                IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(b_, e_);

                bool? g_(MedicationAdministration AntagonistGiven) {
                    Code<MedicationAdministration.MedicationAdministrationStatusCodes> x_ = AntagonistGiven?.StatusElement;
                    MedicationAdministration.MedicationAdministrationStatusCodes? y_ = x_?.Value;
                    string z_ = context.Operators.Convert<string>(y_);
                    bool? aa_ = context.Operators.Equal(z_, "completed");
                    return aa_;
                }

                IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
                return h_;
            });


    private Cached<IEnumerable<Encounter>> _Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration_Cached = new();

    [CqlExpressionDefinition("Encounter With NonOperating Room Opioid And Antagonist Administration")]
    [CqlTag("author", "Measure developer")]
    [CqlTag("description", "Provides guidance to implementers to interpret logic in following defintion correctly")]
    [CqlTag("comment", "Excludes opioid antagonist administered in operating room AND excludes opioids administered in operating room AND opioid is administered before opioid antagonist AND limits opioid antagonist to non-enteral routes")]
    public IEnumerable<Encounter> Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration(CqlContext context) =>
        _Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<MedicationAdministration> a_ = this.Non_Enteral_Opioid_Antagonist_Administration(context);
                IEnumerable<MedicationAdministration> b_ = this.Opioid_Administration(context);
                IEnumerable<Encounter> c_ = this.Denominator(context);
                IEnumerable<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>> d_ = context.Operators.CrossJoin<MedicationAdministration, MedicationAdministration, Encounter>(a_, b_, c_);

                (CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)? e_(ValueTuple<MedicationAdministration, MedicationAdministration, Encounter> _valueTuple) {
                    (CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)? l_ = (CqlTupleMetadata_DUIOCODYLVZhZihGJYZbQjWXO, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
                    return l_;
                }

                IEnumerable<(CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)?> f_ = context.Operators.Select<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>, (CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)?>(d_, e_);

                bool? g_((CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)? tuple_htckrtcfdeaiwittzheehxihp) {
                    List<Encounter.LocationComponent> m_ = tuple_htckrtcfdeaiwittzheehxihp?.InpatientHospitalization?.Location;

                    bool? n_(Encounter.LocationComponent EncounterLocation) {
                        ResourceReference bi_ = EncounterLocation?.Location;
                        Location bj_ = CQMCommon_4_1_000.Instance.getLocation(context, bi_);
                        List<CodeableConcept> bk_ = bj_?.Type;

                        CqlConcept bl_(CodeableConcept @this) {
                            CqlConcept bx_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                            return bx_;
                        }

                        IEnumerable<CqlConcept> bm_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bk_, bl_);
                        CqlValueSet bn_ = this.Operating_Room_Suite(context);
                        bool? bo_ = context.Operators.ConceptsInValueSet(bm_, bn_);
                        DataType bp_ = tuple_htckrtcfdeaiwittzheehxihp?.NonEnteralOpioidAntagonistGiven?.Effective;
                        object bq_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bp_);
                        CqlInterval<CqlDateTime> br_ = QICoreCommon_4_0_000.Instance.toInterval(context, bq_);
                        CqlDateTime bs_ = context.Operators.Start(br_);
                        Period bt_ = EncounterLocation?.Period;
                        CqlInterval<CqlDateTime> bu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bt_);
                        bool? bv_ = context.Operators.In<CqlDateTime>(bs_, bu_, default);
                        bool? bw_ = context.Operators.And(bo_, bv_);
                        return bw_;
                    }

                    IEnumerable<Encounter.LocationComponent> o_ = context.Operators.Where<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)m_, n_);
                    bool? p_ = context.Operators.Exists<Encounter.LocationComponent>(o_);
                    bool? q_ = context.Operators.Not(p_);
                    DataType r_ = tuple_htckrtcfdeaiwittzheehxihp?.NonEnteralOpioidAntagonistGiven?.Effective;
                    object s_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlInterval<CqlDateTime> t_ = QICoreCommon_4_0_000.Instance.toInterval(context, s_);
                    CqlDateTime u_ = context.Operators.Start(t_);
                    CqlInterval<CqlDateTime> v_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_htckrtcfdeaiwittzheehxihp?.InpatientHospitalization);
                    bool? w_ = context.Operators.In<CqlDateTime>(u_, v_, default);
                    DataType x_ = tuple_htckrtcfdeaiwittzheehxihp?.OpioidGiven?.Effective;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                    CqlDateTime aa_ = context.Operators.Start(z_);
                    bool? ac_ = context.Operators.In<CqlDateTime>(aa_, v_, default);
                    bool? ad_ = context.Operators.And(w_, ac_);
                    object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                    CqlDateTime ah_ = context.Operators.End(ag_);
                    object aj_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlInterval<CqlDateTime> ak_ = QICoreCommon_4_0_000.Instance.toInterval(context, aj_);
                    CqlDateTime al_ = context.Operators.Start(ak_);
                    CqlQuantity am_ = context.Operators.Quantity(12m, "hours");
                    CqlDateTime an_ = context.Operators.Subtract(al_, am_);
                    object ap_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlInterval<CqlDateTime> aq_ = QICoreCommon_4_0_000.Instance.toInterval(context, ap_);
                    CqlDateTime ar_ = context.Operators.Start(aq_);
                    CqlInterval<CqlDateTime> as_ = context.Operators.Interval(an_, ar_, true, false);
                    bool? at_ = context.Operators.In<CqlDateTime>(ah_, as_, default);
                    object av_ = FHIRHelpers_4_4_000.Instance.ToValue(context, r_);
                    CqlInterval<CqlDateTime> aw_ = QICoreCommon_4_0_000.Instance.toInterval(context, av_);
                    CqlDateTime ax_ = context.Operators.Start(aw_);
                    bool? ay_ = context.Operators.Not((bool?)(ax_ is null));
                    bool? az_ = context.Operators.And(at_, ay_);
                    bool? ba_ = context.Operators.And(ad_, az_);
                    MedicationAdministration.DosageComponent bb_ = tuple_htckrtcfdeaiwittzheehxihp?.NonEnteralOpioidAntagonistGiven?.Dosage;
                    CodeableConcept bc_ = bb_?.Route;
                    CqlConcept bd_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bc_);
                    CqlValueSet be_ = this.Routes_of_Administration_for_Opioid_Antagonists(context);
                    bool? bf_ = context.Operators.ConceptInValueSet(bd_, be_);
                    bool? bg_ = context.Operators.And(ba_, bf_);
                    bool? bh_ = context.Operators.And(q_, bg_);
                    return bh_;
                }

                IEnumerable<(CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)?> h_ = context.Operators.Where<(CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)?>(f_, g_);
                Encounter i_((CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)? tuple_htckrtcfdeaiwittzheehxihp) => tuple_htckrtcfdeaiwittzheehxihp?.InpatientHospitalization;
                IEnumerable<Encounter> j_ = context.Operators.Select<(CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)?, Encounter>(h_, i_);
                IEnumerable<Encounter> k_ = context.Operators.Distinct<Encounter>(j_);
                return k_;
            });


    private Cached<IEnumerable<Encounter>> _Numerator_Cached = new();

    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        _Numerator_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<Encounter> a_ = this.Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Ethnicity_Cached = new();

    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        _SDE_Ethnicity_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
                return a_;
            });


    private Cached<IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>> _SDE_Payer_Cached = new();

    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        _SDE_Payer_Cached.GetOrReplace(
            context,
            () =>
            {
                IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
                return a_;
            });


    private Cached<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> _SDE_Race_Cached = new();

    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        _SDE_Race_Cached.GetOrReplace(
            context,
            () =>
            {
                (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
                return a_;
            });


    private Cached<CqlCode> _SDE_Sex_Cached = new();

    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        _SDE_Sex_Cached.GetOrReplace(
            context,
            () =>
            {
                CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
                return a_;
            });


    #endregion Functions and Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DUIOCODYLVZhZihGJYZbQjWXO = new(
       [typeof(MedicationAdministration), typeof(MedicationAdministration), typeof(Encounter)],
       ["NonEnteralOpioidAntagonistGiven", "OpioidGiven", "InpatientHospitalization"]);

    #endregion CqlTupleMetadata Properties

}
