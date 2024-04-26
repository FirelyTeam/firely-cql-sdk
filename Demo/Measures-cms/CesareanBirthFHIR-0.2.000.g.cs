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
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM>> __Variable_Calculated_Gestational_Age;

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
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Variable_Calculated_Gestational_Age = new Lazy<IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM>>(this.Variable_Calculated_Gestational_Age_Value);
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
		CqlCode[] a_ = new CqlCode[]
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
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
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
				CqlConcept l_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				CqlValueSet m_ = this._37_to_42_Plus_Weeks_Gestation();
				bool? n_ = context.Operators.ConceptInValueSet(l_, m_);

				return n_;
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
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);
		IEnumerable<Encounter> d_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks_Based_on_Coding();
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(c_, d_);

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
				CqlConcept h_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				CqlValueSet i_ = this.Delivery_of_Singleton();
				bool? j_ = context.Operators.ConceptInValueSet(h_, i_);

				return j_;
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
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation Gravida)
		{
			object j_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Value);
			bool? k_ = context.Operators.Not((bool?)(j_ is null));
			Code<ObservationStatus> l_ = context.Operators.Convert<Code<ObservationStatus>>(Gravida?.StatusElement?.Value);
			string m_ = context.Operators.Convert<string>(l_);
			string[] n_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? o_ = context.Operators.In<string>(m_, (n_ as IEnumerable<string>));
			bool? p_ = context.Operators.And(k_, o_);
			object q_()
			{
				bool ac_()
				{
					object af_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);
					bool ag_ = af_ is CqlDateTime;

					return ag_;
				};
				bool ad_()
				{
					object ah_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);
					bool ai_ = ah_ is CqlInterval<CqlDateTime>;

					return ai_;
				};
				bool ae_()
				{
					object aj_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);
					bool ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				if (ac_())
				{
					object al_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);

					return ((al_ as CqlDateTime) as object);
				}
				else if (ad_())
				{
					object am_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);

					return ((am_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ae_())
				{
					object an_ = FHIRHelpers_4_3_000.ToValue(Gravida?.Effective);

					return ((an_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime r_ = QICoreCommon_2_0_000.earliest(q_());
			CqlDateTime s_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity t_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime u_ = context.Operators.Subtract(s_, t_);
			CqlInterval<CqlDateTime> w_ = context.Operators.Interval(u_, s_, true, false);
			bool? x_ = context.Operators.In<CqlDateTime>(r_, w_, null);
			bool? z_ = context.Operators.Not((bool?)(s_ is null));
			bool? aa_ = context.Operators.And(x_, z_);
			bool? ab_ = context.Operators.And(p_, aa_);

			return ab_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ao_()
			{
				bool aq_()
				{
					object at_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool au_ = at_ is CqlDateTime;

					return au_;
				};
				bool ar_()
				{
					object av_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool aw_ = av_ is CqlInterval<CqlDateTime>;

					return aw_;
				};
				bool as_()
				{
					object ax_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				if (aq_())
				{
					object az_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else if (ar_())
				{
					object ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ba_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (as_())
				{
					object bb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((bb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime ap_ = QICoreCommon_2_0_000.earliest(ao_());

			return ap_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		object i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

    [CqlDeclaration("lastParity")]
	public int? lastParity(Encounter TheEncounter)
	{
		CqlCode a_ = this.____Parity();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation Parity)
		{
			object j_()
			{
				bool ac_()
				{
					object af_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);
					bool ag_ = af_ is CqlDateTime;

					return ag_;
				};
				bool ad_()
				{
					object ah_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);
					bool ai_ = ah_ is CqlInterval<CqlDateTime>;

					return ai_;
				};
				bool ae_()
				{
					object aj_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);
					bool ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				if (ac_())
				{
					object al_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);

					return ((al_ as CqlDateTime) as object);
				}
				else if (ad_())
				{
					object am_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);

					return ((am_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ae_())
				{
					object an_ = FHIRHelpers_4_3_000.ToValue(Parity?.Effective);

					return ((an_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime k_ = QICoreCommon_2_0_000.earliest(j_());
			CqlDateTime l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity m_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(n_, l_, true, false);
			bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, null);
			bool? s_ = context.Operators.Not((bool?)(l_ is null));
			bool? t_ = context.Operators.And(q_, s_);
			Code<ObservationStatus> u_ = context.Operators.Convert<Code<ObservationStatus>>(Parity?.StatusElement?.Value);
			string v_ = context.Operators.Convert<string>(u_);
			string[] w_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? x_ = context.Operators.In<string>(v_, (w_ as IEnumerable<string>));
			bool? y_ = context.Operators.And(t_, x_);
			object z_ = FHIRHelpers_4_3_000.ToValue(Parity?.Value);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(y_, aa_);

			return ab_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ao_()
			{
				bool aq_()
				{
					object at_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool au_ = at_ is CqlDateTime;

					return au_;
				};
				bool ar_()
				{
					object av_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool aw_ = av_ is CqlInterval<CqlDateTime>;

					return aw_;
				};
				bool as_()
				{
					object ax_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				if (aq_())
				{
					object az_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else if (ar_())
				{
					object ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ba_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (as_())
				{
					object bb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((bb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime ap_ = QICoreCommon_2_0_000.earliest(ao_());

			return ap_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		object i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

    [CqlDeclaration("lastHistoryPretermBirth")]
	public int? lastHistoryPretermBirth(Encounter TheEncounter)
	{
		CqlCode a_ = this.____Births_preterm();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation PretermBirth)
		{
			object j_()
			{
				bool ac_()
				{
					object af_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);
					bool ag_ = af_ is CqlDateTime;

					return ag_;
				};
				bool ad_()
				{
					object ah_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);
					bool ai_ = ah_ is CqlInterval<CqlDateTime>;

					return ai_;
				};
				bool ae_()
				{
					object aj_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);
					bool ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				if (ac_())
				{
					object al_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);

					return ((al_ as CqlDateTime) as object);
				}
				else if (ad_())
				{
					object am_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);

					return ((am_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ae_())
				{
					object an_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Effective);

					return ((an_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime k_ = QICoreCommon_2_0_000.earliest(j_());
			CqlDateTime l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity m_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(n_, l_, true, false);
			bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, null);
			bool? s_ = context.Operators.Not((bool?)(l_ is null));
			bool? t_ = context.Operators.And(q_, s_);
			Code<ObservationStatus> u_ = context.Operators.Convert<Code<ObservationStatus>>(PretermBirth?.StatusElement?.Value);
			string v_ = context.Operators.Convert<string>(u_);
			string[] w_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? x_ = context.Operators.In<string>(v_, (w_ as IEnumerable<string>));
			bool? y_ = context.Operators.And(t_, x_);
			object z_ = FHIRHelpers_4_3_000.ToValue(PretermBirth?.Value);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(y_, aa_);

			return ab_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ao_()
			{
				bool aq_()
				{
					object at_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool au_ = at_ is CqlDateTime;

					return au_;
				};
				bool ar_()
				{
					object av_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool aw_ = av_ is CqlInterval<CqlDateTime>;

					return aw_;
				};
				bool as_()
				{
					object ax_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				if (aq_())
				{
					object az_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else if (ar_())
				{
					object ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ba_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (as_())
				{
					object bb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((bb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime ap_ = QICoreCommon_2_0_000.earliest(ao_());

			return ap_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		object i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

    [CqlDeclaration("lastHistoryTermBirth")]
	public int? lastHistoryTermBirth(Encounter TheEncounter)
	{
		CqlCode a_ = this.____Births_term();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation TermBirth)
		{
			object j_()
			{
				bool ac_()
				{
					object af_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);
					bool ag_ = af_ is CqlDateTime;

					return ag_;
				};
				bool ad_()
				{
					object ah_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);
					bool ai_ = ah_ is CqlInterval<CqlDateTime>;

					return ai_;
				};
				bool ae_()
				{
					object aj_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);
					bool ak_ = aj_ is CqlDateTime;

					return ak_;
				};
				if (ac_())
				{
					object al_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);

					return ((al_ as CqlDateTime) as object);
				}
				else if (ad_())
				{
					object am_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);

					return ((am_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (ae_())
				{
					object an_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Effective);

					return ((an_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime k_ = QICoreCommon_2_0_000.earliest(j_());
			CqlDateTime l_ = PCMaternal_5_16_000.lastTimeOfDelivery(TheEncounter);
			CqlQuantity m_ = context.Operators.Quantity(42m, "weeks");
			CqlDateTime n_ = context.Operators.Subtract(l_, m_);
			CqlInterval<CqlDateTime> p_ = context.Operators.Interval(n_, l_, true, false);
			bool? q_ = context.Operators.In<CqlDateTime>(k_, p_, null);
			bool? s_ = context.Operators.Not((bool?)(l_ is null));
			bool? t_ = context.Operators.And(q_, s_);
			Code<ObservationStatus> u_ = context.Operators.Convert<Code<ObservationStatus>>(TermBirth?.StatusElement?.Value);
			string v_ = context.Operators.Convert<string>(u_);
			string[] w_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			bool? x_ = context.Operators.In<string>(v_, (w_ as IEnumerable<string>));
			bool? y_ = context.Operators.And(t_, x_);
			object z_ = FHIRHelpers_4_3_000.ToValue(TermBirth?.Value);
			bool? aa_ = context.Operators.Not((bool?)(z_ is null));
			bool? ab_ = context.Operators.And(y_, aa_);

			return ab_;
		};
		IEnumerable<Observation> e_ = context.Operators.Where<Observation>(c_, d_);
		object f_(Observation @this)
		{
			object ao_()
			{
				bool aq_()
				{
					object at_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool au_ = at_ is CqlDateTime;

					return au_;
				};
				bool ar_()
				{
					object av_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool aw_ = av_ is CqlInterval<CqlDateTime>;

					return aw_;
				};
				bool as_()
				{
					object ax_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
					bool ay_ = ax_ is CqlDateTime;

					return ay_;
				};
				if (aq_())
				{
					object az_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((az_ as CqlDateTime) as object);
				}
				else if (ar_())
				{
					object ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((ba_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (as_())
				{
					object bb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

					return ((bb_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime ap_ = QICoreCommon_2_0_000.earliest(ao_());

			return ap_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		object i_ = FHIRHelpers_4_3_000.ToValue(h_?.Value);

		return (int?)i_;
	}

	private IEnumerable<Encounter> Singleton_Delivery_Encounters_at_37_Plus_Weeks_Gravida_1_Parity_0__No_Previous_Births_Value()
	{
		IEnumerable<Encounter> a_ = this.Delivery_Encounter_with_Gestational_Age_Greater_than_or_Equal_to_37_Weeks();
		IEnumerable<Encounter> b_ = this.Encounter_with_Singleton_Delivery();
		IEnumerable<Encounter> c_ = context.Operators.ListIntersect<Encounter>(a_, b_);
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
				bool m_()
				{
					CqlValueSet p_ = this.Abnormal_Presentation();
					IEnumerable<Observation> q_ = context.Operators.RetrieveByValueSet<Observation>(p_, null);
					bool? r_(Observation AbnormalPresentation)
					{
						object y_()
						{
							bool ah_()
							{
								object ak_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool al_ = ak_ is CqlDateTime;

								return al_;
							};
							bool ai_()
							{
								object am_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool an_ = am_ is CqlInterval<CqlDateTime>;

								return an_;
							};
							bool aj_()
							{
								object ao_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool ap_ = ao_ is CqlDateTime;

								return ap_;
							};
							if (ah_())
							{
								object aq_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((aq_ as CqlDateTime) as object);
							}
							else if (ai_())
							{
								object ar_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ar_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (aj_())
							{
								object as_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((as_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime z_ = QICoreCommon_2_0_000.earliest(y_());
						CqlDateTime aa_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? ab_ = context.Operators.SameOrBefore(z_, aa_, null);
						Code<ObservationStatus> ac_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						string ad_ = context.Operators.Convert<string>(ac_);
						string[] ae_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						bool? af_ = context.Operators.In<string>(ad_, (ae_ as IEnumerable<string>));
						bool? ag_ = context.Operators.And(ab_, af_);

						return ag_;
					};
					IEnumerable<Observation> s_ = context.Operators.Where<Observation>(q_, r_);
					object t_(Observation @this)
					{
						object at_()
						{
							bool av_()
							{
								object ay_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool az_ = ay_ is CqlDateTime;

								return az_;
							};
							bool aw_()
							{
								object ba_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool bb_ = ba_ is CqlInterval<CqlDateTime>;

								return bb_;
							};
							bool ax_()
							{
								object bc_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool bd_ = bc_ is CqlDateTime;

								return bd_;
							};
							if (av_())
							{
								object be_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((be_ as CqlDateTime) as object);
							}
							else if (aw_())
							{
								object bf_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((bf_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (ax_())
							{
								object bg_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((bg_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime au_ = QICoreCommon_2_0_000.earliest(at_());

						return au_;
					};
					IEnumerable<Observation> u_ = context.Operators.SortBy<Observation>(s_, t_, System.ComponentModel.ListSortDirection.Ascending);
					Observation v_ = context.Operators.Last<Observation>(u_);
					object w_ = FHIRHelpers_4_3_000.ToValue(v_?.Effective);
					bool x_ = w_ is CqlDateTime;

					return x_;
				};
				bool n_()
				{
					CqlValueSet bh_ = this.Abnormal_Presentation();
					IEnumerable<Observation> bi_ = context.Operators.RetrieveByValueSet<Observation>(bh_, null);
					bool? bj_(Observation AbnormalPresentation)
					{
						object bq_()
						{
							bool bz_()
							{
								object cc_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool cd_ = cc_ is CqlDateTime;

								return cd_;
							};
							bool ca_()
							{
								object ce_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool cf_ = ce_ is CqlInterval<CqlDateTime>;

								return cf_;
							};
							bool cb_()
							{
								object cg_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool ch_ = cg_ is CqlDateTime;

								return ch_;
							};
							if (bz_())
							{
								object ci_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ci_ as CqlDateTime) as object);
							}
							else if (ca_())
							{
								object cj_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((cj_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (cb_())
							{
								object ck_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ck_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime br_ = QICoreCommon_2_0_000.earliest(bq_());
						CqlDateTime bs_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? bt_ = context.Operators.SameOrBefore(br_, bs_, null);
						Code<ObservationStatus> bu_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						string bv_ = context.Operators.Convert<string>(bu_);
						string[] bw_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						bool? bx_ = context.Operators.In<string>(bv_, (bw_ as IEnumerable<string>));
						bool? by_ = context.Operators.And(bt_, bx_);

						return by_;
					};
					IEnumerable<Observation> bk_ = context.Operators.Where<Observation>(bi_, bj_);
					object bl_(Observation @this)
					{
						object cl_()
						{
							bool cn_()
							{
								object cq_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool cr_ = cq_ is CqlDateTime;

								return cr_;
							};
							bool co_()
							{
								object cs_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool ct_ = cs_ is CqlInterval<CqlDateTime>;

								return ct_;
							};
							bool cp_()
							{
								object cu_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool cv_ = cu_ is CqlDateTime;

								return cv_;
							};
							if (cn_())
							{
								object cw_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((cw_ as CqlDateTime) as object);
							}
							else if (co_())
							{
								object cx_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((cx_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (cp_())
							{
								object cy_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((cy_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime cm_ = QICoreCommon_2_0_000.earliest(cl_());

						return cm_;
					};
					IEnumerable<Observation> bm_ = context.Operators.SortBy<Observation>(bk_, bl_, System.ComponentModel.ListSortDirection.Ascending);
					Observation bn_ = context.Operators.Last<Observation>(bm_);
					object bo_ = FHIRHelpers_4_3_000.ToValue(bn_?.Effective);
					bool bp_ = bo_ is CqlInterval<CqlDateTime>;

					return bp_;
				};
				bool o_()
				{
					CqlValueSet cz_ = this.Abnormal_Presentation();
					IEnumerable<Observation> da_ = context.Operators.RetrieveByValueSet<Observation>(cz_, null);
					bool? db_(Observation AbnormalPresentation)
					{
						object di_()
						{
							bool dr_()
							{
								object du_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool dv_ = du_ is CqlDateTime;

								return dv_;
							};
							bool ds_()
							{
								object dw_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool dx_ = dw_ is CqlInterval<CqlDateTime>;

								return dx_;
							};
							bool dt_()
							{
								object dy_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool dz_ = dy_ is CqlDateTime;

								return dz_;
							};
							if (dr_())
							{
								object ea_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ea_ as CqlDateTime) as object);
							}
							else if (ds_())
							{
								object eb_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((eb_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (dt_())
							{
								object ec_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ec_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime dj_ = QICoreCommon_2_0_000.earliest(di_());
						CqlDateTime dk_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? dl_ = context.Operators.SameOrBefore(dj_, dk_, null);
						Code<ObservationStatus> dm_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						string dn_ = context.Operators.Convert<string>(dm_);
						string[] do_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						bool? dp_ = context.Operators.In<string>(dn_, (do_ as IEnumerable<string>));
						bool? dq_ = context.Operators.And(dl_, dp_);

						return dq_;
					};
					IEnumerable<Observation> dc_ = context.Operators.Where<Observation>(da_, db_);
					object dd_(Observation @this)
					{
						object ed_()
						{
							bool ef_()
							{
								object ei_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool ej_ = ei_ is CqlDateTime;

								return ej_;
							};
							bool eg_()
							{
								object ek_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool el_ = ek_ is CqlInterval<CqlDateTime>;

								return el_;
							};
							bool eh_()
							{
								object em_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool en_ = em_ is CqlDateTime;

								return en_;
							};
							if (ef_())
							{
								object eo_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((eo_ as CqlDateTime) as object);
							}
							else if (eg_())
							{
								object ep_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((ep_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (eh_())
							{
								object eq_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((eq_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime ee_ = QICoreCommon_2_0_000.earliest(ed_());

						return ee_;
					};
					IEnumerable<Observation> de_ = context.Operators.SortBy<Observation>(dc_, dd_, System.ComponentModel.ListSortDirection.Ascending);
					Observation df_ = context.Operators.Last<Observation>(de_);
					object dg_ = FHIRHelpers_4_3_000.ToValue(df_?.Effective);
					bool dh_ = dg_ is CqlDateTime;

					return dh_;
				};
				if (m_())
				{
					CqlValueSet er_ = this.Abnormal_Presentation();
					IEnumerable<Observation> es_ = context.Operators.RetrieveByValueSet<Observation>(er_, null);
					bool? et_(Observation AbnormalPresentation)
					{
						object ez_()
						{
							bool fi_()
							{
								object fl_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool fm_ = fl_ is CqlDateTime;

								return fm_;
							};
							bool fj_()
							{
								object fn_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool fo_ = fn_ is CqlInterval<CqlDateTime>;

								return fo_;
							};
							bool fk_()
							{
								object fp_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool fq_ = fp_ is CqlDateTime;

								return fq_;
							};
							if (fi_())
							{
								object fr_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((fr_ as CqlDateTime) as object);
							}
							else if (fj_())
							{
								object fs_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((fs_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (fk_())
							{
								object ft_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ft_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime fa_ = QICoreCommon_2_0_000.earliest(ez_());
						CqlDateTime fb_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? fc_ = context.Operators.SameOrBefore(fa_, fb_, null);
						Code<ObservationStatus> fd_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						string fe_ = context.Operators.Convert<string>(fd_);
						string[] ff_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						bool? fg_ = context.Operators.In<string>(fe_, (ff_ as IEnumerable<string>));
						bool? fh_ = context.Operators.And(fc_, fg_);

						return fh_;
					};
					IEnumerable<Observation> eu_ = context.Operators.Where<Observation>(es_, et_);
					object ev_(Observation @this)
					{
						object fu_()
						{
							bool fw_()
							{
								object fz_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool ga_ = fz_ is CqlDateTime;

								return ga_;
							};
							bool fx_()
							{
								object gb_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool gc_ = gb_ is CqlInterval<CqlDateTime>;

								return gc_;
							};
							bool fy_()
							{
								object gd_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool ge_ = gd_ is CqlDateTime;

								return ge_;
							};
							if (fw_())
							{
								object gf_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((gf_ as CqlDateTime) as object);
							}
							else if (fx_())
							{
								object gg_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((gg_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (fy_())
							{
								object gh_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((gh_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime fv_ = QICoreCommon_2_0_000.earliest(fu_());

						return fv_;
					};
					IEnumerable<Observation> ew_ = context.Operators.SortBy<Observation>(eu_, ev_, System.ComponentModel.ListSortDirection.Ascending);
					Observation ex_ = context.Operators.Last<Observation>(ew_);
					object ey_ = FHIRHelpers_4_3_000.ToValue(ex_?.Effective);

					return ((ey_ as CqlDateTime) as object);
				}
				else if (n_())
				{
					CqlValueSet gi_ = this.Abnormal_Presentation();
					IEnumerable<Observation> gj_ = context.Operators.RetrieveByValueSet<Observation>(gi_, null);
					bool? gk_(Observation AbnormalPresentation)
					{
						object gq_()
						{
							bool gz_()
							{
								object hc_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool hd_ = hc_ is CqlDateTime;

								return hd_;
							};
							bool ha_()
							{
								object he_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool hf_ = he_ is CqlInterval<CqlDateTime>;

								return hf_;
							};
							bool hb_()
							{
								object hg_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool hh_ = hg_ is CqlDateTime;

								return hh_;
							};
							if (gz_())
							{
								object hi_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((hi_ as CqlDateTime) as object);
							}
							else if (ha_())
							{
								object hj_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((hj_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (hb_())
							{
								object hk_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((hk_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime gr_ = QICoreCommon_2_0_000.earliest(gq_());
						CqlDateTime gs_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? gt_ = context.Operators.SameOrBefore(gr_, gs_, null);
						Code<ObservationStatus> gu_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						string gv_ = context.Operators.Convert<string>(gu_);
						string[] gw_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						bool? gx_ = context.Operators.In<string>(gv_, (gw_ as IEnumerable<string>));
						bool? gy_ = context.Operators.And(gt_, gx_);

						return gy_;
					};
					IEnumerable<Observation> gl_ = context.Operators.Where<Observation>(gj_, gk_);
					object gm_(Observation @this)
					{
						object hl_()
						{
							bool hn_()
							{
								object hq_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool hr_ = hq_ is CqlDateTime;

								return hr_;
							};
							bool ho_()
							{
								object hs_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool ht_ = hs_ is CqlInterval<CqlDateTime>;

								return ht_;
							};
							bool hp_()
							{
								object hu_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool hv_ = hu_ is CqlDateTime;

								return hv_;
							};
							if (hn_())
							{
								object hw_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((hw_ as CqlDateTime) as object);
							}
							else if (ho_())
							{
								object hx_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((hx_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (hp_())
							{
								object hy_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((hy_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime hm_ = QICoreCommon_2_0_000.earliest(hl_());

						return hm_;
					};
					IEnumerable<Observation> gn_ = context.Operators.SortBy<Observation>(gl_, gm_, System.ComponentModel.ListSortDirection.Ascending);
					Observation go_ = context.Operators.Last<Observation>(gn_);
					object gp_ = FHIRHelpers_4_3_000.ToValue(go_?.Effective);

					return ((gp_ as CqlInterval<CqlDateTime>) as object);
				}
				else if (o_())
				{
					CqlValueSet hz_ = this.Abnormal_Presentation();
					IEnumerable<Observation> ia_ = context.Operators.RetrieveByValueSet<Observation>(hz_, null);
					bool? ib_(Observation AbnormalPresentation)
					{
						object ih_()
						{
							bool iq_()
							{
								object it_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool iu_ = it_ is CqlDateTime;

								return iu_;
							};
							bool ir_()
							{
								object iv_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool iw_ = iv_ is CqlInterval<CqlDateTime>;

								return iw_;
							};
							bool is_()
							{
								object ix_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);
								bool iy_ = ix_ is CqlDateTime;

								return iy_;
							};
							if (iq_())
							{
								object iz_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((iz_ as CqlDateTime) as object);
							}
							else if (ir_())
							{
								object ja_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((ja_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (is_())
							{
								object jb_ = FHIRHelpers_4_3_000.ToValue(AbnormalPresentation?.Effective);

								return ((jb_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime ii_ = QICoreCommon_2_0_000.earliest(ih_());
						CqlDateTime ij_ = PCMaternal_5_16_000.lastTimeOfDelivery(ThirtysevenWeeksPlusEncounter);
						bool? ik_ = context.Operators.SameOrBefore(ii_, ij_, null);
						Code<ObservationStatus> il_ = context.Operators.Convert<Code<ObservationStatus>>(AbnormalPresentation?.StatusElement?.Value);
						string im_ = context.Operators.Convert<string>(il_);
						string[] in_ = new string[]
						{
							"final",
							"amended",
							"corrected",
						};
						bool? io_ = context.Operators.In<string>(im_, (in_ as IEnumerable<string>));
						bool? ip_ = context.Operators.And(ik_, io_);

						return ip_;
					};
					IEnumerable<Observation> ic_ = context.Operators.Where<Observation>(ia_, ib_);
					object id_(Observation @this)
					{
						object jc_()
						{
							bool je_()
							{
								object jh_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool ji_ = jh_ is CqlDateTime;

								return ji_;
							};
							bool jf_()
							{
								object jj_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool jk_ = jj_ is CqlInterval<CqlDateTime>;

								return jk_;
							};
							bool jg_()
							{
								object jl_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
								bool jm_ = jl_ is CqlDateTime;

								return jm_;
							};
							if (je_())
							{
								object jn_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((jn_ as CqlDateTime) as object);
							}
							else if (jf_())
							{
								object jo_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((jo_ as CqlInterval<CqlDateTime>) as object);
							}
							else if (jg_())
							{
								object jp_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);

								return ((jp_ as CqlDateTime) as object);
							}
							else
							{
								return null;
							};
						};
						CqlDateTime jd_ = QICoreCommon_2_0_000.earliest(jc_());

						return jd_;
					};
					IEnumerable<Observation> ie_ = context.Operators.SortBy<Observation>(ic_, id_, System.ComponentModel.ListSortDirection.Ascending);
					Observation if_ = context.Operators.Last<Observation>(ie_);
					object ig_ = FHIRHelpers_4_3_000.ToValue(if_?.Effective);

					return ((ig_ as CqlDateTime) as object);
				}
				else
				{
					return null;
				};
			};
			CqlDateTime e_ = QICoreCommon_2_0_000.earliest(d_());
			CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_3_000.ToInterval(ThirtysevenWeeksPlusEncounter?.Period);
			bool? g_ = context.Operators.In<CqlDateTime>(e_, f_, null);
			IEnumerable<Condition> h_ = CQMCommon_2_0_000.encounterDiagnosis(ThirtysevenWeeksPlusEncounter);
			bool? i_(Condition EncounterDiagnosis)
			{
				CqlConcept jq_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				CqlValueSet jr_ = this.Abnormal_Presentation();
				bool? js_ = context.Operators.ConceptInValueSet(jq_, jr_);

				return js_;
			};
			IEnumerable<Condition> j_ = context.Operators.Where<Condition>(h_, i_);
			bool? k_ = context.Operators.Exists<Condition>(j_);
			bool? l_ = context.Operators.Or(g_, k_);

			return l_;
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
				CqlConcept h_ = FHIRHelpers_4_3_000.ToConcept(EncounterDiagnosis?.Code);
				CqlValueSet i_ = this.Placenta_Previa_Accreta_Increta_Percreta_or_Vasa_Previa();
				bool? j_ = context.Operators.ConceptInValueSet(h_, i_);
				CqlValueSet l_ = this.Genital_Herpes();
				bool? m_ = context.Operators.ConceptInValueSet(h_, l_);
				bool? n_ = context.Operators.Or(j_, m_);

				return n_;
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
		IEnumerable<Encounter> c_ = context.Operators.ListUnion<Encounter>(a_, b_);

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
			IEnumerable<Procedure> e_ = context.Operators.RetrieveByValueSet<Procedure>(d_, null);
			bool? f_(Procedure CSection)
			{
				CqlInterval<CqlDateTime> j_ = PCMaternal_5_16_000.hospitalizationWithEDOBTriageObservation(ThirtysevenWeeksPlusEncounter);
				object k_ = FHIRHelpers_4_3_000.ToValue(CSection?.Performed);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.toInterval(k_);
				bool? m_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(j_, l_, null);
				bool? n_ = context.Operators.Equal(CSection?.StatusElement?.Value, "completed");
				bool? o_ = context.Operators.And(m_, n_);

				return o_;
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

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM> Variable_Calculated_Gestational_Age_Value()
	{
		IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM> a_ = PCMaternal_5_16_000.Variable_Calculated_Gestational_Age();

		return a_;
	}

    [CqlDeclaration("Variable Calculated Gestational Age")]
	public IEnumerable<Tuple_CDQdAjUGdePbWTVfePeZUXKFM> Variable_Calculated_Gestational_Age() => 
		__Variable_Calculated_Gestational_Age.Value;

}
