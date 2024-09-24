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

					return (au_ as CqlDateTime) as object;
				}
				else if (ai_())
				{
					DataType av_ = Gravida?.Effective;
					object aw_ = FHIRHelpers_4_3_000.ToValue(av_);
					CqlInterval<CqlDateTime> ax_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(aw_);

					return ax_ as object;
				}
				else if (aj_())
				{
					DataType ay_ = Gravida?.Effective;
					object az_ = FHIRHelpers_4_3_000.ToValue(ay_);

					return (az_ as CqlDateTime) as object;
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
			object ba_()
			{
				bool bc_()
				{
					DataType bf_ = @this?.Effective;
					object bg_ = FHIRHelpers_4_3_000.ToValue(bf_);
					bool bh_ = bg_ is CqlDateTime;

					return bh_;
				};
				bool bd_()
				{
					DataType bi_ = @this?.Effective;
					object bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
					bool bk_ = bj_ is CqlInterval<CqlDateTime>;

					return bk_;
				};
				bool be_()
				{
					DataType bl_ = @this?.Effective;
					object bm_ = FHIRHelpers_4_3_000.ToValue(bl_);
					bool bn_ = bm_ is CqlDateTime;

					return bn_;
				};
				if (bc_())
				{
					DataType bo_ = @this?.Effective;
					object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);

					return (bp_ as CqlDateTime) as object;
				}
				else if (bd_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
					CqlInterval<CqlDateTime> bs_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(br_);

					return bs_ as object;
				}
				else if (be_())
				{
					DataType bt_ = @this?.Effective;
					object bu_ = FHIRHelpers_4_3_000.ToValue(bt_);

					return (bu_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime bb_ = QICoreCommon_2_0_000.earliest(ba_());

			return bb_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);
		int? k_ = context.Operators.Convert<int?>(j_);

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

					return (au_ as CqlDateTime) as object;
				}
				else if (ai_())
				{
					DataType av_ = Parity?.Effective;
					object aw_ = FHIRHelpers_4_3_000.ToValue(av_);
					CqlInterval<CqlDateTime> ax_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(aw_);

					return ax_ as object;
				}
				else if (aj_())
				{
					DataType ay_ = Parity?.Effective;
					object az_ = FHIRHelpers_4_3_000.ToValue(ay_);

					return (az_ as CqlDateTime) as object;
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
			object ba_()
			{
				bool bc_()
				{
					DataType bf_ = @this?.Effective;
					object bg_ = FHIRHelpers_4_3_000.ToValue(bf_);
					bool bh_ = bg_ is CqlDateTime;

					return bh_;
				};
				bool bd_()
				{
					DataType bi_ = @this?.Effective;
					object bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
					bool bk_ = bj_ is CqlInterval<CqlDateTime>;

					return bk_;
				};
				bool be_()
				{
					DataType bl_ = @this?.Effective;
					object bm_ = FHIRHelpers_4_3_000.ToValue(bl_);
					bool bn_ = bm_ is CqlDateTime;

					return bn_;
				};
				if (bc_())
				{
					DataType bo_ = @this?.Effective;
					object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);

					return (bp_ as CqlDateTime) as object;
				}
				else if (bd_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
					CqlInterval<CqlDateTime> bs_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(br_);

					return bs_ as object;
				}
				else if (be_())
				{
					DataType bt_ = @this?.Effective;
					object bu_ = FHIRHelpers_4_3_000.ToValue(bt_);

					return (bu_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime bb_ = QICoreCommon_2_0_000.earliest(ba_());

			return bb_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);
		int? k_ = context.Operators.Convert<int?>(j_);

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

					return (au_ as CqlDateTime) as object;
				}
				else if (ai_())
				{
					DataType av_ = PretermBirth?.Effective;
					object aw_ = FHIRHelpers_4_3_000.ToValue(av_);
					CqlInterval<CqlDateTime> ax_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(aw_);

					return ax_ as object;
				}
				else if (aj_())
				{
					DataType ay_ = PretermBirth?.Effective;
					object az_ = FHIRHelpers_4_3_000.ToValue(ay_);

					return (az_ as CqlDateTime) as object;
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
			object ba_()
			{
				bool bc_()
				{
					DataType bf_ = @this?.Effective;
					object bg_ = FHIRHelpers_4_3_000.ToValue(bf_);
					bool bh_ = bg_ is CqlDateTime;

					return bh_;
				};
				bool bd_()
				{
					DataType bi_ = @this?.Effective;
					object bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
					bool bk_ = bj_ is CqlInterval<CqlDateTime>;

					return bk_;
				};
				bool be_()
				{
					DataType bl_ = @this?.Effective;
					object bm_ = FHIRHelpers_4_3_000.ToValue(bl_);
					bool bn_ = bm_ is CqlDateTime;

					return bn_;
				};
				if (bc_())
				{
					DataType bo_ = @this?.Effective;
					object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);

					return (bp_ as CqlDateTime) as object;
				}
				else if (bd_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
					CqlInterval<CqlDateTime> bs_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(br_);

					return bs_ as object;
				}
				else if (be_())
				{
					DataType bt_ = @this?.Effective;
					object bu_ = FHIRHelpers_4_3_000.ToValue(bt_);

					return (bu_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime bb_ = QICoreCommon_2_0_000.earliest(ba_());

			return bb_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);
		int? k_ = context.Operators.Convert<int?>(j_);

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

					return (au_ as CqlDateTime) as object;
				}
				else if (ai_())
				{
					DataType av_ = TermBirth?.Effective;
					object aw_ = FHIRHelpers_4_3_000.ToValue(av_);
					CqlInterval<CqlDateTime> ax_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(aw_);

					return ax_ as object;
				}
				else if (aj_())
				{
					DataType ay_ = TermBirth?.Effective;
					object az_ = FHIRHelpers_4_3_000.ToValue(ay_);

					return (az_ as CqlDateTime) as object;
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
			object ba_()
			{
				bool bc_()
				{
					DataType bf_ = @this?.Effective;
					object bg_ = FHIRHelpers_4_3_000.ToValue(bf_);
					bool bh_ = bg_ is CqlDateTime;

					return bh_;
				};
				bool bd_()
				{
					DataType bi_ = @this?.Effective;
					object bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
					bool bk_ = bj_ is CqlInterval<CqlDateTime>;

					return bk_;
				};
				bool be_()
				{
					DataType bl_ = @this?.Effective;
					object bm_ = FHIRHelpers_4_3_000.ToValue(bl_);
					bool bn_ = bm_ is CqlDateTime;

					return bn_;
				};
				if (bc_())
				{
					DataType bo_ = @this?.Effective;
					object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);

					return (bp_ as CqlDateTime) as object;
				}
				else if (bd_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);
					CqlInterval<CqlDateTime> bs_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(br_);

					return bs_ as object;
				}
				else if (be_())
				{
					DataType bt_ = @this?.Effective;
					object bu_ = FHIRHelpers_4_3_000.ToValue(bt_);

					return (bu_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime bb_ = QICoreCommon_2_0_000.earliest(ba_());

			return bb_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);
		int? k_ = context.Operators.Convert<int?>(j_);

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

								return (ay_ as CqlDateTime) as object;
							}
							else if (am_())
							{
								DataType az_ = AbnormalPresentation?.Effective;
								object ba_ = FHIRHelpers_4_3_000.ToValue(az_);
								CqlInterval<CqlDateTime> bb_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(ba_);

								return bb_ as object;
							}
							else if (an_())
							{
								DataType bc_ = AbnormalPresentation?.Effective;
								object bd_ = FHIRHelpers_4_3_000.ToValue(bc_);

								return (bd_ as CqlDateTime) as object;
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
						object be_()
						{
							bool bg_()
							{
								DataType bj_ = @this?.Effective;
								object bk_ = FHIRHelpers_4_3_000.ToValue(bj_);
								bool bl_ = bk_ is CqlDateTime;

								return bl_;
							};
							bool bh_()
							{
								DataType bm_ = @this?.Effective;
								object bn_ = FHIRHelpers_4_3_000.ToValue(bm_);
								bool bo_ = bn_ is CqlInterval<CqlDateTime>;

								return bo_;
							};
							bool bi_()
							{
								DataType bp_ = @this?.Effective;
								object bq_ = FHIRHelpers_4_3_000.ToValue(bp_);
								bool br_ = bq_ is CqlDateTime;

								return br_;
							};
							if (bg_())
							{
								DataType bs_ = @this?.Effective;
								object bt_ = FHIRHelpers_4_3_000.ToValue(bs_);

								return (bt_ as CqlDateTime) as object;
							}
							else if (bh_())
							{
								DataType bu_ = @this?.Effective;
								object bv_ = FHIRHelpers_4_3_000.ToValue(bu_);
								CqlInterval<CqlDateTime> bw_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(bv_);

								return bw_ as object;
							}
							else if (bi_())
							{
								DataType bx_ = @this?.Effective;
								object by_ = FHIRHelpers_4_3_000.ToValue(bx_);

								return (by_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime bf_ = QICoreCommon_2_0_000.earliest(be_());

						return bf_;
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
					CqlValueSet bz_ = this.Abnormal_Presentation();
					IEnumerable<Observation> ca_ = context.Operators.RetrieveByValueSet<Observation>(bz_, default);
					bool? cb_(Observation AbnormalPresentation)
					{
						object cj_()
						{
							bool cu_()
							{
								DataType cx_ = AbnormalPresentation?.Effective;
								object cy_ = FHIRHelpers_4_3_000.ToValue(cx_);
								bool cz_ = cy_ is CqlDateTime;

								return cz_;
							};
							bool cv_()
							{
								DataType da_ = AbnormalPresentation?.Effective;
								object db_ = FHIRHelpers_4_3_000.ToValue(da_);
								bool dc_ = db_ is CqlInterval<CqlDateTime>;

								return dc_;
							};
							bool cw_()
							{
								DataType dd_ = AbnormalPresentation?.Effective;
								object de_ = FHIRHelpers_4_3_000.ToValue(dd_);
								bool df_ = de_ is CqlDateTime;

								return df_;
							};
							if (cu_())
							{
								DataType dg_ = AbnormalPresentation?.Effective;
								object dh_ = FHIRHelpers_4_3_000.ToValue(dg_);

								return (dh_ as CqlDateTime) as object;
							}
							else if (cv_())
							{
								DataType di_ = AbnormalPresentation?.Effective;
								object dj_ = FHIRHelpers_4_3_000.ToValue(di_);
								CqlInterval<CqlDateTime> dk_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(dj_);

								return dk_ as object;
							}
							else if (cw_())
							{
								DataType dl_ = AbnormalPresentation?.Effective;
								object dm_ = FHIRHelpers_4_3_000.ToValue(dl_);

								return (dm_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime ck_ = QICoreCommon_2_0_000.earliest(cj_());
						CqlDateTime cl_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? cm_ = context.Operators.SameOrBefore(ck_, cl_, default);
						Code<ObservationStatus> cn_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? co_ = cn_?.Value;
						Code<ObservationStatus> cp_ = context.Operators.Convert<Code<ObservationStatus>>(co_);
						string cq_ = context.Operators.Convert<string>(cp_);
						string[] cr_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? cs_ = context.Operators.In<string>(cq_, cr_ as IEnumerable<string>);
						bool? ct_ = context.Operators.And(cm_, cs_);

						return ct_;
					};
					IEnumerable<Observation> cc_ = context.Operators.Where<Observation>(ca_, cb_);
					object cd_(Observation @this)
					{
						object dn_()
						{
							bool dp_()
							{
								DataType ds_ = @this?.Effective;
								object dt_ = FHIRHelpers_4_3_000.ToValue(ds_);
								bool du_ = dt_ is CqlDateTime;

								return du_;
							};
							bool dq_()
							{
								DataType dv_ = @this?.Effective;
								object dw_ = FHIRHelpers_4_3_000.ToValue(dv_);
								bool dx_ = dw_ is CqlInterval<CqlDateTime>;

								return dx_;
							};
							bool dr_()
							{
								DataType dy_ = @this?.Effective;
								object dz_ = FHIRHelpers_4_3_000.ToValue(dy_);
								bool ea_ = dz_ is CqlDateTime;

								return ea_;
							};
							if (dp_())
							{
								DataType eb_ = @this?.Effective;
								object ec_ = FHIRHelpers_4_3_000.ToValue(eb_);

								return (ec_ as CqlDateTime) as object;
							}
							else if (dq_())
							{
								DataType ed_ = @this?.Effective;
								object ee_ = FHIRHelpers_4_3_000.ToValue(ed_);
								CqlInterval<CqlDateTime> ef_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(ee_);

								return ef_ as object;
							}
							else if (dr_())
							{
								DataType eg_ = @this?.Effective;
								object eh_ = FHIRHelpers_4_3_000.ToValue(eg_);

								return (eh_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime do_ = QICoreCommon_2_0_000.earliest(dn_());

						return do_;
					};
					IEnumerable<Observation> ce_ = context.Operators.SortBy<Observation>(cc_, cd_, System.ComponentModel.ListSortDirection.Ascending);
					Observation cf_ = context.Operators.Last<Observation>(ce_);
					DataType cg_ = cf_?.Effective;
					object ch_ = FHIRHelpers_4_3_000.ToValue(cg_);
					bool ci_ = ch_ is CqlInterval<CqlDateTime>;

					return ci_;
				};
				bool p_()
				{
					CqlValueSet ei_ = this.Abnormal_Presentation();
					IEnumerable<Observation> ej_ = context.Operators.RetrieveByValueSet<Observation>(ei_, default);
					bool? ek_(Observation AbnormalPresentation)
					{
						object es_()
						{
							bool fd_()
							{
								DataType fg_ = AbnormalPresentation?.Effective;
								object fh_ = FHIRHelpers_4_3_000.ToValue(fg_);
								bool fi_ = fh_ is CqlDateTime;

								return fi_;
							};
							bool fe_()
							{
								DataType fj_ = AbnormalPresentation?.Effective;
								object fk_ = FHIRHelpers_4_3_000.ToValue(fj_);
								bool fl_ = fk_ is CqlInterval<CqlDateTime>;

								return fl_;
							};
							bool ff_()
							{
								DataType fm_ = AbnormalPresentation?.Effective;
								object fn_ = FHIRHelpers_4_3_000.ToValue(fm_);
								bool fo_ = fn_ is CqlDateTime;

								return fo_;
							};
							if (fd_())
							{
								DataType fp_ = AbnormalPresentation?.Effective;
								object fq_ = FHIRHelpers_4_3_000.ToValue(fp_);

								return (fq_ as CqlDateTime) as object;
							}
							else if (fe_())
							{
								DataType fr_ = AbnormalPresentation?.Effective;
								object fs_ = FHIRHelpers_4_3_000.ToValue(fr_);
								CqlInterval<CqlDateTime> ft_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(fs_);

								return ft_ as object;
							}
							else if (ff_())
							{
								DataType fu_ = AbnormalPresentation?.Effective;
								object fv_ = FHIRHelpers_4_3_000.ToValue(fu_);

								return (fv_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime et_ = QICoreCommon_2_0_000.earliest(es_());
						CqlDateTime eu_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? ev_ = context.Operators.SameOrBefore(et_, eu_, default);
						Code<ObservationStatus> ew_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? ex_ = ew_?.Value;
						Code<ObservationStatus> ey_ = context.Operators.Convert<Code<ObservationStatus>>(ex_);
						string ez_ = context.Operators.Convert<string>(ey_);
						string[] fa_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? fb_ = context.Operators.In<string>(ez_, fa_ as IEnumerable<string>);
						bool? fc_ = context.Operators.And(ev_, fb_);

						return fc_;
					};
					IEnumerable<Observation> el_ = context.Operators.Where<Observation>(ej_, ek_);
					object em_(Observation @this)
					{
						object fw_()
						{
							bool fy_()
							{
								DataType gb_ = @this?.Effective;
								object gc_ = FHIRHelpers_4_3_000.ToValue(gb_);
								bool gd_ = gc_ is CqlDateTime;

								return gd_;
							};
							bool fz_()
							{
								DataType ge_ = @this?.Effective;
								object gf_ = FHIRHelpers_4_3_000.ToValue(ge_);
								bool gg_ = gf_ is CqlInterval<CqlDateTime>;

								return gg_;
							};
							bool ga_()
							{
								DataType gh_ = @this?.Effective;
								object gi_ = FHIRHelpers_4_3_000.ToValue(gh_);
								bool gj_ = gi_ is CqlDateTime;

								return gj_;
							};
							if (fy_())
							{
								DataType gk_ = @this?.Effective;
								object gl_ = FHIRHelpers_4_3_000.ToValue(gk_);

								return (gl_ as CqlDateTime) as object;
							}
							else if (fz_())
							{
								DataType gm_ = @this?.Effective;
								object gn_ = FHIRHelpers_4_3_000.ToValue(gm_);
								CqlInterval<CqlDateTime> go_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(gn_);

								return go_ as object;
							}
							else if (ga_())
							{
								DataType gp_ = @this?.Effective;
								object gq_ = FHIRHelpers_4_3_000.ToValue(gp_);

								return (gq_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime fx_ = QICoreCommon_2_0_000.earliest(fw_());

						return fx_;
					};
					IEnumerable<Observation> en_ = context.Operators.SortBy<Observation>(el_, em_, System.ComponentModel.ListSortDirection.Ascending);
					Observation eo_ = context.Operators.Last<Observation>(en_);
					DataType ep_ = eo_?.Effective;
					object eq_ = FHIRHelpers_4_3_000.ToValue(ep_);
					bool er_ = eq_ is CqlDateTime;

					return er_;
				};
				if (n_())
				{
					CqlValueSet gr_ = this.Abnormal_Presentation();
					IEnumerable<Observation> gs_ = context.Operators.RetrieveByValueSet<Observation>(gr_, default);
					bool? gt_(Observation AbnormalPresentation)
					{
						object ha_()
						{
							bool hl_()
							{
								DataType ho_ = AbnormalPresentation?.Effective;
								object hp_ = FHIRHelpers_4_3_000.ToValue(ho_);
								bool hq_ = hp_ is CqlDateTime;

								return hq_;
							};
							bool hm_()
							{
								DataType hr_ = AbnormalPresentation?.Effective;
								object hs_ = FHIRHelpers_4_3_000.ToValue(hr_);
								bool ht_ = hs_ is CqlInterval<CqlDateTime>;

								return ht_;
							};
							bool hn_()
							{
								DataType hu_ = AbnormalPresentation?.Effective;
								object hv_ = FHIRHelpers_4_3_000.ToValue(hu_);
								bool hw_ = hv_ is CqlDateTime;

								return hw_;
							};
							if (hl_())
							{
								DataType hx_ = AbnormalPresentation?.Effective;
								object hy_ = FHIRHelpers_4_3_000.ToValue(hx_);

								return (hy_ as CqlDateTime) as object;
							}
							else if (hm_())
							{
								DataType hz_ = AbnormalPresentation?.Effective;
								object ia_ = FHIRHelpers_4_3_000.ToValue(hz_);
								CqlInterval<CqlDateTime> ib_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(ia_);

								return ib_ as object;
							}
							else if (hn_())
							{
								DataType ic_ = AbnormalPresentation?.Effective;
								object id_ = FHIRHelpers_4_3_000.ToValue(ic_);

								return (id_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime hb_ = QICoreCommon_2_0_000.earliest(ha_());
						CqlDateTime hc_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? hd_ = context.Operators.SameOrBefore(hb_, hc_, default);
						Code<ObservationStatus> he_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? hf_ = he_?.Value;
						Code<ObservationStatus> hg_ = context.Operators.Convert<Code<ObservationStatus>>(hf_);
						string hh_ = context.Operators.Convert<string>(hg_);
						string[] hi_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? hj_ = context.Operators.In<string>(hh_, hi_ as IEnumerable<string>);
						bool? hk_ = context.Operators.And(hd_, hj_);

						return hk_;
					};
					IEnumerable<Observation> gu_ = context.Operators.Where<Observation>(gs_, gt_);
					object gv_(Observation @this)
					{
						object ie_()
						{
							bool ig_()
							{
								DataType ij_ = @this?.Effective;
								object ik_ = FHIRHelpers_4_3_000.ToValue(ij_);
								bool il_ = ik_ is CqlDateTime;

								return il_;
							};
							bool ih_()
							{
								DataType im_ = @this?.Effective;
								object in_ = FHIRHelpers_4_3_000.ToValue(im_);
								bool io_ = in_ is CqlInterval<CqlDateTime>;

								return io_;
							};
							bool ii_()
							{
								DataType ip_ = @this?.Effective;
								object iq_ = FHIRHelpers_4_3_000.ToValue(ip_);
								bool ir_ = iq_ is CqlDateTime;

								return ir_;
							};
							if (ig_())
							{
								DataType is_ = @this?.Effective;
								object it_ = FHIRHelpers_4_3_000.ToValue(is_);

								return (it_ as CqlDateTime) as object;
							}
							else if (ih_())
							{
								DataType iu_ = @this?.Effective;
								object iv_ = FHIRHelpers_4_3_000.ToValue(iu_);
								CqlInterval<CqlDateTime> iw_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(iv_);

								return iw_ as object;
							}
							else if (ii_())
							{
								DataType ix_ = @this?.Effective;
								object iy_ = FHIRHelpers_4_3_000.ToValue(ix_);

								return (iy_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime if_ = QICoreCommon_2_0_000.earliest(ie_());

						return if_;
					};
					IEnumerable<Observation> gw_ = context.Operators.SortBy<Observation>(gu_, gv_, System.ComponentModel.ListSortDirection.Ascending);
					Observation gx_ = context.Operators.Last<Observation>(gw_);
					DataType gy_ = gx_?.Effective;
					object gz_ = FHIRHelpers_4_3_000.ToValue(gy_);

					return (gz_ as CqlDateTime) as object;
				}
				else if (o_())
				{
					CqlValueSet iz_ = this.Abnormal_Presentation();
					IEnumerable<Observation> ja_ = context.Operators.RetrieveByValueSet<Observation>(iz_, default);
					bool? jb_(Observation AbnormalPresentation)
					{
						object jj_()
						{
							bool ju_()
							{
								DataType jx_ = AbnormalPresentation?.Effective;
								object jy_ = FHIRHelpers_4_3_000.ToValue(jx_);
								bool jz_ = jy_ is CqlDateTime;

								return jz_;
							};
							bool jv_()
							{
								DataType ka_ = AbnormalPresentation?.Effective;
								object kb_ = FHIRHelpers_4_3_000.ToValue(ka_);
								bool kc_ = kb_ is CqlInterval<CqlDateTime>;

								return kc_;
							};
							bool jw_()
							{
								DataType kd_ = AbnormalPresentation?.Effective;
								object ke_ = FHIRHelpers_4_3_000.ToValue(kd_);
								bool kf_ = ke_ is CqlDateTime;

								return kf_;
							};
							if (ju_())
							{
								DataType kg_ = AbnormalPresentation?.Effective;
								object kh_ = FHIRHelpers_4_3_000.ToValue(kg_);

								return (kh_ as CqlDateTime) as object;
							}
							else if (jv_())
							{
								DataType ki_ = AbnormalPresentation?.Effective;
								object kj_ = FHIRHelpers_4_3_000.ToValue(ki_);
								CqlInterval<CqlDateTime> kk_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(kj_);

								return kk_ as object;
							}
							else if (jw_())
							{
								DataType kl_ = AbnormalPresentation?.Effective;
								object km_ = FHIRHelpers_4_3_000.ToValue(kl_);

								return (km_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime jk_ = QICoreCommon_2_0_000.earliest(jj_());
						CqlDateTime jl_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? jm_ = context.Operators.SameOrBefore(jk_, jl_, default);
						Code<ObservationStatus> jn_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? jo_ = jn_?.Value;
						Code<ObservationStatus> jp_ = context.Operators.Convert<Code<ObservationStatus>>(jo_);
						string jq_ = context.Operators.Convert<string>(jp_);
						string[] jr_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? js_ = context.Operators.In<string>(jq_, jr_ as IEnumerable<string>);
						bool? jt_ = context.Operators.And(jm_, js_);

						return jt_;
					};
					IEnumerable<Observation> jc_ = context.Operators.Where<Observation>(ja_, jb_);
					object jd_(Observation @this)
					{
						object kn_()
						{
							bool kp_()
							{
								DataType ks_ = @this?.Effective;
								object kt_ = FHIRHelpers_4_3_000.ToValue(ks_);
								bool ku_ = kt_ is CqlDateTime;

								return ku_;
							};
							bool kq_()
							{
								DataType kv_ = @this?.Effective;
								object kw_ = FHIRHelpers_4_3_000.ToValue(kv_);
								bool kx_ = kw_ is CqlInterval<CqlDateTime>;

								return kx_;
							};
							bool kr_()
							{
								DataType ky_ = @this?.Effective;
								object kz_ = FHIRHelpers_4_3_000.ToValue(ky_);
								bool la_ = kz_ is CqlDateTime;

								return la_;
							};
							if (kp_())
							{
								DataType lb_ = @this?.Effective;
								object lc_ = FHIRHelpers_4_3_000.ToValue(lb_);

								return (lc_ as CqlDateTime) as object;
							}
							else if (kq_())
							{
								DataType ld_ = @this?.Effective;
								object le_ = FHIRHelpers_4_3_000.ToValue(ld_);
								CqlInterval<CqlDateTime> lf_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(le_);

								return lf_ as object;
							}
							else if (kr_())
							{
								DataType lg_ = @this?.Effective;
								object lh_ = FHIRHelpers_4_3_000.ToValue(lg_);

								return (lh_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime ko_ = QICoreCommon_2_0_000.earliest(kn_());

						return ko_;
					};
					IEnumerable<Observation> je_ = context.Operators.SortBy<Observation>(jc_, jd_, System.ComponentModel.ListSortDirection.Ascending);
					Observation jf_ = context.Operators.Last<Observation>(je_);
					DataType jg_ = jf_?.Effective;
					object jh_ = FHIRHelpers_4_3_000.ToValue(jg_);
					CqlInterval<CqlDateTime> ji_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(jh_);

					return ji_ as object;
				}
				else if (p_())
				{
					CqlValueSet li_ = this.Abnormal_Presentation();
					IEnumerable<Observation> lj_ = context.Operators.RetrieveByValueSet<Observation>(li_, default);
					bool? lk_(Observation AbnormalPresentation)
					{
						object lr_()
						{
							bool mc_()
							{
								DataType mf_ = AbnormalPresentation?.Effective;
								object mg_ = FHIRHelpers_4_3_000.ToValue(mf_);
								bool mh_ = mg_ is CqlDateTime;

								return mh_;
							};
							bool md_()
							{
								DataType mi_ = AbnormalPresentation?.Effective;
								object mj_ = FHIRHelpers_4_3_000.ToValue(mi_);
								bool mk_ = mj_ is CqlInterval<CqlDateTime>;

								return mk_;
							};
							bool me_()
							{
								DataType ml_ = AbnormalPresentation?.Effective;
								object mm_ = FHIRHelpers_4_3_000.ToValue(ml_);
								bool mn_ = mm_ is CqlDateTime;

								return mn_;
							};
							if (mc_())
							{
								DataType mo_ = AbnormalPresentation?.Effective;
								object mp_ = FHIRHelpers_4_3_000.ToValue(mo_);

								return (mp_ as CqlDateTime) as object;
							}
							else if (md_())
							{
								DataType mq_ = AbnormalPresentation?.Effective;
								object mr_ = FHIRHelpers_4_3_000.ToValue(mq_);
								CqlInterval<CqlDateTime> ms_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(mr_);

								return ms_ as object;
							}
							else if (me_())
							{
								DataType mt_ = AbnormalPresentation?.Effective;
								object mu_ = FHIRHelpers_4_3_000.ToValue(mt_);

								return (mu_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime ls_ = QICoreCommon_2_0_000.earliest(lr_());
						CqlDateTime lt_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? lu_ = context.Operators.SameOrBefore(ls_, lt_, default);
						Code<ObservationStatus> lv_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? lw_ = lv_?.Value;
						Code<ObservationStatus> lx_ = context.Operators.Convert<Code<ObservationStatus>>(lw_);
						string ly_ = context.Operators.Convert<string>(lx_);
						string[] lz_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? ma_ = context.Operators.In<string>(ly_, lz_ as IEnumerable<string>);
						bool? mb_ = context.Operators.And(lu_, ma_);

						return mb_;
					};
					IEnumerable<Observation> ll_ = context.Operators.Where<Observation>(lj_, lk_);
					object lm_(Observation @this)
					{
						object mv_()
						{
							bool mx_()
							{
								DataType na_ = @this?.Effective;
								object nb_ = FHIRHelpers_4_3_000.ToValue(na_);
								bool nc_ = nb_ is CqlDateTime;

								return nc_;
							};
							bool my_()
							{
								DataType nd_ = @this?.Effective;
								object ne_ = FHIRHelpers_4_3_000.ToValue(nd_);
								bool nf_ = ne_ is CqlInterval<CqlDateTime>;

								return nf_;
							};
							bool mz_()
							{
								DataType ng_ = @this?.Effective;
								object nh_ = FHIRHelpers_4_3_000.ToValue(ng_);
								bool ni_ = nh_ is CqlDateTime;

								return ni_;
							};
							if (mx_())
							{
								DataType nj_ = @this?.Effective;
								object nk_ = FHIRHelpers_4_3_000.ToValue(nj_);

								return (nk_ as CqlDateTime) as object;
							}
							else if (my_())
							{
								DataType nl_ = @this?.Effective;
								object nm_ = FHIRHelpers_4_3_000.ToValue(nl_);
								CqlInterval<CqlDateTime> nn_ = context.Operators.Convert<CqlInterval<CqlDateTime>>(nm_);

								return nn_ as object;
							}
							else if (mz_())
							{
								DataType no_ = @this?.Effective;
								object np_ = FHIRHelpers_4_3_000.ToValue(no_);

								return (np_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime mw_ = QICoreCommon_2_0_000.earliest(mv_());

						return mw_;
					};
					IEnumerable<Observation> ln_ = context.Operators.SortBy<Observation>(ll_, lm_, System.ComponentModel.ListSortDirection.Ascending);
					Observation lo_ = context.Operators.Last<Observation>(ln_);
					DataType lp_ = lo_?.Effective;
					object lq_ = FHIRHelpers_4_3_000.ToValue(lp_);

					return (lq_ as CqlDateTime) as object;
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
				CodeableConcept nq_ = EncounterDiagnosis?.Code;
				CqlConcept nr_ = FHIRHelpers_4_3_000.ToConcept(nq_);
				CqlValueSet ns_ = this.Abnormal_Presentation();
				bool? nt_ = context.Operators.ConceptInValueSet(nr_, ns_);

				return nt_;
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
