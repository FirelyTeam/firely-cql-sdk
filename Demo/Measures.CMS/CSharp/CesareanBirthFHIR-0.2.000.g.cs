using System;
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
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
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
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<(string EncounterID, int? CalculatedCGA)?>> __Variable_Calculated_Gestational_Age;

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
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Variable_Calculated_Gestational_Age = new Lazy<IEnumerable<(string EncounterID, int? CalculatedCGA)?>>(this.Variable_Calculated_Gestational_Age_Value);
    }
    #region Dependencies

    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public PCMaternal_5_16_000 PCMaternal_5_16_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Abnormal_Presentation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105", default);

    [CqlDeclaration("Abnormal Presentation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105")]
	public CqlValueSet Abnormal_Presentation() => 
		__Abnormal_Presentation.Value;

	private CqlValueSet Cesarean_Birth_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282", default);

    [CqlDeclaration("Cesarean Birth")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282")]
	public CqlValueSet Cesarean_Birth() => 
		__Cesarean_Birth.Value;

	private CqlValueSet Delivery_of_Singleton_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99", default);

    [CqlDeclaration("Delivery of Singleton")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99")]
	public CqlValueSet Delivery_of_Singleton() => 
		__Delivery_of_Singleton.Value;

	private CqlValueSet Delivery_Procedures_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59", default);

    [CqlDeclaration("Delivery Procedures")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59")]
	public CqlValueSet Delivery_Procedures() => 
		__Delivery_Procedures.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Genital_Herpes_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049", default);

    [CqlDeclaration("Genital Herpes")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049")]
	public CqlValueSet Genital_Herpes() => 
		__Genital_Herpes.Value;

	private CqlValueSet Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37", default);

    [CqlDeclaration("Placenta Previa Accreta Increta Percreta or Vasa Previa")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37")]
	public CqlValueSet Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa() => 
		__Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa.Value;

	private CqlValueSet _37_to_42_Plus_Weeks_Gestation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68", default);

    [CqlDeclaration("37 to 42 Plus Weeks Gestation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68")]
	public CqlValueSet _37_to_42_Plus_Weeks_Gestation() => 
		___37_to_42_Plus_Weeks_Gestation.Value;

	private CqlCode ____Births_preterm_Value() => 
		new CqlCode("11637-6", "http://loinc.org", default, default);

    [CqlDeclaration("[#] Births.preterm")]
	public CqlCode ____Births_preterm() => 
		______Births_preterm.Value;

	private CqlCode ____Births_term_Value() => 
		new CqlCode("11639-2", "http://loinc.org", default, default);

    [CqlDeclaration("[#] Births.term")]
	public CqlCode ____Births_term() => 
		______Births_term.Value;

	private CqlCode ____Parity_Value() => 
		new CqlCode("11977-6", "http://loinc.org", default, default);

    [CqlDeclaration("[#] Parity")]
	public CqlCode ____Parity() => 
		______Parity.Value;

	private CqlCode ____Pregnancies_Value() => 
		new CqlCode("11996-6", "http://loinc.org", default, default);

    [CqlDeclaration("[#] Pregnancies")]
	public CqlCode ____Pregnancies() => 
		______Pregnancies.Value;

	private CqlCode Date_and_time_of_obstetric_delivery_Value() => 
		new CqlCode("93857-1", "http://loinc.org", default, default);

    [CqlDeclaration("Date and time of obstetric delivery")]
	public CqlCode Date_and_time_of_obstetric_delivery() => 
		__Date_and_time_of_obstetric_delivery.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("11637-6", "http://loinc.org", default, default),
			new CqlCode("11639-2", "http://loinc.org", default, default),
			new CqlCode("11977-6", "http://loinc.org", default, default),
			new CqlCode("11996-6", "http://loinc.org", default, default),
			new CqlCode("93857-1", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("CesareanBirthFHIR-0.2.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(default, default);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Value()
	{
		IEnumerable<Encounter> a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			int? d_ = PCMaternal_5_16_000.calculatedGestationalAge(DeliveryEncounter);
			bool? e_ = context.Operators.GreaterOrEqual(d_, 37);

			return e_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Calculated Gestational Age Greater than or Equal to 37 Weeks")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks() => 
		__Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Value()
	{
		IEnumerable<Encounter> a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			int? d_ = PCMaternal_5_16_000.calculatedGestationalAge(DeliveryEncounter);
			CqlQuantity e_ = PCMaternal_5_16_000.lastEstimatedGestationalAge(DeliveryEncounter);
			CqlQuantity f_ = context.Operators.Quantity(37m, "weeks");
			bool? g_ = context.Operators.GreaterOrEqual(e_, f_);
			bool? h_ = context.Operators.And((bool?)(d_ is null), g_);

			return h_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Estimated Gestational Age Greater than or Equal to 37 Weeks")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks() => 
		__Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding_Value()
	{
		IEnumerable<Encounter> a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			int? d_ = PCMaternal_5_16_000.calculatedGestationalAge(DeliveryEncounter);
			CqlQuantity e_ = PCMaternal_5_16_000.lastEstimatedGestationalAge(DeliveryEncounter);
			bool? f_ = context.Operators.And((bool?)(d_ is null), (bool?)(e_ is null));
			IEnumerable<Condition> g_ = CQMCommon_2_0_000.encounterDiagnosis(DeliveryEncounter);
			bool? h_(Condition EncounterDiagnosis)
			{
				CodeableConcept l_ = EncounterDiagnosis?.Code;
				CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(l_);
				CqlValueSet n_ = this._37_to_42_Plus_Weeks_Gestation();
				bool? o_ = context.Operators.ConceptInValueSet(m_, n_);

				return o_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			bool? j_ = context.Operators.Exists<Condition>(i_);
			bool? k_ = context.Operators.And(f_, j_);

			return k_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks Based on Coding")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding() => 
		__Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounter_with_Calculated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks();
		IEnumerable<Encounter> b_ = this.Delivery_Encounter_with_Estimated_Gestational_Age_Greater_than_or_Equal_to_37_Weeks();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding();
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks() => 
		__Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks.Value;

	private IEnumerable<Encounter> Encounter_with_Singleton_Delivery_Value()
	{
		IEnumerable<Encounter> a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();
		bool? b_(Encounter DeliveryEncounter)
		{
			IEnumerable<Condition> d_ = CQMCommon_2_0_000.encounterDiagnosis(DeliveryEncounter);
			bool? e_(Condition EncounterDiagnosis)
			{
				CodeableConcept h_ = EncounterDiagnosis?.Code;
				CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(h_);
				CqlValueSet j_ = this.Delivery_of_Singleton();
				bool? k_ = context.Operators.ConceptInValueSet(i_, j_);

				return k_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			bool? g_ = context.Operators.Exists<Condition>(f_);

			return g_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Singleton Delivery")]
	public IEnumerable<Encounter> Encounter_with_Singleton_Delivery() => 
		__Encounter_with_Singleton_Delivery.Value;

    [CqlDeclaration("lastGravida")]
	public int? lastGravida(Encounter TheEncounter)
	{
		CqlCode a_ = this.____Pregnancies();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		bool? d_(Observation Gravida)
		{
			DataType l_ = Gravida?.Value;
			object m_ = FHIRHelpers_4_3_000.ToValue(l_);
			bool? n_ = context.Operators.Not((bool?)(m_ is null));
			Code<ObservationStatus> o_ = Gravida?.StatusElement;
			ObservationStatus? p_ = o_?.Value;
			Code<ObservationStatus> q_ = context.Operators.Convert<Code<ObservationStatus>>(p_);
			string r_ = context.Operators.Convert<string>(q_);
			string[] s_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? t_ = context.Operators.In<string>(r_, s_ as IEnumerable<string>);
			bool? u_ = context.Operators.And(n_, t_);
			object v_()
			{
				bool ah_()
				{
					DataType ak_ = Gravida?.Effective;
					object al_ = FHIRHelpers_4_3_000.ToValue(ak_);
					bool am_ = al_ is CqlDateTime;

					return am_;
				};
				bool ai_()
				{
					DataType an_ = Gravida?.Effective;
					object ao_ = FHIRHelpers_4_3_000.ToValue(an_);
					bool ap_ = ao_ is CqlInterval<CqlDateTime>;

					return ap_;
				};
				bool aj_()
				{
					DataType aq_ = Gravida?.Effective;
					object ar_ = FHIRHelpers_4_3_000.ToValue(aq_);
					bool as_ = ar_ is CqlDateTime;

					return as_;
				};
				if (ah_())
				{
					DataType at_ = Gravida?.Effective;
					object au_ = FHIRHelpers_4_3_000.ToValue(at_);
					CqlDateTime av_ = au_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return av_ as object;
				}
				else if (ai_())
				{
					DataType aw_ = Gravida?.Effective;
					object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
					CqlInterval<CqlDateTime> ay_ = ax_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ay_ as object;
				}
				else if (aj_())
				{
					DataType az_ = Gravida?.Effective;
					object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
					CqlDateTime bb_ = ba_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bb_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime w_ = QICoreCommon_2_0_000.earliest(v_());
			CqlDateTime x_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity y_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime z_ = context.Operators.Subtract(x_, y_);
			CqlInterval<CqlDateTime> ab_ = context.Operators.Interval(z_, x_, true, false);
			bool? ac_ = context.Operators.In<CqlDateTime>(w_, ab_, default);
			bool? ae_ = context.Operators.Not((bool?)(x_ is null));
			bool? af_ = context.Operators.And(ac_, ae_);
			bool? ag_ = context.Operators.And(u_, af_);

			return ag_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object bc_()
			{
				bool be_()
				{
					DataType bh_ = @this?.Effective;
					object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
					bool bj_ = bi_ is CqlDateTime;

					return bj_;
				};
				bool bf_()
				{
					DataType bk_ = @this?.Effective;
					object bl_ = FHIRHelpers_4_3_000.ToValue(bk_);
					bool bm_ = bl_ is CqlInterval<CqlDateTime>;

					return bm_;
				};
				bool bg_()
				{
					DataType bn_ = @this?.Effective;
					object bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
					bool bp_ = bo_ is CqlDateTime;

					return bp_;
				};
				if (be_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
					CqlDateTime bs_ = br_ switch { null => null , CqlDateTime d => d/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bs_ as object;
				}
				else if (bf_())
				{
					DataType bt_ = @this?.Effective;
					object bu_ = FHIRHelpers_4_3_000.ToValue(bt_);
					CqlInterval<CqlDateTime> bv_ = bu_ switch { null => null , CqlInterval<CqlDateTime> e => e/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bv_ as object;
				}
				else if (bg_())
				{
					DataType bw_ = @this?.Effective;
					object bx_ = FHIRHelpers_4_3_000.ToValue(bw_);
					CqlDateTime by_ = bx_ switch { null => null , CqlDateTime f => f/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return by_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime bd_ = QICoreCommon_2_0_000.earliest(bc_());

			return bd_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);
		int? k_ = j_ switch { null => null , int g => context.Operators.ConvertStringToInteger(g)/* , CqlQuantity => ???, CqlConcept => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

		return k_;
	}

    [CqlDeclaration("lastParity")]
	public int? lastParity(Encounter TheEncounter)
	{
		CqlCode a_ = this.____Parity();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		bool? d_(Observation Parity)
		{
			object l_()
			{
				bool ah_()
				{
					DataType ak_ = Parity?.Effective;
					object al_ = FHIRHelpers_4_3_000.ToValue(ak_);
					bool am_ = al_ is CqlDateTime;

					return am_;
				};
				bool ai_()
				{
					DataType an_ = Parity?.Effective;
					object ao_ = FHIRHelpers_4_3_000.ToValue(an_);
					bool ap_ = ao_ is CqlInterval<CqlDateTime>;

					return ap_;
				};
				bool aj_()
				{
					DataType aq_ = Parity?.Effective;
					object ar_ = FHIRHelpers_4_3_000.ToValue(aq_);
					bool as_ = ar_ is CqlDateTime;

					return as_;
				};
				if (ah_())
				{
					DataType at_ = Parity?.Effective;
					object au_ = FHIRHelpers_4_3_000.ToValue(at_);
					CqlDateTime av_ = au_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return av_ as object;
				}
				else if (ai_())
				{
					DataType aw_ = Parity?.Effective;
					object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
					CqlInterval<CqlDateTime> ay_ = ax_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ay_ as object;
				}
				else if (aj_())
				{
					DataType az_ = Parity?.Effective;
					object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
					CqlDateTime bb_ = ba_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bb_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime m_ = QICoreCommon_2_0_000.earliest(l_());
			CqlDateTime n_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity o_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime p_ = context.Operators.Subtract(n_, o_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(p_, n_, true, false);
			bool? s_ = context.Operators.In<CqlDateTime>(m_, r_, default);
			bool? u_ = context.Operators.Not((bool?)(n_ is null));
			bool? v_ = context.Operators.And(s_, u_);
			Code<ObservationStatus> w_ = Parity?.StatusElement;
			ObservationStatus? x_ = w_?.Value;
			Code<ObservationStatus> y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
			string z_ = context.Operators.Convert<string>(y_);
			string[] aa_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? ab_ = context.Operators.In<string>(z_, aa_ as IEnumerable<string>);
			bool? ac_ = context.Operators.And(v_, ab_);
			DataType ad_ = Parity?.Value;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			bool? af_ = context.Operators.Not((bool?)(ae_ is null));
			bool? ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object bc_()
			{
				bool be_()
				{
					DataType bh_ = @this?.Effective;
					object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
					bool bj_ = bi_ is CqlDateTime;

					return bj_;
				};
				bool bf_()
				{
					DataType bk_ = @this?.Effective;
					object bl_ = FHIRHelpers_4_3_000.ToValue(bk_);
					bool bm_ = bl_ is CqlInterval<CqlDateTime>;

					return bm_;
				};
				bool bg_()
				{
					DataType bn_ = @this?.Effective;
					object bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
					bool bp_ = bo_ is CqlDateTime;

					return bp_;
				};
				if (be_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
					CqlDateTime bs_ = br_ switch { null => null , CqlDateTime d => d/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bs_ as object;
				}
				else if (bf_())
				{
					DataType bt_ = @this?.Effective;
					object bu_ = FHIRHelpers_4_3_000.ToValue(bt_);
					CqlInterval<CqlDateTime> bv_ = bu_ switch { null => null , CqlInterval<CqlDateTime> e => e/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bv_ as object;
				}
				else if (bg_())
				{
					DataType bw_ = @this?.Effective;
					object bx_ = FHIRHelpers_4_3_000.ToValue(bw_);
					CqlDateTime by_ = bx_ switch { null => null , CqlDateTime f => f/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return by_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime bd_ = QICoreCommon_2_0_000.earliest(bc_());

			return bd_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);
		int? k_ = j_ switch { null => null , int g => context.Operators.ConvertStringToInteger(g)/* , CqlQuantity => ???, CqlConcept => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

		return k_;
	}

    [CqlDeclaration("lastHistoryPretermBirth")]
	public int? lastHistoryPretermBirth(Encounter TheEncounter)
	{
		CqlCode a_ = this.____Births_preterm();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		bool? d_(Observation PretermBirth)
		{
			object l_()
			{
				bool ah_()
				{
					DataType ak_ = PretermBirth?.Effective;
					object al_ = FHIRHelpers_4_3_000.ToValue(ak_);
					bool am_ = al_ is CqlDateTime;

					return am_;
				};
				bool ai_()
				{
					DataType an_ = PretermBirth?.Effective;
					object ao_ = FHIRHelpers_4_3_000.ToValue(an_);
					bool ap_ = ao_ is CqlInterval<CqlDateTime>;

					return ap_;
				};
				bool aj_()
				{
					DataType aq_ = PretermBirth?.Effective;
					object ar_ = FHIRHelpers_4_3_000.ToValue(aq_);
					bool as_ = ar_ is CqlDateTime;

					return as_;
				};
				if (ah_())
				{
					DataType at_ = PretermBirth?.Effective;
					object au_ = FHIRHelpers_4_3_000.ToValue(at_);
					CqlDateTime av_ = au_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return av_ as object;
				}
				else if (ai_())
				{
					DataType aw_ = PretermBirth?.Effective;
					object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
					CqlInterval<CqlDateTime> ay_ = ax_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ay_ as object;
				}
				else if (aj_())
				{
					DataType az_ = PretermBirth?.Effective;
					object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
					CqlDateTime bb_ = ba_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bb_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime m_ = QICoreCommon_2_0_000.earliest(l_());
			CqlDateTime n_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity o_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime p_ = context.Operators.Subtract(n_, o_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(p_, n_, true, false);
			bool? s_ = context.Operators.In<CqlDateTime>(m_, r_, default);
			bool? u_ = context.Operators.Not((bool?)(n_ is null));
			bool? v_ = context.Operators.And(s_, u_);
			Code<ObservationStatus> w_ = PretermBirth?.StatusElement;
			ObservationStatus? x_ = w_?.Value;
			Code<ObservationStatus> y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
			string z_ = context.Operators.Convert<string>(y_);
			string[] aa_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? ab_ = context.Operators.In<string>(z_, aa_ as IEnumerable<string>);
			bool? ac_ = context.Operators.And(v_, ab_);
			DataType ad_ = PretermBirth?.Value;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			bool? af_ = context.Operators.Not((bool?)(ae_ is null));
			bool? ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object bc_()
			{
				bool be_()
				{
					DataType bh_ = @this?.Effective;
					object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
					bool bj_ = bi_ is CqlDateTime;

					return bj_;
				};
				bool bf_()
				{
					DataType bk_ = @this?.Effective;
					object bl_ = FHIRHelpers_4_3_000.ToValue(bk_);
					bool bm_ = bl_ is CqlInterval<CqlDateTime>;

					return bm_;
				};
				bool bg_()
				{
					DataType bn_ = @this?.Effective;
					object bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
					bool bp_ = bo_ is CqlDateTime;

					return bp_;
				};
				if (be_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
					CqlDateTime bs_ = br_ switch { null => null , CqlDateTime d => d/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bs_ as object;
				}
				else if (bf_())
				{
					DataType bt_ = @this?.Effective;
					object bu_ = FHIRHelpers_4_3_000.ToValue(bt_);
					CqlInterval<CqlDateTime> bv_ = bu_ switch { null => null , CqlInterval<CqlDateTime> e => e/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bv_ as object;
				}
				else if (bg_())
				{
					DataType bw_ = @this?.Effective;
					object bx_ = FHIRHelpers_4_3_000.ToValue(bw_);
					CqlDateTime by_ = bx_ switch { null => null , CqlDateTime f => f/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return by_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime bd_ = QICoreCommon_2_0_000.earliest(bc_());

			return bd_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);
		int? k_ = j_ switch { null => null , int g => context.Operators.ConvertStringToInteger(g)/* , CqlQuantity => ???, CqlConcept => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

		return k_;
	}

    [CqlDeclaration("lastHistoryTermBirth")]
	public int? lastHistoryTermBirth(Encounter TheEncounter)
	{
		CqlCode a_ = this.____Births_term();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, default);
		bool? d_(Observation TermBirth)
		{
			object l_()
			{
				bool ah_()
				{
					DataType ak_ = TermBirth?.Effective;
					object al_ = FHIRHelpers_4_3_000.ToValue(ak_);
					bool am_ = al_ is CqlDateTime;

					return am_;
				};
				bool ai_()
				{
					DataType an_ = TermBirth?.Effective;
					object ao_ = FHIRHelpers_4_3_000.ToValue(an_);
					bool ap_ = ao_ is CqlInterval<CqlDateTime>;

					return ap_;
				};
				bool aj_()
				{
					DataType aq_ = TermBirth?.Effective;
					object ar_ = FHIRHelpers_4_3_000.ToValue(aq_);
					bool as_ = ar_ is CqlDateTime;

					return as_;
				};
				if (ah_())
				{
					DataType at_ = TermBirth?.Effective;
					object au_ = FHIRHelpers_4_3_000.ToValue(at_);
					CqlDateTime av_ = au_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return av_ as object;
				}
				else if (ai_())
				{
					DataType aw_ = TermBirth?.Effective;
					object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);
					CqlInterval<CqlDateTime> ay_ = ax_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return ay_ as object;
				}
				else if (aj_())
				{
					DataType az_ = TermBirth?.Effective;
					object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
					CqlDateTime bb_ = ba_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bb_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime m_ = QICoreCommon_2_0_000.earliest(l_());
			CqlDateTime n_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity o_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime p_ = context.Operators.Subtract(n_, o_);
			CqlInterval<CqlDateTime> r_ = context.Operators.Interval(p_, n_, true, false);
			bool? s_ = context.Operators.In<CqlDateTime>(m_, r_, default);
			bool? u_ = context.Operators.Not((bool?)(n_ is null));
			bool? v_ = context.Operators.And(s_, u_);
			Code<ObservationStatus> w_ = TermBirth?.StatusElement;
			ObservationStatus? x_ = w_?.Value;
			Code<ObservationStatus> y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
			string z_ = context.Operators.Convert<string>(y_);
			string[] aa_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? ab_ = context.Operators.In<string>(z_, aa_ as IEnumerable<string>);
			bool? ac_ = context.Operators.And(v_, ab_);
			DataType ad_ = TermBirth?.Value;
			object ae_ = FHIRHelpers_4_3_000.ToValue(ad_);
			bool? af_ = context.Operators.Not((bool?)(ae_ is null));
			bool? ag_ = context.Operators.And(ac_, af_);

			return ag_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object bc_()
			{
				bool be_()
				{
					DataType bh_ = @this?.Effective;
					object bi_ = FHIRHelpers_4_3_000.ToValue(bh_);
					bool bj_ = bi_ is CqlDateTime;

					return bj_;
				};
				bool bf_()
				{
					DataType bk_ = @this?.Effective;
					object bl_ = FHIRHelpers_4_3_000.ToValue(bk_);
					bool bm_ = bl_ is CqlInterval<CqlDateTime>;

					return bm_;
				};
				bool bg_()
				{
					DataType bn_ = @this?.Effective;
					object bo_ = FHIRHelpers_4_3_000.ToValue(bn_);
					bool bp_ = bo_ is CqlDateTime;

					return bp_;
				};
				if (be_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
					CqlDateTime bs_ = br_ switch { null => null , CqlDateTime d => d/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bs_ as object;
				}
				else if (bf_())
				{
					DataType bt_ = @this?.Effective;
					object bu_ = FHIRHelpers_4_3_000.ToValue(bt_);
					CqlInterval<CqlDateTime> bv_ = bu_ switch { null => null , CqlInterval<CqlDateTime> e => e/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return bv_ as object;
				}
				else if (bg_())
				{
					DataType bw_ = @this?.Effective;
					object bx_ = FHIRHelpers_4_3_000.ToValue(bw_);
					CqlDateTime by_ = bx_ switch { null => null , CqlDateTime f => f/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return by_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime bd_ = QICoreCommon_2_0_000.earliest(bc_());

			return bd_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);
		int? k_ = j_ switch { null => null , int g => context.Operators.ConvertStringToInteger(g)/* , CqlQuantity => ???, CqlConcept => ???, CqlInterval<CqlQuantity> => ???, CqlRatio => ???, SampledData => ???, CqlTime => ???, CqlDateTime => ???, CqlInterval<CqlDateTime> => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

		return k_;
	}

	private IEnumerable<Encounter> Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks();
		IEnumerable<Encounter> b_ = this.Encounter_with_Singleton_Delivery();
		IEnumerable<Encounter> c_ = context.Operators.Intersect<Encounter>(a_, b_);
		bool? d_(Encounter SingletonEncounterGE37Weeks)
		{
			int? f_ = this.lastGravida(SingletonEncounterGE37Weeks);
			bool? g_ = context.Operators.Equal(f_, 1);
			int? h_ = this.lastParity(SingletonEncounterGE37Weeks);
			bool? i_ = context.Operators.Equal(h_, 0);
			bool? j_ = context.Operators.Or(g_, i_);
			int? k_ = this.lastHistoryPretermBirth(SingletonEncounterGE37Weeks);
			bool? l_ = context.Operators.Equal(k_, 0);
			int? m_ = this.lastHistoryTermBirth(SingletonEncounterGE37Weeks);
			bool? n_ = context.Operators.Equal(m_, 0);
			bool? o_ = context.Operators.And(l_, n_);
			bool? p_ = context.Operators.Or(j_, o_);

			return p_;
		};
		IEnumerable<Encounter> e_ = context.Operators.Where<Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births")]
	public IEnumerable<Encounter> Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births() => 
		__Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births.Value;

	private IEnumerable<Encounter> Encounter_with_Abnormal_Presentation_Value()
	{
		IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births();
		bool? b_(Encounter ThirtysevenWeeksPlusEncounter)
		{
			object d_()
			{
				bool n_()
				{
					CqlValueSet q_ = this.Abnormal_Presentation();
					IEnumerable<Observation> r_ = context.Operators.RetrieveByValueSet<Observation>(q_, default);
					bool? s_(Observation AbnormalPresentation)
					{
						object aa_()
						{
							bool al_()
							{
								DataType ao_ = AbnormalPresentation?.Effective;
								object ap_ = FHIRHelpers_4_3_000.ToValue(ao_);
								bool aq_ = ap_ is CqlDateTime;

								return aq_;
							};
							bool am_()
							{
								DataType ar_ = AbnormalPresentation?.Effective;
								object as_ = FHIRHelpers_4_3_000.ToValue(ar_);
								bool at_ = as_ is CqlInterval<CqlDateTime>;

								return at_;
							};
							bool an_()
							{
								DataType au_ = AbnormalPresentation?.Effective;
								object av_ = FHIRHelpers_4_3_000.ToValue(au_);
								bool aw_ = av_ is CqlDateTime;

								return aw_;
							};
							if (al_())
							{
								DataType ax_ = AbnormalPresentation?.Effective;
								object ay_ = FHIRHelpers_4_3_000.ToValue(ax_);
								CqlDateTime az_ = ay_ switch { null => null , CqlDateTime a => a/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return az_ as object;
							}
							else if (am_())
							{
								DataType ba_ = AbnormalPresentation?.Effective;
								object bb_ = FHIRHelpers_4_3_000.ToValue(ba_);
								CqlInterval<CqlDateTime> bc_ = bb_ switch { null => null , CqlInterval<CqlDateTime> b => b/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return bc_ as object;
							}
							else if (an_())
							{
								DataType bd_ = AbnormalPresentation?.Effective;
								object be_ = FHIRHelpers_4_3_000.ToValue(bd_);
								CqlDateTime bf_ = be_ switch { null => null , CqlDateTime c => c/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return bf_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime ab_ = QICoreCommon_2_0_000.earliest(aa_());
						CqlDateTime ac_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? ad_ = context.Operators.SameOrBefore(ab_, ac_, default);
						Code<ObservationStatus> ae_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? af_ = ae_?.Value;
						Code<ObservationStatus> ag_ = context.Operators.Convert<Code<ObservationStatus>>(af_);
						string ah_ = context.Operators.Convert<string>(ag_);
						string[] ai_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? aj_ = context.Operators.In<string>(ah_, ai_ as IEnumerable<string>);
						bool? ak_ = context.Operators.And(ad_, aj_);

						return ak_;
					};
					IEnumerable<Observation> t_ = context.Operators.Where<Observation>(r_, s_);
					object u_(Observation @this)
					{
						object bg_()
						{
							bool bi_()
							{
								DataType bl_ = @this?.Effective;
								object bm_ = FHIRHelpers_4_3_000.ToValue(bl_);
								bool bn_ = bm_ is CqlDateTime;

								return bn_;
							};
							bool bj_()
							{
								DataType bo_ = @this?.Effective;
								object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
								bool bq_ = bp_ is CqlInterval<CqlDateTime>;

								return bq_;
							};
							bool bk_()
							{
								DataType br_ = @this?.Effective;
								object bs_ = FHIRHelpers_4_3_000.ToValue(br_);
								bool bt_ = bs_ is CqlDateTime;

								return bt_;
							};
							if (bi_())
							{
								DataType bu_ = @this?.Effective;
								object bv_ = FHIRHelpers_4_3_000.ToValue(bu_);
								CqlDateTime bw_ = bv_ switch { null => null , CqlDateTime d => d/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return bw_ as object;
							}
							else if (bj_())
							{
								DataType bx_ = @this?.Effective;
								object by_ = FHIRHelpers_4_3_000.ToValue(bx_);
								CqlInterval<CqlDateTime> bz_ = by_ switch { null => null , CqlInterval<CqlDateTime> e => e/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return bz_ as object;
							}
							else if (bk_())
							{
								DataType ca_ = @this?.Effective;
								object cb_ = FHIRHelpers_4_3_000.ToValue(ca_);
								CqlDateTime cc_ = cb_ switch { null => null , CqlDateTime f => f/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return cc_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime bh_ = QICoreCommon_2_0_000.earliest(bg_());

						return bh_;
					};
					IEnumerable<Observation> v_ = context.Operators.SortBy<Observation>(t_, u_, System.ComponentModel.ListSortDirection.Ascending);
					Observation w_ = context.Operators.Last<Observation>(v_);
					DataType x_ = w_?.Effective;
					object y_ = FHIRHelpers_4_3_000.ToValue(x_);
					bool z_ = y_ is CqlDateTime;

					return z_;
				};
				bool o_()
				{
					CqlValueSet cd_ = this.Abnormal_Presentation();
					IEnumerable<Observation> ce_ = context.Operators.RetrieveByValueSet<Observation>(cd_, default);
					bool? cf_(Observation AbnormalPresentation)
					{
						object cn_()
						{
							bool cy_()
							{
								DataType db_ = AbnormalPresentation?.Effective;
								object dc_ = FHIRHelpers_4_3_000.ToValue(db_);
								bool dd_ = dc_ is CqlDateTime;

								return dd_;
							};
							bool cz_()
							{
								DataType de_ = AbnormalPresentation?.Effective;
								object df_ = FHIRHelpers_4_3_000.ToValue(de_);
								bool dg_ = df_ is CqlInterval<CqlDateTime>;

								return dg_;
							};
							bool da_()
							{
								DataType dh_ = AbnormalPresentation?.Effective;
								object di_ = FHIRHelpers_4_3_000.ToValue(dh_);
								bool dj_ = di_ is CqlDateTime;

								return dj_;
							};
							if (cy_())
							{
								DataType dk_ = AbnormalPresentation?.Effective;
								object dl_ = FHIRHelpers_4_3_000.ToValue(dk_);
								CqlDateTime dm_ = dl_ switch { null => null , CqlDateTime g => g/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return dm_ as object;
							}
							else if (cz_())
							{
								DataType dn_ = AbnormalPresentation?.Effective;
								object do_ = FHIRHelpers_4_3_000.ToValue(dn_);
								CqlInterval<CqlDateTime> dp_ = do_ switch { null => null , CqlInterval<CqlDateTime> h => h/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return dp_ as object;
							}
							else if (da_())
							{
								DataType dq_ = AbnormalPresentation?.Effective;
								object dr_ = FHIRHelpers_4_3_000.ToValue(dq_);
								CqlDateTime ds_ = dr_ switch { null => null , CqlDateTime i => i/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ds_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime co_ = QICoreCommon_2_0_000.earliest(cn_());
						CqlDateTime cp_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? cq_ = context.Operators.SameOrBefore(co_, cp_, default);
						Code<ObservationStatus> cr_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? cs_ = cr_?.Value;
						Code<ObservationStatus> ct_ = context.Operators.Convert<Code<ObservationStatus>>(cs_);
						string cu_ = context.Operators.Convert<string>(ct_);
						string[] cv_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? cw_ = context.Operators.In<string>(cu_, cv_ as IEnumerable<string>);
						bool? cx_ = context.Operators.And(cq_, cw_);

						return cx_;
					};
					IEnumerable<Observation> cg_ = context.Operators.Where<Observation>(ce_, cf_);
					object ch_(Observation @this)
					{
						object dt_()
						{
							bool dv_()
							{
								DataType dy_ = @this?.Effective;
								object dz_ = FHIRHelpers_4_3_000.ToValue(dy_);
								bool ea_ = dz_ is CqlDateTime;

								return ea_;
							};
							bool dw_()
							{
								DataType eb_ = @this?.Effective;
								object ec_ = FHIRHelpers_4_3_000.ToValue(eb_);
								bool ed_ = ec_ is CqlInterval<CqlDateTime>;

								return ed_;
							};
							bool dx_()
							{
								DataType ee_ = @this?.Effective;
								object ef_ = FHIRHelpers_4_3_000.ToValue(ee_);
								bool eg_ = ef_ is CqlDateTime;

								return eg_;
							};
							if (dv_())
							{
								DataType eh_ = @this?.Effective;
								object ei_ = FHIRHelpers_4_3_000.ToValue(eh_);
								CqlDateTime ej_ = ei_ switch { null => null , CqlDateTime j => j/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ej_ as object;
							}
							else if (dw_())
							{
								DataType ek_ = @this?.Effective;
								object el_ = FHIRHelpers_4_3_000.ToValue(ek_);
								CqlInterval<CqlDateTime> em_ = el_ switch { null => null , CqlInterval<CqlDateTime> k => k/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return em_ as object;
							}
							else if (dx_())
							{
								DataType en_ = @this?.Effective;
								object eo_ = FHIRHelpers_4_3_000.ToValue(en_);
								CqlDateTime ep_ = eo_ switch { null => null , CqlDateTime l => l/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ep_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime du_ = QICoreCommon_2_0_000.earliest(dt_());

						return du_;
					};
					IEnumerable<Observation> ci_ = context.Operators.SortBy<Observation>(cg_, ch_, System.ComponentModel.ListSortDirection.Ascending);
					Observation cj_ = context.Operators.Last<Observation>(ci_);
					DataType ck_ = cj_?.Effective;
					object cl_ = FHIRHelpers_4_3_000.ToValue(ck_);
					bool cm_ = cl_ is CqlInterval<CqlDateTime>;

					return cm_;
				};
				bool p_()
				{
					CqlValueSet eq_ = this.Abnormal_Presentation();
					IEnumerable<Observation> er_ = context.Operators.RetrieveByValueSet<Observation>(eq_, default);
					bool? es_(Observation AbnormalPresentation)
					{
						object fa_()
						{
							bool fl_()
							{
								DataType fo_ = AbnormalPresentation?.Effective;
								object fp_ = FHIRHelpers_4_3_000.ToValue(fo_);
								bool fq_ = fp_ is CqlDateTime;

								return fq_;
							};
							bool fm_()
							{
								DataType fr_ = AbnormalPresentation?.Effective;
								object fs_ = FHIRHelpers_4_3_000.ToValue(fr_);
								bool ft_ = fs_ is CqlInterval<CqlDateTime>;

								return ft_;
							};
							bool fn_()
							{
								DataType fu_ = AbnormalPresentation?.Effective;
								object fv_ = FHIRHelpers_4_3_000.ToValue(fu_);
								bool fw_ = fv_ is CqlDateTime;

								return fw_;
							};
							if (fl_())
							{
								DataType fx_ = AbnormalPresentation?.Effective;
								object fy_ = FHIRHelpers_4_3_000.ToValue(fx_);
								CqlDateTime fz_ = fy_ switch { null => null , CqlDateTime m => m/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return fz_ as object;
							}
							else if (fm_())
							{
								DataType ga_ = AbnormalPresentation?.Effective;
								object gb_ = FHIRHelpers_4_3_000.ToValue(ga_);
								CqlInterval<CqlDateTime> gc_ = gb_ switch { null => null , CqlInterval<CqlDateTime> n => n/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return gc_ as object;
							}
							else if (fn_())
							{
								DataType gd_ = AbnormalPresentation?.Effective;
								object ge_ = FHIRHelpers_4_3_000.ToValue(gd_);
								CqlDateTime gf_ = ge_ switch { null => null , CqlDateTime o => o/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return gf_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime fb_ = QICoreCommon_2_0_000.earliest(fa_());
						CqlDateTime fc_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? fd_ = context.Operators.SameOrBefore(fb_, fc_, default);
						Code<ObservationStatus> fe_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? ff_ = fe_?.Value;
						Code<ObservationStatus> fg_ = context.Operators.Convert<Code<ObservationStatus>>(ff_);
						string fh_ = context.Operators.Convert<string>(fg_);
						string[] fi_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? fj_ = context.Operators.In<string>(fh_, fi_ as IEnumerable<string>);
						bool? fk_ = context.Operators.And(fd_, fj_);

						return fk_;
					};
					IEnumerable<Observation> et_ = context.Operators.Where<Observation>(er_, es_);
					object eu_(Observation @this)
					{
						object gg_()
						{
							bool gi_()
							{
								DataType gl_ = @this?.Effective;
								object gm_ = FHIRHelpers_4_3_000.ToValue(gl_);
								bool gn_ = gm_ is CqlDateTime;

								return gn_;
							};
							bool gj_()
							{
								DataType go_ = @this?.Effective;
								object gp_ = FHIRHelpers_4_3_000.ToValue(go_);
								bool gq_ = gp_ is CqlInterval<CqlDateTime>;

								return gq_;
							};
							bool gk_()
							{
								DataType gr_ = @this?.Effective;
								object gs_ = FHIRHelpers_4_3_000.ToValue(gr_);
								bool gt_ = gs_ is CqlDateTime;

								return gt_;
							};
							if (gi_())
							{
								DataType gu_ = @this?.Effective;
								object gv_ = FHIRHelpers_4_3_000.ToValue(gu_);
								CqlDateTime gw_ = gv_ switch { null => null , CqlDateTime p => p/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return gw_ as object;
							}
							else if (gj_())
							{
								DataType gx_ = @this?.Effective;
								object gy_ = FHIRHelpers_4_3_000.ToValue(gx_);
								CqlInterval<CqlDateTime> gz_ = gy_ switch { null => null , CqlInterval<CqlDateTime> q => q/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return gz_ as object;
							}
							else if (gk_())
							{
								DataType ha_ = @this?.Effective;
								object hb_ = FHIRHelpers_4_3_000.ToValue(ha_);
								CqlDateTime hc_ = hb_ switch { null => null , CqlDateTime r => r/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return hc_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime gh_ = QICoreCommon_2_0_000.earliest(gg_());

						return gh_;
					};
					IEnumerable<Observation> ev_ = context.Operators.SortBy<Observation>(et_, eu_, System.ComponentModel.ListSortDirection.Ascending);
					Observation ew_ = context.Operators.Last<Observation>(ev_);
					DataType ex_ = ew_?.Effective;
					object ey_ = FHIRHelpers_4_3_000.ToValue(ex_);
					bool ez_ = ey_ is CqlDateTime;

					return ez_;
				};
				if (n_())
				{
					CqlValueSet hd_ = this.Abnormal_Presentation();
					IEnumerable<Observation> he_ = context.Operators.RetrieveByValueSet<Observation>(hd_, default);
					bool? hf_(Observation AbnormalPresentation)
					{
						object hn_()
						{
							bool hy_()
							{
								DataType ib_ = AbnormalPresentation?.Effective;
								object ic_ = FHIRHelpers_4_3_000.ToValue(ib_);
								bool id_ = ic_ is CqlDateTime;

								return id_;
							};
							bool hz_()
							{
								DataType ie_ = AbnormalPresentation?.Effective;
								object if_ = FHIRHelpers_4_3_000.ToValue(ie_);
								bool ig_ = if_ is CqlInterval<CqlDateTime>;

								return ig_;
							};
							bool ia_()
							{
								DataType ih_ = AbnormalPresentation?.Effective;
								object ii_ = FHIRHelpers_4_3_000.ToValue(ih_);
								bool ij_ = ii_ is CqlDateTime;

								return ij_;
							};
							if (hy_())
							{
								DataType ik_ = AbnormalPresentation?.Effective;
								object il_ = FHIRHelpers_4_3_000.ToValue(ik_);
								CqlDateTime im_ = il_ switch { null => null , CqlDateTime s => s/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return im_ as object;
							}
							else if (hz_())
							{
								DataType in_ = AbnormalPresentation?.Effective;
								object io_ = FHIRHelpers_4_3_000.ToValue(in_);
								CqlInterval<CqlDateTime> ip_ = io_ switch { null => null , CqlInterval<CqlDateTime> t => t/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ip_ as object;
							}
							else if (ia_())
							{
								DataType iq_ = AbnormalPresentation?.Effective;
								object ir_ = FHIRHelpers_4_3_000.ToValue(iq_);
								CqlDateTime is_ = ir_ switch { null => null , CqlDateTime u => u/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return is_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime ho_ = QICoreCommon_2_0_000.earliest(hn_());
						CqlDateTime hp_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? hq_ = context.Operators.SameOrBefore(ho_, hp_, default);
						Code<ObservationStatus> hr_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? hs_ = hr_?.Value;
						Code<ObservationStatus> ht_ = context.Operators.Convert<Code<ObservationStatus>>(hs_);
						string hu_ = context.Operators.Convert<string>(ht_);
						string[] hv_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? hw_ = context.Operators.In<string>(hu_, hv_ as IEnumerable<string>);
						bool? hx_ = context.Operators.And(hq_, hw_);

						return hx_;
					};
					IEnumerable<Observation> hg_ = context.Operators.Where<Observation>(he_, hf_);
					object hh_(Observation @this)
					{
						object it_()
						{
							bool iv_()
							{
								DataType iy_ = @this?.Effective;
								object iz_ = FHIRHelpers_4_3_000.ToValue(iy_);
								bool ja_ = iz_ is CqlDateTime;

								return ja_;
							};
							bool iw_()
							{
								DataType jb_ = @this?.Effective;
								object jc_ = FHIRHelpers_4_3_000.ToValue(jb_);
								bool jd_ = jc_ is CqlInterval<CqlDateTime>;

								return jd_;
							};
							bool ix_()
							{
								DataType je_ = @this?.Effective;
								object jf_ = FHIRHelpers_4_3_000.ToValue(je_);
								bool jg_ = jf_ is CqlDateTime;

								return jg_;
							};
							if (iv_())
							{
								DataType jh_ = @this?.Effective;
								object ji_ = FHIRHelpers_4_3_000.ToValue(jh_);
								CqlDateTime jj_ = ji_ switch { null => null , CqlDateTime v => v/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return jj_ as object;
							}
							else if (iw_())
							{
								DataType jk_ = @this?.Effective;
								object jl_ = FHIRHelpers_4_3_000.ToValue(jk_);
								CqlInterval<CqlDateTime> jm_ = jl_ switch { null => null , CqlInterval<CqlDateTime> w => w/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return jm_ as object;
							}
							else if (ix_())
							{
								DataType jn_ = @this?.Effective;
								object jo_ = FHIRHelpers_4_3_000.ToValue(jn_);
								CqlDateTime jp_ = jo_ switch { null => null , CqlDateTime x => x/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return jp_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime iu_ = QICoreCommon_2_0_000.earliest(it_());

						return iu_;
					};
					IEnumerable<Observation> hi_ = context.Operators.SortBy<Observation>(hg_, hh_, System.ComponentModel.ListSortDirection.Ascending);
					Observation hj_ = context.Operators.Last<Observation>(hi_);
					DataType hk_ = hj_?.Effective;
					object hl_ = FHIRHelpers_4_3_000.ToValue(hk_);
					CqlDateTime hm_ = hl_ switch { null => null , CqlDateTime y => y/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return hm_ as object;
				}
				else if (o_())
				{
					CqlValueSet jq_ = this.Abnormal_Presentation();
					IEnumerable<Observation> jr_ = context.Operators.RetrieveByValueSet<Observation>(jq_, default);
					bool? js_(Observation AbnormalPresentation)
					{
						object ka_()
						{
							bool kl_()
							{
								DataType ko_ = AbnormalPresentation?.Effective;
								object kp_ = FHIRHelpers_4_3_000.ToValue(ko_);
								bool kq_ = kp_ is CqlDateTime;

								return kq_;
							};
							bool km_()
							{
								DataType kr_ = AbnormalPresentation?.Effective;
								object ks_ = FHIRHelpers_4_3_000.ToValue(kr_);
								bool kt_ = ks_ is CqlInterval<CqlDateTime>;

								return kt_;
							};
							bool kn_()
							{
								DataType ku_ = AbnormalPresentation?.Effective;
								object kv_ = FHIRHelpers_4_3_000.ToValue(ku_);
								bool kw_ = kv_ is CqlDateTime;

								return kw_;
							};
							if (kl_())
							{
								DataType kx_ = AbnormalPresentation?.Effective;
								object ky_ = FHIRHelpers_4_3_000.ToValue(kx_);
								CqlDateTime kz_ = ky_ switch { null => null , CqlDateTime z => z/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return kz_ as object;
							}
							else if (km_())
							{
								DataType la_ = AbnormalPresentation?.Effective;
								object lb_ = FHIRHelpers_4_3_000.ToValue(la_);
								CqlInterval<CqlDateTime> lc_ = lb_ switch { null => null , CqlInterval<CqlDateTime> aa => aa/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return lc_ as object;
							}
							else if (kn_())
							{
								DataType ld_ = AbnormalPresentation?.Effective;
								object le_ = FHIRHelpers_4_3_000.ToValue(ld_);
								CqlDateTime lf_ = le_ switch { null => null , CqlDateTime ab => ab/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return lf_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime kb_ = QICoreCommon_2_0_000.earliest(ka_());
						CqlDateTime kc_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? kd_ = context.Operators.SameOrBefore(kb_, kc_, default);
						Code<ObservationStatus> ke_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? kf_ = ke_?.Value;
						Code<ObservationStatus> kg_ = context.Operators.Convert<Code<ObservationStatus>>(kf_);
						string kh_ = context.Operators.Convert<string>(kg_);
						string[] ki_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? kj_ = context.Operators.In<string>(kh_, ki_ as IEnumerable<string>);
						bool? kk_ = context.Operators.And(kd_, kj_);

						return kk_;
					};
					IEnumerable<Observation> jt_ = context.Operators.Where<Observation>(jr_, js_);
					object ju_(Observation @this)
					{
						object lg_()
						{
							bool li_()
							{
								DataType ll_ = @this?.Effective;
								object lm_ = FHIRHelpers_4_3_000.ToValue(ll_);
								bool ln_ = lm_ is CqlDateTime;

								return ln_;
							};
							bool lj_()
							{
								DataType lo_ = @this?.Effective;
								object lp_ = FHIRHelpers_4_3_000.ToValue(lo_);
								bool lq_ = lp_ is CqlInterval<CqlDateTime>;

								return lq_;
							};
							bool lk_()
							{
								DataType lr_ = @this?.Effective;
								object ls_ = FHIRHelpers_4_3_000.ToValue(lr_);
								bool lt_ = ls_ is CqlDateTime;

								return lt_;
							};
							if (li_())
							{
								DataType lu_ = @this?.Effective;
								object lv_ = FHIRHelpers_4_3_000.ToValue(lu_);
								CqlDateTime lw_ = lv_ switch { null => null , CqlDateTime ac => ac/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return lw_ as object;
							}
							else if (lj_())
							{
								DataType lx_ = @this?.Effective;
								object ly_ = FHIRHelpers_4_3_000.ToValue(lx_);
								CqlInterval<CqlDateTime> lz_ = ly_ switch { null => null , CqlInterval<CqlDateTime> ad => ad/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return lz_ as object;
							}
							else if (lk_())
							{
								DataType ma_ = @this?.Effective;
								object mb_ = FHIRHelpers_4_3_000.ToValue(ma_);
								CqlDateTime mc_ = mb_ switch { null => null , CqlDateTime ae => ae/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return mc_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime lh_ = QICoreCommon_2_0_000.earliest(lg_());

						return lh_;
					};
					IEnumerable<Observation> jv_ = context.Operators.SortBy<Observation>(jt_, ju_, System.ComponentModel.ListSortDirection.Ascending);
					Observation jw_ = context.Operators.Last<Observation>(jv_);
					DataType jx_ = jw_?.Effective;
					object jy_ = FHIRHelpers_4_3_000.ToValue(jx_);
					CqlInterval<CqlDateTime> jz_ = jy_ switch { null => null , CqlInterval<CqlDateTime> af => af/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return jz_ as object;
				}
				else if (p_())
				{
					CqlValueSet md_ = this.Abnormal_Presentation();
					IEnumerable<Observation> me_ = context.Operators.RetrieveByValueSet<Observation>(md_, default);
					bool? mf_(Observation AbnormalPresentation)
					{
						object mn_()
						{
							bool my_()
							{
								DataType nb_ = AbnormalPresentation?.Effective;
								object nc_ = FHIRHelpers_4_3_000.ToValue(nb_);
								bool nd_ = nc_ is CqlDateTime;

								return nd_;
							};
							bool mz_()
							{
								DataType ne_ = AbnormalPresentation?.Effective;
								object nf_ = FHIRHelpers_4_3_000.ToValue(ne_);
								bool ng_ = nf_ is CqlInterval<CqlDateTime>;

								return ng_;
							};
							bool na_()
							{
								DataType nh_ = AbnormalPresentation?.Effective;
								object ni_ = FHIRHelpers_4_3_000.ToValue(nh_);
								bool nj_ = ni_ is CqlDateTime;

								return nj_;
							};
							if (my_())
							{
								DataType nk_ = AbnormalPresentation?.Effective;
								object nl_ = FHIRHelpers_4_3_000.ToValue(nk_);
								CqlDateTime nm_ = nl_ switch { null => null , CqlDateTime ag => ag/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return nm_ as object;
							}
							else if (mz_())
							{
								DataType nn_ = AbnormalPresentation?.Effective;
								object no_ = FHIRHelpers_4_3_000.ToValue(nn_);
								CqlInterval<CqlDateTime> np_ = no_ switch { null => null , CqlInterval<CqlDateTime> ah => ah/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return np_ as object;
							}
							else if (na_())
							{
								DataType nq_ = AbnormalPresentation?.Effective;
								object nr_ = FHIRHelpers_4_3_000.ToValue(nq_);
								CqlDateTime ns_ = nr_ switch { null => null , CqlDateTime ai => ai/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return ns_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime mo_ = QICoreCommon_2_0_000.earliest(mn_());
						CqlDateTime mp_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? mq_ = context.Operators.SameOrBefore(mo_, mp_, default);
						Code<ObservationStatus> mr_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? ms_ = mr_?.Value;
						Code<ObservationStatus> mt_ = context.Operators.Convert<Code<ObservationStatus>>(ms_);
						string mu_ = context.Operators.Convert<string>(mt_);
						string[] mv_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? mw_ = context.Operators.In<string>(mu_, mv_ as IEnumerable<string>);
						bool? mx_ = context.Operators.And(mq_, mw_);

						return mx_;
					};
					IEnumerable<Observation> mg_ = context.Operators.Where<Observation>(me_, mf_);
					object mh_(Observation @this)
					{
						object nt_()
						{
							bool nv_()
							{
								DataType ny_ = @this?.Effective;
								object nz_ = FHIRHelpers_4_3_000.ToValue(ny_);
								bool oa_ = nz_ is CqlDateTime;

								return oa_;
							};
							bool nw_()
							{
								DataType ob_ = @this?.Effective;
								object oc_ = FHIRHelpers_4_3_000.ToValue(ob_);
								bool od_ = oc_ is CqlInterval<CqlDateTime>;

								return od_;
							};
							bool nx_()
							{
								DataType oe_ = @this?.Effective;
								object of_ = FHIRHelpers_4_3_000.ToValue(oe_);
								bool og_ = of_ is CqlDateTime;

								return og_;
							};
							if (nv_())
							{
								DataType oh_ = @this?.Effective;
								object oi_ = FHIRHelpers_4_3_000.ToValue(oh_);
								CqlDateTime oj_ = oi_ switch { null => null , CqlDateTime aj => aj/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return oj_ as object;
							}
							else if (nw_())
							{
								DataType ok_ = @this?.Effective;
								object ol_ = FHIRHelpers_4_3_000.ToValue(ok_);
								CqlInterval<CqlDateTime> om_ = ol_ switch { null => null , CqlInterval<CqlDateTime> ak => ak/* , CqlDateTime => ???, Timing => ???, CqlDateTime => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return om_ as object;
							}
							else if (nx_())
							{
								DataType on_ = @this?.Effective;
								object oo_ = FHIRHelpers_4_3_000.ToValue(on_);
								CqlDateTime op_ = oo_ switch { null => null , CqlDateTime al => al/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

								return op_ as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime nu_ = QICoreCommon_2_0_000.earliest(nt_());

						return nu_;
					};
					IEnumerable<Observation> mi_ = context.Operators.SortBy<Observation>(mg_, mh_, System.ComponentModel.ListSortDirection.Ascending);
					Observation mj_ = context.Operators.Last<Observation>(mi_);
					DataType mk_ = mj_?.Effective;
					object ml_ = FHIRHelpers_4_3_000.ToValue(mk_);
					CqlDateTime mm_ = ml_ switch { null => null , CqlDateTime am => am/* , CqlInterval<CqlDateTime> => ???, Timing => ??? */, _ => throw new System.Diagnostics.UnreachableException() };

					return mm_ as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime e_ = QICoreCommon_2_0_000.earliest(d_());
			Period f_ = ThirtysevenWeeksPlusEncounter?.Period;
			CqlInterval<CqlDateTime> g_ = FHIRHelpers_4_3_000.ToInterval(f_);
			bool? h_ = context.Operators.In<CqlDateTime>(e_, g_, default);
			IEnumerable<Condition> i_ = CQMCommon_2_0_000.encounterDiagnosis(ThirtysevenWeeksPlusEncounter);
			bool? j_(Condition EncounterDiagnosis)
			{
				CodeableConcept oq_ = EncounterDiagnosis?.Code;
				CqlConcept or_ = FHIRHelpers_4_3_000.ToConcept(oq_);
				CqlValueSet os_ = this.Abnormal_Presentation();
				bool? ot_ = context.Operators.ConceptInValueSet(or_, os_);

				return ot_;
			};
			IEnumerable<Condition> k_ = context.Operators.Where<Condition>(i_, j_);
			bool? l_ = context.Operators.Exists<Condition>(k_);
			bool? m_ = context.Operators.Or(h_, l_);

			return m_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Abnormal Presentation")]
	public IEnumerable<Encounter> Encounter_with_Abnormal_Presentation() => 
		__Encounter_with_Abnormal_Presentation.Value;

	private IEnumerable<Encounter> Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum_Value()
	{
		IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births();
		bool? b_(Encounter ThirtysevenWeeksPlusEncounter)
		{
			IEnumerable<Condition> d_ = CQMCommon_2_0_000.encounterDiagnosis(ThirtysevenWeeksPlusEncounter);
			bool? e_(Condition EncounterDiagnosis)
			{
				CodeableConcept h_ = EncounterDiagnosis?.Code;
				CqlConcept i_ = FHIRHelpers_4_3_000.ToConcept(h_);
				CqlValueSet j_ = this.Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa();
				bool? k_ = context.Operators.ConceptInValueSet(i_, j_);
				CqlConcept m_ = FHIRHelpers_4_3_000.ToConcept(h_);
				CqlValueSet n_ = this.Genital_Herpes();
				bool? o_ = context.Operators.ConceptInValueSet(m_, n_);
				bool? p_ = context.Operators.Or(k_, o_);

				return p_;
			};
			IEnumerable<Condition> f_ = context.Operators.Where<Condition>(d_, e_);
			bool? g_ = context.Operators.Exists<Condition>(f_);

			return g_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Encounter with Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
	public IEnumerable<Encounter> Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum() => 
		__Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_with_Abnormal_Presentation();
		IEnumerable<Encounter> b_ = this.Encounter_with_Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum();
		IEnumerable<Encounter> c_ = context.Operators.Union<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum() => 
		__Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Denominator_Exclusions_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounter_with_Abnormal_Presentation__Genital_Herpes__Placenta_Previa__Vasa_Previa_or_Placenta_Accreta_Spectrum();

		return a_;
	}

    [CqlDeclaration("Denominator Exclusions")]
	public IEnumerable<Encounter> Denominator_Exclusions() => 
		__Denominator_Exclusions.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = PCMaternal_5_16_000.Delivery_Encounter_with_Age_Range();

		return a_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Delivery_Encounter_with_Cesarean_Birth_Value()
	{
		IEnumerable<Encounter> a_ = this.Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births();
		IEnumerable<Encounter> b_(Encounter ThirtysevenWeeksPlusEncounter)
		{
			CqlValueSet d_ = this.Cesarean_Birth();
			IEnumerable<Procedure> e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, default);
			bool? f_(Procedure CSection)
			{
				CqlInterval<CqlDateTime> j_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(ThirtysevenWeeksPlusEncounter);
				DataType k_ = CSection?.Performed;
				object l_ = FHIRHelpers_4_3_000.ToValue(k_);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.toInterval(l_);
				bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, m_, default);
				Code<EventStatus> o_ = CSection?.StatusElement;
				EventStatus? p_ = o_?.Value;
				string q_ = context.Operators.Convert<string>(p_);
				bool? r_ = context.Operators.Equal(q_, "completed");
				bool? s_ = context.Operators.And(n_, r_);

				return s_;
			};
			IEnumerable<Procedure> g_ = context.Operators.Where<Procedure>(e_, f_);
			Encounter h_(Procedure CSection) => 
				ThirtysevenWeeksPlusEncounter;
			IEnumerable<Encounter> i_ = context.Operators.Select<Procedure, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Delivery Encounter with Cesarean Birth")]
	public IEnumerable<Encounter> Delivery_Encounter_with_Cesarean_Birth() => 
		__Delivery_Encounter_with_Cesarean_Birth.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounter_with_Cesarean_Birth();

		return a_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<(string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age_Value()
	{
		IEnumerable<(string EncounterID, int? CalculatedCGA)?> a_ = PCMaternal_5_16_000.Variable_Calculated_Gestational_Age();

		return a_;
	}

    [CqlDeclaration("Variable Calculated Gestational Age")]
	public IEnumerable<(string EncounterID, int? CalculatedCGA)?> Variable_Calculated_Gestational_Age() => 
		__Variable_Calculated_Gestational_Age.Value;

}
