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
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
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
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? d_(Observation Gravida)
		{
			DataType k_ = Gravida?.Value;
			object l_ = FHIRHelpers_4_3_000.ToValue(k_);
			bool? m_ = context.Operators.Not((bool?)(l_ is null));
			Code<ObservationStatus> n_ = Gravida?.StatusElement;
			ObservationStatus? o_ = n_?.Value;
			Code<ObservationStatus> p_ = context.Operators.Convert<Code<ObservationStatus>>(o_);
			string q_ = context.Operators.Convert<string>(p_);
			string[] r_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? s_ = context.Operators.In<string>(q_, r_ as IEnumerable<string>);
			bool? t_ = context.Operators.And(m_, s_);
			object u_()
			{
				bool ag_()
				{
					DataType aj_ = Gravida?.Effective;
					object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
					bool al_ = ak_ is CqlDateTime;

					return al_;
				};
				bool ah_()
				{
					DataType am_ = Gravida?.Effective;
					object an_ = FHIRHelpers_4_3_000.ToValue(am_);
					bool ao_ = an_ is CqlInterval<CqlDateTime>;

					return ao_;
				};
				bool ai_()
				{
					DataType ap_ = Gravida?.Effective;
					object aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
					bool ar_ = aq_ is CqlDateTime;

					return ar_;
				};
				if (ag_())
				{
					DataType as_ = Gravida?.Effective;
					object at_ = FHIRHelpers_4_3_000.ToValue(as_);

					return (at_ as CqlDateTime) as object;
				}
				else if (ah_())
				{
					DataType au_ = Gravida?.Effective;
					object av_ = FHIRHelpers_4_3_000.ToValue(au_);

					return (av_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (ai_())
				{
					DataType aw_ = Gravida?.Effective;
					object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);

					return (ax_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime v_ = QICoreCommon_2_0_000.earliest(u_());
			CqlDateTime w_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity x_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime y_ = context.Operators.Subtract(w_, x_);
			CqlInterval<CqlDateTime> aa_ = context.Operators.Interval(y_, w_, true, false);
			bool? ab_ = context.Operators.In<CqlDateTime>(v_, aa_, default);
			bool? ad_ = context.Operators.Not((bool?)(w_ is null));
			bool? ae_ = context.Operators.And(ab_, ad_);
			bool? af_ = context.Operators.And(t_, ae_);

			return af_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ay_()
			{
				bool ba_()
				{
					DataType bd_ = @this?.Effective;
					object be_ = FHIRHelpers_4_3_000.ToValue(bd_);
					bool bf_ = be_ is CqlDateTime;

					return bf_;
				};
				bool bb_()
				{
					DataType bg_ = @this?.Effective;
					object bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
					bool bi_ = bh_ is CqlInterval<CqlDateTime>;

					return bi_;
				};
				bool bc_()
				{
					DataType bj_ = @this?.Effective;
					object bk_ = FHIRHelpers_4_3_000.ToValue(bj_);
					bool bl_ = bk_ is CqlDateTime;

					return bl_;
				};
				if (ba_())
				{
					DataType bm_ = @this?.Effective;
					object bn_ = FHIRHelpers_4_3_000.ToValue(bm_);

					return (bn_ as CqlDateTime) as object;
				}
				else if (bb_())
				{
					DataType bo_ = @this?.Effective;
					object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);

					return (bp_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (bc_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);

					return (br_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime az_ = QICoreCommon_2_0_000.earliest(ay_());

			return az_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);

		return j_ as int?;
	}

    [CqlDeclaration("lastParity")]
	public int? lastParity(Encounter TheEncounter)
	{
		CqlCode a_ = this.____Parity();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? d_(Observation Parity)
		{
			object k_()
			{
				bool ag_()
				{
					DataType aj_ = Parity?.Effective;
					object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
					bool al_ = ak_ is CqlDateTime;

					return al_;
				};
				bool ah_()
				{
					DataType am_ = Parity?.Effective;
					object an_ = FHIRHelpers_4_3_000.ToValue(am_);
					bool ao_ = an_ is CqlInterval<CqlDateTime>;

					return ao_;
				};
				bool ai_()
				{
					DataType ap_ = Parity?.Effective;
					object aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
					bool ar_ = aq_ is CqlDateTime;

					return ar_;
				};
				if (ag_())
				{
					DataType as_ = Parity?.Effective;
					object at_ = FHIRHelpers_4_3_000.ToValue(as_);

					return (at_ as CqlDateTime) as object;
				}
				else if (ah_())
				{
					DataType au_ = Parity?.Effective;
					object av_ = FHIRHelpers_4_3_000.ToValue(au_);

					return (av_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (ai_())
				{
					DataType aw_ = Parity?.Effective;
					object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);

					return (ax_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime l_ = QICoreCommon_2_0_000.earliest(k_());
			CqlDateTime m_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime o_ = context.Operators.Subtract(m_, n_);
			CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, m_, true, false);
			bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, default);
			bool? t_ = context.Operators.Not((bool?)(m_ is null));
			bool? u_ = context.Operators.And(r_, t_);
			Code<ObservationStatus> v_ = Parity?.StatusElement;
			ObservationStatus? w_ = v_?.Value;
			Code<ObservationStatus> x_ = context.Operators.Convert<Code<ObservationStatus>>(w_);
			string y_ = context.Operators.Convert<string>(x_);
			string[] z_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? aa_ = context.Operators.In<string>(y_, z_ as IEnumerable<string>);
			bool? ab_ = context.Operators.And(u_, aa_);
			DataType ac_ = Parity?.Value;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
			bool? af_ = context.Operators.And(ab_, ae_);

			return af_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ay_()
			{
				bool ba_()
				{
					DataType bd_ = @this?.Effective;
					object be_ = FHIRHelpers_4_3_000.ToValue(bd_);
					bool bf_ = be_ is CqlDateTime;

					return bf_;
				};
				bool bb_()
				{
					DataType bg_ = @this?.Effective;
					object bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
					bool bi_ = bh_ is CqlInterval<CqlDateTime>;

					return bi_;
				};
				bool bc_()
				{
					DataType bj_ = @this?.Effective;
					object bk_ = FHIRHelpers_4_3_000.ToValue(bj_);
					bool bl_ = bk_ is CqlDateTime;

					return bl_;
				};
				if (ba_())
				{
					DataType bm_ = @this?.Effective;
					object bn_ = FHIRHelpers_4_3_000.ToValue(bm_);

					return (bn_ as CqlDateTime) as object;
				}
				else if (bb_())
				{
					DataType bo_ = @this?.Effective;
					object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);

					return (bp_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (bc_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);

					return (br_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime az_ = QICoreCommon_2_0_000.earliest(ay_());

			return az_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);

		return j_ as int?;
	}

    [CqlDeclaration("lastHistoryPretermBirth")]
	public int? lastHistoryPretermBirth(Encounter TheEncounter)
	{
		CqlCode a_ = this.____Births_preterm();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? d_(Observation PretermBirth)
		{
			object k_()
			{
				bool ag_()
				{
					DataType aj_ = PretermBirth?.Effective;
					object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
					bool al_ = ak_ is CqlDateTime;

					return al_;
				};
				bool ah_()
				{
					DataType am_ = PretermBirth?.Effective;
					object an_ = FHIRHelpers_4_3_000.ToValue(am_);
					bool ao_ = an_ is CqlInterval<CqlDateTime>;

					return ao_;
				};
				bool ai_()
				{
					DataType ap_ = PretermBirth?.Effective;
					object aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
					bool ar_ = aq_ is CqlDateTime;

					return ar_;
				};
				if (ag_())
				{
					DataType as_ = PretermBirth?.Effective;
					object at_ = FHIRHelpers_4_3_000.ToValue(as_);

					return (at_ as CqlDateTime) as object;
				}
				else if (ah_())
				{
					DataType au_ = PretermBirth?.Effective;
					object av_ = FHIRHelpers_4_3_000.ToValue(au_);

					return (av_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (ai_())
				{
					DataType aw_ = PretermBirth?.Effective;
					object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);

					return (ax_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime l_ = QICoreCommon_2_0_000.earliest(k_());
			CqlDateTime m_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime o_ = context.Operators.Subtract(m_, n_);
			CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, m_, true, false);
			bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, default);
			bool? t_ = context.Operators.Not((bool?)(m_ is null));
			bool? u_ = context.Operators.And(r_, t_);
			Code<ObservationStatus> v_ = PretermBirth?.StatusElement;
			ObservationStatus? w_ = v_?.Value;
			Code<ObservationStatus> x_ = context.Operators.Convert<Code<ObservationStatus>>(w_);
			string y_ = context.Operators.Convert<string>(x_);
			string[] z_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? aa_ = context.Operators.In<string>(y_, z_ as IEnumerable<string>);
			bool? ab_ = context.Operators.And(u_, aa_);
			DataType ac_ = PretermBirth?.Value;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
			bool? af_ = context.Operators.And(ab_, ae_);

			return af_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ay_()
			{
				bool ba_()
				{
					DataType bd_ = @this?.Effective;
					object be_ = FHIRHelpers_4_3_000.ToValue(bd_);
					bool bf_ = be_ is CqlDateTime;

					return bf_;
				};
				bool bb_()
				{
					DataType bg_ = @this?.Effective;
					object bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
					bool bi_ = bh_ is CqlInterval<CqlDateTime>;

					return bi_;
				};
				bool bc_()
				{
					DataType bj_ = @this?.Effective;
					object bk_ = FHIRHelpers_4_3_000.ToValue(bj_);
					bool bl_ = bk_ is CqlDateTime;

					return bl_;
				};
				if (ba_())
				{
					DataType bm_ = @this?.Effective;
					object bn_ = FHIRHelpers_4_3_000.ToValue(bm_);

					return (bn_ as CqlDateTime) as object;
				}
				else if (bb_())
				{
					DataType bo_ = @this?.Effective;
					object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);

					return (bp_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (bc_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);

					return (br_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime az_ = QICoreCommon_2_0_000.earliest(ay_());

			return az_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);

		return j_ as int?;
	}

    [CqlDeclaration("lastHistoryTermBirth")]
	public int? lastHistoryTermBirth(Encounter TheEncounter)
	{
		CqlCode a_ = this.____Births_term();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? d_(Observation TermBirth)
		{
			object k_()
			{
				bool ag_()
				{
					DataType aj_ = TermBirth?.Effective;
					object ak_ = FHIRHelpers_4_3_000.ToValue(aj_);
					bool al_ = ak_ is CqlDateTime;

					return al_;
				};
				bool ah_()
				{
					DataType am_ = TermBirth?.Effective;
					object an_ = FHIRHelpers_4_3_000.ToValue(am_);
					bool ao_ = an_ is CqlInterval<CqlDateTime>;

					return ao_;
				};
				bool ai_()
				{
					DataType ap_ = TermBirth?.Effective;
					object aq_ = FHIRHelpers_4_3_000.ToValue(ap_);
					bool ar_ = aq_ is CqlDateTime;

					return ar_;
				};
				if (ag_())
				{
					DataType as_ = TermBirth?.Effective;
					object at_ = FHIRHelpers_4_3_000.ToValue(as_);

					return (at_ as CqlDateTime) as object;
				}
				else if (ah_())
				{
					DataType au_ = TermBirth?.Effective;
					object av_ = FHIRHelpers_4_3_000.ToValue(au_);

					return (av_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (ai_())
				{
					DataType aw_ = TermBirth?.Effective;
					object ax_ = FHIRHelpers_4_3_000.ToValue(aw_);

					return (ax_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime l_ = QICoreCommon_2_0_000.earliest(k_());
			CqlDateTime m_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity n_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime o_ = context.Operators.Subtract(m_, n_);
			CqlInterval<CqlDateTime> q_ = context.Operators.Interval(o_, m_, true, false);
			bool? r_ = context.Operators.In<CqlDateTime>(l_, q_, default);
			bool? t_ = context.Operators.Not((bool?)(m_ is null));
			bool? u_ = context.Operators.And(r_, t_);
			Code<ObservationStatus> v_ = TermBirth?.StatusElement;
			ObservationStatus? w_ = v_?.Value;
			Code<ObservationStatus> x_ = context.Operators.Convert<Code<ObservationStatus>>(w_);
			string y_ = context.Operators.Convert<string>(x_);
			string[] z_ = [
				"final",
				"amended",
				"corrected",
			];
			bool? aa_ = context.Operators.In<string>(y_, z_ as IEnumerable<string>);
			bool? ab_ = context.Operators.And(u_, aa_);
			DataType ac_ = TermBirth?.Value;
			object ad_ = FHIRHelpers_4_3_000.ToValue(ac_);
			bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
			bool? af_ = context.Operators.And(ab_, ae_);

			return af_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ay_()
			{
				bool ba_()
				{
					DataType bd_ = @this?.Effective;
					object be_ = FHIRHelpers_4_3_000.ToValue(bd_);
					bool bf_ = be_ is CqlDateTime;

					return bf_;
				};
				bool bb_()
				{
					DataType bg_ = @this?.Effective;
					object bh_ = FHIRHelpers_4_3_000.ToValue(bg_);
					bool bi_ = bh_ is CqlInterval<CqlDateTime>;

					return bi_;
				};
				bool bc_()
				{
					DataType bj_ = @this?.Effective;
					object bk_ = FHIRHelpers_4_3_000.ToValue(bj_);
					bool bl_ = bk_ is CqlDateTime;

					return bl_;
				};
				if (ba_())
				{
					DataType bm_ = @this?.Effective;
					object bn_ = FHIRHelpers_4_3_000.ToValue(bm_);

					return (bn_ as CqlDateTime) as object;
				}
				else if (bb_())
				{
					DataType bo_ = @this?.Effective;
					object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);

					return (bp_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (bc_())
				{
					DataType bq_ = @this?.Effective;
					object br_ = FHIRHelpers_4_3_000.ToValue(bq_);

					return (br_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime az_ = QICoreCommon_2_0_000.earliest(ay_());

			return az_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		DataType i_ = h_?.Value;
		object j_ = FHIRHelpers_4_3_000.ToValue(i_);

		return j_ as int?;
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
					IEnumerable<Observation> r_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, q_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
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

								return (ba_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (an_())
							{
								DataType bb_ = AbnormalPresentation?.Effective;
								object bc_ = FHIRHelpers_4_3_000.ToValue(bb_);

								return (bc_ as CqlDateTime) as object;
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
						object bd_()
						{
							bool bf_()
							{
								DataType bi_ = @this?.Effective;
								object bj_ = FHIRHelpers_4_3_000.ToValue(bi_);
								bool bk_ = bj_ is CqlDateTime;

								return bk_;
							};
							bool bg_()
							{
								DataType bl_ = @this?.Effective;
								object bm_ = FHIRHelpers_4_3_000.ToValue(bl_);
								bool bn_ = bm_ is CqlInterval<CqlDateTime>;

								return bn_;
							};
							bool bh_()
							{
								DataType bo_ = @this?.Effective;
								object bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
								bool bq_ = bp_ is CqlDateTime;

								return bq_;
							};
							if (bf_())
							{
								DataType br_ = @this?.Effective;
								object bs_ = FHIRHelpers_4_3_000.ToValue(br_);

								return (bs_ as CqlDateTime) as object;
							}
							else if (bg_())
							{
								DataType bt_ = @this?.Effective;
								object bu_ = FHIRHelpers_4_3_000.ToValue(bt_);

								return (bu_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (bh_())
							{
								DataType bv_ = @this?.Effective;
								object bw_ = FHIRHelpers_4_3_000.ToValue(bv_);

								return (bw_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime be_ = QICoreCommon_2_0_000.earliest(bd_());

						return be_;
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
					CqlValueSet bx_ = this.Abnormal_Presentation();
					IEnumerable<Observation> by_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, bx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
					bool? bz_(Observation AbnormalPresentation)
					{
						object ch_()
						{
							bool cs_()
							{
								DataType cv_ = AbnormalPresentation?.Effective;
								object cw_ = FHIRHelpers_4_3_000.ToValue(cv_);
								bool cx_ = cw_ is CqlDateTime;

								return cx_;
							};
							bool ct_()
							{
								DataType cy_ = AbnormalPresentation?.Effective;
								object cz_ = FHIRHelpers_4_3_000.ToValue(cy_);
								bool da_ = cz_ is CqlInterval<CqlDateTime>;

								return da_;
							};
							bool cu_()
							{
								DataType db_ = AbnormalPresentation?.Effective;
								object dc_ = FHIRHelpers_4_3_000.ToValue(db_);
								bool dd_ = dc_ is CqlDateTime;

								return dd_;
							};
							if (cs_())
							{
								DataType de_ = AbnormalPresentation?.Effective;
								object df_ = FHIRHelpers_4_3_000.ToValue(de_);

								return (df_ as CqlDateTime) as object;
							}
							else if (ct_())
							{
								DataType dg_ = AbnormalPresentation?.Effective;
								object dh_ = FHIRHelpers_4_3_000.ToValue(dg_);

								return (dh_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (cu_())
							{
								DataType di_ = AbnormalPresentation?.Effective;
								object dj_ = FHIRHelpers_4_3_000.ToValue(di_);

								return (dj_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime ci_ = QICoreCommon_2_0_000.earliest(ch_());
						CqlDateTime cj_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? ck_ = context.Operators.SameOrBefore(ci_, cj_, default);
						Code<ObservationStatus> cl_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? cm_ = cl_?.Value;
						Code<ObservationStatus> cn_ = context.Operators.Convert<Code<ObservationStatus>>(cm_);
						string co_ = context.Operators.Convert<string>(cn_);
						string[] cp_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? cq_ = context.Operators.In<string>(co_, cp_ as IEnumerable<string>);
						bool? cr_ = context.Operators.And(ck_, cq_);

						return cr_;
					};
					IEnumerable<Observation> ca_ = context.Operators.Where<Observation>(by_, bz_);
					object cb_(Observation @this)
					{
						object dk_()
						{
							bool dm_()
							{
								DataType dp_ = @this?.Effective;
								object dq_ = FHIRHelpers_4_3_000.ToValue(dp_);
								bool dr_ = dq_ is CqlDateTime;

								return dr_;
							};
							bool dn_()
							{
								DataType ds_ = @this?.Effective;
								object dt_ = FHIRHelpers_4_3_000.ToValue(ds_);
								bool du_ = dt_ is CqlInterval<CqlDateTime>;

								return du_;
							};
							bool do_()
							{
								DataType dv_ = @this?.Effective;
								object dw_ = FHIRHelpers_4_3_000.ToValue(dv_);
								bool dx_ = dw_ is CqlDateTime;

								return dx_;
							};
							if (dm_())
							{
								DataType dy_ = @this?.Effective;
								object dz_ = FHIRHelpers_4_3_000.ToValue(dy_);

								return (dz_ as CqlDateTime) as object;
							}
							else if (dn_())
							{
								DataType ea_ = @this?.Effective;
								object eb_ = FHIRHelpers_4_3_000.ToValue(ea_);

								return (eb_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (do_())
							{
								DataType ec_ = @this?.Effective;
								object ed_ = FHIRHelpers_4_3_000.ToValue(ec_);

								return (ed_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime dl_ = QICoreCommon_2_0_000.earliest(dk_());

						return dl_;
					};
					IEnumerable<Observation> cc_ = context.Operators.SortBy<Observation>(ca_, cb_, System.ComponentModel.ListSortDirection.Ascending);
					Observation cd_ = context.Operators.Last<Observation>(cc_);
					DataType ce_ = cd_?.Effective;
					object cf_ = FHIRHelpers_4_3_000.ToValue(ce_);
					bool cg_ = cf_ is CqlInterval<CqlDateTime>;

					return cg_;
				};
				bool p_()
				{
					CqlValueSet ee_ = this.Abnormal_Presentation();
					IEnumerable<Observation> ef_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ee_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
					bool? eg_(Observation AbnormalPresentation)
					{
						object eo_()
						{
							bool ez_()
							{
								DataType fc_ = AbnormalPresentation?.Effective;
								object fd_ = FHIRHelpers_4_3_000.ToValue(fc_);
								bool fe_ = fd_ is CqlDateTime;

								return fe_;
							};
							bool fa_()
							{
								DataType ff_ = AbnormalPresentation?.Effective;
								object fg_ = FHIRHelpers_4_3_000.ToValue(ff_);
								bool fh_ = fg_ is CqlInterval<CqlDateTime>;

								return fh_;
							};
							bool fb_()
							{
								DataType fi_ = AbnormalPresentation?.Effective;
								object fj_ = FHIRHelpers_4_3_000.ToValue(fi_);
								bool fk_ = fj_ is CqlDateTime;

								return fk_;
							};
							if (ez_())
							{
								DataType fl_ = AbnormalPresentation?.Effective;
								object fm_ = FHIRHelpers_4_3_000.ToValue(fl_);

								return (fm_ as CqlDateTime) as object;
							}
							else if (fa_())
							{
								DataType fn_ = AbnormalPresentation?.Effective;
								object fo_ = FHIRHelpers_4_3_000.ToValue(fn_);

								return (fo_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (fb_())
							{
								DataType fp_ = AbnormalPresentation?.Effective;
								object fq_ = FHIRHelpers_4_3_000.ToValue(fp_);

								return (fq_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime ep_ = QICoreCommon_2_0_000.earliest(eo_());
						CqlDateTime eq_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? er_ = context.Operators.SameOrBefore(ep_, eq_, default);
						Code<ObservationStatus> es_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? et_ = es_?.Value;
						Code<ObservationStatus> eu_ = context.Operators.Convert<Code<ObservationStatus>>(et_);
						string ev_ = context.Operators.Convert<string>(eu_);
						string[] ew_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? ex_ = context.Operators.In<string>(ev_, ew_ as IEnumerable<string>);
						bool? ey_ = context.Operators.And(er_, ex_);

						return ey_;
					};
					IEnumerable<Observation> eh_ = context.Operators.Where<Observation>(ef_, eg_);
					object ei_(Observation @this)
					{
						object fr_()
						{
							bool ft_()
							{
								DataType fw_ = @this?.Effective;
								object fx_ = FHIRHelpers_4_3_000.ToValue(fw_);
								bool fy_ = fx_ is CqlDateTime;

								return fy_;
							};
							bool fu_()
							{
								DataType fz_ = @this?.Effective;
								object ga_ = FHIRHelpers_4_3_000.ToValue(fz_);
								bool gb_ = ga_ is CqlInterval<CqlDateTime>;

								return gb_;
							};
							bool fv_()
							{
								DataType gc_ = @this?.Effective;
								object gd_ = FHIRHelpers_4_3_000.ToValue(gc_);
								bool ge_ = gd_ is CqlDateTime;

								return ge_;
							};
							if (ft_())
							{
								DataType gf_ = @this?.Effective;
								object gg_ = FHIRHelpers_4_3_000.ToValue(gf_);

								return (gg_ as CqlDateTime) as object;
							}
							else if (fu_())
							{
								DataType gh_ = @this?.Effective;
								object gi_ = FHIRHelpers_4_3_000.ToValue(gh_);

								return (gi_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (fv_())
							{
								DataType gj_ = @this?.Effective;
								object gk_ = FHIRHelpers_4_3_000.ToValue(gj_);

								return (gk_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime fs_ = QICoreCommon_2_0_000.earliest(fr_());

						return fs_;
					};
					IEnumerable<Observation> ej_ = context.Operators.SortBy<Observation>(eh_, ei_, System.ComponentModel.ListSortDirection.Ascending);
					Observation ek_ = context.Operators.Last<Observation>(ej_);
					DataType el_ = ek_?.Effective;
					object em_ = FHIRHelpers_4_3_000.ToValue(el_);
					bool en_ = em_ is CqlDateTime;

					return en_;
				};
				if (n_())
				{
					CqlValueSet gl_ = this.Abnormal_Presentation();
					IEnumerable<Observation> gm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, gl_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
					bool? gn_(Observation AbnormalPresentation)
					{
						object gu_()
						{
							bool hf_()
							{
								DataType hi_ = AbnormalPresentation?.Effective;
								object hj_ = FHIRHelpers_4_3_000.ToValue(hi_);
								bool hk_ = hj_ is CqlDateTime;

								return hk_;
							};
							bool hg_()
							{
								DataType hl_ = AbnormalPresentation?.Effective;
								object hm_ = FHIRHelpers_4_3_000.ToValue(hl_);
								bool hn_ = hm_ is CqlInterval<CqlDateTime>;

								return hn_;
							};
							bool hh_()
							{
								DataType ho_ = AbnormalPresentation?.Effective;
								object hp_ = FHIRHelpers_4_3_000.ToValue(ho_);
								bool hq_ = hp_ is CqlDateTime;

								return hq_;
							};
							if (hf_())
							{
								DataType hr_ = AbnormalPresentation?.Effective;
								object hs_ = FHIRHelpers_4_3_000.ToValue(hr_);

								return (hs_ as CqlDateTime) as object;
							}
							else if (hg_())
							{
								DataType ht_ = AbnormalPresentation?.Effective;
								object hu_ = FHIRHelpers_4_3_000.ToValue(ht_);

								return (hu_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (hh_())
							{
								DataType hv_ = AbnormalPresentation?.Effective;
								object hw_ = FHIRHelpers_4_3_000.ToValue(hv_);

								return (hw_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime gv_ = QICoreCommon_2_0_000.earliest(gu_());
						CqlDateTime gw_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? gx_ = context.Operators.SameOrBefore(gv_, gw_, default);
						Code<ObservationStatus> gy_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? gz_ = gy_?.Value;
						Code<ObservationStatus> ha_ = context.Operators.Convert<Code<ObservationStatus>>(gz_);
						string hb_ = context.Operators.Convert<string>(ha_);
						string[] hc_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? hd_ = context.Operators.In<string>(hb_, hc_ as IEnumerable<string>);
						bool? he_ = context.Operators.And(gx_, hd_);

						return he_;
					};
					IEnumerable<Observation> go_ = context.Operators.Where<Observation>(gm_, gn_);
					object gp_(Observation @this)
					{
						object hx_()
						{
							bool hz_()
							{
								DataType ic_ = @this?.Effective;
								object id_ = FHIRHelpers_4_3_000.ToValue(ic_);
								bool ie_ = id_ is CqlDateTime;

								return ie_;
							};
							bool ia_()
							{
								DataType if_ = @this?.Effective;
								object ig_ = FHIRHelpers_4_3_000.ToValue(if_);
								bool ih_ = ig_ is CqlInterval<CqlDateTime>;

								return ih_;
							};
							bool ib_()
							{
								DataType ii_ = @this?.Effective;
								object ij_ = FHIRHelpers_4_3_000.ToValue(ii_);
								bool ik_ = ij_ is CqlDateTime;

								return ik_;
							};
							if (hz_())
							{
								DataType il_ = @this?.Effective;
								object im_ = FHIRHelpers_4_3_000.ToValue(il_);

								return (im_ as CqlDateTime) as object;
							}
							else if (ia_())
							{
								DataType in_ = @this?.Effective;
								object io_ = FHIRHelpers_4_3_000.ToValue(in_);

								return (io_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (ib_())
							{
								DataType ip_ = @this?.Effective;
								object iq_ = FHIRHelpers_4_3_000.ToValue(ip_);

								return (iq_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime hy_ = QICoreCommon_2_0_000.earliest(hx_());

						return hy_;
					};
					IEnumerable<Observation> gq_ = context.Operators.SortBy<Observation>(go_, gp_, System.ComponentModel.ListSortDirection.Ascending);
					Observation gr_ = context.Operators.Last<Observation>(gq_);
					DataType gs_ = gr_?.Effective;
					object gt_ = FHIRHelpers_4_3_000.ToValue(gs_);

					return (gt_ as CqlDateTime) as object;
				}
				else if (o_())
				{
					CqlValueSet ir_ = this.Abnormal_Presentation();
					IEnumerable<Observation> is_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ir_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
					bool? it_(Observation AbnormalPresentation)
					{
						object ja_()
						{
							bool jl_()
							{
								DataType jo_ = AbnormalPresentation?.Effective;
								object jp_ = FHIRHelpers_4_3_000.ToValue(jo_);
								bool jq_ = jp_ is CqlDateTime;

								return jq_;
							};
							bool jm_()
							{
								DataType jr_ = AbnormalPresentation?.Effective;
								object js_ = FHIRHelpers_4_3_000.ToValue(jr_);
								bool jt_ = js_ is CqlInterval<CqlDateTime>;

								return jt_;
							};
							bool jn_()
							{
								DataType ju_ = AbnormalPresentation?.Effective;
								object jv_ = FHIRHelpers_4_3_000.ToValue(ju_);
								bool jw_ = jv_ is CqlDateTime;

								return jw_;
							};
							if (jl_())
							{
								DataType jx_ = AbnormalPresentation?.Effective;
								object jy_ = FHIRHelpers_4_3_000.ToValue(jx_);

								return (jy_ as CqlDateTime) as object;
							}
							else if (jm_())
							{
								DataType jz_ = AbnormalPresentation?.Effective;
								object ka_ = FHIRHelpers_4_3_000.ToValue(jz_);

								return (ka_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (jn_())
							{
								DataType kb_ = AbnormalPresentation?.Effective;
								object kc_ = FHIRHelpers_4_3_000.ToValue(kb_);

								return (kc_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime jb_ = QICoreCommon_2_0_000.earliest(ja_());
						CqlDateTime jc_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? jd_ = context.Operators.SameOrBefore(jb_, jc_, default);
						Code<ObservationStatus> je_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? jf_ = je_?.Value;
						Code<ObservationStatus> jg_ = context.Operators.Convert<Code<ObservationStatus>>(jf_);
						string jh_ = context.Operators.Convert<string>(jg_);
						string[] ji_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? jj_ = context.Operators.In<string>(jh_, ji_ as IEnumerable<string>);
						bool? jk_ = context.Operators.And(jd_, jj_);

						return jk_;
					};
					IEnumerable<Observation> iu_ = context.Operators.Where<Observation>(is_, it_);
					object iv_(Observation @this)
					{
						object kd_()
						{
							bool kf_()
							{
								DataType ki_ = @this?.Effective;
								object kj_ = FHIRHelpers_4_3_000.ToValue(ki_);
								bool kk_ = kj_ is CqlDateTime;

								return kk_;
							};
							bool kg_()
							{
								DataType kl_ = @this?.Effective;
								object km_ = FHIRHelpers_4_3_000.ToValue(kl_);
								bool kn_ = km_ is CqlInterval<CqlDateTime>;

								return kn_;
							};
							bool kh_()
							{
								DataType ko_ = @this?.Effective;
								object kp_ = FHIRHelpers_4_3_000.ToValue(ko_);
								bool kq_ = kp_ is CqlDateTime;

								return kq_;
							};
							if (kf_())
							{
								DataType kr_ = @this?.Effective;
								object ks_ = FHIRHelpers_4_3_000.ToValue(kr_);

								return (ks_ as CqlDateTime) as object;
							}
							else if (kg_())
							{
								DataType kt_ = @this?.Effective;
								object ku_ = FHIRHelpers_4_3_000.ToValue(kt_);

								return (ku_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (kh_())
							{
								DataType kv_ = @this?.Effective;
								object kw_ = FHIRHelpers_4_3_000.ToValue(kv_);

								return (kw_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime ke_ = QICoreCommon_2_0_000.earliest(kd_());

						return ke_;
					};
					IEnumerable<Observation> iw_ = context.Operators.SortBy<Observation>(iu_, iv_, System.ComponentModel.ListSortDirection.Ascending);
					Observation ix_ = context.Operators.Last<Observation>(iw_);
					DataType iy_ = ix_?.Effective;
					object iz_ = FHIRHelpers_4_3_000.ToValue(iy_);

					return (iz_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (p_())
				{
					CqlValueSet kx_ = this.Abnormal_Presentation();
					IEnumerable<Observation> ky_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
					bool? kz_(Observation AbnormalPresentation)
					{
						object lg_()
						{
							bool lr_()
							{
								DataType lu_ = AbnormalPresentation?.Effective;
								object lv_ = FHIRHelpers_4_3_000.ToValue(lu_);
								bool lw_ = lv_ is CqlDateTime;

								return lw_;
							};
							bool ls_()
							{
								DataType lx_ = AbnormalPresentation?.Effective;
								object ly_ = FHIRHelpers_4_3_000.ToValue(lx_);
								bool lz_ = ly_ is CqlInterval<CqlDateTime>;

								return lz_;
							};
							bool lt_()
							{
								DataType ma_ = AbnormalPresentation?.Effective;
								object mb_ = FHIRHelpers_4_3_000.ToValue(ma_);
								bool mc_ = mb_ is CqlDateTime;

								return mc_;
							};
							if (lr_())
							{
								DataType md_ = AbnormalPresentation?.Effective;
								object me_ = FHIRHelpers_4_3_000.ToValue(md_);

								return (me_ as CqlDateTime) as object;
							}
							else if (ls_())
							{
								DataType mf_ = AbnormalPresentation?.Effective;
								object mg_ = FHIRHelpers_4_3_000.ToValue(mf_);

								return (mg_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (lt_())
							{
								DataType mh_ = AbnormalPresentation?.Effective;
								object mi_ = FHIRHelpers_4_3_000.ToValue(mh_);

								return (mi_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime lh_ = QICoreCommon_2_0_000.earliest(lg_());
						CqlDateTime li_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? lj_ = context.Operators.SameOrBefore(lh_, li_, default);
						Code<ObservationStatus> lk_ = AbnormalPresentation?.StatusElement;
						ObservationStatus? ll_ = lk_?.Value;
						Code<ObservationStatus> lm_ = context.Operators.Convert<Code<ObservationStatus>>(ll_);
						string ln_ = context.Operators.Convert<string>(lm_);
						string[] lo_ = [
							"final",
							"amended",
							"corrected",
						];
						bool? lp_ = context.Operators.In<string>(ln_, lo_ as IEnumerable<string>);
						bool? lq_ = context.Operators.And(lj_, lp_);

						return lq_;
					};
					IEnumerable<Observation> la_ = context.Operators.Where<Observation>(ky_, kz_);
					object lb_(Observation @this)
					{
						object mj_()
						{
							bool ml_()
							{
								DataType mo_ = @this?.Effective;
								object mp_ = FHIRHelpers_4_3_000.ToValue(mo_);
								bool mq_ = mp_ is CqlDateTime;

								return mq_;
							};
							bool mm_()
							{
								DataType mr_ = @this?.Effective;
								object ms_ = FHIRHelpers_4_3_000.ToValue(mr_);
								bool mt_ = ms_ is CqlInterval<CqlDateTime>;

								return mt_;
							};
							bool mn_()
							{
								DataType mu_ = @this?.Effective;
								object mv_ = FHIRHelpers_4_3_000.ToValue(mu_);
								bool mw_ = mv_ is CqlDateTime;

								return mw_;
							};
							if (ml_())
							{
								DataType mx_ = @this?.Effective;
								object my_ = FHIRHelpers_4_3_000.ToValue(mx_);

								return (my_ as CqlDateTime) as object;
							}
							else if (mm_())
							{
								DataType mz_ = @this?.Effective;
								object na_ = FHIRHelpers_4_3_000.ToValue(mz_);

								return (na_ as CqlInterval<CqlDateTime>) as object;
							}
							else if (mn_())
							{
								DataType nb_ = @this?.Effective;
								object nc_ = FHIRHelpers_4_3_000.ToValue(nb_);

								return (nc_ as CqlDateTime) as object;
							}
							else
							{
								return null;
							}
						};
						CqlDateTime mk_ = QICoreCommon_2_0_000.earliest(mj_());

						return mk_;
					};
					IEnumerable<Observation> lc_ = context.Operators.SortBy<Observation>(la_, lb_, System.ComponentModel.ListSortDirection.Ascending);
					Observation ld_ = context.Operators.Last<Observation>(lc_);
					DataType le_ = ld_?.Effective;
					object lf_ = FHIRHelpers_4_3_000.ToValue(le_);

					return (lf_ as CqlDateTime) as object;
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
				CodeableConcept nd_ = EncounterDiagnosis?.Code;
				CqlConcept ne_ = FHIRHelpers_4_3_000.ToConcept(nd_);
				CqlValueSet nf_ = this.Abnormal_Presentation();
				bool? ng_ = context.Operators.ConceptInValueSet(ne_, nf_);

				return ng_;
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
			IEnumerable<Procedure> e_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
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
