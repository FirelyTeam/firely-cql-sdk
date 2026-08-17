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
[CqlLibrary("CMS819FHIRHHORAE", "1.0.000")]
public partial class CMS819FHIRHHORAE_1_0_000 : ILibrary, ISingleton<CMS819FHIRHHORAE_1_0_000>
{
    #region ValueSets (5)

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

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, []);

    #endregion CodeSystems

    #region Parameters (1)

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -7496935743061075012L;

    private CqlInterval<CqlDateTime> Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
        object d_ = context.ResolveParameter("CMS819FHIRHHORAE-1.0.000", "Measurement Period", c_);
        return (CqlInterval<CqlDateTime>)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (13)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -4767839273629787073L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter> Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter, Qualifying_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Encounter = -7346840467972461308L;

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

            return (bool?)(/* CQL 'and' (42:5-44:48) */ (/* CQL 'and' (42:11-43:75) */ ((CqlBoolean)n_
                && o_())
                && p_()));
        }

        IEnumerable<Encounter> d_ = context.Operators.Where<Encounter>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("Opioid Administration")]
    public IEnumerable<MedicationAdministration> Opioid_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Opioid_Administration, Opioid_Administration_Compute);

    private const long _cacheIndex_Opioid_Administration = 8985121007387053906L;

    private IEnumerable<MedicationAdministration> Opioid_Administration_Compute(CqlContext context)
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
                    CqlValueSet t_ = this.Opioids__All(context);
                    bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                    return u_;
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)p_
                    && q_()));
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Opioids__All(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration Opioids) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> v_ = Opioids?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            bool? y_ = context.Operators.Equal(x_, "completed");
            return y_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter With Opioid Administration Outside Of Operating Room")]
    public IEnumerable<Encounter> Encounter_With_Opioid_Administration_Outside_Of_Operating_Room(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Opioid_Administration_Outside_Of_Operating_Room, Encounter_With_Opioid_Administration_Outside_Of_Operating_Room_Compute);

    private const long _cacheIndex_Encounter_With_Opioid_Administration_Outside_Of_Operating_Room = -2842666379935109002L;

    private IEnumerable<Encounter> Encounter_With_Opioid_Administration_Outside_Of_Operating_Room_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter InpatientEncounter) {
            IEnumerable<MedicationAdministration> d_ = this.Opioid_Administration(context);

            bool? e_(MedicationAdministration OpioidGiven) {
                DataType g_ = OpioidGiven?.Effective;
                object h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlInterval<CqlDateTime> i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime j_ = context.Operators.Start(i_);
                CqlInterval<CqlDateTime> k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? l_ = context.Operators.In<CqlDateTime>(j_, k_, (string)default);

                CqlBoolean m_() {
                    List<Encounter.LocationComponent> n_ = InpatientEncounter?.Location;

                    bool? o_(Encounter.LocationComponent EncounterLocation) {
                        ResourceReference q_ = EncounterLocation?.Location;
                        Location r_ = CQMCommon_4_1_000.Instance.getLocation(context, q_);
                        List<CodeableConcept> s_ = r_?.Type;

                        CqlConcept t_(CodeableConcept @this) {
                            CqlConcept y_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                            return y_;
                        }

                        IEnumerable<CqlConcept> u_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)s_, t_);
                        CqlValueSet v_ = this.Operating_Room_Suite(context);
                        bool? w_ = context.Operators.ConceptsInValueSet(u_, v_);

                        CqlBoolean x_() {
                            DataType z_ = OpioidGiven?.Effective;
                            object aa_ = FHIRHelpers_4_4_000.Instance.ToValue(context, z_);
                            CqlInterval<CqlDateTime> ab_ = QICoreCommon_4_0_000.Instance.toInterval(context, aa_);
                            CqlDateTime ac_ = context.Operators.Start(ab_);
                            Period ad_ = EncounterLocation?.Period;
                            CqlInterval<CqlDateTime> ae_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ad_);
                            bool? af_ = context.Operators.In<CqlDateTime>(ac_, ae_, (string)default);
                            return af_;
                        }

                        return (bool?)(/* CQL 'and' (63:13-64:93) */ ((CqlBoolean)w_
                            && x_()));
                    }

                    bool? p_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)n_, o_);
                    return !p_;
                }

                return (bool?)(/* CQL 'and' (61:17-65:9) */ ((CqlBoolean)l_
                    && m_()));
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

    private const long _cacheIndex_Initial_Population = -4560790684055662395L;

    private IEnumerable<Encounter> Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_Opioid_Administration_Outside_Of_Operating_Room(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter> Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -5947658479433857118L;

    private IEnumerable<Encounter> Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Non Enteral Opioid Antagonist Administration")]
    public IEnumerable<MedicationAdministration> Non_Enteral_Opioid_Antagonist_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Non_Enteral_Opioid_Antagonist_Administration, Non_Enteral_Opioid_Antagonist_Administration_Compute);

    private const long _cacheIndex_Non_Enteral_Opioid_Antagonist_Administration = -4076388615638109566L;

    private IEnumerable<MedicationAdministration> Non_Enteral_Opioid_Antagonist_Administration_Compute(CqlContext context)
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
                    CqlValueSet t_ = this.Opioid_Antagonist(context);
                    bool? u_ = context.Operators.ConceptInValueSet(s_, t_);
                    return u_;
                }

                return (bool?)(/* CQL 'and' */ ((CqlBoolean)p_
                    && q_()));
            }

            bool? k_ = context.Operators.WhereAny<Medication>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationAdministration> c_ = context.Operators.Where<MedicationAdministration>(a_, b_);
        CqlValueSet d_ = this.Opioid_Antagonist(context);
        IEnumerable<MedicationAdministration> e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration> f_ = context.Operators.Union<MedicationAdministration>(c_, e_);

        bool? g_(MedicationAdministration AntagonistGiven) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes> v_ = AntagonistGiven?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? w_ = v_?.Value;
            string x_ = context.Operators.Convert<string>(w_);
            bool? y_ = context.Operators.Equal(x_, "completed");
            return y_;
        }

        IEnumerable<MedicationAdministration> h_ = context.Operators.Where<MedicationAdministration>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter With NonOperating Room Opioid And Antagonist Administration")]
    [CqlTag("author", "Measure developer")]
    [CqlTag("description", "Provides guidance to implementers to interpret logic in following defintion correctly")]
    [CqlTag("comment", "Excludes opioid antagonist administered in operating room AND excludes opioids administered in operating room AND opioid is administered before opioid antagonist AND limits opioid antagonist to non-enteral routes")]
    public IEnumerable<Encounter> Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration, Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration_Compute);

    private const long _cacheIndex_Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration = -8872899499043941012L;

    private IEnumerable<Encounter> Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration_Compute(CqlContext context)
    {
        IEnumerable<MedicationAdministration> a_ = this.Non_Enteral_Opioid_Antagonist_Administration(context);
        IEnumerable<MedicationAdministration> b_ = this.Opioid_Administration(context);
        IEnumerable<Encounter> c_ = this.Denominator(context);
        IEnumerable<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>> d_ = context.Operators.CrossJoin<MedicationAdministration, MedicationAdministration, Encounter>(a_, b_, c_);

        (CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)? e_(ValueTuple<MedicationAdministration, MedicationAdministration, Encounter> _valueTuple) {
            (CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)? j_ = (CqlTupleMetadata_DUIOCODYLVZhZihGJYZbQjWXO, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? f_((CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)? tuple_htckrtcfdeaiwittzheehxihp) {
            List<Encounter.LocationComponent> k_ = tuple_htckrtcfdeaiwittzheehxihp?.InpatientHospitalization?.Location;

            bool? l_(Encounter.LocationComponent EncounterLocation) {
                ResourceReference o_ = EncounterLocation?.Location;
                Location p_ = CQMCommon_4_1_000.Instance.getLocation(context, o_);
                List<CodeableConcept> q_ = p_?.Type;

                CqlConcept r_(CodeableConcept @this) {
                    CqlConcept w_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return w_;
                }

                IEnumerable<CqlConcept> s_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)q_, r_);
                CqlValueSet t_ = this.Operating_Room_Suite(context);
                bool? u_ = context.Operators.ConceptsInValueSet(s_, t_);

                CqlBoolean v_() {
                    DataType x_ = tuple_htckrtcfdeaiwittzheehxihp?.NonEnteralOpioidAntagonistGiven?.Effective;
                    object y_ = FHIRHelpers_4_4_000.Instance.ToValue(context, x_);
                    CqlInterval<CqlDateTime> z_ = QICoreCommon_4_0_000.Instance.toInterval(context, y_);
                    CqlDateTime aa_ = context.Operators.Start(z_);
                    Period ab_ = EncounterLocation?.Period;
                    CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ab_);
                    bool? ad_ = context.Operators.In<CqlDateTime>(aa_, ac_, (string)default);
                    return ad_;
                }

                return (bool?)(/* CQL 'and' (81:9-82:109) */ ((CqlBoolean)u_
                    && v_()));
            }

            bool? m_ = context.Operators.WhereAny<Encounter.LocationComponent>((IEnumerable<Encounter.LocationComponent>)k_, l_);

            CqlBoolean n_() {
                DataType ae_ = tuple_htckrtcfdeaiwittzheehxihp?.NonEnteralOpioidAntagonistGiven?.Effective;
                object af_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ae_);
                CqlInterval<CqlDateTime> ag_ = QICoreCommon_4_0_000.Instance.toInterval(context, af_);
                CqlDateTime ah_ = context.Operators.Start(ag_);
                CqlInterval<CqlDateTime> ai_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_htckrtcfdeaiwittzheehxihp?.InpatientHospitalization);
                bool? aj_ = context.Operators.In<CqlDateTime>(ah_, ai_, (string)default);

                CqlBoolean ak_() {
                    DataType an_ = tuple_htckrtcfdeaiwittzheehxihp?.OpioidGiven?.Effective;
                    object ao_ = FHIRHelpers_4_4_000.Instance.ToValue(context, an_);
                    CqlInterval<CqlDateTime> ap_ = QICoreCommon_4_0_000.Instance.toInterval(context, ao_);
                    CqlDateTime aq_ = context.Operators.Start(ap_);
                    CqlInterval<CqlDateTime> ar_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_htckrtcfdeaiwittzheehxihp?.InpatientHospitalization);
                    bool? as_ = context.Operators.In<CqlDateTime>(aq_, ar_, (string)default);
                    return as_;
                }


                CqlBoolean al_() {
                    DataType at_ = tuple_htckrtcfdeaiwittzheehxihp?.OpioidGiven?.Effective;
                    object au_ = FHIRHelpers_4_4_000.Instance.ToValue(context, at_);
                    CqlInterval<CqlDateTime> av_ = QICoreCommon_4_0_000.Instance.toInterval(context, au_);
                    CqlDateTime aw_ = context.Operators.End(av_);
                    DataType ax_ = tuple_htckrtcfdeaiwittzheehxihp?.NonEnteralOpioidAntagonistGiven?.Effective;
                    object ay_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ax_);
                    CqlInterval<CqlDateTime> az_ = QICoreCommon_4_0_000.Instance.toInterval(context, ay_);
                    CqlDateTime ba_ = context.Operators.Start(az_);
                    CqlQuantity bb_ = context.Operators.Quantity(12m, "hours");
                    CqlDateTime bc_ = context.Operators.Subtract(ba_, bb_);
                    CqlInterval<CqlDateTime> bd_ = context.Operators.Interval(bc_, ba_, true, false);
                    bool? be_ = context.Operators.In<CqlDateTime>(aw_, bd_, (string)default);

                    CqlBoolean bf_() {
                        DataType bg_ = tuple_htckrtcfdeaiwittzheehxihp?.NonEnteralOpioidAntagonistGiven?.Effective;
                        object bh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bg_);
                        CqlInterval<CqlDateTime> bi_ = QICoreCommon_4_0_000.Instance.toInterval(context, bh_);
                        CqlDateTime bj_ = context.Operators.Start(bi_);
                        return !((bool?)(bj_ is null));
                    }

                    return /* CQL 'and' (86:15-86:145) */ ((CqlBoolean)be_
                        && bf_());
                }


                CqlBoolean am_() {
                    MedicationAdministration.DosageComponent bk_ = tuple_htckrtcfdeaiwittzheehxihp?.NonEnteralOpioidAntagonistGiven?.Dosage;
                    CodeableConcept bl_ = bk_?.Route;
                    CqlConcept bm_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bl_);
                    CqlValueSet bn_ = this.Routes_of_Administration_for_Opioid_Antagonists(context);
                    bool? bo_ = context.Operators.ConceptInValueSet(bm_, bn_);
                    return bo_;
                }

                return /* CQL 'and' (84:11-88:7) */ (/* CQL 'and' (84:13-86:145) */ (/* CQL 'and' (84:13-85:124) */ ((CqlBoolean)aj_
                    && ak_())
                    && al_())
                    && am_());
            }

            return (bool?)(/* CQL 'and' (80:5-88:7) */ ((CqlBoolean)!m_
                && n_()));
        }

        IEnumerable<(CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)?> g_ = context.Operators.SelectWhere<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>, (CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)?>(d_, e_, f_);
        Encounter h_((CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)? tuple_htckrtcfdeaiwittzheehxihp) => tuple_htckrtcfdeaiwittzheehxihp?.InpatientHospitalization;
        IEnumerable<Encounter> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, MedicationAdministration NonEnteralOpioidAntagonistGiven, MedicationAdministration OpioidGiven, Encounter InpatientHospitalization)?, Encounter>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter> Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -446362921718484696L;

    private IEnumerable<Encounter> Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter> a_ = this.Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -8298349004878973388L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -1509794374290297893L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 2611777138581899658L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -4798689236628573622L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        CqlCode a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
        return a_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private CMS819FHIRHHORAE_1_0_000() {}

    public static CMS819FHIRHHORAE_1_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "CMS819FHIRHHORAE";
    public string Version => "1.0.000";
    public ILibrary[] Dependencies => [SupplementalDataElements_5_1_000.Instance, CQMCommon_4_1_000.Instance, QICoreCommon_4_0_000.Instance, FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_DUIOCODYLVZhZihGJYZbQjWXO = new(
       [typeof(MedicationAdministration), typeof(MedicationAdministration), typeof(Encounter)],
       ["NonEnteralOpioidAntagonistGiven", "OpioidGiven", "InpatientHospitalization"]);

    #endregion CqlTupleMetadata Properties

}
