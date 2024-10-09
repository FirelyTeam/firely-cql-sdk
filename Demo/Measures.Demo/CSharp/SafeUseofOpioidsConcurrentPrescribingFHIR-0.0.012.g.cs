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
    internal Lazy<IEnumerable<(CodeableConcept code, Period period)?>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<(CodeableConcept code, Period period)?>>(this.SDE_Payer_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161", default);

    [CqlDeclaration("All Primary and Secondary Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161")]
	public CqlValueSet All_Primary_and_Secondary_Cancer() => 
		__All_Primary_and_Secondary_Cancer.Value;

	private CqlValueSet Discharge_To_Acute_Care_Facility_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", default);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
	public CqlValueSet Discharge_To_Acute_Care_Facility() => 
		__Discharge_To_Acute_Care_Facility.Value;

	private CqlValueSet Encounter_Inpatient_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", default);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
	public CqlValueSet Encounter_Inpatient() => 
		__Encounter_Inpatient.Value;

	private CqlValueSet Hospice_Care_Referral_or_Admission_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", default);

    [CqlDeclaration("Hospice Care Referral or Admission")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365")]
	public CqlValueSet Hospice_Care_Referral_or_Admission() => 
		__Hospice_Care_Referral_or_Admission.Value;

	private CqlValueSet Palliative_or_Hospice_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", default);

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
	public CqlValueSet Palliative_or_Hospice_Care() => 
		__Palliative_or_Hospice_Care.Value;

	private CqlValueSet Patient_Expired_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", default);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
	public CqlValueSet Patient_Expired() => 
		__Patient_Expired.Value;

	private CqlValueSet Schedule_II_and_III_Opioid_Medications_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165", default);

    [CqlDeclaration("Schedule II & III Opioid Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165")]
	public CqlValueSet Schedule_II_and_III_Opioid_Medications() => 
		__Schedule_II_and_III_Opioid_Medications.Value;

	private CqlValueSet Schedule_IV_Benzodiazepines_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", default);

    [CqlDeclaration("Schedule IV Benzodiazepines")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1")]
	public CqlValueSet Schedule_IV_Benzodiazepines() => 
		__Schedule_IV_Benzodiazepines.Value;

	private CqlCode Birth_date_Value() => 
		new CqlCode("21112-8", "http://loinc.org", default, default);

    [CqlDeclaration("Birth date")]
	public CqlCode Birth_date() => 
		__Birth_date.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("21112-8", "http://loinc.org", default, default),
		];

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
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
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
			Date e_ = d_?.BirthDateElement;
			string f_ = e_?.Value;
			CqlDate g_ = context.Operators.ConvertStringToDate(f_);
			Period h_ = EncounterInpatient?.Period;
			CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_0_001.ToInterval(h_);
			CqlDateTime j_ = context.Operators.Start(i_);
			CqlDate k_ = context.Operators.DateFrom(j_);
			int? l_ = context.Operators.CalculateAgeAt(g_, k_, "year");
			bool? m_ = context.Operators.GreaterOrEqual(l_, 18);
			Code<Encounter.EncounterStatus> n_ = EncounterInpatient?.StatusElement;
			string o_ = FHIRHelpers_4_0_001.ToString(n_);
			bool? p_ = context.Operators.Equal(o_, "finished");
			bool? q_ = context.Operators.And(m_, p_);

			return q_;
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
			IEnumerable<MedicationRequest> e_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
			IEnumerable<MedicationRequest> g_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, d_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
			IEnumerable<MedicationRequest> h_ = context.Operators.Union<MedicationRequest>(e_, g_);
			CqlValueSet i_ = this.Schedule_IV_Benzodiazepines();
			IEnumerable<MedicationRequest> j_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
			IEnumerable<MedicationRequest> l_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, i_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
			IEnumerable<MedicationRequest> m_ = context.Operators.Union<MedicationRequest>(j_, l_);
			bool? n_(MedicationRequest Medications)
			{
				List<CodeableConcept> u_ = Medications?.Category;
				bool? v_(CodeableConcept C)
				{
					CqlConcept y_ = FHIRHelpers_4_0_001.ToConcept(C);
					CqlCode z_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
					CqlConcept aa_ = context.Operators.ConvertCodeToConcept(z_);
					bool? ab_ = context.Operators.Equivalent(y_, aa_);

					return ab_;
				};
				IEnumerable<CodeableConcept> w_ = context.Operators.Where<CodeableConcept>((IEnumerable<CodeableConcept>)u_, v_);
				bool? x_ = context.Operators.Exists<CodeableConcept>(w_);

				return x_;
			};
			IEnumerable<MedicationRequest> o_ = context.Operators.Where<MedicationRequest>(m_, n_);
			IEnumerable<MedicationRequest> p_ = context.Operators.Union<MedicationRequest>(h_, o_);
			bool? q_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication)
			{
				FhirDateTime ac_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
				CqlDateTime ad_ = FHIRHelpers_4_0_001.ToDateTime(ac_);
				Period ae_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> af_ = FHIRHelpers_4_0_001.ToInterval(ae_);
				bool? ag_ = context.Operators.In<CqlDateTime>(ad_, af_, default);
				Code<MedicationRequest.MedicationrequestStatus> ah_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
				string ai_ = FHIRHelpers_4_0_001.ToString(ah_);
				bool? aj_ = context.Operators.Equal(ai_, "active");
				bool? ak_ = context.Operators.And(ag_, aj_);
				Code<MedicationRequest.MedicationRequestIntent> al_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
				string am_ = FHIRHelpers_4_0_001.ToString(al_);
				bool? an_ = context.Operators.Equal(am_, "plan");
				bool? ao_ = context.Operators.And(ak_, an_);

				return ao_;
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

	private IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer_Value()
	{
		IEnumerable<(CodeableConcept code, Period period)?> a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer() => 
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
			IEnumerable<MedicationRequest> k_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, j_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
			bool? l_(MedicationRequest Opioids)
			{
				FhirDateTime r_ = Opioids?.AuthoredOnElement;
				CqlDateTime s_ = FHIRHelpers_4_0_001.ToDateTime(r_);
				Period t_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_0_001.ToInterval(t_);
				bool? v_ = context.Operators.In<CqlDateTime>(s_, u_, default);

				return v_;
			};
			IEnumerable<MedicationRequest> m_ = context.Operators.Where<MedicationRequest>(k_, l_);
			object n_(MedicationRequest Opioids)
			{
				DataType w_ = Opioids?.Medication;

				return w_;
			};
			IEnumerable<object> o_ = context.Operators.Select<MedicationRequest, object>(m_, n_);
			int? p_ = context.Operators.Count<object>(o_);
			bool? q_ = context.Operators.GreaterOrEqual(p_, 2);

			return q_;
		};
		IEnumerable<Encounter> c_ = context.Operators.Where<Encounter>(a_, b_);
		IEnumerable<Encounter> e_(Encounter InpatientEncounter)
		{
			CqlValueSet x_ = this.Schedule_II_and_III_Opioid_Medications();
			IEnumerable<MedicationRequest> y_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
			bool? z_(MedicationRequest OpioidsDischarge)
			{
				FhirDateTime ad_ = OpioidsDischarge?.AuthoredOnElement;
				CqlDateTime ae_ = FHIRHelpers_4_0_001.ToDateTime(ad_);
				Period af_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ag_ = FHIRHelpers_4_0_001.ToInterval(af_);
				bool? ah_ = context.Operators.In<CqlDateTime>(ae_, ag_, default);

				return ah_;
			};
			IEnumerable<MedicationRequest> aa_ = context.Operators.Where<MedicationRequest>(y_, z_);
			Encounter ab_(MedicationRequest OpioidsDischarge) => 
				InpatientEncounter;
			IEnumerable<Encounter> ac_ = context.Operators.Select<MedicationRequest, Encounter>(aa_, ab_);

			return ac_;
		};
		IEnumerable<Encounter> f_ = context.Operators.SelectMany<Encounter, Encounter>(a_, e_);
		IEnumerable<Encounter> g_(Encounter InpatientEncounter)
		{
			CqlValueSet ai_ = this.Schedule_IV_Benzodiazepines();
			IEnumerable<MedicationRequest> aj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, ai_, default, "http://hl7.org/fhir/StructureDefinition/MedicationRequest"));
			bool? ak_(MedicationRequest BenzodiazepinesDischarge)
			{
				FhirDateTime ao_ = BenzodiazepinesDischarge?.AuthoredOnElement;
				CqlDateTime ap_ = FHIRHelpers_4_0_001.ToDateTime(ao_);
				Period aq_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_0_001.ToInterval(aq_);
				bool? as_ = context.Operators.In<CqlDateTime>(ap_, ar_, default);

				return as_;
			};
			IEnumerable<MedicationRequest> al_ = context.Operators.Where<MedicationRequest>(aj_, ak_);
			Encounter am_(MedicationRequest BenzodiazepinesDischarge) => 
				InpatientEncounter;
			IEnumerable<Encounter> an_ = context.Operators.Select<MedicationRequest, Encounter>(al_, am_);

			return an_;
		};
		IEnumerable<Encounter> h_ = context.Operators.SelectMany<Encounter, Encounter>(f_, g_);
		IEnumerable<Encounter> i_ = context.Operators.Union<Encounter>(c_, h_);

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
			IEnumerable<Condition> g_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/StructureDefinition/Condition"));
			bool? h_(Condition Cancer)
			{
				CqlInterval<CqlDateTime> ab_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Cancer);
				Period ac_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ad_ = FHIRHelpers_4_0_001.ToInterval(ac_);
				bool? ae_ = context.Operators.Overlaps(ab_, ad_, default);

				return ae_;
			};
			IEnumerable<Condition> i_ = context.Operators.Where<Condition>(g_, h_);
			bool? j_ = context.Operators.Exists<Condition>(i_);
			CqlValueSet k_ = this.Palliative_or_Hospice_Care();
			IEnumerable<ServiceRequest> l_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/StructureDefinition/ServiceRequest"));
			bool? m_(ServiceRequest PalliativeOrHospiceCareOrder)
			{
				FhirDateTime af_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
				CqlDateTime ag_ = FHIRHelpers_4_0_001.ToDateTime(af_);
				Period ah_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ai_ = FHIRHelpers_4_0_001.ToInterval(ah_);
				bool? aj_ = context.Operators.In<CqlDateTime>(ag_, ai_, default);
				Code<RequestIntent> ak_ = PalliativeOrHospiceCareOrder?.IntentElement;
				string al_ = FHIRHelpers_4_0_001.ToString(ak_);
				bool? am_ = context.Operators.Equal(al_, "order");
				bool? an_ = context.Operators.And(aj_, am_);

				return an_;
			};
			IEnumerable<ServiceRequest> n_ = context.Operators.Where<ServiceRequest>(l_, m_);
			bool? o_ = context.Operators.Exists<ServiceRequest>(n_);
			bool? p_ = context.Operators.Or(j_, o_);
			IEnumerable<Procedure> r_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, k_, default, "http://hl7.org/fhir/StructureDefinition/Procedure"));
			bool? s_(Procedure PalliativeOrHospiceCarePerformed)
			{
				DataType ao_ = PalliativeOrHospiceCarePerformed?.Performed;
				CqlInterval<CqlDateTime> ap_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(ao_);
				Period aq_ = InpatientEncounter?.Period;
				CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_0_001.ToInterval(aq_);
				bool? as_ = context.Operators.Overlaps(ap_, ar_, default);

				return as_;
			};
			IEnumerable<Procedure> t_ = context.Operators.Where<Procedure>(r_, s_);
			bool? u_ = context.Operators.Exists<Procedure>(t_);
			bool? v_ = context.Operators.Or(p_, u_);
			IEnumerable<Encounter> w_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
			bool? x_(Encounter InpatientEncounter)
			{
				Encounter.HospitalizationComponent at_ = InpatientEncounter?.Hospitalization;
				CodeableConcept au_ = at_?.DischargeDisposition;
				CqlConcept av_ = FHIRHelpers_4_0_001.ToConcept(au_);
				CqlValueSet aw_ = this.Discharge_To_Acute_Care_Facility();
				bool? ax_ = context.Operators.ConceptInValueSet(av_, aw_);
				CodeableConcept az_ = at_?.DischargeDisposition;
				CqlConcept ba_ = FHIRHelpers_4_0_001.ToConcept(az_);
				CqlValueSet bb_ = this.Hospice_Care_Referral_or_Admission();
				bool? bc_ = context.Operators.ConceptInValueSet(ba_, bb_);
				bool? bd_ = context.Operators.Or(ax_, bc_);
				CodeableConcept bf_ = at_?.DischargeDisposition;
				CqlConcept bg_ = FHIRHelpers_4_0_001.ToConcept(bf_);
				CqlValueSet bh_ = this.Patient_Expired();
				bool? bi_ = context.Operators.ConceptInValueSet(bg_, bh_);
				bool? bj_ = context.Operators.Or(bd_, bi_);

				return bj_;
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
