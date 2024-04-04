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
[CqlLibrary("HospitalHarmSevereHypoglycemiaFHIR", "0.1.000")]
public class HospitalHarmSevereHypoglycemiaFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __birth_date;
    internal Lazy<CqlValueSet> __Emergency_Department_Visit;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Glucose_Lab_Test_Mass_Per_Volume;
    internal Lazy<CqlValueSet> __Hypoglycemics_Severe_Hypoglycemia;
    internal Lazy<CqlValueSet> __Observation_Services;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Qualifying_Encounter;
    internal Lazy<IEnumerable<MedicationAdministration>> __Hypoglycemic_Medication_Administration;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Hypoglycemic_Medication_Administration;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Observation>> __Glucose_Test_with_Result_Less_Than_40;
    internal Lazy<IEnumerable<Observation>> __Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80;
    internal Lazy<IEnumerable<Observation>> __Severe_Hypoglycemic_Harm_Event;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Severe_Hypoglycemic_Harm_Event;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public HospitalHarmSevereHypoglycemiaFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);

        __birth_date = new Lazy<CqlValueSet>(this.birth_date_Value);
        __Emergency_Department_Visit = new Lazy<CqlValueSet>(this.Emergency_Department_Visit_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Glucose_Lab_Test_Mass_Per_Volume = new Lazy<CqlValueSet>(this.Glucose_Lab_Test_Mass_Per_Volume_Value);
        __Hypoglycemics_Severe_Hypoglycemia = new Lazy<CqlValueSet>(this.Hypoglycemics_Severe_Hypoglycemia_Value);
        __Observation_Services = new Lazy<CqlValueSet>(this.Observation_Services_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Qualifying_Encounter = new Lazy<IEnumerable<Encounter>>(this.Qualifying_Encounter_Value);
        __Hypoglycemic_Medication_Administration = new Lazy<IEnumerable<MedicationAdministration>>(this.Hypoglycemic_Medication_Administration_Value);
        __Encounter_with_Hypoglycemic_Medication_Administration = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Hypoglycemic_Medication_Administration_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Glucose_Test_with_Result_Less_Than_40 = new Lazy<IEnumerable<Observation>>(this.Glucose_Test_with_Result_Less_Than_40_Value);
        __Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80 = new Lazy<IEnumerable<Observation>>(this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80_Value);
        __Severe_Hypoglycemic_Harm_Event = new Lazy<IEnumerable<Observation>>(this.Severe_Hypoglycemic_Harm_Event_Value);
        __Encounter_with_Severe_Hypoglycemic_Harm_Event = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Severe_Hypoglycemic_Harm_Event_Value);
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

	private CqlValueSet birth_date_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4", null);

    [CqlDeclaration("birth date")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.560.100.4")]
	public CqlValueSet birth_date() => 
		__birth_date.Value;

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

	private CqlValueSet Glucose_Lab_Test_Mass_Per_Volume_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34", null);

    [CqlDeclaration("Glucose Lab Test Mass Per Volume")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1248.34")]
	public CqlValueSet Glucose_Lab_Test_Mass_Per_Volume() => 
		__Glucose_Lab_Test_Mass_Per_Volume.Value;

	private CqlValueSet Hypoglycemics_Severe_Hypoglycemia_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393", null);

    [CqlDeclaration("Hypoglycemics Severe Hypoglycemia")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1196.393")]
	public CqlValueSet Hypoglycemics_Severe_Hypoglycemia() => 
		__Hypoglycemics_Severe_Hypoglycemia.Value;

	private CqlValueSet Observation_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143", null);

    [CqlDeclaration("Observation Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.143")]
	public CqlValueSet Observation_Services() => 
		__Observation_Services.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("HospitalHarmSevereHypoglycemiaFHIR-0.1.000", "Measurement Period", e_);

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

	private IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration_Value()
	{
		var a_ = this.Hypoglycemics_Severe_Hypoglycemia();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var e_ = context.Operators.ListUnion<MedicationAdministration>(b_, d_);
		bool? f_(MedicationAdministration HypoMedication)
		{
			var h_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(HypoMedication?.StatusElement?.Value);
			var i_ = context.Operators.Equal(h_, "completed");
			var k_ = context.Operators.Equal(h_, "not-done");
			var l_ = context.Operators.Not(k_);
			var m_ = context.Operators.And(i_, l_);

			return m_;
		};
		var g_ = context.Operators.WhereOrNull<MedicationAdministration>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Hypoglycemic Medication Administration")]
	public IEnumerable<MedicationAdministration> Hypoglycemic_Medication_Administration() => 
		__Hypoglycemic_Medication_Administration.Value;

	private IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Administration_Value()
	{
		var a_ = this.Qualifying_Encounter();
		IEnumerable<Encounter> b_(Encounter InpatientHospitalization)
		{
			var d_ = this.Hypoglycemic_Medication_Administration();
			bool? e_(MedicationAdministration HypoglycemicMedication)
			{
				var i_ = FHIRHelpers_4_3_000.ToValue(HypoglycemicMedication?.Effective);
				var j_ = QICoreCommon_2_0_000.ToInterval(i_);
				var k_ = context.Operators.Start(j_);
				var l_ = CQMCommon_2_0_000.HospitalizationWithObservation(InpatientHospitalization);
				var m_ = context.Operators.ElementInInterval<CqlDateTime>(k_, l_, null);

				return m_;
			};
			var f_ = context.Operators.WhereOrNull<MedicationAdministration>(d_, e_);
			Encounter g_(MedicationAdministration HypoglycemicMedication) => 
				InpatientHospitalization;
			var h_ = context.Operators.SelectOrNull<MedicationAdministration, Encounter>(f_, g_);

			return h_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Hypoglycemic Medication Administration")]
	public IEnumerable<Encounter> Encounter_with_Hypoglycemic_Medication_Administration() => 
		__Encounter_with_Hypoglycemic_Medication_Administration.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Encounter_with_Hypoglycemic_Medication_Administration();

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

	private IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40_Value()
	{
		var a_ = this.Denominator();
		IEnumerable<MedicationAdministration> b_(Encounter _QualifyingEncounter)
		{
			var l_ = this.Hypoglycemic_Medication_Administration();

			return l_;
		};
		Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ c_(Encounter _QualifyingEncounter, MedicationAdministration _HypoglycemicMedication)
		{
			var m_ = new Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ
			{
				QualifyingEncounter = _QualifyingEncounter,
				HypoglycemicMedication = _HypoglycemicMedication,
			};

			return m_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, MedicationAdministration, Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ>(a_, b_, c_);
		IEnumerable<Observation> e_(Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ _QualifyingEncounterHypoglycemicMedication)
		{
			var n_ = this.Glucose_Lab_Test_Mass_Per_Volume();
			var o_ = context.Operators.RetrieveByValueSet<Observation>(n_, null);

			return o_;
		};
		Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ f_(Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ QualifyingEncounterHypoglycemicMedication, Observation _GlucoseTest)
		{
			var p_ = new Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ
			{
				QualifyingEncounter = QualifyingEncounterHypoglycemicMedication.QualifyingEncounter,
				HypoglycemicMedication = QualifyingEncounterHypoglycemicMedication.HypoglycemicMedication,
				GlucoseTest = _GlucoseTest,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ, Observation, Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ>(d_, e_, f_);
		bool? h_(Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ tuple_dsfjbilfcbvjwbysgxhdjckiz)
		{
			object q_()
			{
				if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlDateTime)
				{
					var at_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((at_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlInterval<CqlDateTime>)
				{
					var au_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((au_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlDateTime)
				{
					var av_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((av_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var r_ = QICoreCommon_2_0_000.Earliest(q_());
			var s_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_dsfjbilfcbvjwbysgxhdjckiz.QualifyingEncounter);
			var t_ = context.Operators.ElementInInterval<CqlDateTime>(r_, s_, null);
			var u_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.StatusElement?.Value);
			var v_ = context.Operators.Convert<string>(u_);
			var w_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var x_ = context.Operators.InList<string>(v_, (w_ as IEnumerable<string>));
			var y_ = context.Operators.And(t_, x_);
			var z_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Value);
			var aa_ = context.Operators.Quantity(40m, "mg/dL");
			var ab_ = context.Operators.Less((z_ as CqlQuantity), aa_);
			var ac_ = context.Operators.And(y_, ab_);
			var ad_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.HypoglycemicMedication?.Effective);
			var ae_ = QICoreCommon_2_0_000.ToInterval(ad_);
			var af_ = context.Operators.Start(ae_);
			object ag_()
			{
				if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlDateTime)
				{
					var aw_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((aw_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ax_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((ax_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlDateTime)
				{
					var ay_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((ay_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ah_ = QICoreCommon_2_0_000.Earliest(ag_());
			var ai_ = context.Operators.Quantity(24m, "hours");
			var aj_ = context.Operators.Subtract(ah_, ai_);
			object ak_()
			{
				if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlDateTime)
				{
					var az_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ba_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((ba_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlDateTime)
				{
					var bb_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var al_ = QICoreCommon_2_0_000.Earliest(ak_());
			var am_ = context.Operators.Interval(aj_, al_, true, true);
			var an_ = context.Operators.ElementInInterval<CqlDateTime>(af_, am_, null);
			object ao_()
			{
				if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlDateTime)
				{
					var bc_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bc_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlInterval<CqlDateTime>)
				{
					var bd_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((bd_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective) is CqlDateTime)
				{
					var be_ = FHIRHelpers_4_3_000.ToValue(tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest?.Effective);

					return ((be_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ap_ = QICoreCommon_2_0_000.Earliest(ao_());
			var aq_ = context.Operators.Not((bool?)(ap_ is null));
			var ar_ = context.Operators.And(an_, aq_);
			var as_ = context.Operators.And(ac_, ar_);

			return as_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ>(g_, h_);
		Observation j_(Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ tuple_dsfjbilfcbvjwbysgxhdjckiz) => 
			tuple_dsfjbilfcbvjwbysgxhdjckiz.GlucoseTest;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_DSFJBiLfcBVJWbYSgXHdjCKIZ, Observation>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Glucose Test with Result Less Than 40")]
	public IEnumerable<Observation> Glucose_Test_with_Result_Less_Than_40() => 
		__Glucose_Test_with_Result_Less_Than_40.Value;

	private IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80_Value()
	{
		var a_ = this.Denominator();
		IEnumerable<Observation> b_(Encounter _QualifyingEncounter)
		{
			var l_ = this.Glucose_Test_with_Result_Less_Than_40();

			return l_;
		};
		Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ c_(Encounter _QualifyingEncounter, Observation _LowGlucoseTest)
		{
			var m_ = new Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ
			{
				QualifyingEncounter = _QualifyingEncounter,
				LowGlucoseTest = _LowGlucoseTest,
			};

			return m_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, Observation, Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ>(a_, b_, c_);
		IEnumerable<Observation> e_(Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ _QualifyingEncounterLowGlucoseTest)
		{
			var n_ = this.Glucose_Lab_Test_Mass_Per_Volume();
			var o_ = context.Operators.RetrieveByValueSet<Observation>(n_, null);

			return o_;
		};
		Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ f_(Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ QualifyingEncounterLowGlucoseTest, Observation _FollowupGlucoseTest)
		{
			var p_ = new Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ
			{
				QualifyingEncounter = QualifyingEncounterLowGlucoseTest.QualifyingEncounter,
				LowGlucoseTest = QualifyingEncounterLowGlucoseTest.LowGlucoseTest,
				FollowupGlucoseTest = _FollowupGlucoseTest,
			};

			return p_;
		};
		var g_ = context.Operators.SelectManyResultsOrNull<Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ, Observation, Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ>(d_, e_, f_);
		bool? h_(Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ tuple_cqtbbrgobhbjhtlcmkyteoihz)
		{
			object q_()
			{
				if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective) is CqlDateTime)
				{
					var ba_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((ba_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective) is CqlInterval<CqlDateTime>)
				{
					var bb_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((bb_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective) is CqlDateTime)
				{
					var bc_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((bc_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var r_ = QICoreCommon_2_0_000.Earliest(q_());
			object s_()
			{
				if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlDateTime)
				{
					var bd_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bd_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlInterval<CqlDateTime>)
				{
					var be_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((be_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlDateTime)
				{
					var bf_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bf_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var t_ = QICoreCommon_2_0_000.Earliest(s_());
			object u_()
			{
				if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlDateTime)
				{
					var bg_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bg_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlInterval<CqlDateTime>)
				{
					var bh_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bh_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlDateTime)
				{
					var bi_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bi_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var v_ = QICoreCommon_2_0_000.Earliest(u_());
			var w_ = context.Operators.Quantity(5m, "minutes");
			var x_ = context.Operators.Add(v_, w_);
			var y_ = context.Operators.Interval(t_, x_, false, true);
			var z_ = context.Operators.ElementInInterval<CqlDateTime>(r_, y_, null);
			object aa_()
			{
				if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlDateTime)
				{
					var bj_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bj_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlInterval<CqlDateTime>)
				{
					var bk_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bk_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlDateTime)
				{
					var bl_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bl_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ab_ = QICoreCommon_2_0_000.Earliest(aa_());
			var ac_ = context.Operators.Not((bool?)(ab_ is null));
			var ad_ = context.Operators.And(z_, ac_);
			object ae_()
			{
				if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlDateTime)
				{
					var bm_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bm_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlInterval<CqlDateTime>)
				{
					var bn_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bn_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective) is CqlDateTime)
				{
					var bo_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.Effective);

					return ((bo_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var af_ = QICoreCommon_2_0_000.Earliest(ae_());
			var ag_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_cqtbbrgobhbjhtlcmkyteoihz.QualifyingEncounter);
			var ah_ = context.Operators.ElementInInterval<CqlDateTime>(af_, ag_, null);
			var ai_ = context.Operators.And(ad_, ah_);
			object aj_()
			{
				if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective) is CqlDateTime)
				{
					var bp_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((bp_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective) is CqlInterval<CqlDateTime>)
				{
					var bq_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((bq_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective) is CqlDateTime)
				{
					var br_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Effective);

					return ((br_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ak_ = QICoreCommon_2_0_000.Earliest(aj_());
			var am_ = context.Operators.ElementInInterval<CqlDateTime>(ak_, ag_, null);
			var an_ = context.Operators.And(ai_, am_);
			var ao_ = context.Operators.Equivalent(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.IdElement?.Value, tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest?.IdElement?.Value);
			var ap_ = context.Operators.Not(ao_);
			var aq_ = context.Operators.And(an_, ap_);
			var ar_ = context.Operators.Convert<Code<ObservationStatus>>(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.StatusElement?.Value);
			var as_ = context.Operators.Convert<string>(ar_);
			var at_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var au_ = context.Operators.InList<string>(as_, (at_ as IEnumerable<string>));
			var av_ = context.Operators.And(aq_, au_);
			var aw_ = FHIRHelpers_4_3_000.ToValue(tuple_cqtbbrgobhbjhtlcmkyteoihz.FollowupGlucoseTest?.Value);
			var ax_ = context.Operators.Quantity(80m, "mg/dL");
			var ay_ = context.Operators.Greater((aw_ as CqlQuantity), ax_);
			var az_ = context.Operators.And(av_, ay_);

			return az_;
		};
		var i_ = context.Operators.WhereOrNull<Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ>(g_, h_);
		Observation j_(Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ tuple_cqtbbrgobhbjhtlcmkyteoihz) => 
			tuple_cqtbbrgobhbjhtlcmkyteoihz.LowGlucoseTest;
		var k_ = context.Operators.SelectOrNull<Tuples.Tuple_CQTbBRGObHbJhTLCMKYTEOihZ, Observation>(i_, j_);

		return k_;
	}

    [CqlDeclaration("Low Glucose Test Followed By Glucose Test Result Greater Than 80")]
	public IEnumerable<Observation> Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80() => 
		__Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80.Value;

	private IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event_Value()
	{
		var a_ = this.Glucose_Test_with_Result_Less_Than_40();
		bool? b_(Observation LowGlucoseTest)
		{
			var d_ = this.Low_Glucose_Test_Followed_By_Glucose_Test_Result_Greater_Than_80();
			bool? e_(Observation @this)
			{
				var k_ = context.Operators.Not((bool?)(((@this is Resource)
	? ((@this as Resource).IdElement)
	: null)?.Value is null));

				return k_;
			};
			var f_ = context.Operators.WhereOrNull<Observation>(d_, e_);
			string g_(Observation @this) => 
				((@this is Resource)
	? ((@this as Resource).IdElement)
	: null)?.Value;
			var h_ = context.Operators.SelectOrNull<Observation, string>(f_, g_);
			var i_ = context.Operators.InList<string>(LowGlucoseTest?.IdElement?.Value, h_);
			var j_ = context.Operators.Not(i_);

			return j_;
		};
		var c_ = context.Operators.WhereOrNull<Observation>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Severe Hypoglycemic Harm Event")]
	public IEnumerable<Observation> Severe_Hypoglycemic_Harm_Event() => 
		__Severe_Hypoglycemic_Harm_Event.Value;

	private IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event_Value()
	{
		var a_ = this.Denominator();
		IEnumerable<Observation> b_(Encounter _QualifyingEncounter)
		{
			var i_ = this.Severe_Hypoglycemic_Harm_Event();

			return i_;
		};
		Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS c_(Encounter _QualifyingEncounter, Observation _HypoglycemicEvent)
		{
			var j_ = new Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS
			{
				QualifyingEncounter = _QualifyingEncounter,
				HypoglycemicEvent = _HypoglycemicEvent,
			};

			return j_;
		};
		var d_ = context.Operators.SelectManyResultsOrNull<Encounter, Observation, Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS>(a_, b_, c_);
		bool? e_(Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS tuple_dkowlzzjeftkbjljexpnieafs)
		{
			object k_()
			{
				if (FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective) is CqlDateTime)
				{
					var o_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);

					return ((o_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective) is CqlInterval<CqlDateTime>)
				{
					var p_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);

					return ((p_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective) is CqlDateTime)
				{
					var q_ = FHIRHelpers_4_3_000.ToValue(tuple_dkowlzzjeftkbjljexpnieafs.HypoglycemicEvent?.Effective);

					return ((q_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var l_ = QICoreCommon_2_0_000.Earliest(k_());
			var m_ = CQMCommon_2_0_000.HospitalizationWithObservation(tuple_dkowlzzjeftkbjljexpnieafs.QualifyingEncounter);
			var n_ = context.Operators.ElementInInterval<CqlDateTime>(l_, m_, null);

			return n_;
		};
		var f_ = context.Operators.WhereOrNull<Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS>(d_, e_);
		Encounter g_(Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS tuple_dkowlzzjeftkbjljexpnieafs) => 
			tuple_dkowlzzjeftkbjljexpnieafs.QualifyingEncounter;
		var h_ = context.Operators.SelectOrNull<Tuples.Tuple_DKOWLZZJefTKbjLjeXPNieaFS, Encounter>(f_, g_);

		return h_;
	}

    [CqlDeclaration("Encounter with Severe Hypoglycemic Harm Event")]
	public IEnumerable<Encounter> Encounter_with_Severe_Hypoglycemic_Harm_Event() => 
		__Encounter_with_Severe_Hypoglycemic_Harm_Event.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Encounter_with_Severe_Hypoglycemic_Harm_Event();

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
