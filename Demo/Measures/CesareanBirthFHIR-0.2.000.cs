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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "1.0.0.0")]
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
    internal Lazy<CqlCode> ___#__Births_preterm;
    internal Lazy<CqlCode> ___#__Births_term;
    internal Lazy<CqlCode> ___#__Parity;
    internal Lazy<CqlCode> ___#__Pregnancies;
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
        ___#__Births_preterm = new Lazy<CqlCode>(this._#__Births_preterm_Value);
        ___#__Births_term = new Lazy<CqlCode>(this._#__Births_term_Value);
        ___#__Parity = new Lazy<CqlCode>(this._#__Parity_Value);
        ___#__Pregnancies = new Lazy<CqlCode>(this._#__Pregnancies_Value);
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

	private CqlCode _#__Births_preterm_Value() => 
		new CqlCode("11637-6", "http://loinc.org", null, null);

    [CqlDeclaration("[#] Births.preterm")]
	public CqlCode _#__Births_preterm() => 
		___#__Births_preterm.Value;

	private CqlCode _#__Births_term_Value() => 
		new CqlCode("11639-2", "http://loinc.org", null, null);

    [CqlDeclaration("[#] Births.term")]
	public CqlCode _#__Births_term() => 
		___#__Births_term.Value;

	private CqlCode _#__Parity_Value() => 
		new CqlCode("11977-6", "http://loinc.org", null, null);

    [CqlDeclaration("[#] Parity")]
	public CqlCode _#__Parity() => 
		___#__Parity.Value;

	private CqlCode _#__Pregnancies_Value() => 
		new CqlCode("11996-6", "http://loinc.org", null, null);

    [CqlDeclaration("[#] Pregnancies")]
	public CqlCode _#__Pregnancies() => 
		___#__Pregnancies.Value;

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
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("CesareanBirthFHIR-0.2.000", "Measurement Period", e_);

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
			var f_ = context.Operators.Quantity(37m, "weeks");
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
		var a_ = this._#__Pregnancies();
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
				if (FHIRHelpers_4_3_000.ToValue(Gravida?.Effective) is CqlDateTime)
				{
					var ac_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);

					return ((ac_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(Gravida?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ad_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);

					return ((ad_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(Gravida?.Effective) is CqlDateTime)
				{
					var ae_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);

					return ((ae_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var r_ = QICoreCommon_2_0_000.earliest(q_());
			var s_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var t_ = context.Operators.Quantity(42m, "weeks");
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
			object af_()
			{
				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var ah_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ah_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ai_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ai_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var aj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((aj_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ag_ = QICoreCommon_2_0_000.earliest(af_());

			return ag_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);
		var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

    [CqlDeclaration("lastParity")]
	public int? lastParity(Encounter TheEncounter)
	{
		var a_ = this._#__Parity();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation Parity)
		{
			object j_()
			{
				if (FHIRHelpers_4_3_000.ToValue(Parity?.Effective) is CqlDateTime)
				{
					var ac_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);

					return ((ac_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(Parity?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ad_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);

					return ((ad_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(Parity?.Effective) is CqlDateTime)
				{
					var ae_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);

					return ((ae_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var k_ = QICoreCommon_2_0_000.earliest(j_());
			var l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var m_ = context.Operators.Quantity(42m, "weeks");
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
			object af_()
			{
				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var ah_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ah_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ai_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ai_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var aj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((aj_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ag_ = QICoreCommon_2_0_000.earliest(af_());

			return ag_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);
		var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

    [CqlDeclaration("lastHistoryPretermBirth")]
	public int? lastHistoryPretermBirth(Encounter TheEncounter)
	{
		var a_ = this._#__Births_preterm();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation PretermBirth)
		{
			object j_()
			{
				if (FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective) is CqlDateTime)
				{
					var ac_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);

					return ((ac_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ad_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);

					return ((ad_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective) is CqlDateTime)
				{
					var ae_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);

					return ((ae_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var k_ = QICoreCommon_2_0_000.earliest(j_());
			var l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var m_ = context.Operators.Quantity(42m, "weeks");
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
			object af_()
			{
				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var ah_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ah_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ai_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ai_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var aj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((aj_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ag_ = QICoreCommon_2_0_000.earliest(af_());

			return ag_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);
		var i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

    [CqlDeclaration("lastHistoryTermBirth")]
	public int? lastHistoryTermBirth(Encounter TheEncounter)
	{
		var a_ = this._#__Births_term();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation TermBirth)
		{
			object j_()
			{
				if (FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective) is CqlDateTime)
				{
					var ac_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);

					return ((ac_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ad_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);

					return ((ad_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective) is CqlDateTime)
				{
					var ae_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);

					return ((ae_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var k_ = QICoreCommon_2_0_000.earliest(j_());
			var l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			var m_ = context.Operators.Quantity(42m, "weeks");
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
			object af_()
			{
				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var ah_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ah_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					var ai_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ai_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					var aj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((aj_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			var ag_ = QICoreCommon_2_0_000.earliest(af_());

			return ag_;
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
				if (FHIRHelpers_4_3_000.ToValue((context.Operators.LastOfList<Observation>(context.Operators.ListSortBy<Observation>(context.Operators.WhereOrNull<Observation>(context.Operators.RetrieveByValueSet<Observation>(this.Abnormal_Presentation(), null), (Observation AbnormalPresentation) => 
				context.Operators.And(context.Operators.SameOrBefore(QICoreCommon_2_0_000.earliest(							if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								return ((FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlInterval<CqlDateTime>)
							{
								return ((FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								return ((FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) as CqlDateTime) as object);
							}
							else
							{
								return null;
							}), PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter), null), context.Operators.InList<string>(context.Operators.Convert<string>(context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value)), (new string[]
						{
							"final",
							"amended",
							"corrected",
						} as IEnumerable<string>)))), (Observation @this) => 
			QICoreCommon_2_0_000.earliest(				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else
				{
					return null;
				}), System.ComponentModel.ListSortDirection.Ascending)))?.Effective) is CqlDateTime)
				{
					var m_ = this.Abnormal_Presentation();
					var n_ = context.Operators.RetrieveByValueSet<Observation>(m_, null);
					bool? o_(Observation AbnormalPresentation)
					{
						object u_()
						{
							if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								var ad_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ad_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlInterval<CqlDateTime>)
							{
								var ae_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ae_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								var af_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((af_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var v_ = QICoreCommon_2_0_000.earliest(u_());
						var w_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var x_ = context.Operators.SameOrBefore(v_, w_, null);
						var y_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						var z_ = context.Operators.Convert<string>(y_);
						var aa_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var ab_ = context.Operators.InList<string>(z_, (aa_ as IEnumerable<string>));
						var ac_ = context.Operators.And(x_, ab_);

						return ac_;
					};
					var p_ = context.Operators.WhereOrNull<Observation>(n_, o_);
					object q_(Observation @this)
					{
						object ag_()
						{
							if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var ai_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((ai_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
							{
								var aj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((aj_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var ak_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((ak_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var ah_ = QICoreCommon_2_0_000.earliest(ag_());

						return ah_;
					};
					var r_ = context.Operators.ListSortBy<Observation>(p_, q_, System.ComponentModel.ListSortDirection.Ascending);
					var s_ = context.Operators.LastOfList<Observation>(r_);
					var t_ = FHIRHelpers_4_3_000.ToValue(s_?.Effective);

					return ((t_ as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue((context.Operators.LastOfList<Observation>(context.Operators.ListSortBy<Observation>(context.Operators.WhereOrNull<Observation>(context.Operators.RetrieveByValueSet<Observation>(this.Abnormal_Presentation(), null), (Observation AbnormalPresentation) => 
				context.Operators.And(context.Operators.SameOrBefore(QICoreCommon_2_0_000.earliest(							if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								return ((FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlInterval<CqlDateTime>)
							{
								return ((FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								return ((FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) as CqlDateTime) as object);
							}
							else
							{
								return null;
							}), PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter), null), context.Operators.InList<string>(context.Operators.Convert<string>(context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value)), (new string[]
						{
							"final",
							"amended",
							"corrected",
						} as IEnumerable<string>)))), (Observation @this) => 
			QICoreCommon_2_0_000.earliest(				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else
				{
					return null;
				}), System.ComponentModel.ListSortDirection.Ascending)))?.Effective) is CqlInterval<CqlDateTime>)
				{
					var al_ = this.Abnormal_Presentation();
					var am_ = context.Operators.RetrieveByValueSet<Observation>(al_, null);
					bool? an_(Observation AbnormalPresentation)
					{
						object at_()
						{
							if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								var bc_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((bc_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlInterval<CqlDateTime>)
							{
								var bd_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((bd_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								var be_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((be_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var au_ = QICoreCommon_2_0_000.earliest(at_());
						var av_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var aw_ = context.Operators.SameOrBefore(au_, av_, null);
						var ax_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						var ay_ = context.Operators.Convert<string>(ax_);
						var az_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var ba_ = context.Operators.InList<string>(ay_, (az_ as IEnumerable<string>));
						var bb_ = context.Operators.And(aw_, ba_);

						return bb_;
					};
					var ao_ = context.Operators.WhereOrNull<Observation>(am_, an_);
					object ap_(Observation @this)
					{
						object bf_()
						{
							if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var bh_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((bh_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
							{
								var bi_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((bi_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var bj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((bj_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var bg_ = QICoreCommon_2_0_000.earliest(bf_());

						return bg_;
					};
					var aq_ = context.Operators.ListSortBy<Observation>(ao_, ap_, System.ComponentModel.ListSortDirection.Ascending);
					var ar_ = context.Operators.LastOfList<Observation>(aq_);
					var as_ = FHIRHelpers_4_3_000.ToValue(ar_?.Effective);

					return ((as_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue((context.Operators.LastOfList<Observation>(context.Operators.ListSortBy<Observation>(context.Operators.WhereOrNull<Observation>(context.Operators.RetrieveByValueSet<Observation>(this.Abnormal_Presentation(), null), (Observation AbnormalPresentation) => 
				context.Operators.And(context.Operators.SameOrBefore(QICoreCommon_2_0_000.earliest(							if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								return ((FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlInterval<CqlDateTime>)
							{
								return ((FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								return ((FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) as CqlDateTime) as object);
							}
							else
							{
								return null;
							}), PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter), null), context.Operators.InList<string>(context.Operators.Convert<string>(context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value)), (new string[]
						{
							"final",
							"amended",
							"corrected",
						} as IEnumerable<string>)))), (Observation @this) => 
			QICoreCommon_2_0_000.earliest(				if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlInterval<CqlDateTime>) as object);
				}
				else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
				{
					return ((FHIRHelpers_4_3_000.ToValue(@this?.Effective) as CqlDateTime) as object);
				}
				else
				{
					return null;
				}), System.ComponentModel.ListSortDirection.Ascending)))?.Effective) is CqlDateTime)
				{
					var bk_ = this.Abnormal_Presentation();
					var bl_ = context.Operators.RetrieveByValueSet<Observation>(bk_, null);
					bool? bm_(Observation AbnormalPresentation)
					{
						object bs_()
						{
							if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								var cb_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((cb_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlInterval<CqlDateTime>)
							{
								var cc_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((cc_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective) is CqlDateTime)
							{
								var cd_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((cd_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var bt_ = QICoreCommon_2_0_000.earliest(bs_());
						var bu_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						var bv_ = context.Operators.SameOrBefore(bt_, bu_, null);
						var bw_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						var bx_ = context.Operators.Convert<string>(bw_);
						var by_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						var bz_ = context.Operators.InList<string>(bx_, (by_ as IEnumerable<string>));
						var ca_ = context.Operators.And(bv_, bz_);

						return ca_;
					};
					var bn_ = context.Operators.WhereOrNull<Observation>(bl_, bm_);
					object bo_(Observation @this)
					{
						object ce_()
						{
							if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var cg_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((cg_ as CqlDateTime) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlInterval<CqlDateTime>)
							{
								var ch_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((ch_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (FHIRHelpers_4_3_000.ToValue(@this?.Effective) is CqlDateTime)
							{
								var ci_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((ci_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						var cf_ = QICoreCommon_2_0_000.earliest(ce_());

						return cf_;
					};
					var bp_ = context.Operators.ListSortBy<Observation>(bn_, bo_, System.ComponentModel.ListSortDirection.Ascending);
					var bq_ = context.Operators.LastOfList<Observation>(bp_);
					var br_ = FHIRHelpers_4_3_000.ToValue(bq_?.Effective);

					return ((br_ as CqlDateTime) as object);
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
				var cj_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				var ck_ = this.Abnormal_Presentation();
				var cl_ = context.Operators.ConceptInValueSet(cj_, ck_);

				return cl_;
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