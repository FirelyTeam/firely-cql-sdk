using System;
using Tuples;
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
    internal Lazy<IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
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
		CqlCode[] a_ = new CqlCode[]
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
		object a_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
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

	private IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18_Value()
	{
		IEnumerable<Encounter> a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Inpatient_Encounter();
		bool? b_(Encounter EncounterInpatient)
		{
			Patient d_ = this.Patient();
			CqlDate e_ = context.Operators.Convert<CqlDate>(d_?.BirthDateElement?.Value);
			CqlInterval<CqlDateTime> f_ = FHIRHelpers_4_0_001.ToInterval(EncounterInpatient?.Period);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlDate h_ = context.Operators.DateFrom(g_);
			int? i_ = context.Operators.CalculateAgeAt(e_, h_, "year");
			bool? j_ = context.Operators.GreaterOrEqual(i_, 18);
			string k_ = context.Operators.Convert<string>(EncounterInpatient?.StatusElement);
			bool? l_ = context.Operators.Equal(k_, "finished");
			bool? m_ = context.Operators.And(j_, l_);

			return m_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Inpatient Encounter with Age Greater than or Equal to 18")]
	public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18() => 
		__Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		IEnumerable<Encounter> b_(Encounter InpatientEncounter)
		{
			CqlValueSet d_ = this.Schedule_II_and_III_Opioid_Medications();
			IEnumerable<MedicationRequest> e_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			IEnumerable<MedicationRequest> g_ = context.Operators.RetrieveByValueSet<MedicationRequest>(d_, null);
			IEnumerable<MedicationRequest> h_ = context.Operators.ListUnion<MedicationRequest>(e_, g_);
			CqlValueSet i_ = this.Schedule_IV_Benzodiazepines();
			IEnumerable<MedicationRequest> j_ = context.Operators.RetrieveByValueSet<MedicationRequest>(i_, null);
			IEnumerable<MedicationRequest> l_ = context.Operators.RetrieveByValueSet<MedicationRequest>(i_, null);
			IEnumerable<MedicationRequest> m_ = context.Operators.ListUnion<MedicationRequest>(j_, l_);
			bool? n_(MedicationRequest Medications)
			{
				bool? u_(CodeableConcept C)
				{
					CqlConcept x_ = FHIRHelpers_4_0_001.ToConcept(C);
					CqlCode y_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
					CqlConcept z_ = context.Operators.ConvertCodeToConcept(y_);
					bool? aa_ = context.Operators.Equivalent(x_, z_);

					return aa_;
				};
				IEnumerable<CodeableConcept> v_ = context.Operators.Where<CodeableConcept>((Medications?.Category as IEnumerable<CodeableConcept>), u_);
				bool? w_ = context.Operators.Exists<CodeableConcept>(v_);

				return w_;
			};
			IEnumerable<MedicationRequest> o_ = context.Operators.Where<MedicationRequest>(m_, n_);
			IEnumerable<MedicationRequest> p_ = context.Operators.ListUnion<MedicationRequest>(h_, o_);
			bool? q_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication)
			{
				CqlDateTime ab_ = FHIRHelpers_4_0_001.ToDateTime(OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement);
				CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_0_001.ToInterval(InpatientEncounter?.Period);
				bool? ad_ = context.Operators.In<CqlDateTime>(ab_, ac_, null);
				string ae_ = context.Operators.Convert<string>(OpioidOrBenzodiazepineDischargeMedication?.StatusElement);
				bool? af_ = context.Operators.Equal(ae_, "active");
				bool? ag_ = context.Operators.And(ad_, af_);
				string ah_ = context.Operators.Convert<string>(OpioidOrBenzodiazepineDischargeMedication?.IntentElement);
				bool? ai_ = context.Operators.Equal(ah_, "plan");
				bool? aj_ = context.Operators.And(ag_, ai_);

				return aj_;
			};
			IEnumerable<MedicationRequest> r_ = context.Operators.Where<MedicationRequest>(p_, q_);
			Encounter s_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) => 
				InpatientEncounter;
			IEnumerable<Encounter> t_ = context.Operators.Select<MedicationRequest, Encounter>(r_, s_);

			return t_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public IEnumerable<Encounter> Initial_Population() => 
		__Initial_Population.Value;

	private IEnumerable<Encounter> Denominator_Value()
	{
		IEnumerable<Encounter> a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public IEnumerable<Encounter> Denominator() => 
		__Denominator.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		IEnumerable<Coding> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Encounter> Numerator_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		bool? b_(Encounter InpatientEncounter)
		{
			CqlValueSet j_ = this.Schedule_II_and_III_Opioid_Medications();
			IEnumerable<MedicationRequest> k_ = context.Operators.RetrieveByValueSet<MedicationRequest>(j_, null);
			bool? l_(MedicationRequest Opioids)
			{
				CqlDateTime r_ = FHIRHelpers_4_0_001.ToDateTime(Opioids?.AuthoredOnElement);
				CqlInterval<CqlDateTime> s_ = FHIRHelpers_4_0_001.ToInterval(InpatientEncounter?.Period);
				bool? t_ = context.Operators.In<CqlDateTime>(r_, s_, null);

				return t_;
			};
			IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(k_, l_);
			object n_(MedicationRequest Opioids) => 
				Opioids?.Medication;
			IEnumerable<object> o_ = context.Operators.Select<MedicationRequest, object>(m_, n_);
			int? p_ = context.Operators.Count<object>(o_);
			bool? q_ = context.Operators.GreaterOrEqual(p_, 2);

			return q_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter InpatientEncounter)
		{
			CqlValueSet u_ = this.Schedule_II_and_III_Opioid_Medications();
			IEnumerable<MedicationRequest> v_ = context.Operators.RetrieveByValueSet<MedicationRequest>(u_, null);
			bool? w_(MedicationRequest OpioidsDischarge)
			{
				CqlDateTime aa_ = FHIRHelpers_4_0_001.ToDateTime(OpioidsDischarge?.AuthoredOnElement);
				CqlInterval<CqlDateTime> ab_ = FHIRHelpers_4_0_001.ToInterval(InpatientEncounter?.Period);
				bool? ac_ = context.Operators.In<CqlDateTime>(aa_, ab_, null);

				return ac_;
			};
			IEnumerable<MedicationRequest> x_ = context.Operators.Where<MedicationRequest>(v_, w_);
			Encounter y_(MedicationRequest OpioidsDischarge) => 
				InpatientEncounter;
			IEnumerable<Encounter> z_ = context.Operators.Select<MedicationRequest, Encounter>(x_, y_);

			return z_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_(Encounter InpatientEncounter)
		{
			CqlValueSet ad_ = this.Schedule_IV_Benzodiazepines();
			IEnumerable<MedicationRequest> ae_ = context.Operators.RetrieveByValueSet<MedicationRequest>(ad_, null);
			bool? af_(MedicationRequest BenzodiazepinesDischarge)
			{
				CqlDateTime aj_ = FHIRHelpers_4_0_001.ToDateTime(BenzodiazepinesDischarge?.AuthoredOnElement);
				CqlInterval<CqlDateTime> ak_ = FHIRHelpers_4_0_001.ToInterval(InpatientEncounter?.Period);
				bool? al_ = context.Operators.In<CqlDateTime>(aj_, ak_, null);

				return al_;
			};
			IEnumerable<MedicationRequest> ag_ = context.Operators.Where<MedicationRequest>(ae_, af_);
			Encounter ah_(MedicationRequest BenzodiazepinesDischarge) => 
				InpatientEncounter;
			IEnumerable<Encounter> ai_ = context.Operators.Select<MedicationRequest, Encounter>(ag_, ah_);

			return ai_;
		};
		IEnumerable<Encounter> h_ = context.Operators.SelectMany<Encounter, Encounter>(f_, g_);
		IEnumerable<Encounter> i_ = context.Operators.ListUnion<Encounter>(c_, h_);

		return i_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Denominator_Exclusion_Value()
	{
		IEnumerable<Encounter> a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		bool? b_(Encounter InpatientEncounter)
		{
			CqlValueSet f_ = this.All_Primary_and_Secondary_Cancer();
			IEnumerable<Condition> g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
			bool? h_(Condition Cancer)
			{
				CqlInterval<CqlDateTime> ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Cancer);
				CqlInterval<CqlDateTime> ac_ = FHIRHelpers_4_0_001.ToInterval(InpatientEncounter?.Period);
				bool? ad_ = context.Operators.Overlaps(ab_, ac_, null);

				return ad_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			bool? j_ = context.Operators.Exists<Condition>(i_);
			CqlValueSet k_ = this.Palliative_or_Hospice_Care();
			IEnumerable<ServiceRequest> l_ = context.Operators.RetrieveByValueSet<ServiceRequest>(k_, null);
			bool? m_(ServiceRequest PalliativeOrHospiceCareOrder)
			{
				CqlDateTime ae_ = FHIRHelpers_4_0_001.ToDateTime(PalliativeOrHospiceCareOrder?.AuthoredOnElement);
				CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_0_001.ToInterval(InpatientEncounter?.Period);
				bool? ag_ = context.Operators.In<CqlDateTime>(ae_, af_, null);
				string ah_ = context.Operators.Convert<string>(PalliativeOrHospiceCareOrder?.IntentElement);
				bool? ai_ = context.Operators.Equal(ah_, "order");
				bool? aj_ = context.Operators.And(ag_, ai_);

				return aj_;
			};
			IEnumerable<ServiceRequest> n_ = context.Operators.Where<ServiceRequest>(l_, m_);
			bool? o_ = context.Operators.Exists<ServiceRequest>(n_);
			bool? p_ = context.Operators.Or(j_, o_);
			IEnumerable<Procedure> r_ = context.Operators.RetrieveByValueSet<Procedure>(k_, null);
			bool? s_(Procedure PalliativeOrHospiceCarePerformed)
			{
				CqlInterval<CqlDateTime> ak_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(PalliativeOrHospiceCarePerformed?.Performed);
				CqlInterval<CqlDateTime> al_ = FHIRHelpers_4_0_001.ToInterval(InpatientEncounter?.Period);
				bool? am_ = context.Operators.Overlaps(ak_, al_, null);

				return am_;
			};
			IEnumerable<Procedure> t_ = context.Operators.Where<Procedure>(r_, s_);
			bool? u_ = context.Operators.Exists<Procedure>(t_);
			bool? v_ = context.Operators.Or(p_, u_);
			IEnumerable<Encounter> w_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
			bool? x_(Encounter InpatientEncounter)
			{
				CqlConcept an_ = FHIRHelpers_4_0_001.ToConcept(InpatientEncounter?.Hospitalization?.DischargeDisposition);
				CqlValueSet ao_ = this.Discharge_To_Acute_Care_Facility();
				bool? ap_ = context.Operators.ConceptInValueSet(an_, ao_);
				CqlValueSet ar_ = this.Hospice_Care_Referral_or_Admission();
				bool? as_ = context.Operators.ConceptInValueSet(an_, ar_);
				bool? at_ = context.Operators.Or(ap_, as_);
				CqlValueSet av_ = this.Patient_Expired();
				bool? aw_ = context.Operators.ConceptInValueSet(an_, av_);
				bool? ax_ = context.Operators.Or(at_, aw_);

				return ax_;
			};
			IEnumerable<Encounter> y_ = context.Operators.Where<Encounter>(w_, x_);
			bool? z_ = context.Operators.Exists<Encounter>(y_);
			bool? aa_ = context.Operators.Or(v_, z_);

			return aa_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		Encounter d_(Encounter InpatientEncounter) => 
			InpatientEncounter;
		IEnumerable<Encounter> e_ = context.Operators.Select<Encounter, Encounter>(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public IEnumerable<Encounter> Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

}
