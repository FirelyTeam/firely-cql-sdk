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
[CqlLibrary("SafeUseofOpioidsConcurrentPrescribingFHIR", "0.0.012")]
public class SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __All_Primary_and_Secondary_Cancer;
    internal Lazy<CqlValueSet> __Discharge_To_Acute_Care_Facility;
    internal Lazy<CqlValueSet> __Encounter_Inpatient;
    internal Lazy<CqlValueSet> __Hospice_Care_Referral_or_Admission;
    internal Lazy<CqlValueSet> __Palliative_or_Hospice_Care;
    internal Lazy<CqlValueSet> __Patient_Expired;
    internal Lazy<CqlValueSet> __Schedule_II_and_III_Opioid_Medications;
    internal Lazy<CqlValueSet> __Schedule_IV_Benzodiazepines;
    internal Lazy<CqlCode> __Birth_date;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Encounter>> __Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18;
    internal Lazy<IEnumerable<Encounter>> __Initial_Population;
    internal Lazy<IEnumerable<Encounter>> __Denominator;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_CaKghTfWMNOTHSWhifjFZOVYO>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Encounter>> __Numerator;
    internal Lazy<IEnumerable<Encounter>> __Denominator_Exclusion;

    #endregion
    public SafeUseofOpioidsConcurrentPrescribingFHIR_0_0_012(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);
        SupplementalDataElementsFHIR4_2_0_000 = new SupplementalDataElementsFHIR4_2_0_000(context);
        MATGlobalCommonFunctionsFHIR4_6_1_000 = new MATGlobalCommonFunctionsFHIR4_6_1_000(context);

        __All_Primary_and_Secondary_Cancer = new Lazy<CqlValueSet>(this.All_Primary_and_Secondary_Cancer_Value);
        __Discharge_To_Acute_Care_Facility = new Lazy<CqlValueSet>(this.Discharge_To_Acute_Care_Facility_Value);
        __Encounter_Inpatient = new Lazy<CqlValueSet>(this.Encounter_Inpatient_Value);
        __Hospice_Care_Referral_or_Admission = new Lazy<CqlValueSet>(this.Hospice_Care_Referral_or_Admission_Value);
        __Palliative_or_Hospice_Care = new Lazy<CqlValueSet>(this.Palliative_or_Hospice_Care_Value);
        __Patient_Expired = new Lazy<CqlValueSet>(this.Patient_Expired_Value);
        __Schedule_II_and_III_Opioid_Medications = new Lazy<CqlValueSet>(this.Schedule_II_and_III_Opioid_Medications_Value);
        __Schedule_IV_Benzodiazepines = new Lazy<CqlValueSet>(this.Schedule_IV_Benzodiazepines_Value);
        __Birth_date = new Lazy<CqlCode>(this.Birth_date_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18 = new Lazy<IEnumerable<Encounter>>(this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18_Value);
        __Initial_Population = new Lazy<IEnumerable<Encounter>>(this.Initial_Population_Value);
        __Denominator = new Lazy<IEnumerable<Encounter>>(this.Denominator_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_CaKghTfWMNOTHSWhifjFZOVYO>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Numerator = new Lazy<IEnumerable<Encounter>>(this.Numerator_Value);
        __Denominator_Exclusion = new Lazy<IEnumerable<Encounter>>(this.Denominator_Exclusion_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }
    public SupplementalDataElementsFHIR4_2_0_000 SupplementalDataElementsFHIR4_2_0_000 { get; }
    public MATGlobalCommonFunctionsFHIR4_6_1_000 MATGlobalCommonFunctionsFHIR4_6_1_000 { get; }

    #endregion

	private CqlValueSet All_Primary_and_Secondary_Cancer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161", null);

    [CqlDeclaration("All Primary and Secondary Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161")]
	public CqlValueSet All_Primary_and_Secondary_Cancer() => 
		__All_Primary_and_Secondary_Cancer.Value;

	private CqlValueSet Discharge_To_Acute_Care_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility() => 
		__Discharge_To_Acute_Care_Facility.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Hospice_Care_Referral_or_Admission_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);

    [CqlDeclaration("Hospice Care Referral or Admission")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365")]
	public CqlValueSet Hospice_Care_Referral_or_Admission() => 
		__Hospice_Care_Referral_or_Admission.Value;

	private CqlValueSet Palliative_or_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
	public CqlValueSet Palliative_or_Hospice_Care() => 
		__Palliative_or_Hospice_Care.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Schedule_II_and_III_Opioid_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165", null);

    [CqlDeclaration("Schedule II & III Opioid Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165")]
	public CqlValueSet Schedule_II_and_III_Opioid_Medications() => 
		__Schedule_II_and_III_Opioid_Medications.Value;

	private CqlValueSet Schedule_IV_Benzodiazepines_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", null);

    [CqlDeclaration("Schedule IV Benzodiazepines")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1")]
	public CqlValueSet Schedule_IV_Benzodiazepines() => 
		__Schedule_IV_Benzodiazepines.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21112-8", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
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

	private IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18_Value()
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Inpatient_Encounter();
		bool? b_(Encounter EncounterInpatient)
		{
			var d_ = this.Patient();
			var e_ = d_?.BirthDateElement;
			var f_ = e_?.Value;
			var g_ = context.Operators.Convert<CqlDate>(f_);
			var h_ = EncounterInpatient?.Period;
			var i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			var j_ = context.Operators.Start(i_);
			var k_ = context.Operators.DateFrom(j_);
			var l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
			var m_ = context.Operators.GreaterOrEqual(l_, 18);
			var n_ = EncounterInpatient?.StatusElement;
			var o_ = FHIRHelpers_4_0_001.ToString(n_);
			var p_ = context.Operators.Equal(o_, "finished");
			var q_ = context.Operators.And(m_, p_);

			return q_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Inpatient Encounter with Age Greater than or Equal to 18")]
	public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18() => 
		__Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		IEnumerable<Encounter> b_(Encounter InpatientEncounter)
		{
			var d_ = this.Schedule_II_and_III_Opioid_Medications();
			var e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			var h_ = context.Operators.Union<MedicationRequest>(e_, g_);
			var i_ = this.Schedule_IV_Benzodiazepines();
			var j_ = context.Operators.RetrieveByValueSet<MedicationRequest>(i_, null);
			var l_ = context.Operators.RetrieveByValueSet<MedicationRequest>(i_, null);
			var m_ = context.Operators.Union<MedicationRequest>(j_, l_);
			bool? n_(MedicationRequest Medications)
			{
				var u_ = Medications?.Category;
				bool? v_(CodeableConcept C)
				{
					var y_ = FHIRHelpers_4_0_001.ToConcept(C);
					var z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
					var aa_ = context.Operators.ConvertCodeToConcept(z_);
					var ab_ = context.Operators.Equivalent(y_, aa_);

					return ab_;
				};
				var w_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)u_, v_);
				var x_ = context.Operators.Exists<CodeableConcept>(w_);

				return x_;
			};
			var o_ = context.Operators.Where<MedicationRequest>(m_, n_);
			var p_ = context.Operators.Union<MedicationRequest>(h_, o_);
			bool? q_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication)
			{
				var ac_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
				var ad_ = FHIRHelpers_4_0_001.ToDateTime(ac_);
				var ae_ = InpatientEncounter?.Period;
				var af_ = FHIRHelpers_4_0_001.ToInterval(ae_);
				var ag_ = context.Operators.In<CqlDateTime>(ad_, af_, null);
				var ah_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
				var ai_ = FHIRHelpers_4_0_001.ToString(ah_);
				var aj_ = context.Operators.Equal(ai_, "active");
				var ak_ = context.Operators.And(ag_, aj_);
				var al_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
				var am_ = FHIRHelpers_4_0_001.ToString(al_);
				var an_ = context.Operators.Equal(am_, "plan");
				var ao_ = context.Operators.And(ak_, an_);

				return ao_;
			};
			var r_ = context.Operators.Where<MedicationRequest>(p_, q_);
			Encounter s_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) => 
				InpatientEncounter;
			var t_ = context.Operators.Select<MedicationRequest, Encounter>(r_, s_);

			return t_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
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

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_CaKghTfWMNOTHSWhifjFZOVYO> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_CaKghTfWMNOTHSWhifjFZOVYO> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		bool? b_(Encounter InpatientEncounter)
		{
			var j_ = this.Schedule_II_and_III_Opioid_Medications();
			var k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(j_, null);
			bool? l_(MedicationRequest Opioids)
			{
				var r_ = Opioids?.AuthoredOnElement;
				var s_ = FHIRHelpers_4_0_001.ToDateTime(r_);
				var t_ = InpatientEncounter?.Period;
				var u_ = FHIRHelpers_4_0_001.ToInterval(t_);
				var v_ = context.Operators.In<CqlDateTime>(s_, u_, null);

				return v_;
			};
			var m_ = context.Operators.Where<MedicationRequest>(k_, l_);
			object n_(MedicationRequest Opioids)
			{
				var w_ = Opioids?.Medication;

				return w_;
			};
			var o_ = context.Operators.Select<MedicationRequest, object>(m_, n_);
			var p_ = context.Operators.Count<object>(o_);
			var q_ = context.Operators.GreaterOrEqual(p_, 2);

			return q_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter InpatientEncounter)
		{
			var x_ = this.Schedule_II_and_III_Opioid_Medications();
			var y_ = context.Operators.RetrieveByValueSet<MedicationRequest>(x_, null);
			bool? z_(MedicationRequest OpioidsDischarge)
			{
				var ad_ = OpioidsDischarge?.AuthoredOnElement;
				var ae_ = FHIRHelpers_4_0_001.ToDateTime(ad_);
				var af_ = InpatientEncounter?.Period;
				var ag_ = FHIRHelpers_4_0_001.ToInterval(af_);
				var ah_ = context.Operators.In<CqlDateTime>(ae_, ag_, null);

				return ah_;
			};
			var aa_ = context.Operators.Where<MedicationRequest>(y_, z_);
			Encounter ab_(MedicationRequest OpioidsDischarge) => 
				InpatientEncounter;
			var ac_ = context.Operators.Select<MedicationRequest, Encounter>(aa_, ab_);

			return ac_;
		};
		var f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_(Encounter InpatientEncounter)
		{
			var ai_ = this.Schedule_IV_Benzodiazepines();
			var aj_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ai_, null);
			bool? ak_(MedicationRequest BenzodiazepinesDischarge)
			{
				var ao_ = BenzodiazepinesDischarge?.AuthoredOnElement;
				var ap_ = FHIRHelpers_4_0_001.ToDateTime(ao_);
				var aq_ = InpatientEncounter?.Period;
				var ar_ = FHIRHelpers_4_0_001.ToInterval(aq_);
				var as_ = context.Operators.In<CqlDateTime>(ap_, ar_, null);

				return as_;
			};
			var al_ = context.Operators.Where<MedicationRequest>(aj_, ak_);
			Encounter am_(MedicationRequest BenzodiazepinesDischarge) => 
				InpatientEncounter;
			var an_ = context.Operators.Select<MedicationRequest, Encounter>(al_, am_);

			return an_;
		};
		var h_ = context.Operators.SelectMany<Encounter, Encounter>(f_, g_);
		var i_ = context.Operators.Union<Encounter>(c_, h_);

		return i_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Denominator_Exclusion_Value()
	{
		var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		bool? b_(Encounter InpatientEncounter)
		{
			var f_ = this.All_Primary_and_Secondary_Cancer();
			var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			bool? h_(Condition Cancer)
			{
				var ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Cancer);
				var ac_ = InpatientEncounter?.Period;
				var ad_ = FHIRHelpers_4_0_001.ToInterval(ac_);
				var ae_ = context.Operators.Overlaps(ab_, ad_, null);

				return ae_;
			};
			var i_ = context.Operators.Where<Condition>(g_, h_);
			var j_ = context.Operators.Exists<Condition>(i_);
			var k_ = this.Palliative_or_Hospice_Care();
			var l_ = context.Operators.RetrieveByValueSet<ServiceRequest>(k_, null);
			bool? m_(ServiceRequest PalliativeOrHospiceCareOrder)
			{
				var af_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
				var ag_ = FHIRHelpers_4_0_001.ToDateTime(af_);
				var ah_ = InpatientEncounter?.Period;
				var ai_ = FHIRHelpers_4_0_001.ToInterval(ah_);
				var aj_ = context.Operators.In<CqlDateTime>(ag_, ai_, null);
				var ak_ = PalliativeOrHospiceCareOrder?.IntentElement;
				var al_ = FHIRHelpers_4_0_001.ToString(ak_);
				var am_ = context.Operators.Equal(al_, "order");
				var an_ = context.Operators.And(aj_, am_);

				return an_;
			};
			var n_ = context.Operators.Where<ServiceRequest>(l_, m_);
			var o_ = context.Operators.Exists<ServiceRequest>(n_);
			var p_ = context.Operators.Or(j_, o_);
			var r_ = context.Operators.RetrieveByValueSet<Procedure>(k_, null);
			bool? s_(Procedure PalliativeOrHospiceCarePerformed)
			{
				var ao_ = PalliativeOrHospiceCarePerformed?.Performed;
				var ap_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ao_);
				var aq_ = InpatientEncounter?.Period;
				var ar_ = FHIRHelpers_4_0_001.ToInterval(aq_);
				var as_ = context.Operators.Overlaps(ap_, ar_, null);

				return as_;
			};
			var t_ = context.Operators.Where<Procedure>(r_, s_);
			var u_ = context.Operators.Exists<Procedure>(t_);
			var v_ = context.Operators.Or(p_, u_);
			var w_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
			bool? x_(Encounter InpatientEncounter)
			{
				var at_ = InpatientEncounter?.Hospitalization;
				var au_ = at_?.DischargeDisposition;
				var av_ = FHIRHelpers_4_0_001.ToConcept(au_);
				var aw_ = this.Discharge_To_Acute_Care_Facility();
				var ax_ = context.Operators.ConceptInValueSet(av_, aw_);
				var az_ = at_?.DischargeDisposition;
				var ba_ = FHIRHelpers_4_0_001.ToConcept(az_);
				var bb_ = this.Hospice_Care_Referral_or_Admission();
				var bc_ = context.Operators.ConceptInValueSet(ba_, bb_);
				var bd_ = context.Operators.Or(ax_, bc_);
				var bf_ = at_?.DischargeDisposition;
				var bg_ = FHIRHelpers_4_0_001.ToConcept(bf_);
				var bh_ = this.Patient_Expired();
				var bi_ = context.Operators.ConceptInValueSet(bg_, bh_);
				var bj_ = context.Operators.Or(bd_, bi_);

				return bj_;
			};
			var y_ = context.Operators.Where<Encounter>(w_, x_);
			var z_ = context.Operators.Exists<Encounter>(y_);
			var aa_ = context.Operators.Or(v_, z_);

			return aa_;
		};
		var c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter InpatientEncounter) => 
			InpatientEncounter;
		var e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public IEnumerable<Encounter> Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

}
