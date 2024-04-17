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
[CqlLibrary("CesareanBirthFHIR", "0.2.000")]
public class CesareanBirthFHIR_0_2_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Abnormal_Presentation;
    internal Lazy<CqlValueSet> __Cesarean_Birth;
    internal Lazy<CqlValueSet> __Delivery_of_Singleton;
    internal Lazy<CqlValueSet> __Delivery_Procedures;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Genital_Herpes;
    internal Lazy<CqlValueSet> __Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa;
    internal Lazy<CqlValueSet> ___37_to_42_Plus_Weeks_Gestation;
    internal Lazy<CqlCode> ______Births_preterm;
    internal Lazy<CqlCode> ______Births_term;
    internal Lazy<CqlCode> ______Parity;
    internal Lazy<CqlCode> ______Pregnancies;
    internal Lazy<CqlCode> __Date_and_time_of_obstetric_delivery;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Singleton_Delivery;
    internal Lazy<IEnumerable<Encounter>> __Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Abnormal_Presentation;
    internal Lazy<IEnumerable<Encounter>> __Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusions;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Delivery_Encounter_with_Cesarean_Birth;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Tuples.Tuple_CDQdAjUGdePbWTVfePeZUXKFM>> __Variable_Calculated_Gestational_Age;

    #endregion
    public CesareanBirthFHIR_0_2_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        PCMaternal_5_16_000 = new PCMaternal_5_16_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Abnormal_Presentation = new Lazy<CqlValueSet>(this.Abnormal_Presentation_Value);
        __Cesarean_Birth = new Lazy<CqlValueSet>(this.Cesarean_Birth_Value);
        __Delivery_of_Singleton = new Lazy<CqlValueSet>(this.Delivery_of_Singleton_Value);
        __Delivery_Procedures = new Lazy<CqlValueSet>(this.Delivery_Procedures_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Genital_Herpes = new Lazy<CqlValueSet>(this.Genital_Herpes_Value);
        __Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa = new Lazy<CqlValueSet>(this.Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa_Value);
        ___37_to_42_Plus_Weeks_Gestation = new Lazy<CqlValueSet>(this._37_to_42_Plus_Weeks_Gestation_Value);
        ______Births_preterm = new Lazy<CqlCode>(this.____Births_preterm_Value);
        ______Births_term = new Lazy<CqlCode>(this.____Births_term_Value);
        ______Parity = new Lazy<CqlCode>(this.____Parity_Value);
        ______Pregnancies = new Lazy<CqlCode>(this.____Pregnancies_Value);
        __Date_and_time_of_obstetric_delivery = new Lazy<CqlCode>(this.Date_and_time_of_obstetric_delivery_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Value);
        __Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Value);
        __Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding_Value);
        __Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Value);
        __Encounter_with_Singleton_Delivery = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Singleton_Delivery_Value);
        __Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births = new Lazy<IEnumerable<Encounter>>(this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births_Value);
        __Encounter_with_Abnormal_Presentation = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Abnormal_Presentation_Value);
        __Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum = new Lazy<IEnumerable<Encounter>>(this.Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum_Value);
        __Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __Denominator_Exclusions = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusions_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Delivery_Encounter_with_Cesarean_Birth = new Lazy<IEnumerable<Encounter>>(this.Delivery_Encounter_with_Cesarean_Birth_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Variable_Calculated_Gestational_Age = new Lazy<IEnumerable<Tuples.Tuple_CDQdAjUGdePbWTVfePeZUXKFM>>(this.Variable_Calculated_Gestational_Age_Value);
    }
    #region Dependencies

    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public PCMaternal_5_16_000 PCMaternal_5_16_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Abnormal_Presentation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105", null);

    [CqlDeclaration("Abnormal Presentation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105")]
	public CqlValueSet Abnormal_Presentation() => 
		__Abnormal_Presentation.Value;

	private CqlValueSet Cesarean_Birth_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282", null);

    [CqlDeclaration("Cesarean Birth")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282")]
	public CqlValueSet Cesarean_Birth() => 
		__Cesarean_Birth.Value;

	private CqlValueSet Delivery_of_Singleton_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99", null);

    [CqlDeclaration("Delivery of Singleton")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99")]
	public CqlValueSet Delivery_of_Singleton() => 
		__Delivery_of_Singleton.Value;

	private CqlValueSet Delivery_Procedures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", null);

    [CqlDeclaration("Delivery Procedures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59")]
	public CqlValueSet Delivery_Procedures() => 
		__Delivery_Procedures.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Genital_Herpes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049", null);

    [CqlDeclaration("Genital Herpes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049")]
	public CqlValueSet Genital_Herpes() => 
		__Genital_Herpes.Value;

	private CqlValueSet Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37", null);

    [CqlDeclaration("Placenta Previa Accreta Increta Percreta or Vasa Previa")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37")]
	public CqlValueSet Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa() => 
		__Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa.Value;

	private CqlValueSet _37_to_42_Plus_Weeks_Gestation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68", null);

    [CqlDeclaration("37 to 42 Plus Weeks Gestation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68")]
	public CqlValueSet _37_to_42_Plus_Weeks_Gestation() => 
		___37_to_42_Plus_Weeks_Gestation.Value;

	private CqlCode ____Births_preterm_Value() => 
		new CqlCode("11637-6", "http://loinc.org", null, null);

    [CqlDeclaration("[#] Births.preterm")]
	public CqlCode ____Births_preterm() => 
		______Births_preterm.Value;

	private CqlCode ____Births_term_Value() => 
		new CqlCode("11639-2", "http://loinc.org", null, null);

    [CqlDeclaration("[#] Births.term")]
	public CqlCode ____Births_term() => 
		______Births_term.Value;

	private CqlCode ____Parity_Value() => 
		new CqlCode("11977-6", "http://loinc.org", null, null);

    [CqlDeclaration("[#] Parity")]
	public CqlCode ____Parity() => 
		______Parity.Value;

	private CqlCode ____Pregnancies_Value() => 
		new CqlCode("11996-6", "http://loinc.org", null, null);

    [CqlDeclaration("[#] Pregnancies")]
	public CqlCode ____Pregnancies() => 
		______Pregnancies.Value;

	private CqlCode Date_and_time_of_obstetric_delivery_Value() => 
		new CqlCode("93857-1", "http://loinc.org", null, null);

    [CqlDeclaration("Date and time of obstetric delivery")]
	public CqlCode Date_and_time_of_obstetric_delivery() => 
		__Date_and_time_of_obstetric_delivery.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("11637-6", "http://loinc.org", null, null),
			new CqlCode("11639-2", "http://loinc.org", null, null),
			new CqlCode("11977-6", "http://loinc.org", null, null),
			new CqlCode("11996-6", "http://loinc.org", null, null),
			new CqlCode("93857-1", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var b_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("CesareanBirthFHIR-0.2.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
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

	private IEnumerable<Encounter> Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Value()
	{
		var a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			var d_ = PCMaternal_5_16_000.calculatedGestationalAge(DeliveryEncounter);
			var e_ = context.Operators.GreaterOrEqual(d_, (int?)37);

			return e_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Calculated Gestational Age Greater than or Equal to 37 Weeks")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks() => 
		__Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Value()
	{
		var a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			var d_ = PCMaternal_5_16_000.calculatedGestationalAge(DeliveryEncounter);
			var e_ = PCMaternal_5_16_000.lastEstimatedGestationalAge(DeliveryEncounter);
			var f_ = context.Operators.Quantity((decimal?)37m, "weeks");
			var g_ = context.Operators.GreaterOrEqual(e_, f_);
			var h_ = context.Operators.And((bool?)(d_ is null), g_);

			return h_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Estimated Gestational Age Greater than or Equal to 37 Weeks")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks() => 
		__Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding_Value()
	{
		var a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			var d_ = PCMaternal_5_16_000.calculatedGestationalAge(DeliveryEncounter);
			var e_ = PCMaternal_5_16_000.lastEstimatedGestationalAge(DeliveryEncounter);
			var f_ = context.Operators.And((bool?)(d_ is null), (bool?)(e_ is null));
			var g_ = CQMCommon_2_0_000.encounterDiagnosis(DeliveryEncounter);
			bool? h_(Condition EncounterDiagnosis)
			{
				var l_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				var m_ = this._37_to_42_Plus_Weeks_Gestation();
				var n_ = context.Operators.ConceptInValueSet(l_, m_);

				return n_;
			};
			var i_ = context.Operators.WhereOrNull<Condition>(g_, h_);
			var j_ = context.Operators.ExistsInList<Condition>(i_);
			var k_ = context.Operators.And(f_, j_);

			return k_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks Based on Coding")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding() => 
		__Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Value()
	{
		var a_ = this.Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks();
		var b_ = this.Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		var d_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding();
		var e_ = context.Operators.ListUnion<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks() => 
		__Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks.Value;

	private IEnumerable<Encounter> Encounter_with_Singleton_Delivery_Value()
	{
		var a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			var d_ = CQMCommon_2_0_000.encounterDiagnosis(DeliveryEncounter);
			bool? e_(Condition EncounterDiagnosis)
			{
				var h_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				var i_ = this.Delivery_of_Singleton();
				var j_ = context.Operators.ConceptInValueSet(h_, i_);

				return j_;
			};
			var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);
			var g_ = context.Operators.ExistsInList<Condition>(f_);

			return g_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Singleton Delivery")]
	public IEnumerable<Encounter> Encounter_with_Singleton_Delivery() => 
		__Encounter_with_Singleton_Delivery.Value;

    [CqlDeclaration("lastGravida")]
	public int? lastGravida(Encounter TheEncounter)
	{
		var a_ = this.____Pregnancies();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation Gravida)
		{
			var j_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Value);
			var k_ = context.Operators.Not((bool?)(j_ is null));
			var l_ = context.Operators.Convert<Code<ObservationStatus>>(Gravida?.StatusElement?.Value);
			var m_ = context.Operators.Convert<string>(l_);
			var n_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var o_ = context.Operators.InList<string>(m_, (n_ as IEnumerable<string>));
			var p_ = context.Operators.And(k_, o_);
			object q_()
			{
				bool ac_()
				{
					var af_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);
					var ag_ = af_ is CqlDateTime;

					return ag_;
				};
				bool ad_()
				{
					var ah_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);
					var ai_ = ah_ is CqlInterval<CqlDateTime>;

					return ai_;
				};
				bool ae_()
				{
					var aj_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);
					var ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				if (ac_())
				{
					var al_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);

					return ((al_ as CqlDateTime) as object);
				}
				else if (ad_())
				{
					var am_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);

					return ((am_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ae_())
				{
					var an_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);

					return ((an_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var r_ = QICoreCommon_2_0_000.earliest(q_());
			var s_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var t_ = context.Operators.Quantity((decimal?)42m, "weeks");
			var u_ = context.Operators.Subtract(s_, t_);
			var w_ = context.Operators.Interval(u_, s_, true, false);
			var x_ = context.Operators.ElementInInterval<CqlDateTime>(r_, w_, null);
			var z_ = context.Operators.Not((bool?)(s_ is null));
			var aa_ = context.Operators.And(x_, z_);
			var ab_ = context.Operators.And(p_, aa_);

			return ab_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ao_()
			{
				bool aq_()
				{
					var at_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var au_ = at_ is CqlDateTime;

					return au_;
				};
				bool ar_()
				{
					var av_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var aw_ = av_ is CqlInterval<CqlDateTime>;

					return aw_;
				};
				bool as_()
				{
					var ax_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				if (aq_())
				{
					var az_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else if (ar_())
				{
					var ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ba_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (as_())
				{
					var bb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((bb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ap_ = QICoreCommon_2_0_000.earliest(ao_());

			return ap_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);
		var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

    [CqlDeclaration("lastParity")]
	public int? lastParity(Encounter TheEncounter)
	{
		var a_ = this.____Parity();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation Parity)
		{
			object j_()
			{
				bool ac_()
				{
					var af_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);
					var ag_ = af_ is CqlDateTime;

					return ag_;
				};
				bool ad_()
				{
					var ah_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);
					var ai_ = ah_ is CqlInterval<CqlDateTime>;

					return ai_;
				};
				bool ae_()
				{
					var aj_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);
					var ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				if (ac_())
				{
					var al_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);

					return ((al_ as CqlDateTime) as object);
				}
				else if (ad_())
				{
					var am_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);

					return ((am_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ae_())
				{
					var an_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);

					return ((an_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var k_ = QICoreCommon_2_0_000.earliest(j_());
			var l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var m_ = context.Operators.Quantity((decimal?)42m, "weeks");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.Interval(n_, l_, true, false);
			var q_ = context.Operators.ElementInInterval<CqlDateTime>(k_, p_, null);
			var s_ = context.Operators.Not((bool?)(l_ is null));
			var t_ = context.Operators.And(q_, s_);
			var u_ = context.Operators.Convert<Code<ObservationStatus>>(Parity?.StatusElement?.Value);
			var v_ = context.Operators.Convert<string>(u_);
			var w_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var x_ = context.Operators.InList<string>(v_, (w_ as IEnumerable<string>));
			var y_ = context.Operators.And(t_, x_);
			var z_ = FHIRHelpers_4_3_000.ToValue(Parity?.Value);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(y_, aa_);

			return ab_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ao_()
			{
				bool aq_()
				{
					var at_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var au_ = at_ is CqlDateTime;

					return au_;
				};
				bool ar_()
				{
					var av_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var aw_ = av_ is CqlInterval<CqlDateTime>;

					return aw_;
				};
				bool as_()
				{
					var ax_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				if (aq_())
				{
					var az_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else if (ar_())
				{
					var ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ba_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (as_())
				{
					var bb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((bb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ap_ = QICoreCommon_2_0_000.earliest(ao_());

			return ap_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);
		var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

    [CqlDeclaration("lastHistoryPretermBirth")]
	public int? lastHistoryPretermBirth(Encounter TheEncounter)
	{
		var a_ = this.____Births_preterm();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation PretermBirth)
		{
			object j_()
			{
				bool ac_()
				{
					var af_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);
					var ag_ = af_ is CqlDateTime;

					return ag_;
				};
				bool ad_()
				{
					var ah_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);
					var ai_ = ah_ is CqlInterval<CqlDateTime>;

					return ai_;
				};
				bool ae_()
				{
					var aj_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);
					var ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				if (ac_())
				{
					var al_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);

					return ((al_ as CqlDateTime) as object);
				}
				else if (ad_())
				{
					var am_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);

					return ((am_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ae_())
				{
					var an_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);

					return ((an_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var k_ = QICoreCommon_2_0_000.earliest(j_());
			var l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var m_ = context.Operators.Quantity((decimal?)42m, "weeks");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.Interval(n_, l_, true, false);
			var q_ = context.Operators.ElementInInterval<CqlDateTime>(k_, p_, null);
			var s_ = context.Operators.Not((bool?)(l_ is null));
			var t_ = context.Operators.And(q_, s_);
			var u_ = context.Operators.Convert<Code<ObservationStatus>>(PretermBirth?.StatusElement?.Value);
			var v_ = context.Operators.Convert<string>(u_);
			var w_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var x_ = context.Operators.InList<string>(v_, (w_ as IEnumerable<string>));
			var y_ = context.Operators.And(t_, x_);
			var z_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Value);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(y_, aa_);

			return ab_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ao_()
			{
				bool aq_()
				{
					var at_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var au_ = at_ is CqlDateTime;

					return au_;
				};
				bool ar_()
				{
					var av_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var aw_ = av_ is CqlInterval<CqlDateTime>;

					return aw_;
				};
				bool as_()
				{
					var ax_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				if (aq_())
				{
					var az_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else if (ar_())
				{
					var ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ba_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (as_())
				{
					var bb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((bb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ap_ = QICoreCommon_2_0_000.earliest(ao_());

			return ap_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);
		var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

    [CqlDeclaration("lastHistoryTermBirth")]
	public int? lastHistoryTermBirth(Encounter TheEncounter)
	{
		var a_ = this.____Births_term();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation TermBirth)
		{
			object j_()
			{
				bool ac_()
				{
					var af_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);
					var ag_ = af_ is CqlDateTime;

					return ag_;
				};
				bool ad_()
				{
					var ah_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);
					var ai_ = ah_ is CqlInterval<CqlDateTime>;

					return ai_;
				};
				bool ae_()
				{
					var aj_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);
					var ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				if (ac_())
				{
					var al_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);

					return ((al_ as CqlDateTime) as object);
				}
				else if (ad_())
				{
					var am_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);

					return ((am_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ae_())
				{
					var an_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);

					return ((an_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var k_ = QICoreCommon_2_0_000.earliest(j_());
			var l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var m_ = context.Operators.Quantity((decimal?)42m, "weeks");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.Interval(n_, l_, true, false);
			var q_ = context.Operators.ElementInInterval<CqlDateTime>(k_, p_, null);
			var s_ = context.Operators.Not((bool?)(l_ is null));
			var t_ = context.Operators.And(q_, s_);
			var u_ = context.Operators.Convert<Code<ObservationStatus>>(TermBirth?.StatusElement?.Value);
			var v_ = context.Operators.Convert<string>(u_);
			var w_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var x_ = context.Operators.InList<string>(v_, (w_ as IEnumerable<string>));
			var y_ = context.Operators.And(t_, x_);
			var z_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Value);
			var aa_ = context.Operators.Not((bool?)(z_ is null));
			var ab_ = context.Operators.And(y_, aa_);

			return ab_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ao_()
			{
				bool aq_()
				{
					var at_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var au_ = at_ is CqlDateTime;

					return au_;
				};
				bool ar_()
				{
					var av_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var aw_ = av_ is CqlInterval<CqlDateTime>;

					return aw_;
				};
				bool as_()
				{
					var ax_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					var ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				if (aq_())
				{
					var az_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else if (ar_())
				{
					var ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ba_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (as_())
				{
					var bb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((bb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ap_ = QICoreCommon_2_0_000.earliest(ao_());

			return ap_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);
		var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

	private IEnumerable<Encounter> Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births_Value()
	{
		var a_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks();
		var b_ = this.Encounter_with_Singleton_Delivery();
		var c_ = context.Operators.ListIntersect<Encounter>(a_, b_);
		bool? d_(Encounter SingletonEncounterGE37Weeks)
		{
			var f_ = this.lastGravida(SingletonEncounterGE37Weeks);
			var g_ = context.Operators.Equal(f_, (int?)1);
			var h_ = this.lastParity(SingletonEncounterGE37Weeks);
			var i_ = context.Operators.Equal(h_, (int?)0);
			var j_ = context.Operators.Or(g_, i_);
			var k_ = this.lastHistoryPretermBirth(SingletonEncounterGE37Weeks);
			var l_ = context.Operators.Equal(k_, (int?)0);
			var m_ = this.lastHistoryTermBirth(SingletonEncounterGE37Weeks);
			var n_ = context.Operators.Equal(m_, (int?)0);
			var o_ = context.Operators.And(l_, n_);
			var p_ = context.Operators.Or(j_, o_);

			return p_;
		};
		var e_ = context.Operators.WhereOrNull<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births")]
	public IEnumerable<Encounter> Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births() => 
		__Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births.Value;

	private IEnumerable<Encounter> Encounter_with_Abnormal_Presentation_Value()
	{
		var a_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births();
		bool? b_(Encounter ThirtysevenWeeksPlusEncounter)
		{
			object d_()
			{
				bool m_()
				{
					var p_ = this.Abnormal_Presentation();
					var q_ = context.Operators.RetrieveByValueSet<Observation>(p_, null);
					bool? r_(Observation AbnormalPresentation)
					{
						object y_()
						{
							bool ah_()
							{
								var ak_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var al_ = ak_ is CqlDateTime;

								return al_;
							};
							bool ai_()
							{
								var am_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var an_ = am_ is CqlInterval<CqlDateTime>;

								return an_;
							};
							bool aj_()
							{
								var ao_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var ap_ = ao_ is CqlDateTime;

								return ap_;
							};
							if (ah_())
							{
								var aq_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((aq_ as CqlDateTime) as object);
							}
							else if (ai_())
							{
								var ar_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ar_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (aj_())
							{
								var as_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((as_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var z_ = QICoreCommon_2_0_000.earliest(y_());
						var aa_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var ab_ = context.Operators.SameOrBefore(z_, aa_, null);
						var ac_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						var ad_ = context.Operators.Convert<string>(ac_);
						var ae_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var af_ = context.Operators.InList<string>(ad_, (ae_ as IEnumerable<string>));
						var ag_ = context.Operators.And(ab_, af_);

						return ag_;
					};
					var s_ = context.Operators.WhereOrNull<Observation>(q_, r_);
					object t_(Observation @this)
					{
						object at_()
						{
							bool av_()
							{
								var ay_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var az_ = ay_ is CqlDateTime;

								return az_;
							};
							bool aw_()
							{
								var ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var bb_ = ba_ is CqlInterval<CqlDateTime>;

								return bb_;
							};
							bool ax_()
							{
								var bc_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var bd_ = bc_ is CqlDateTime;

								return bd_;
							};
							if (av_())
							{
								var be_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((be_ as CqlDateTime) as object);
							}
							else if (aw_())
							{
								var bf_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((bf_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (ax_())
							{
								var bg_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((bg_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var au_ = QICoreCommon_2_0_000.earliest(at_());

						return au_;
					};
					var u_ = context.Operators.ListSortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
					var v_ = context.Operators.LastOfList<Observation>(u_);
					var w_ = FHIRHelpers_4_3_000.ToValue(v_?.Effective);
					var x_ = w_ is CqlDateTime;

					return x_;
				};
				bool n_()
				{
					var bh_ = this.Abnormal_Presentation();
					var bi_ = context.Operators.RetrieveByValueSet<Observation>(bh_, null);
					bool? bj_(Observation AbnormalPresentation)
					{
						object bq_()
						{
							bool bz_()
							{
								var cc_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var cd_ = cc_ is CqlDateTime;

								return cd_;
							};
							bool ca_()
							{
								var ce_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var cf_ = ce_ is CqlInterval<CqlDateTime>;

								return cf_;
							};
							bool cb_()
							{
								var cg_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var ch_ = cg_ is CqlDateTime;

								return ch_;
							};
							if (bz_())
							{
								var ci_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ci_ as CqlDateTime) as object);
							}
							else if (ca_())
							{
								var cj_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((cj_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (cb_())
							{
								var ck_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ck_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var br_ = QICoreCommon_2_0_000.earliest(bq_());
						var bs_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var bt_ = context.Operators.SameOrBefore(br_, bs_, null);
						var bu_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						var bv_ = context.Operators.Convert<string>(bu_);
						var bw_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var bx_ = context.Operators.InList<string>(bv_, (bw_ as IEnumerable<string>));
						var by_ = context.Operators.And(bt_, bx_);

						return by_;
					};
					var bk_ = context.Operators.WhereOrNull<Observation>(bi_, bj_);
					object bl_(Observation @this)
					{
						object cl_()
						{
							bool cn_()
							{
								var cq_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var cr_ = cq_ is CqlDateTime;

								return cr_;
							};
							bool co_()
							{
								var cs_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var ct_ = cs_ is CqlInterval<CqlDateTime>;

								return ct_;
							};
							bool cp_()
							{
								var cu_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var cv_ = cu_ is CqlDateTime;

								return cv_;
							};
							if (cn_())
							{
								var cw_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((cw_ as CqlDateTime) as object);
							}
							else if (co_())
							{
								var cx_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((cx_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (cp_())
							{
								var cy_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((cy_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var cm_ = QICoreCommon_2_0_000.earliest(cl_());

						return cm_;
					};
					var bm_ = context.Operators.ListSortBy<Observation>(bk_, bl_, System.ComponentModel.ListSortDirection.Ascending);
					var bn_ = context.Operators.LastOfList<Observation>(bm_);
					var bo_ = FHIRHelpers_4_3_000.ToValue(bn_?.Effective);
					var bp_ = bo_ is CqlInterval<CqlDateTime>;

					return bp_;
				};
				bool o_()
				{
					var cz_ = this.Abnormal_Presentation();
					var da_ = context.Operators.RetrieveByValueSet<Observation>(cz_, null);
					bool? db_(Observation AbnormalPresentation)
					{
						object di_()
						{
							bool dr_()
							{
								var du_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var dv_ = du_ is CqlDateTime;

								return dv_;
							};
							bool ds_()
							{
								var dw_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var dx_ = dw_ is CqlInterval<CqlDateTime>;

								return dx_;
							};
							bool dt_()
							{
								var dy_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var dz_ = dy_ is CqlDateTime;

								return dz_;
							};
							if (dr_())
							{
								var ea_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ea_ as CqlDateTime) as object);
							}
							else if (ds_())
							{
								var eb_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((eb_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (dt_())
							{
								var ec_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ec_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var dj_ = QICoreCommon_2_0_000.earliest(di_());
						var dk_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var dl_ = context.Operators.SameOrBefore(dj_, dk_, null);
						var dm_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						var dn_ = context.Operators.Convert<string>(dm_);
						var do_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var dp_ = context.Operators.InList<string>(dn_, (do_ as IEnumerable<string>));
						var dq_ = context.Operators.And(dl_, dp_);

						return dq_;
					};
					var dc_ = context.Operators.WhereOrNull<Observation>(da_, db_);
					object dd_(Observation @this)
					{
						object ed_()
						{
							bool ef_()
							{
								var ei_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var ej_ = ei_ is CqlDateTime;

								return ej_;
							};
							bool eg_()
							{
								var ek_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var el_ = ek_ is CqlInterval<CqlDateTime>;

								return el_;
							};
							bool eh_()
							{
								var em_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var en_ = em_ is CqlDateTime;

								return en_;
							};
							if (ef_())
							{
								var eo_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((eo_ as CqlDateTime) as object);
							}
							else if (eg_())
							{
								var ep_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((ep_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (eh_())
							{
								var eq_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((eq_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var ee_ = QICoreCommon_2_0_000.earliest(ed_());

						return ee_;
					};
					var de_ = context.Operators.ListSortBy<Observation>(dc_, dd_, System.ComponentModel.ListSortDirection.Ascending);
					var df_ = context.Operators.LastOfList<Observation>(de_);
					var dg_ = FHIRHelpers_4_3_000.ToValue(df_?.Effective);
					var dh_ = dg_ is CqlDateTime;

					return dh_;
				};
				if (m_())
				{
					var er_ = this.Abnormal_Presentation();
					var es_ = context.Operators.RetrieveByValueSet<Observation>(er_, null);
					bool? et_(Observation AbnormalPresentation)
					{
						object ez_()
						{
							bool fi_()
							{
								var fl_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var fm_ = fl_ is CqlDateTime;

								return fm_;
							};
							bool fj_()
							{
								var fn_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var fo_ = fn_ is CqlInterval<CqlDateTime>;

								return fo_;
							};
							bool fk_()
							{
								var fp_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var fq_ = fp_ is CqlDateTime;

								return fq_;
							};
							if (fi_())
							{
								var fr_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((fr_ as CqlDateTime) as object);
							}
							else if (fj_())
							{
								var fs_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((fs_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (fk_())
							{
								var ft_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ft_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var fa_ = QICoreCommon_2_0_000.earliest(ez_());
						var fb_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var fc_ = context.Operators.SameOrBefore(fa_, fb_, null);
						var fd_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						var fe_ = context.Operators.Convert<string>(fd_);
						var ff_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var fg_ = context.Operators.InList<string>(fe_, (ff_ as IEnumerable<string>));
						var fh_ = context.Operators.And(fc_, fg_);

						return fh_;
					};
					var eu_ = context.Operators.WhereOrNull<Observation>(es_, et_);
					object ev_(Observation @this)
					{
						object fu_()
						{
							bool fw_()
							{
								var fz_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var ga_ = fz_ is CqlDateTime;

								return ga_;
							};
							bool fx_()
							{
								var gb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var gc_ = gb_ is CqlInterval<CqlDateTime>;

								return gc_;
							};
							bool fy_()
							{
								var gd_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var ge_ = gd_ is CqlDateTime;

								return ge_;
							};
							if (fw_())
							{
								var gf_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((gf_ as CqlDateTime) as object);
							}
							else if (fx_())
							{
								var gg_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((gg_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (fy_())
							{
								var gh_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((gh_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var fv_ = QICoreCommon_2_0_000.earliest(fu_());

						return fv_;
					};
					var ew_ = context.Operators.ListSortBy<Observation>(eu_, ev_, System.ComponentModel.ListSortDirection.Ascending);
					var ex_ = context.Operators.LastOfList<Observation>(ew_);
					var ey_ = FHIRHelpers_4_3_000.ToValue(ex_?.Effective);

					return ((ey_ as CqlDateTime) as object);
				}
				else if (n_())
				{
					var gi_ = this.Abnormal_Presentation();
					var gj_ = context.Operators.RetrieveByValueSet<Observation>(gi_, null);
					bool? gk_(Observation AbnormalPresentation)
					{
						object gq_()
						{
							bool gz_()
							{
								var hc_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var hd_ = hc_ is CqlDateTime;

								return hd_;
							};
							bool ha_()
							{
								var he_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var hf_ = he_ is CqlInterval<CqlDateTime>;

								return hf_;
							};
							bool hb_()
							{
								var hg_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var hh_ = hg_ is CqlDateTime;

								return hh_;
							};
							if (gz_())
							{
								var hi_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((hi_ as CqlDateTime) as object);
							}
							else if (ha_())
							{
								var hj_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((hj_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (hb_())
							{
								var hk_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((hk_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var gr_ = QICoreCommon_2_0_000.earliest(gq_());
						var gs_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var gt_ = context.Operators.SameOrBefore(gr_, gs_, null);
						var gu_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						var gv_ = context.Operators.Convert<string>(gu_);
						var gw_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var gx_ = context.Operators.InList<string>(gv_, (gw_ as IEnumerable<string>));
						var gy_ = context.Operators.And(gt_, gx_);

						return gy_;
					};
					var gl_ = context.Operators.WhereOrNull<Observation>(gj_, gk_);
					object gm_(Observation @this)
					{
						object hl_()
						{
							bool hn_()
							{
								var hq_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var hr_ = hq_ is CqlDateTime;

								return hr_;
							};
							bool ho_()
							{
								var hs_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var ht_ = hs_ is CqlInterval<CqlDateTime>;

								return ht_;
							};
							bool hp_()
							{
								var hu_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var hv_ = hu_ is CqlDateTime;

								return hv_;
							};
							if (hn_())
							{
								var hw_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((hw_ as CqlDateTime) as object);
							}
							else if (ho_())
							{
								var hx_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((hx_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (hp_())
							{
								var hy_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((hy_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var hm_ = QICoreCommon_2_0_000.earliest(hl_());

						return hm_;
					};
					var gn_ = context.Operators.ListSortBy<Observation>(gl_, gm_, System.ComponentModel.ListSortDirection.Ascending);
					var go_ = context.Operators.LastOfList<Observation>(gn_);
					var gp_ = FHIRHelpers_4_3_000.ToValue(go_?.Effective);

					return ((gp_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (o_())
				{
					var hz_ = this.Abnormal_Presentation();
					var ia_ = context.Operators.RetrieveByValueSet<Observation>(hz_, null);
					bool? ib_(Observation AbnormalPresentation)
					{
						object ih_()
						{
							bool iq_()
							{
								var it_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var iu_ = it_ is CqlDateTime;

								return iu_;
							};
							bool ir_()
							{
								var iv_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var iw_ = iv_ is CqlInterval<CqlDateTime>;

								return iw_;
							};
							bool is_()
							{
								var ix_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								var iy_ = ix_ is CqlDateTime;

								return iy_;
							};
							if (iq_())
							{
								var iz_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((iz_ as CqlDateTime) as object);
							}
							else if (ir_())
							{
								var ja_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ja_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (is_())
							{
								var jb_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((jb_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var ii_ = QICoreCommon_2_0_000.earliest(ih_());
						var ij_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var ik_ = context.Operators.SameOrBefore(ii_, ij_, null);
						var il_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						var im_ = context.Operators.Convert<string>(il_);
						var in_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var io_ = context.Operators.InList<string>(im_, (in_ as IEnumerable<string>));
						var ip_ = context.Operators.And(ik_, io_);

						return ip_;
					};
					var ic_ = context.Operators.WhereOrNull<Observation>(ia_, ib_);
					object id_(Observation @this)
					{
						object jc_()
						{
							bool je_()
							{
								var jh_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var ji_ = jh_ is CqlDateTime;

								return ji_;
							};
							bool jf_()
							{
								var jj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var jk_ = jj_ is CqlInterval<CqlDateTime>;

								return jk_;
							};
							bool jg_()
							{
								var jl_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								var jm_ = jl_ is CqlDateTime;

								return jm_;
							};
							if (je_())
							{
								var jn_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((jn_ as CqlDateTime) as object);
							}
							else if (jf_())
							{
								var jo_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((jo_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (jg_())
							{
								var jp_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((jp_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var jd_ = QICoreCommon_2_0_000.earliest(jc_());

						return jd_;
					};
					var ie_ = context.Operators.ListSortBy<Observation>(ic_, id_, System.ComponentModel.ListSortDirection.Ascending);
					var if_ = context.Operators.LastOfList<Observation>(ie_);
					var ig_ = FHIRHelpers_4_3_000.ToValue(if_?.Effective);

					return ((ig_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var e_ = QICoreCommon_2_0_000.earliest(d_());
			var f_ = FHIRHelpers_4_3_000.ToInterval(ThirtysevenWeeksPlusEncounter?.Period);
			var g_ = context.Operators.ElementInInterval<CqlDateTime>(e_, f_, null);
			var h_ = CQMCommon_2_0_000.encounterDiagnosis(ThirtysevenWeeksPlusEncounter);
			bool? i_(Condition EncounterDiagnosis)
			{
				var jq_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				var jr_ = this.Abnormal_Presentation();
				var js_ = context.Operators.ConceptInValueSet(jq_, jr_);

				return js_;
			};
			var j_ = context.Operators.WhereOrNull<Condition>(h_, i_);
			var k_ = context.Operators.ExistsInList<Condition>(j_);
			var l_ = context.Operators.Or(g_, k_);

			return l_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Abnormal Presentation")]
	public IEnumerable<Encounter> Encounter_with_Abnormal_Presentation() => 
		__Encounter_with_Abnormal_Presentation.Value;

	private IEnumerable<Encounter> Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum_Value()
	{
		var a_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births();
		bool? b_(Encounter ThirtysevenWeeksPlusEncounter)
		{
			var d_ = CQMCommon_2_0_000.encounterDiagnosis(ThirtysevenWeeksPlusEncounter);
			bool? e_(Condition EncounterDiagnosis)
			{
				var h_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				var i_ = this.Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa();
				var j_ = context.Operators.ConceptInValueSet(h_, i_);
				var l_ = this.Genital_Herpes();
				var m_ = context.Operators.ConceptInValueSet(h_, l_);
				var n_ = context.Operators.Or(j_, m_);

				return n_;
			};
			var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);
			var g_ = context.Operators.ExistsInList<Condition>(f_);

			return g_;
		};
		var c_ = context.Operators.WhereOrNull<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
	public IEnumerable<Encounter> Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum() => 
		__Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum_Value()
	{
		var a_ = this.Encounter_with_Abnormal_Presentation();
		var b_ = this.Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum();
		var c_ = context.Operators.ListUnion<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum() => 
		__Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		var a_ = this.Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum();

		return a_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Cesarean_Birth_Value()
	{
		var a_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births();
		IEnumerable<Encounter> b_(Encounter ThirtysevenWeeksPlusEncounter)
		{
			var d_ = this.Cesarean_Birth();
			var e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
			bool? f_(Procedure CSection)
			{
				var j_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(ThirtysevenWeeksPlusEncounter);
				var k_ = FHIRHelpers_4_3_000.ToValue(CSection?.Performed);
				var l_ = QICoreCommon_2_0_000.toInterval(k_);
				var m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, null);
				var n_ = context.Operators.EnumEqualsString(CSection?.StatusElement?.Value, "completed");
				var o_ = context.Operators.And(m_, n_);

				return o_;
			};
			var g_ = context.Operators.WhereOrNull<Procedure>(e_, f_);
			Encounter h_(Procedure CSection) => 
				ThirtysevenWeeksPlusEncounter;
			var i_ = context.Operators.SelectOrNull<Procedure, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Cesarean Birth")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Cesarean_Birth() => 
		__Delivery_Encounter_with_Cesarean_Birth.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Delivery_Encounter_with_Cesarean_Birth();

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

	private IEnumerable<Tuples.Tuple_CDQdAjUGdePbWTVfePeZUXKFM> Variable_Calculated_Gestational_Age_Value()
	{
		var a_ = PCMaternal_5_16_000.Variable_Calculated_Gestational_Age();

		return a_;
	}

    [CqlDeclaration("Variable Calculated Gestational Age")]
	public IEnumerable<Tuples.Tuple_CDQdAjUGdePbWTVfePeZUXKFM> Variable_Calculated_Gestational_Age() => 
		__Variable_Calculated_Gestational_Age.Value;

}
