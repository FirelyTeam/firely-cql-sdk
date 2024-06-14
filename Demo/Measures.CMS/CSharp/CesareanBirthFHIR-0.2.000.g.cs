using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
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
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Tuple_QRZgNJCaGQEYIeOSBhjLZNSO>> __Variable_Calculated_Gestational_Age;

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
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Variable_Calculated_Gestational_Age = new Lazy<IEnumerable<Tuple_QRZgNJCaGQEYIeOSBhjLZNSO>>(this.Variable_Calculated_Gestational_Age_Value);
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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
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
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

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
			var e_ = context.Operators.GreaterOrEqual(d_, 37);

			return e_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

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
			var f_ = context.Operators.Quantity(37m, "weeks");
			var g_ = context.Operators.GreaterOrEqual(e_, f_);
			var h_ = context.Operators.And((bool?)(d_ is null), g_);

			return h_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

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
				var l_ = EncounterDiagnosis?.Code;
				var m_ = FHIRHelpers_4_3_000.ToConcept(l_);
				var n_ = this._37_to_42_Plus_Weeks_Gestation();
				var o_ = context.Operators.ConceptInValueSet(m_, n_);

				return o_;
			};
			var i_ = context.Operators.Where<Condition>(g_, h_);
			var j_ = context.Operators.Exists<Condition>(i_);
			var k_ = context.Operators.And(f_, j_);

			return k_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks Based on Coding")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding() => 
		__Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Value()
	{
		var a_ = this.Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks();
		var b_ = this.Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks();
		var c_ = context.Operators.Union<Encounter>(a_, b_);
		var d_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding();
		var e_ = context.Operators.Union<Encounter>(c_, d_);

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
				var h_ = EncounterDiagnosis?.Code;
				var i_ = FHIRHelpers_4_3_000.ToConcept(h_);
				var j_ = this.Delivery_of_Singleton();
				var k_ = context.Operators.ConceptInValueSet(i_, j_);

				return k_;
			};
			var f_ = context.Operators.Where<Condition>(d_, e_);
			var g_ = context.Operators.Exists<Condition>(f_);

			return g_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

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
			var j_ = Gravida?.Value;
			var k_ = FHIRHelpers_4_3_000.ToValue(j_);
			var l_ = context.Operators.Not((bool?)(k_ is null));
			var m_ = Gravida?.StatusElement;
			var n_ = m_?.Value;
			var o_ = context.Operators.Convert<Code<ObservationStatus>>(n_);
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var r_ = context.Operators.In<string>(p_, (q_ as IEnumerable<string>));
			var s_ = context.Operators.And(l_, r_);
			object t_()
			{
				bool af_()
				{
					var ai_ = Gravida?.Effective;
					var aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
					var ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				bool ag_()
				{
					var al_ = Gravida?.Effective;
					var am_ = FHIRHelpers_4_3_000.ToValue(al_);
					var an_ = am_ is CqlInterval<CqlDateTime>;

					return an_;
				};
				bool ah_()
				{
					var ao_ = Gravida?.Effective;
					var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
					var aq_ = ap_ is CqlDateTime;

					return aq_;
				};
				if (af_())
				{
					var ar_ = Gravida?.Effective;
					var as_ = FHIRHelpers_4_3_000.ToValue(ar_);

					return ((as_ as CqlDateTime) as object);
				}
				else if (ag_())
				{
					var at_ = Gravida?.Effective;
					var au_ = FHIRHelpers_4_3_000.ToValue(at_);

					return ((au_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ah_())
				{
					var av_ = Gravida?.Effective;
					var aw_ = FHIRHelpers_4_3_000.ToValue(av_);

					return ((aw_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var u_ = QICoreCommon_2_0_000.earliest(t_());
			var v_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var w_ = context.Operators.Quantity(42m, "weeks");
			var x_ = context.Operators.Subtract(v_, w_);
			var z_ = context.Operators.Interval(x_, v_, true, false);
			var aa_ = context.Operators.In<CqlDateTime>(u_, z_, null);
			var ac_ = context.Operators.Not((bool?)(v_ is null));
			var ad_ = context.Operators.And(aa_, ac_);
			var ae_ = context.Operators.And(s_, ad_);

			return ae_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ax_()
			{
				bool az_()
				{
					var bc_ = @this?.Effective;
					var bd_ = FHIRHelpers_4_3_000.ToValue(bc_);
					var be_ = bd_ is CqlDateTime;

					return be_;
				};
				bool ba_()
				{
					var bf_ = @this?.Effective;
					var bg_ = FHIRHelpers_4_3_000.ToValue(bf_);
					var bh_ = bg_ is CqlInterval<CqlDateTime>;

					return bh_;
				};
				bool bb_()
				{
					var bi_ = @this?.Effective;
					var bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
					var bk_ = bj_ is CqlDateTime;

					return bk_;
				};
				if (az_())
				{
					var bl_ = @this?.Effective;
					var bm_ = FHIRHelpers_4_3_000.ToValue(bl_);

					return ((bm_ as CqlDateTime) as object);
				}
				else if (ba_())
				{
					var bn_ = @this?.Effective;
					var bo_ = FHIRHelpers_4_3_000.ToValue(bn_);

					return ((bo_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bb_())
				{
					var bp_ = @this?.Effective;
					var bq_ = FHIRHelpers_4_3_000.ToValue(bp_);

					return ((bq_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var ay_ = QICoreCommon_2_0_000.earliest(ax_());

			return ay_;
		};
		var g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.Last<Observation>(g_);
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
				bool af_()
				{
					var ai_ = Parity?.Effective;
					var aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
					var ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				bool ag_()
				{
					var al_ = Parity?.Effective;
					var am_ = FHIRHelpers_4_3_000.ToValue(al_);
					var an_ = am_ is CqlInterval<CqlDateTime>;

					return an_;
				};
				bool ah_()
				{
					var ao_ = Parity?.Effective;
					var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
					var aq_ = ap_ is CqlDateTime;

					return aq_;
				};
				if (af_())
				{
					var ar_ = Parity?.Effective;
					var as_ = FHIRHelpers_4_3_000.ToValue(ar_);

					return ((as_ as CqlDateTime) as object);
				}
				else if (ag_())
				{
					var at_ = Parity?.Effective;
					var au_ = FHIRHelpers_4_3_000.ToValue(at_);

					return ((au_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ah_())
				{
					var av_ = Parity?.Effective;
					var aw_ = FHIRHelpers_4_3_000.ToValue(av_);

					return ((aw_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var k_ = QICoreCommon_2_0_000.earliest(j_());
			var l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var m_ = context.Operators.Quantity(42m, "weeks");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.Interval(n_, l_, true, false);
			var q_ = context.Operators.In<CqlDateTime>(k_, p_, null);
			var s_ = context.Operators.Not((bool?)(l_ is null));
			var t_ = context.Operators.And(q_, s_);
			var u_ = Parity?.StatusElement;
			var v_ = u_?.Value;
			var w_ = context.Operators.Convert<Code<ObservationStatus>>(v_);
			var x_ = context.Operators.Convert<string>(w_);
			var y_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var z_ = context.Operators.In<string>(x_, (y_ as IEnumerable<string>));
			var aa_ = context.Operators.And(t_, z_);
			var ab_ = Parity?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(aa_, ad_);

			return ae_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ax_()
			{
				bool az_()
				{
					var bc_ = @this?.Effective;
					var bd_ = FHIRHelpers_4_3_000.ToValue(bc_);
					var be_ = bd_ is CqlDateTime;

					return be_;
				};
				bool ba_()
				{
					var bf_ = @this?.Effective;
					var bg_ = FHIRHelpers_4_3_000.ToValue(bf_);
					var bh_ = bg_ is CqlInterval<CqlDateTime>;

					return bh_;
				};
				bool bb_()
				{
					var bi_ = @this?.Effective;
					var bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
					var bk_ = bj_ is CqlDateTime;

					return bk_;
				};
				if (az_())
				{
					var bl_ = @this?.Effective;
					var bm_ = FHIRHelpers_4_3_000.ToValue(bl_);

					return ((bm_ as CqlDateTime) as object);
				}
				else if (ba_())
				{
					var bn_ = @this?.Effective;
					var bo_ = FHIRHelpers_4_3_000.ToValue(bn_);

					return ((bo_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bb_())
				{
					var bp_ = @this?.Effective;
					var bq_ = FHIRHelpers_4_3_000.ToValue(bp_);

					return ((bq_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var ay_ = QICoreCommon_2_0_000.earliest(ax_());

			return ay_;
		};
		var g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.Last<Observation>(g_);
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
				bool af_()
				{
					var ai_ = PretermBirth?.Effective;
					var aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
					var ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				bool ag_()
				{
					var al_ = PretermBirth?.Effective;
					var am_ = FHIRHelpers_4_3_000.ToValue(al_);
					var an_ = am_ is CqlInterval<CqlDateTime>;

					return an_;
				};
				bool ah_()
				{
					var ao_ = PretermBirth?.Effective;
					var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
					var aq_ = ap_ is CqlDateTime;

					return aq_;
				};
				if (af_())
				{
					var ar_ = PretermBirth?.Effective;
					var as_ = FHIRHelpers_4_3_000.ToValue(ar_);

					return ((as_ as CqlDateTime) as object);
				}
				else if (ag_())
				{
					var at_ = PretermBirth?.Effective;
					var au_ = FHIRHelpers_4_3_000.ToValue(at_);

					return ((au_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ah_())
				{
					var av_ = PretermBirth?.Effective;
					var aw_ = FHIRHelpers_4_3_000.ToValue(av_);

					return ((aw_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var k_ = QICoreCommon_2_0_000.earliest(j_());
			var l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var m_ = context.Operators.Quantity(42m, "weeks");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.Interval(n_, l_, true, false);
			var q_ = context.Operators.In<CqlDateTime>(k_, p_, null);
			var s_ = context.Operators.Not((bool?)(l_ is null));
			var t_ = context.Operators.And(q_, s_);
			var u_ = PretermBirth?.StatusElement;
			var v_ = u_?.Value;
			var w_ = context.Operators.Convert<Code<ObservationStatus>>(v_);
			var x_ = context.Operators.Convert<string>(w_);
			var y_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var z_ = context.Operators.In<string>(x_, (y_ as IEnumerable<string>));
			var aa_ = context.Operators.And(t_, z_);
			var ab_ = PretermBirth?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(aa_, ad_);

			return ae_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ax_()
			{
				bool az_()
				{
					var bc_ = @this?.Effective;
					var bd_ = FHIRHelpers_4_3_000.ToValue(bc_);
					var be_ = bd_ is CqlDateTime;

					return be_;
				};
				bool ba_()
				{
					var bf_ = @this?.Effective;
					var bg_ = FHIRHelpers_4_3_000.ToValue(bf_);
					var bh_ = bg_ is CqlInterval<CqlDateTime>;

					return bh_;
				};
				bool bb_()
				{
					var bi_ = @this?.Effective;
					var bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
					var bk_ = bj_ is CqlDateTime;

					return bk_;
				};
				if (az_())
				{
					var bl_ = @this?.Effective;
					var bm_ = FHIRHelpers_4_3_000.ToValue(bl_);

					return ((bm_ as CqlDateTime) as object);
				}
				else if (ba_())
				{
					var bn_ = @this?.Effective;
					var bo_ = FHIRHelpers_4_3_000.ToValue(bn_);

					return ((bo_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bb_())
				{
					var bp_ = @this?.Effective;
					var bq_ = FHIRHelpers_4_3_000.ToValue(bp_);

					return ((bq_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var ay_ = QICoreCommon_2_0_000.earliest(ax_());

			return ay_;
		};
		var g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.Last<Observation>(g_);
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
				bool af_()
				{
					var ai_ = TermBirth?.Effective;
					var aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
					var ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				bool ag_()
				{
					var al_ = TermBirth?.Effective;
					var am_ = FHIRHelpers_4_3_000.ToValue(al_);
					var an_ = am_ is CqlInterval<CqlDateTime>;

					return an_;
				};
				bool ah_()
				{
					var ao_ = TermBirth?.Effective;
					var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
					var aq_ = ap_ is CqlDateTime;

					return aq_;
				};
				if (af_())
				{
					var ar_ = TermBirth?.Effective;
					var as_ = FHIRHelpers_4_3_000.ToValue(ar_);

					return ((as_ as CqlDateTime) as object);
				}
				else if (ag_())
				{
					var at_ = TermBirth?.Effective;
					var au_ = FHIRHelpers_4_3_000.ToValue(at_);

					return ((au_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ah_())
				{
					var av_ = TermBirth?.Effective;
					var aw_ = FHIRHelpers_4_3_000.ToValue(av_);

					return ((aw_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var k_ = QICoreCommon_2_0_000.earliest(j_());
			var l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var m_ = context.Operators.Quantity(42m, "weeks");
			var n_ = context.Operators.Subtract(l_, m_);
			var p_ = context.Operators.Interval(n_, l_, true, false);
			var q_ = context.Operators.In<CqlDateTime>(k_, p_, null);
			var s_ = context.Operators.Not((bool?)(l_ is null));
			var t_ = context.Operators.And(q_, s_);
			var u_ = TermBirth?.StatusElement;
			var v_ = u_?.Value;
			var w_ = context.Operators.Convert<Code<ObservationStatus>>(v_);
			var x_ = context.Operators.Convert<string>(w_);
			var y_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var z_ = context.Operators.In<string>(x_, (y_ as IEnumerable<string>));
			var aa_ = context.Operators.And(t_, z_);
			var ab_ = TermBirth?.Value;
			var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
			var ad_ = context.Operators.Not((bool?)(ac_ is null));
			var ae_ = context.Operators.And(aa_, ad_);

			return ae_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ax_()
			{
				bool az_()
				{
					var bc_ = @this?.Effective;
					var bd_ = FHIRHelpers_4_3_000.ToValue(bc_);
					var be_ = bd_ is CqlDateTime;

					return be_;
				};
				bool ba_()
				{
					var bf_ = @this?.Effective;
					var bg_ = FHIRHelpers_4_3_000.ToValue(bf_);
					var bh_ = bg_ is CqlInterval<CqlDateTime>;

					return bh_;
				};
				bool bb_()
				{
					var bi_ = @this?.Effective;
					var bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
					var bk_ = bj_ is CqlDateTime;

					return bk_;
				};
				if (az_())
				{
					var bl_ = @this?.Effective;
					var bm_ = FHIRHelpers_4_3_000.ToValue(bl_);

					return ((bm_ as CqlDateTime) as object);
				}
				else if (ba_())
				{
					var bn_ = @this?.Effective;
					var bo_ = FHIRHelpers_4_3_000.ToValue(bn_);

					return ((bo_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (bb_())
				{
					var bp_ = @this?.Effective;
					var bq_ = FHIRHelpers_4_3_000.ToValue(bp_);

					return ((bq_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var ay_ = QICoreCommon_2_0_000.earliest(ax_());

			return ay_;
		};
		var g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.Last<Observation>(g_);
		var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

	private IEnumerable<Encounter> Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births_Value()
	{
		var a_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks();
		var b_ = this.Encounter_with_Singleton_Delivery();
		var c_ = context.Operators.Intersect<Encounter>(a_, b_);
		bool? d_(Encounter SingletonEncounterGE37Weeks)
		{
			var f_ = this.lastGravida(SingletonEncounterGE37Weeks);
			var g_ = context.Operators.Equal(f_, 1);
			var h_ = this.lastParity(SingletonEncounterGE37Weeks);
			var i_ = context.Operators.Equal(h_, 0);
			var j_ = context.Operators.Or(g_, i_);
			var k_ = this.lastHistoryPretermBirth(SingletonEncounterGE37Weeks);
			var l_ = context.Operators.Equal(k_, 0);
			var m_ = this.lastHistoryTermBirth(SingletonEncounterGE37Weeks);
			var n_ = context.Operators.Equal(m_, 0);
			var o_ = context.Operators.And(l_, n_);
			var p_ = context.Operators.Or(j_, o_);

			return p_;
		};
		var e_ = context.Operators.Where<Encounter>(c_, d_);

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
				bool n_()
				{
					var q_ = this.Abnormal_Presentation();
					var r_ = context.Operators.RetrieveByValueSet<Observation>(q_, null);
					bool? s_(Observation AbnormalPresentation)
					{
						object aa_()
						{
							bool al_()
							{
								var ao_ = AbnormalPresentation?.Effective;
								var ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
								var aq_ = ap_ is CqlDateTime;

								return aq_;
							};
							bool am_()
							{
								var ar_ = AbnormalPresentation?.Effective;
								var as_ = FHIRHelpers_4_3_000.ToValue(ar_);
								var at_ = as_ is CqlInterval<CqlDateTime>;

								return at_;
							};
							bool an_()
							{
								var au_ = AbnormalPresentation?.Effective;
								var av_ = FHIRHelpers_4_3_000.ToValue(au_);
								var aw_ = av_ is CqlDateTime;

								return aw_;
							};
							if (al_())
							{
								var ax_ = AbnormalPresentation?.Effective;
								var ay_ = FHIRHelpers_4_3_000.ToValue(ax_);

								return ((ay_ as CqlDateTime) as object);
							}
							else if (am_())
							{
								var az_ = AbnormalPresentation?.Effective;
								var ba_ = FHIRHelpers_4_3_000.ToValue(az_);

								return ((ba_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (an_())
							{
								var bb_ = AbnormalPresentation?.Effective;
								var bc_ = FHIRHelpers_4_3_000.ToValue(bb_);

								return ((bc_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var ab_ = QICoreCommon_2_0_000.earliest(aa_());
						var ac_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var ad_ = context.Operators.SameOrBefore(ab_, ac_, null);
						var ae_ = AbnormalPresentation?.StatusElement;
						var af_ = ae_?.Value;
						var ag_ = context.Operators.Convert<Code<ObservationStatus>>(af_);
						var ah_ = context.Operators.Convert<string>(ag_);
						var ai_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var aj_ = context.Operators.In<string>(ah_, (ai_ as IEnumerable<string>));
						var ak_ = context.Operators.And(ad_, aj_);

						return ak_;
					};
					var t_ = context.Operators.Where<Observation>(r_, s_);
					object u_(Observation @this)
					{
						object bd_()
						{
							bool bf_()
							{
								var bi_ = @this?.Effective;
								var bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
								var bk_ = bj_ is CqlDateTime;

								return bk_;
							};
							bool bg_()
							{
								var bl_ = @this?.Effective;
								var bm_ = FHIRHelpers_4_3_000.ToValue(bl_);
								var bn_ = bm_ is CqlInterval<CqlDateTime>;

								return bn_;
							};
							bool bh_()
							{
								var bo_ = @this?.Effective;
								var bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
								var bq_ = bp_ is CqlDateTime;

								return bq_;
							};
							if (bf_())
							{
								var br_ = @this?.Effective;
								var bs_ = FHIRHelpers_4_3_000.ToValue(br_);

								return ((bs_ as CqlDateTime) as object);
							}
							else if (bg_())
							{
								var bt_ = @this?.Effective;
								var bu_ = FHIRHelpers_4_3_000.ToValue(bt_);

								return ((bu_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (bh_())
							{
								var bv_ = @this?.Effective;
								var bw_ = FHIRHelpers_4_3_000.ToValue(bv_);

								return ((bw_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var be_ = QICoreCommon_2_0_000.earliest(bd_());

						return be_;
					};
					var v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
					var w_ = context.Operators.Last<Observation>(v_);
					var x_ = w_?.Effective;
					var y_ = FHIRHelpers_4_3_000.ToValue(x_);
					var z_ = y_ is CqlDateTime;

					return z_;
				};
				bool o_()
				{
					var bx_ = this.Abnormal_Presentation();
					var by_ = context.Operators.RetrieveByValueSet<Observation>(bx_, null);
					bool? bz_(Observation AbnormalPresentation)
					{
						object ch_()
						{
							bool cs_()
							{
								var cv_ = AbnormalPresentation?.Effective;
								var cw_ = FHIRHelpers_4_3_000.ToValue(cv_);
								var cx_ = cw_ is CqlDateTime;

								return cx_;
							};
							bool ct_()
							{
								var cy_ = AbnormalPresentation?.Effective;
								var cz_ = FHIRHelpers_4_3_000.ToValue(cy_);
								var da_ = cz_ is CqlInterval<CqlDateTime>;

								return da_;
							};
							bool cu_()
							{
								var db_ = AbnormalPresentation?.Effective;
								var dc_ = FHIRHelpers_4_3_000.ToValue(db_);
								var dd_ = dc_ is CqlDateTime;

								return dd_;
							};
							if (cs_())
							{
								var de_ = AbnormalPresentation?.Effective;
								var df_ = FHIRHelpers_4_3_000.ToValue(de_);

								return ((df_ as CqlDateTime) as object);
							}
							else if (ct_())
							{
								var dg_ = AbnormalPresentation?.Effective;
								var dh_ = FHIRHelpers_4_3_000.ToValue(dg_);

								return ((dh_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (cu_())
							{
								var di_ = AbnormalPresentation?.Effective;
								var dj_ = FHIRHelpers_4_3_000.ToValue(di_);

								return ((dj_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var ci_ = QICoreCommon_2_0_000.earliest(ch_());
						var cj_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var ck_ = context.Operators.SameOrBefore(ci_, cj_, null);
						var cl_ = AbnormalPresentation?.StatusElement;
						var cm_ = cl_?.Value;
						var cn_ = context.Operators.Convert<Code<ObservationStatus>>(cm_);
						var co_ = context.Operators.Convert<string>(cn_);
						var cp_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var cq_ = context.Operators.In<string>(co_, (cp_ as IEnumerable<string>));
						var cr_ = context.Operators.And(ck_, cq_);

						return cr_;
					};
					var ca_ = context.Operators.Where<Observation>(by_, bz_);
					object cb_(Observation @this)
					{
						object dk_()
						{
							bool dm_()
							{
								var dp_ = @this?.Effective;
								var dq_ = FHIRHelpers_4_3_000.ToValue(dp_);
								var dr_ = dq_ is CqlDateTime;

								return dr_;
							};
							bool dn_()
							{
								var ds_ = @this?.Effective;
								var dt_ = FHIRHelpers_4_3_000.ToValue(ds_);
								var du_ = dt_ is CqlInterval<CqlDateTime>;

								return du_;
							};
							bool do_()
							{
								var dv_ = @this?.Effective;
								var dw_ = FHIRHelpers_4_3_000.ToValue(dv_);
								var dx_ = dw_ is CqlDateTime;

								return dx_;
							};
							if (dm_())
							{
								var dy_ = @this?.Effective;
								var dz_ = FHIRHelpers_4_3_000.ToValue(dy_);

								return ((dz_ as CqlDateTime) as object);
							}
							else if (dn_())
							{
								var ea_ = @this?.Effective;
								var eb_ = FHIRHelpers_4_3_000.ToValue(ea_);

								return ((eb_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (do_())
							{
								var ec_ = @this?.Effective;
								var ed_ = FHIRHelpers_4_3_000.ToValue(ec_);

								return ((ed_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var dl_ = QICoreCommon_2_0_000.earliest(dk_());

						return dl_;
					};
					var cc_ = context.Operators.SortBy<Observation>(ca_, cb_, System.ComponentModel.ListSortDirection.Ascending);
					var cd_ = context.Operators.Last<Observation>(cc_);
					var ce_ = cd_?.Effective;
					var cf_ = FHIRHelpers_4_3_000.ToValue(ce_);
					var cg_ = cf_ is CqlInterval<CqlDateTime>;

					return cg_;
				};
				bool p_()
				{
					var ee_ = this.Abnormal_Presentation();
					var ef_ = context.Operators.RetrieveByValueSet<Observation>(ee_, null);
					bool? eg_(Observation AbnormalPresentation)
					{
						object eo_()
						{
							bool ez_()
							{
								var fc_ = AbnormalPresentation?.Effective;
								var fd_ = FHIRHelpers_4_3_000.ToValue(fc_);
								var fe_ = fd_ is CqlDateTime;

								return fe_;
							};
							bool fa_()
							{
								var ff_ = AbnormalPresentation?.Effective;
								var fg_ = FHIRHelpers_4_3_000.ToValue(ff_);
								var fh_ = fg_ is CqlInterval<CqlDateTime>;

								return fh_;
							};
							bool fb_()
							{
								var fi_ = AbnormalPresentation?.Effective;
								var fj_ = FHIRHelpers_4_3_000.ToValue(fi_);
								var fk_ = fj_ is CqlDateTime;

								return fk_;
							};
							if (ez_())
							{
								var fl_ = AbnormalPresentation?.Effective;
								var fm_ = FHIRHelpers_4_3_000.ToValue(fl_);

								return ((fm_ as CqlDateTime) as object);
							}
							else if (fa_())
							{
								var fn_ = AbnormalPresentation?.Effective;
								var fo_ = FHIRHelpers_4_3_000.ToValue(fn_);

								return ((fo_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (fb_())
							{
								var fp_ = AbnormalPresentation?.Effective;
								var fq_ = FHIRHelpers_4_3_000.ToValue(fp_);

								return ((fq_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var ep_ = QICoreCommon_2_0_000.earliest(eo_());
						var eq_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var er_ = context.Operators.SameOrBefore(ep_, eq_, null);
						var es_ = AbnormalPresentation?.StatusElement;
						var et_ = es_?.Value;
						var eu_ = context.Operators.Convert<Code<ObservationStatus>>(et_);
						var ev_ = context.Operators.Convert<string>(eu_);
						var ew_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var ex_ = context.Operators.In<string>(ev_, (ew_ as IEnumerable<string>));
						var ey_ = context.Operators.And(er_, ex_);

						return ey_;
					};
					var eh_ = context.Operators.Where<Observation>(ef_, eg_);
					object ei_(Observation @this)
					{
						object fr_()
						{
							bool ft_()
							{
								var fw_ = @this?.Effective;
								var fx_ = FHIRHelpers_4_3_000.ToValue(fw_);
								var fy_ = fx_ is CqlDateTime;

								return fy_;
							};
							bool fu_()
							{
								var fz_ = @this?.Effective;
								var ga_ = FHIRHelpers_4_3_000.ToValue(fz_);
								var gb_ = ga_ is CqlInterval<CqlDateTime>;

								return gb_;
							};
							bool fv_()
							{
								var gc_ = @this?.Effective;
								var gd_ = FHIRHelpers_4_3_000.ToValue(gc_);
								var ge_ = gd_ is CqlDateTime;

								return ge_;
							};
							if (ft_())
							{
								var gf_ = @this?.Effective;
								var gg_ = FHIRHelpers_4_3_000.ToValue(gf_);

								return ((gg_ as CqlDateTime) as object);
							}
							else if (fu_())
							{
								var gh_ = @this?.Effective;
								var gi_ = FHIRHelpers_4_3_000.ToValue(gh_);

								return ((gi_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (fv_())
							{
								var gj_ = @this?.Effective;
								var gk_ = FHIRHelpers_4_3_000.ToValue(gj_);

								return ((gk_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var fs_ = QICoreCommon_2_0_000.earliest(fr_());

						return fs_;
					};
					var ej_ = context.Operators.SortBy<Observation>(eh_, ei_, System.ComponentModel.ListSortDirection.Ascending);
					var ek_ = context.Operators.Last<Observation>(ej_);
					var el_ = ek_?.Effective;
					var em_ = FHIRHelpers_4_3_000.ToValue(el_);
					var en_ = em_ is CqlDateTime;

					return en_;
				};
				if (n_())
				{
					var gl_ = this.Abnormal_Presentation();
					var gm_ = context.Operators.RetrieveByValueSet<Observation>(gl_, null);
					bool? gn_(Observation AbnormalPresentation)
					{
						object gu_()
						{
							bool hf_()
							{
								var hi_ = AbnormalPresentation?.Effective;
								var hj_ = FHIRHelpers_4_3_000.ToValue(hi_);
								var hk_ = hj_ is CqlDateTime;

								return hk_;
							};
							bool hg_()
							{
								var hl_ = AbnormalPresentation?.Effective;
								var hm_ = FHIRHelpers_4_3_000.ToValue(hl_);
								var hn_ = hm_ is CqlInterval<CqlDateTime>;

								return hn_;
							};
							bool hh_()
							{
								var ho_ = AbnormalPresentation?.Effective;
								var hp_ = FHIRHelpers_4_3_000.ToValue(ho_);
								var hq_ = hp_ is CqlDateTime;

								return hq_;
							};
							if (hf_())
							{
								var hr_ = AbnormalPresentation?.Effective;
								var hs_ = FHIRHelpers_4_3_000.ToValue(hr_);

								return ((hs_ as CqlDateTime) as object);
							}
							else if (hg_())
							{
								var ht_ = AbnormalPresentation?.Effective;
								var hu_ = FHIRHelpers_4_3_000.ToValue(ht_);

								return ((hu_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (hh_())
							{
								var hv_ = AbnormalPresentation?.Effective;
								var hw_ = FHIRHelpers_4_3_000.ToValue(hv_);

								return ((hw_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var gv_ = QICoreCommon_2_0_000.earliest(gu_());
						var gw_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var gx_ = context.Operators.SameOrBefore(gv_, gw_, null);
						var gy_ = AbnormalPresentation?.StatusElement;
						var gz_ = gy_?.Value;
						var ha_ = context.Operators.Convert<Code<ObservationStatus>>(gz_);
						var hb_ = context.Operators.Convert<string>(ha_);
						var hc_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var hd_ = context.Operators.In<string>(hb_, (hc_ as IEnumerable<string>));
						var he_ = context.Operators.And(gx_, hd_);

						return he_;
					};
					var go_ = context.Operators.Where<Observation>(gm_, gn_);
					object gp_(Observation @this)
					{
						object hx_()
						{
							bool hz_()
							{
								var ic_ = @this?.Effective;
								var id_ = FHIRHelpers_4_3_000.ToValue(ic_);
								var ie_ = id_ is CqlDateTime;

								return ie_;
							};
							bool ia_()
							{
								var if_ = @this?.Effective;
								var ig_ = FHIRHelpers_4_3_000.ToValue(if_);
								var ih_ = ig_ is CqlInterval<CqlDateTime>;

								return ih_;
							};
							bool ib_()
							{
								var ii_ = @this?.Effective;
								var ij_ = FHIRHelpers_4_3_000.ToValue(ii_);
								var ik_ = ij_ is CqlDateTime;

								return ik_;
							};
							if (hz_())
							{
								var il_ = @this?.Effective;
								var im_ = FHIRHelpers_4_3_000.ToValue(il_);

								return ((im_ as CqlDateTime) as object);
							}
							else if (ia_())
							{
								var in_ = @this?.Effective;
								var io_ = FHIRHelpers_4_3_000.ToValue(in_);

								return ((io_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (ib_())
							{
								var ip_ = @this?.Effective;
								var iq_ = FHIRHelpers_4_3_000.ToValue(ip_);

								return ((iq_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var hy_ = QICoreCommon_2_0_000.earliest(hx_());

						return hy_;
					};
					var gq_ = context.Operators.SortBy<Observation>(go_, gp_, System.ComponentModel.ListSortDirection.Ascending);
					var gr_ = context.Operators.Last<Observation>(gq_);
					var gs_ = gr_?.Effective;
					var gt_ = FHIRHelpers_4_3_000.ToValue(gs_);

					return ((gt_ as CqlDateTime) as object);
				}
				else if (o_())
				{
					var ir_ = this.Abnormal_Presentation();
					var is_ = context.Operators.RetrieveByValueSet<Observation>(ir_, null);
					bool? it_(Observation AbnormalPresentation)
					{
						object ja_()
						{
							bool jl_()
							{
								var jo_ = AbnormalPresentation?.Effective;
								var jp_ = FHIRHelpers_4_3_000.ToValue(jo_);
								var jq_ = jp_ is CqlDateTime;

								return jq_;
							};
							bool jm_()
							{
								var jr_ = AbnormalPresentation?.Effective;
								var js_ = FHIRHelpers_4_3_000.ToValue(jr_);
								var jt_ = js_ is CqlInterval<CqlDateTime>;

								return jt_;
							};
							bool jn_()
							{
								var ju_ = AbnormalPresentation?.Effective;
								var jv_ = FHIRHelpers_4_3_000.ToValue(ju_);
								var jw_ = jv_ is CqlDateTime;

								return jw_;
							};
							if (jl_())
							{
								var jx_ = AbnormalPresentation?.Effective;
								var jy_ = FHIRHelpers_4_3_000.ToValue(jx_);

								return ((jy_ as CqlDateTime) as object);
							}
							else if (jm_())
							{
								var jz_ = AbnormalPresentation?.Effective;
								var ka_ = FHIRHelpers_4_3_000.ToValue(jz_);

								return ((ka_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (jn_())
							{
								var kb_ = AbnormalPresentation?.Effective;
								var kc_ = FHIRHelpers_4_3_000.ToValue(kb_);

								return ((kc_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var jb_ = QICoreCommon_2_0_000.earliest(ja_());
						var jc_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var jd_ = context.Operators.SameOrBefore(jb_, jc_, null);
						var je_ = AbnormalPresentation?.StatusElement;
						var jf_ = je_?.Value;
						var jg_ = context.Operators.Convert<Code<ObservationStatus>>(jf_);
						var jh_ = context.Operators.Convert<string>(jg_);
						var ji_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var jj_ = context.Operators.In<string>(jh_, (ji_ as IEnumerable<string>));
						var jk_ = context.Operators.And(jd_, jj_);

						return jk_;
					};
					var iu_ = context.Operators.Where<Observation>(is_, it_);
					object iv_(Observation @this)
					{
						object kd_()
						{
							bool kf_()
							{
								var ki_ = @this?.Effective;
								var kj_ = FHIRHelpers_4_3_000.ToValue(ki_);
								var kk_ = kj_ is CqlDateTime;

								return kk_;
							};
							bool kg_()
							{
								var kl_ = @this?.Effective;
								var km_ = FHIRHelpers_4_3_000.ToValue(kl_);
								var kn_ = km_ is CqlInterval<CqlDateTime>;

								return kn_;
							};
							bool kh_()
							{
								var ko_ = @this?.Effective;
								var kp_ = FHIRHelpers_4_3_000.ToValue(ko_);
								var kq_ = kp_ is CqlDateTime;

								return kq_;
							};
							if (kf_())
							{
								var kr_ = @this?.Effective;
								var ks_ = FHIRHelpers_4_3_000.ToValue(kr_);

								return ((ks_ as CqlDateTime) as object);
							}
							else if (kg_())
							{
								var kt_ = @this?.Effective;
								var ku_ = FHIRHelpers_4_3_000.ToValue(kt_);

								return ((ku_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (kh_())
							{
								var kv_ = @this?.Effective;
								var kw_ = FHIRHelpers_4_3_000.ToValue(kv_);

								return ((kw_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var ke_ = QICoreCommon_2_0_000.earliest(kd_());

						return ke_;
					};
					var iw_ = context.Operators.SortBy<Observation>(iu_, iv_, System.ComponentModel.ListSortDirection.Ascending);
					var ix_ = context.Operators.Last<Observation>(iw_);
					var iy_ = ix_?.Effective;
					var iz_ = FHIRHelpers_4_3_000.ToValue(iy_);

					return ((iz_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (p_())
				{
					var kx_ = this.Abnormal_Presentation();
					var ky_ = context.Operators.RetrieveByValueSet<Observation>(kx_, null);
					bool? kz_(Observation AbnormalPresentation)
					{
						object lg_()
						{
							bool lr_()
							{
								var lu_ = AbnormalPresentation?.Effective;
								var lv_ = FHIRHelpers_4_3_000.ToValue(lu_);
								var lw_ = lv_ is CqlDateTime;

								return lw_;
							};
							bool ls_()
							{
								var lx_ = AbnormalPresentation?.Effective;
								var ly_ = FHIRHelpers_4_3_000.ToValue(lx_);
								var lz_ = ly_ is CqlInterval<CqlDateTime>;

								return lz_;
							};
							bool lt_()
							{
								var ma_ = AbnormalPresentation?.Effective;
								var mb_ = FHIRHelpers_4_3_000.ToValue(ma_);
								var mc_ = mb_ is CqlDateTime;

								return mc_;
							};
							if (lr_())
							{
								var md_ = AbnormalPresentation?.Effective;
								var me_ = FHIRHelpers_4_3_000.ToValue(md_);

								return ((me_ as CqlDateTime) as object);
							}
							else if (ls_())
							{
								var mf_ = AbnormalPresentation?.Effective;
								var mg_ = FHIRHelpers_4_3_000.ToValue(mf_);

								return ((mg_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (lt_())
							{
								var mh_ = AbnormalPresentation?.Effective;
								var mi_ = FHIRHelpers_4_3_000.ToValue(mh_);

								return ((mi_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var lh_ = QICoreCommon_2_0_000.earliest(lg_());
						var li_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var lj_ = context.Operators.SameOrBefore(lh_, li_, null);
						var lk_ = AbnormalPresentation?.StatusElement;
						var ll_ = lk_?.Value;
						var lm_ = context.Operators.Convert<Code<ObservationStatus>>(ll_);
						var ln_ = context.Operators.Convert<string>(lm_);
						var lo_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var lp_ = context.Operators.In<string>(ln_, (lo_ as IEnumerable<string>));
						var lq_ = context.Operators.And(lj_, lp_);

						return lq_;
					};
					var la_ = context.Operators.Where<Observation>(ky_, kz_);
					object lb_(Observation @this)
					{
						object mj_()
						{
							bool ml_()
							{
								var mo_ = @this?.Effective;
								var mp_ = FHIRHelpers_4_3_000.ToValue(mo_);
								var mq_ = mp_ is CqlDateTime;

								return mq_;
							};
							bool mm_()
							{
								var mr_ = @this?.Effective;
								var ms_ = FHIRHelpers_4_3_000.ToValue(mr_);
								var mt_ = ms_ is CqlInterval<CqlDateTime>;

								return mt_;
							};
							bool mn_()
							{
								var mu_ = @this?.Effective;
								var mv_ = FHIRHelpers_4_3_000.ToValue(mu_);
								var mw_ = mv_ is CqlDateTime;

								return mw_;
							};
							if (ml_())
							{
								var mx_ = @this?.Effective;
								var my_ = FHIRHelpers_4_3_000.ToValue(mx_);

								return ((my_ as CqlDateTime) as object);
							}
							else if (mm_())
							{
								var mz_ = @this?.Effective;
								var na_ = FHIRHelpers_4_3_000.ToValue(mz_);

								return ((na_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (mn_())
							{
								var nb_ = @this?.Effective;
								var nc_ = FHIRHelpers_4_3_000.ToValue(nb_);

								return ((nc_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							}
						};
						var mk_ = QICoreCommon_2_0_000.earliest(mj_());

						return mk_;
					};
					var lc_ = context.Operators.SortBy<Observation>(la_, lb_, System.ComponentModel.ListSortDirection.Ascending);
					var ld_ = context.Operators.Last<Observation>(lc_);
					var le_ = ld_?.Effective;
					var lf_ = FHIRHelpers_4_3_000.ToValue(le_);

					return ((lf_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				}
			};
			var e_ = QICoreCommon_2_0_000.earliest(d_());
			var f_ = ThirtysevenWeeksPlusEncounter?.Period;
			var g_ = FHIRHelpers_4_3_000.ToInterval(f_);
			var h_ = context.Operators.In<CqlDateTime>(e_, g_, null);
			var i_ = CQMCommon_2_0_000.encounterDiagnosis(ThirtysevenWeeksPlusEncounter);
			bool? j_(Condition EncounterDiagnosis)
			{
				var nd_ = EncounterDiagnosis?.Code;
				var ne_ = FHIRHelpers_4_3_000.ToConcept(nd_);
				var nf_ = this.Abnormal_Presentation();
				var ng_ = context.Operators.ConceptInValueSet(ne_, nf_);

				return ng_;
			};
			var k_ = context.Operators.Where<Condition>(i_, j_);
			var l_ = context.Operators.Exists<Condition>(k_);
			var m_ = context.Operators.Or(h_, l_);

			return m_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

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
				var h_ = EncounterDiagnosis?.Code;
				var i_ = FHIRHelpers_4_3_000.ToConcept(h_);
				var j_ = this.Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa();
				var k_ = context.Operators.ConceptInValueSet(i_, j_);
				var m_ = FHIRHelpers_4_3_000.ToConcept(h_);
				var n_ = this.Genital_Herpes();
				var o_ = context.Operators.ConceptInValueSet(m_, n_);
				var p_ = context.Operators.Or(k_, o_);

				return p_;
			};
			var f_ = context.Operators.Where<Condition>(d_, e_);
			var g_ = context.Operators.Exists<Condition>(f_);

			return g_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
	public IEnumerable<Encounter> Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum() => 
		__Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum_Value()
	{
		var a_ = this.Encounter_with_Abnormal_Presentation();
		var b_ = this.Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum();
		var c_ = context.Operators.Union<Encounter>(a_, b_);

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
				var k_ = CSection?.Performed;
				var l_ = FHIRHelpers_4_3_000.ToValue(k_);
				var m_ = QICoreCommon_2_0_000.toInterval(l_);
				var n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, m_, null);
				var o_ = CSection?.StatusElement;
				var p_ = o_?.Value;
				var q_ = context.Operators.Convert<string>(p_);
				var r_ = context.Operators.Equal(q_, "completed");
				var s_ = context.Operators.And(n_, r_);

				return s_;
			};
			var g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure CSection) => 
				ThirtysevenWeeksPlusEncounter;
			var i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

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

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Tuple_QRZgNJCaGQEYIeOSBhjLZNSO> Variable_Calculated_Gestational_Age_Value()
	{
		var a_ = PCMaternal_5_16_000.Variable_Calculated_Gestational_Age();

		return a_;
	}

    [CqlDeclaration("Variable Calculated Gestational Age")]
	public IEnumerable<Tuple_QRZgNJCaGQEYIeOSBhjLZNSO> Variable_Calculated_Gestational_Age() => 
		__Variable_Calculated_Gestational_Age.Value;

}
