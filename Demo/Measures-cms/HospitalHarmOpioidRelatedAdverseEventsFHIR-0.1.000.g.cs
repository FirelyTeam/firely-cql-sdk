using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("HospitalHarmOpioidRelatedAdverseEventsFHIR", "0.1.000")]
public class HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlValueSet> __Operating_Room_Suite;
    internal Lazy<CqlValueSet> __Opioid_Antagonist;
    internal Lazy<CqlValueSet> __Opioids__All;
    internal Lazy<CqlValueSet> __Routes_of_Administration_for_Opioid_Antagonists;
    internal Lazy<CqlCode> __Dead;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __HSLOC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter;
    internal Lazy<IEnumerable<MedicationAdministration>> __Opioid_Administration;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Opioid_Administration_Outside_of_Operating_Room;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<MedicationAdministration>> __Opioid_Antagonist_Administration;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public HospitalHarmOpioidRelatedAdverseEventsFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);

        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Operating_Room_Suite = new Lazy<CqlValueSet>(this.Operating_Room_Suite_Value);
        __Opioid_Antagonist = new Lazy<CqlValueSet>(this.Opioid_Antagonist_Value);
        __Opioids__All = new Lazy<CqlValueSet>(this.Opioids__All_Value);
        __Routes_of_Administration_for_Opioid_Antagonists = new Lazy<CqlValueSet>(this.Routes_of_Administration_for_Opioid_Antagonists_Value);
        __Dead = new Lazy<CqlCode>(this.Dead_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __HSLOC = new Lazy<CqlCode[]>(this.HSLOC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualifying_Encounter = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_Value);
        __Opioid_Administration = new Lazy<IEnumerable<MedicationAdministration>>(this.Opioid_Administration_Value);
        __Encounter_with_Opioid_Administration_Outside_of_Operating_Room = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Opioid_Administration_Outside_of_Operating_Room_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Opioid_Antagonist_Administration = new Lazy<IEnumerable<MedicationAdministration>>(this.Opioid_Antagonist_Administration_Value);
        __Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }

    #endregion

	private CqlValueSet Emergency_Department_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292", null);

    [CqlDeclaration("Emergency Department Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292")]
	public CqlValueSet Emergency_Department_Visit() => 
		__Emergency_Department_Visit.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlValueSet Operating_Room_Suite_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141", null);

    [CqlDeclaration("Operating Room Suite")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.141")]
	public CqlValueSet Operating_Room_Suite() => 
		__Operating_Room_Suite.Value;

	private CqlValueSet Opioid_Antagonist_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119", null);

    [CqlDeclaration("Opioid Antagonist")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.119")]
	public CqlValueSet Opioid_Antagonist() => 
		__Opioid_Antagonist.Value;

	private CqlValueSet Opioids__All_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226", null);

    [CqlDeclaration("Opioids, All")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.226")]
	public CqlValueSet Opioids__All() => 
		__Opioids__All.Value;

	private CqlValueSet Routes_of_Administration_for_Opioid_Antagonists_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187", null);

    [CqlDeclaration("Routes of Administration for Opioid Antagonists")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.187")]
	public CqlValueSet Routes_of_Administration_for_Opioid_Antagonists() => 
		__Routes_of_Administration_for_Opioid_Antagonists.Value;

	private CqlCode Dead_Value() => 
		new CqlCode("419099009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Dead")]
	public CqlCode Dead() => 
		__Dead.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("419099009", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] HSLOC_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("HSLOC")]
	public CqlCode[] HSLOC() => 
		__HSLOC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("HospitalHarmOpioidRelatedAdverseEventsFHIR-0.1.000", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Qualifying_Encounter_Value()
	{
		var a_ = this.Encounter_Inpatient();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter InpatientEncounter)
		{
			var e_ = this.Patient();
			var f_ = context.Operators.Convert<CqlDate>(e_?.BirthDateElement?.Value);
			var g_ = FHIRHelpers_4_3_000.ToInterval(InpatientEncounter?.Period);
			var h_ = context.Operators.Start(g_);
			var i_ = context.Operators.DateFrom(h_);
			var j_ = context.Operators.CalculateAgeAt(f_, i_, "year");
			var k_ = context.Operators.GreaterOrEqual(j_, (int?)18);
			var m_ = context.Operators.End(g_);
			var n_ = this.Measurement_Period();
			var o_ = context.Operators.ElementInInterval<CqlDateTime>(m_, n_, "day");
			var p_ = context.Operators.And(k_, o_);
			var q_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(InpatientEncounter?.StatusElement?.Value);
			var r_ = context.Operators.Equal(q_, "finished");
			var s_ = context.Operators.And(p_, r_);

			return s_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Qualifying Encounter")]
	public IEnumerable<Encounter> Qualifying_Encounter() => 
		__Qualifying_Encounter.Value;

	private IEnumerable<MedicationAdministration> Opioid_Administration_Value()
	{
		var a_ = this.Opioids__All();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration Opioids)
		{
			var h_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(Opioids?.StatusElement?.Value);
			var i_ = context.Operators.Equal(h_, "completed");
			var k_ = context.Operators.Equal(h_, "not-done");
			var l_ = context.Operators.Not(k_);
			var m_ = context.Operators.And(i_, l_);

			return m_;
		};
		var g_ = context.Operators.WhereOrNull<MedicationAdministration>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Opioid Administration")]
	public IEnumerable<MedicationAdministration> Opioid_Administration() => 
		__Opioid_Administration.Value;

	private IEnumerable<Encounter> Encounter_with_Opioid_Administration_Outside_of_Operating_Room_Value()
	{
		var a_ = this.Qualifying_Encounter();
		IEnumerable<Encounter> b_(Encounter InpatientEncounter)
		{
			var d_ = this.Opioid_Administration();
			bool? e_(MedicationAdministration OpioidGiven)
			{
				var i_ = FHIRHelpers_4_3_000.ToValue(OpioidGiven?.Effective);
				var j_ = QICoreCommon_2_0_000.ToInterval(i_);
				var k_ = context.Operators.Start(j_);
				var l_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientEncounter);
				var m_ = context.Operators.ElementInInterval<CqlDateTime>(k_, l_, null);
				bool? n_(Encounter.LocationComponent EncounterLocation)
				{
					var s_ = CQMCommon_2_0_000.GetLocation(EncounterLocation?.Location);
					CqlConcept t_(CodeableConcept @this)
					{
						var ad_ = FHIRHelpers_4_3_000.ToConcept(@this);

						return ad_;
					};
					var u_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(s_?.Type, t_);
					var v_ = this.Operating_Room_Suite();
					var w_ = context.Operators.ConceptsInValueSet(u_, v_);
					var x_ = FHIRHelpers_4_3_000.ToValue(OpioidGiven?.Effective);
					var y_ = QICoreCommon_2_0_000.ToInterval(x_);
					var z_ = context.Operators.Start(y_);
					var aa_ = FHIRHelpers_4_3_000.ToInterval(EncounterLocation?.Period);
					var ab_ = context.Operators.ElementInInterval<CqlDateTime>(z_, aa_, null);
					var ac_ = context.Operators.And(w_, ab_);

					return ac_;
				};
				var o_ = context.Operators.WhereOrNull<Encounter.LocationComponent>((InpatientEncounter?.Location as IEnumerable<Encounter.LocationComponent>), n_);
				var p_ = context.Operators.ExistsInList<Encounter.LocationComponent>(o_);
				var q_ = context.Operators.Not(p_);
				var r_ = context.Operators.And(m_, q_);

				return r_;
			};
			var f_ = context.Operators.WhereOrNull<MedicationAdministration>(d_, e_);
			Encounter g_(MedicationAdministration OpioidGiven) => 
				InpatientEncounter;
			var h_ = context.Operators.SelectOrNull<MedicationAdministration, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Opioid Administration Outside of Operating Room")]
	public IEnumerable<Encounter> Encounter_with_Opioid_Administration_Outside_of_Operating_Room() => 
		__Encounter_with_Opioid_Administration_Outside_of_Operating_Room.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Encounter_with_Opioid_Administration_Outside_of_Operating_Room();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<MedicationAdministration> Opioid_Antagonist_Administration_Value()
	{
		var a_ = this.Opioid_Antagonist();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration AntagonistGiven)
		{
			var h_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(AntagonistGiven?.StatusElement?.Value);
			var i_ = context.Operators.Equal(h_, "completed");
			var k_ = context.Operators.Equal(h_, "not-done");
			var l_ = context.Operators.Not(k_);
			var m_ = context.Operators.And(i_, l_);

			return m_;
		};
		var g_ = context.Operators.WhereOrNull<MedicationAdministration>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Opioid Antagonist Administration")]
	public IEnumerable<MedicationAdministration> Opioid_Antagonist_Administration() => 
		__Opioid_Antagonist_Administration.Value;

	private IEnumerable<Encounter> Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid_Value()
	{
		var a_ = this.Opioid_Antagonist_Administration();
		IEnumerable<MedicationAdministration> b_(MedicationAdministration _OpioidAntagonistGiven)
		{
			var l_ = this.Opioid_Administration();

			return l_;
		};
		Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI c_(MedicationAdministration _OpioidAntagonistGiven, MedicationAdministration _OpioidGiven)
		{
			var m_ = new Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI
			{
				OpioidAntagonistGiven = _OpioidAntagonistGiven,
				OpioidGiven = _OpioidGiven,
			};

			return m_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<MedicationAdministration, MedicationAdministration, Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI>(a_, b_, c_);
		IEnumerable<Encounter> e_(Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI _OpioidAntagonistGivenOpioidGiven)
		{
			var n_ = this.Denominator();

			return n_;
		};
		Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI f_(Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI OpioidAntagonistGivenOpioidGiven, Encounter _EncounterWithQualifyingAge)
		{
			var o_ = new Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI
			{
				OpioidAntagonistGiven = OpioidAntagonistGivenOpioidGiven.OpioidAntagonistGiven,
				OpioidGiven = OpioidAntagonistGivenOpioidGiven.OpioidGiven,
				EncounterWithQualifyingAge = _EncounterWithQualifyingAge,
			};

			return o_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI, Encounter, Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI>(d_, e_, f_);
		bool? h_(Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI tuple_eupiswiddkenbbaixeecrbcdi)
		{
			bool? p_(Encounter.LocationComponent EncounterLocation)
			{
				var bc_ = CQMCommon_2_0_000.GetLocation(EncounterLocation?.Location);
				CqlConcept bd_(CodeableConcept @this)
				{
					var bn_ = FHIRHelpers_4_3_000.ToConcept(@this);

					return bn_;
				};
				var be_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(bc_?.Type, bd_);
				var bf_ = this.Operating_Room_Suite();
				var bg_ = context.Operators.ConceptsInValueSet(be_, bf_);
				var bh_ = FHIRHelpers_4_3_000.ToValue(tuple_eupiswiddkenbbaixeecrbcdi.OpioidAntagonistGiven?.Effective);
				var bi_ = QICoreCommon_2_0_000.ToInterval(bh_);
				var bj_ = context.Operators.Start(bi_);
				var bk_ = FHIRHelpers_4_3_000.ToInterval(EncounterLocation?.Period);
				var bl_ = context.Operators.ElementInInterval<CqlDateTime>(bj_, bk_, null);
				var bm_ = context.Operators.And(bg_, bl_);

				return bm_;
			};
			var q_ = context.Operators.WhereOrNull<Encounter.LocationComponent>((tuple_eupiswiddkenbbaixeecrbcdi.EncounterWithQualifyingAge?.Location as IEnumerable<Encounter.LocationComponent>), p_);
			var r_ = context.Operators.ExistsInList<Encounter.LocationComponent>(q_);
			var s_ = context.Operators.Not(r_);
			var t_ = FHIRHelpers_4_3_000.ToValue(tuple_eupiswiddkenbbaixeecrbcdi.OpioidAntagonistGiven?.Effective);
			var u_ = QICoreCommon_2_0_000.ToInterval(t_);
			var v_ = context.Operators.Start(u_);
			var w_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_eupiswiddkenbbaixeecrbcdi.EncounterWithQualifyingAge);
			var x_ = context.Operators.ElementInInterval<CqlDateTime>(v_, w_, null);
			var y_ = FHIRHelpers_4_3_000.ToValue(tuple_eupiswiddkenbbaixeecrbcdi.OpioidGiven?.Effective);
			var z_ = QICoreCommon_2_0_000.ToInterval(y_);
			var aa_ = context.Operators.Start(z_);
			var ac_ = context.Operators.ElementInInterval<CqlDateTime>(aa_, w_, null);
			var ad_ = context.Operators.And(x_, ac_);
			var af_ = QICoreCommon_2_0_000.ToInterval(y_);
			var ag_ = context.Operators.End(af_);
			var ai_ = QICoreCommon_2_0_000.ToInterval(t_);
			var aj_ = context.Operators.Start(ai_);
			var ak_ = context.Operators.Quantity(12m, "hours");
			var al_ = context.Operators.Subtract(aj_, ak_);
			var an_ = QICoreCommon_2_0_000.ToInterval(t_);
			var ao_ = context.Operators.Start(an_);
			var ap_ = context.Operators.Interval(al_, ao_, true, false);
			var aq_ = context.Operators.ElementInInterval<CqlDateTime>(ag_, ap_, null);
			var as_ = QICoreCommon_2_0_000.ToInterval(t_);
			var at_ = context.Operators.Start(as_);
			var au_ = context.Operators.Not((bool?)(at_ is null));
			var av_ = context.Operators.And(aq_, au_);
			var aw_ = context.Operators.And(ad_, av_);
			var ax_ = FHIRHelpers_4_3_000.ToConcept(tuple_eupiswiddkenbbaixeecrbcdi.OpioidAntagonistGiven?.Dosage?.Route);
			var ay_ = this.Routes_of_Administration_for_Opioid_Antagonists();
			var az_ = context.Operators.ConceptInValueSet(ax_, ay_);
			var ba_ = context.Operators.And(aw_, az_);
			var bb_ = context.Operators.And(s_, ba_);

			return bb_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI>(g_, h_);
		Encounter j_(Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI tuple_eupiswiddkenbbaixeecrbcdi) => 
			tuple_eupiswiddkenbbaixeecrbcdi.EncounterWithQualifyingAge;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_EUPiSWiDDKENbbAiXeEcRBcdI, Encounter>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Encounter with Non Enteral Opioid Antagonist Administration Outside of Operating Room and within 12 Hrs After Opioid")]
	public IEnumerable<Encounter> Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid() => 
		__Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Encounter_with_Non_Enteral_Opioid_Antagonist_Administration_Outside_of_Operating_Room_and_within_12_Hrs_After_Opioid();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
