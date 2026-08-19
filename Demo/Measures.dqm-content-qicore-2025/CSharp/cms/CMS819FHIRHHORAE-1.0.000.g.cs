#nullable enable

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
    public CqlInterval<CqlDateTime?>? Measurement_Period(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Measurement_Period, Measurement_Period_Compute);

    private const long _cacheIndex_Measurement_Period = -7496935743061075012L;

    private CqlInterval<CqlDateTime?>? Measurement_Period_Compute(CqlContext context)
    {
        CqlDateTime? a_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime? b_ = context.Operators.DateTime(2027, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlInterval<CqlDateTime?>? c_ = context.Operators.Interval(a_, b_, true, false);
        object? d_ = context.ResolveParameter("CMS819FHIRHHORAE-1.0.000"!, ("Measurement Period")!, c_);
        return (CqlInterval<CqlDateTime?>?)d_;
    }


    #endregion Parameters

    #region Functions and Expressions (13)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -4767839273629787073L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("Qualifying Encounter")]
    public IEnumerable<Encounter?>? Qualifying_Encounter(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Qualifying_Encounter, Qualifying_Encounter_Compute);

    private const long _cacheIndex_Qualifying_Encounter = -7346840467972461308L;

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


    [CqlExpressionDefinition("Opioid Administration")]
    public IEnumerable<MedicationAdministration?>? Opioid_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Opioid_Administration, Opioid_Administration_Compute);

    private const long _cacheIndex_Opioid_Administration = 8985121007387053906L;

    private IEnumerable<MedicationAdministration?>? Opioid_Administration_Compute(CqlContext context)
    {
        IEnumerable<MedicationAdministration?>? a_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? b_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication? M) {
                object? l_ = context.Operators.LateBoundProperty<object?>(M, "id.value"!);
                object? m_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value"!);
                IEnumerable<string?>? n_ = context.Operators.Split(((string?)m_)!, "/"!);
                string? o_ = context.Operators.Last<string?>(n_!);
                bool? p_ = context.Operators.Equal(l_, o_);
                CodeableConcept? q_ = M?.Code;
                CqlConcept? r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlValueSet? s_ = this.Opioids__All(context);
                bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                bool? u_ = context.Operators.And(p_, t_);
                return u_;
            }

            bool? k_ = context.Operators.WhereAny<Medication?>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationAdministration?>? c_ = context.Operators.Where<MedicationAdministration?>(a_, b_);
        CqlValueSet? d_ = this.Opioids__All(context);
        IEnumerable<MedicationAdministration?>? e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? f_ = context.Operators.Union<MedicationAdministration?>(c_, e_);

        bool? g_(MedicationAdministration? Opioids) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? v_ = Opioids?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? w_ = v_?.Value;
            string? x_ = context.Operators.Convert<string?>(w_);
            bool? y_ = context.Operators.Equal(x_, "completed");
            return y_;
        }

        IEnumerable<MedicationAdministration?>? h_ = context.Operators.Where<MedicationAdministration?>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter With Opioid Administration Outside Of Operating Room")]
    public IEnumerable<Encounter?>? Encounter_With_Opioid_Administration_Outside_Of_Operating_Room(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_Opioid_Administration_Outside_Of_Operating_Room, Encounter_With_Opioid_Administration_Outside_Of_Operating_Room_Compute);

    private const long _cacheIndex_Encounter_With_Opioid_Administration_Outside_Of_Operating_Room = -2842666379935109002L;

    private IEnumerable<Encounter?>? Encounter_With_Opioid_Administration_Outside_Of_Operating_Room_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Qualifying_Encounter(context);

        bool? b_(Encounter? InpatientEncounter) {
            IEnumerable<MedicationAdministration?>? d_ = this.Opioid_Administration(context);

            bool? e_(MedicationAdministration? OpioidGiven) {
                DataType? g_ = OpioidGiven?.Effective;
                object? h_ = FHIRHelpers_4_4_000.Instance.ToValue(context, g_);
                CqlInterval<CqlDateTime?>? i_ = QICoreCommon_4_0_000.Instance.toInterval(context, h_);
                CqlDateTime? j_ = context.Operators.Start(i_);
                CqlInterval<CqlDateTime?>? k_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, InpatientEncounter);
                bool? l_ = context.Operators.In<CqlDateTime?>(j_, k_, (string?)default);
                List<Encounter.LocationComponent>? m_ = InpatientEncounter?.Location;

                bool? n_(Encounter.LocationComponent? EncounterLocation) {
                    ResourceReference? r_ = EncounterLocation?.Location;
                    Location? s_ = CQMCommon_4_1_000.Instance.getLocation(context, r_);
                    List<CodeableConcept>? t_ = s_?.Type;

                    CqlConcept? u_(CodeableConcept? @this) {
                        CqlConcept? ag_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                        return ag_;
                    }

                    IEnumerable<CqlConcept?>? v_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)t_, u_);
                    CqlValueSet? w_ = this.Operating_Room_Suite(context);
                    bool? x_ = context.Operators.ConceptsInValueSet(v_, w_);
                    DataType? y_ = OpioidGiven?.Effective;
                    object? z_ = FHIRHelpers_4_4_000.Instance.ToValue(context, y_);
                    CqlInterval<CqlDateTime?>? aa_ = QICoreCommon_4_0_000.Instance.toInterval(context, z_);
                    CqlDateTime? ab_ = context.Operators.Start(aa_);
                    Period? ac_ = EncounterLocation?.Period;
                    CqlInterval<CqlDateTime?>? ad_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ac_);
                    bool? ae_ = context.Operators.In<CqlDateTime?>(ab_, ad_, (string?)default);
                    bool? af_ = context.Operators.And(x_, ae_);
                    return af_;
                }

                bool? o_ = context.Operators.WhereAny<Encounter.LocationComponent?>((IEnumerable<Encounter.LocationComponent?>?)m_, n_);
                bool? p_ = context.Operators.Not(o_);
                bool? q_ = context.Operators.And(l_, p_);
                return q_;
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

    private const long _cacheIndex_Initial_Population = -4560790684055662395L;

    private IEnumerable<Encounter?>? Initial_Population_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_With_Opioid_Administration_Outside_Of_Operating_Room(context);
        return a_;
    }


    [CqlExpressionDefinition("Denominator")]
    public IEnumerable<Encounter?>? Denominator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Denominator, Denominator_Compute);

    private const long _cacheIndex_Denominator = -5947658479433857118L;

    private IEnumerable<Encounter?>? Denominator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Initial_Population(context);
        return a_;
    }


    [CqlExpressionDefinition("Non Enteral Opioid Antagonist Administration")]
    public IEnumerable<MedicationAdministration?>? Non_Enteral_Opioid_Antagonist_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Non_Enteral_Opioid_Antagonist_Administration, Non_Enteral_Opioid_Antagonist_Administration_Compute);

    private const long _cacheIndex_Non_Enteral_Opioid_Antagonist_Administration = -4076388615638109566L;

    private IEnumerable<MedicationAdministration?>? Non_Enteral_Opioid_Antagonist_Administration_Compute(CqlContext context)
    {
        IEnumerable<MedicationAdministration?>? a_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));

        bool? b_(MedicationAdministration? MR) {
            IEnumerable<Medication?>? i_ = context.Operators.Retrieve<Medication>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medication"));

            bool? j_(Medication? M) {
                object? l_ = context.Operators.LateBoundProperty<object?>(M, "id.value"!);
                object? m_ = context.Operators.LateBoundProperty<object?>(MR, "medication.reference.value"!);
                IEnumerable<string?>? n_ = context.Operators.Split(((string?)m_)!, "/"!);
                string? o_ = context.Operators.Last<string?>(n_!);
                bool? p_ = context.Operators.Equal(l_, o_);
                CodeableConcept? q_ = M?.Code;
                CqlConcept? r_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, q_);
                CqlValueSet? s_ = this.Opioid_Antagonist(context);
                bool? t_ = context.Operators.ConceptInValueSet(r_, s_);
                bool? u_ = context.Operators.And(p_, t_);
                return u_;
            }

            bool? k_ = context.Operators.WhereAny<Medication?>(i_, j_);
            return k_;
        }

        IEnumerable<MedicationAdministration?>? c_ = context.Operators.Where<MedicationAdministration?>(a_, b_);
        CqlValueSet? d_ = this.Opioid_Antagonist(context);
        IEnumerable<MedicationAdministration?>? e_ = context.Operators.Retrieve<MedicationAdministration>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationadministration"));
        IEnumerable<MedicationAdministration?>? f_ = context.Operators.Union<MedicationAdministration?>(c_, e_);

        bool? g_(MedicationAdministration? AntagonistGiven) {
            Code<MedicationAdministration.MedicationAdministrationStatusCodes>? v_ = AntagonistGiven?.StatusElement;
            MedicationAdministration.MedicationAdministrationStatusCodes? w_ = v_?.Value;
            string? x_ = context.Operators.Convert<string?>(w_);
            bool? y_ = context.Operators.Equal(x_, "completed");
            return y_;
        }

        IEnumerable<MedicationAdministration?>? h_ = context.Operators.Where<MedicationAdministration?>(f_, g_);
        return h_;
    }


    [CqlExpressionDefinition("Encounter With NonOperating Room Opioid And Antagonist Administration")]
    [CqlTag("author", "Measure developer")]
    [CqlTag("description", "Provides guidance to implementers to interpret logic in following defintion correctly")]
    [CqlTag("comment", "Excludes opioid antagonist administered in operating room AND excludes opioids administered in operating room AND opioid is administered before opioid antagonist AND limits opioid antagonist to non-enteral routes")]
    public IEnumerable<Encounter?>? Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration, Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration_Compute);

    private const long _cacheIndex_Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration = -8872899499043941012L;

    private IEnumerable<Encounter?>? Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration_Compute(CqlContext context)
    {
        IEnumerable<MedicationAdministration?>? a_ = this.Non_Enteral_Opioid_Antagonist_Administration(context);
        IEnumerable<MedicationAdministration?>? b_ = this.Opioid_Administration(context);
        IEnumerable<Encounter?>? c_ = this.Denominator(context);
        IEnumerable<ValueTuple<MedicationAdministration?, MedicationAdministration?, Encounter?>>? d_ = context.Operators.CrossJoin<MedicationAdministration?, MedicationAdministration?, Encounter?>(a_, b_, c_);

        (CqlTupleMetadata, MedicationAdministration? NonEnteralOpioidAntagonistGiven, MedicationAdministration? OpioidGiven, Encounter? InpatientHospitalization)? e_(ValueTuple<MedicationAdministration?, MedicationAdministration?, Encounter?> _valueTuple) {
            (CqlTupleMetadata, MedicationAdministration? NonEnteralOpioidAntagonistGiven, MedicationAdministration? OpioidGiven, Encounter? InpatientHospitalization)? j_ = (CqlTupleMetadata_DUIOCODYLVZhZihGJYZbQjWXO, _valueTuple.Item1, _valueTuple.Item2, _valueTuple.Item3);
            return j_;
        }


        bool? f_((CqlTupleMetadata, MedicationAdministration? NonEnteralOpioidAntagonistGiven, MedicationAdministration? OpioidGiven, Encounter? InpatientHospitalization)? tuple_htckrtcfdeaiwittzheehxihp) {
            List<Encounter.LocationComponent>? k_ = tuple_htckrtcfdeaiwittzheehxihp?.InpatientHospitalization?.Location;

            bool? l_(Encounter.LocationComponent? EncounterLocation) {
                ResourceReference? ap_ = EncounterLocation?.Location;
                Location? aq_ = CQMCommon_4_1_000.Instance.getLocation(context, ap_);
                List<CodeableConcept>? ar_ = aq_?.Type;

                CqlConcept? as_(CodeableConcept? @this) {
                    CqlConcept? be_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, @this);
                    return be_;
                }

                IEnumerable<CqlConcept?>? at_ = context.Operators.Select<CodeableConcept?, CqlConcept?>((IEnumerable<CodeableConcept?>?)ar_, as_);
                CqlValueSet? au_ = this.Operating_Room_Suite(context);
                bool? av_ = context.Operators.ConceptsInValueSet(at_, au_);
                DataType? aw_ = tuple_htckrtcfdeaiwittzheehxihp?.NonEnteralOpioidAntagonistGiven?.Effective;
                object? ax_ = FHIRHelpers_4_4_000.Instance.ToValue(context, aw_);
                CqlInterval<CqlDateTime?>? ay_ = QICoreCommon_4_0_000.Instance.toInterval(context, ax_);
                CqlDateTime? az_ = context.Operators.Start(ay_);
                Period? ba_ = EncounterLocation?.Period;
                CqlInterval<CqlDateTime?>? bb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, ba_);
                bool? bc_ = context.Operators.In<CqlDateTime?>(az_, bb_, (string?)default);
                bool? bd_ = context.Operators.And(av_, bc_);
                return bd_;
            }

            bool? m_ = context.Operators.WhereAny<Encounter.LocationComponent?>((IEnumerable<Encounter.LocationComponent?>?)k_, l_);
            bool? n_ = context.Operators.Not(m_);
            DataType? o_ = tuple_htckrtcfdeaiwittzheehxihp?.NonEnteralOpioidAntagonistGiven?.Effective;
            object? p_ = FHIRHelpers_4_4_000.Instance.ToValue(context, o_);
            CqlInterval<CqlDateTime?>? q_ = QICoreCommon_4_0_000.Instance.toInterval(context, p_);
            CqlDateTime? r_ = context.Operators.Start(q_);
            CqlInterval<CqlDateTime?>? s_ = CQMCommon_4_1_000.Instance.hospitalizationWithObservation(context, tuple_htckrtcfdeaiwittzheehxihp?.InpatientHospitalization);
            bool? t_ = context.Operators.In<CqlDateTime?>(r_, s_, (string?)default);
            DataType? u_ = tuple_htckrtcfdeaiwittzheehxihp?.OpioidGiven?.Effective;
            object? v_ = FHIRHelpers_4_4_000.Instance.ToValue(context, u_);
            CqlInterval<CqlDateTime?>? w_ = QICoreCommon_4_0_000.Instance.toInterval(context, v_);
            CqlDateTime? x_ = context.Operators.Start(w_);
            bool? y_ = context.Operators.In<CqlDateTime?>(x_, s_, (string?)default);
            bool? z_ = context.Operators.And(t_, y_);
            CqlDateTime? aa_ = context.Operators.End(w_);
            CqlQuantity? ab_ = context.Operators.Quantity(12m, "hours");
            CqlDateTime? ac_ = context.Operators.Subtract(r_, ab_);
            CqlInterval<CqlDateTime?>? ad_ = context.Operators.Interval(ac_, r_, true, false);
            bool? ae_ = context.Operators.In<CqlDateTime?>(aa_, ad_, (string?)default);
            bool? af_ = context.Operators.Not((bool?)(r_ is null));
            bool? ag_ = context.Operators.And(ae_, af_);
            bool? ah_ = context.Operators.And(z_, ag_);
            MedicationAdministration.DosageComponent? ai_ = tuple_htckrtcfdeaiwittzheehxihp?.NonEnteralOpioidAntagonistGiven?.Dosage;
            CodeableConcept? aj_ = ai_?.Route;
            CqlConcept? ak_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, aj_);
            CqlValueSet? al_ = this.Routes_of_Administration_for_Opioid_Antagonists(context);
            bool? am_ = context.Operators.ConceptInValueSet(ak_, al_);
            bool? an_ = context.Operators.And(ah_, am_);
            bool? ao_ = context.Operators.And(n_, an_);
            return ao_;
        }

        IEnumerable<(CqlTupleMetadata, MedicationAdministration? NonEnteralOpioidAntagonistGiven, MedicationAdministration? OpioidGiven, Encounter? InpatientHospitalization)?>? g_ = context.Operators.SelectWhere<ValueTuple<MedicationAdministration?, MedicationAdministration?, Encounter?>, (CqlTupleMetadata, MedicationAdministration? NonEnteralOpioidAntagonistGiven, MedicationAdministration? OpioidGiven, Encounter? InpatientHospitalization)?>((IEnumerable<ValueTuple<MedicationAdministration, MedicationAdministration, Encounter>>?)d_, e_, f_);
        Encounter? h_((CqlTupleMetadata, MedicationAdministration? NonEnteralOpioidAntagonistGiven, MedicationAdministration? OpioidGiven, Encounter? InpatientHospitalization)? tuple_htckrtcfdeaiwittzheehxihp) => tuple_htckrtcfdeaiwittzheehxihp?.InpatientHospitalization;
        IEnumerable<Encounter?>? i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, MedicationAdministration? NonEnteralOpioidAntagonistGiven, MedicationAdministration? OpioidGiven, Encounter? InpatientHospitalization)?, Encounter?>(g_, h_);
        return i_;
    }


    [CqlExpressionDefinition("Numerator")]
    public IEnumerable<Encounter?>? Numerator(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Numerator, Numerator_Compute);

    private const long _cacheIndex_Numerator = -446362921718484696L;

    private IEnumerable<Encounter?>? Numerator_Compute(CqlContext context)
    {
        IEnumerable<Encounter?>? a_ = this.Encounter_With_NonOperating_Room_Opioid_And_Antagonist_Administration(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -8298349004878973388L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Ethnicity(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = -1509794374290297893L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Payer(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 2611777138581899658L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Race(context);
        return a_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -4798689236628573622L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        CqlCode? a_ = SupplementalDataElements_5_1_000.Instance.SDE_Sex(context);
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
