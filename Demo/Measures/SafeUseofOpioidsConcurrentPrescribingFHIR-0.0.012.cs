using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
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
    public CqlValueSet All_Primary_and_Secondary_Cancer() => __All_Primary_and_Secondary_Cancer.Value;

    private CqlValueSet Discharge_To_Acute_Care_Facility_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
    public CqlValueSet Discharge_To_Acute_Care_Facility() => __Discharge_To_Acute_Care_Facility.Value;

    private CqlValueSet Encounter_Inpatient_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Hospice_Care_Referral_or_Admission_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);

    [CqlDeclaration("Hospice Care Referral or Admission")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365")]
    public CqlValueSet Hospice_Care_Referral_or_Admission() => __Hospice_Care_Referral_or_Admission.Value;

    private CqlValueSet Palliative_or_Hospice_Care_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
    public CqlValueSet Palliative_or_Hospice_Care() => __Palliative_or_Hospice_Care.Value;

    private CqlValueSet Patient_Expired_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
    public CqlValueSet Patient_Expired() => __Patient_Expired.Value;

    private CqlValueSet Schedule_II_and_III_Opioid_Medications_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165", null);

    [CqlDeclaration("Schedule II & III Opioid Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165")]
    public CqlValueSet Schedule_II_and_III_Opioid_Medications() => __Schedule_II_and_III_Opioid_Medications.Value;

    private CqlValueSet Schedule_IV_Benzodiazepines_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", null);

    [CqlDeclaration("Schedule IV Benzodiazepines")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1")]
    public CqlValueSet Schedule_IV_Benzodiazepines() => __Schedule_IV_Benzodiazepines.Value;

    private CqlCode Birth_date_Value() =>
		new CqlCode("21112-8", "http://loinc.org", null, null);

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return new CqlCode[]
		{
			a_,
		};
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", null);

		return (CqlInterval<CqlDateTime>)a_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18_Value()
	{
		var t_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Inpatient_Encounter();
		var u_ = (Encounter EncounterInpatient) =>
		{
			var a_ = this.Patient();
			var b_ = a_?.BirthDateElement;
			var c_ = b_?.Value;
			var d_ = (c_ as object);
			var e_ = context?.Operators?.TypeConverter.Convert<CqlDate>(d_);
			var f_ = EncounterInpatient?.Period;
			var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
			var h_ = context?.Operators.Start(g_);
			var i_ = context?.Operators.DateFrom(h_);
			var j_ = context?.Operators.CalculateAgeAt(e_, i_, "year");
			var k_ = j_;
			var l_ = (int?)18;
			var m_ = l_;
			var n_ = context?.Operators.GreaterOrEqual(k_, m_);
			var o_ = EncounterInpatient?.StatusElement;
			var p_ = (o_ as object);
			var q_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(p_);
			var r_ = (q_ as object);
			var s_ = context?.Operators.Equal(r_, ("finished" as object));

			return context?.Operators.And(n_, s_);
		};

		return context?.Operators.WhereOrNull<Encounter>(t_, u_);
	}

    [CqlDeclaration("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18() => __Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
	{
		var ap_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		var aq_ = (Encounter InpatientEncounter) =>
		{
			var z_ = this.Schedule_II_and_III_Opioid_Medications();
			var aa_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(z_, null);
			var ab_ = this.Schedule_II_and_III_Opioid_Medications();
			var ac_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(ab_, null);
			var ad_ = context?.Operators.ListUnion<MedicationRequest>(aa_, ac_);
			var ae_ = this.Schedule_IV_Benzodiazepines();
			var af_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(ae_, null);
			var ag_ = this.Schedule_IV_Benzodiazepines();
			var ah_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(ag_, null);
			var ai_ = context?.Operators.ListUnion<MedicationRequest>(af_, ah_);
			var aj_ = (MedicationRequest Medications) =>
			{
				var f_ = Medications?.Category;
				var g_ = (f_ as IEnumerable<CodeableConcept>);
				var h_ = (CodeableConcept C) =>
				{
					var a_ = FHIRHelpers_4_0_001.ToConcept(C);
					var b_ = (a_ as object);
					var c_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
					var d_ = context?.Operators.ConvertCodeToConcept(c_);
					var e_ = (d_ as object);

					return context?.Operators.Equivalent(b_, e_);
				};
				var i_ = context?.Operators.WhereOrNull<CodeableConcept>(g_, h_);

				return context?.Operators.ExistsInList<CodeableConcept>(i_);
			};
			var ak_ = context?.Operators.WhereOrNull<MedicationRequest>(ai_, aj_);
			var al_ = context?.Operators.ListUnion<MedicationRequest>(ad_, ak_);
			var am_ = (MedicationRequest OpioidOrBenzodiazepineDischargeMedication) =>
			{
				var j_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
				var k_ = FHIRHelpers_4_0_001.ToDateTime(j_);
				var l_ = InpatientEncounter?.Period;
				var m_ = FHIRHelpers_4_0_001.ToInterval(l_);
				var n_ = context?.Operators.ElementInInterval<CqlDateTime>(k_, m_, null);
				var o_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
				var p_ = (o_ as object);
				var q_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(p_);
				var r_ = (q_ as object);
				var s_ = context?.Operators.Equal(r_, ("active" as object));
				var t_ = context?.Operators.And(n_, s_);
				var u_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
				var v_ = (u_ as object);
				var w_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(v_);
				var x_ = (w_ as object);
				var y_ = context?.Operators.Equal(x_, ("plan" as object));

				return context?.Operators.And(t_, y_);
			};
			var an_ = context?.Operators.WhereOrNull<MedicationRequest>(al_, am_);
			var ao_ = (MedicationRequest OpioidOrBenzodiazepineDischargeMedication) => InpatientEncounter;

			return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(an_, ao_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(ap_, aq_);
	}

    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    private IEnumerable<Encounter> Denominator_Value() =>
		this.Initial_Population();

    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator() => __Denominator.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value() =>
		SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Numerator_Value()
	{
		var ah_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		var ai_ = (Encounter InpatientEncounter) =>
		{
			var f_ = this.Schedule_II_and_III_Opioid_Medications();
			var g_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(f_, null);
			var h_ = (MedicationRequest Opioids) =>
			{
				var a_ = Opioids?.AuthoredOnElement;
				var b_ = FHIRHelpers_4_0_001.ToDateTime(a_);
				var c_ = InpatientEncounter?.Period;
				var d_ = FHIRHelpers_4_0_001.ToInterval(c_);

				return context?.Operators.ElementInInterval<CqlDateTime>(b_, d_, null);
			};
			var i_ = context?.Operators.WhereOrNull<MedicationRequest>(g_, h_);
			var j_ = (MedicationRequest Opioids) =>
			{
				var e_ = Opioids?.Medication;

				return (e_ as object);
			};
			var k_ = context?.Operators.SelectOrNull<MedicationRequest, object>(i_, j_);
			var l_ = context?.Operators.CountOrNull<object>(k_);
			var m_ = l_;
			var n_ = (int?)2;
			var o_ = n_;

			return context?.Operators.GreaterOrEqual(m_, o_);
		};
		var aj_ = context?.Operators.WhereOrNull<Encounter>(ah_, ai_);
		var ak_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		var al_ = (Encounter InpatientEncounter) =>
		{
			var t_ = this.Schedule_II_and_III_Opioid_Medications();
			var u_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(t_, null);
			var v_ = (MedicationRequest OpioidsDischarge) =>
			{
				var p_ = OpioidsDischarge?.AuthoredOnElement;
				var q_ = FHIRHelpers_4_0_001.ToDateTime(p_);
				var r_ = InpatientEncounter?.Period;
				var s_ = FHIRHelpers_4_0_001.ToInterval(r_);

				return context?.Operators.ElementInInterval<CqlDateTime>(q_, s_, null);
			};
			var w_ = context?.Operators.WhereOrNull<MedicationRequest>(u_, v_);
			var x_ = (MedicationRequest OpioidsDischarge) => InpatientEncounter;

			return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(w_, x_);
		};
		var am_ = context?.Operators.SelectManyOrNull<Encounter, Encounter>(ak_, al_);
		var an_ = (Encounter InpatientEncounter) =>
		{
			var ac_ = this.Schedule_IV_Benzodiazepines();
			var ad_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(ac_, null);
			var ae_ = (MedicationRequest BenzodiazepinesDischarge) =>
			{
				var y_ = BenzodiazepinesDischarge?.AuthoredOnElement;
				var z_ = FHIRHelpers_4_0_001.ToDateTime(y_);
				var aa_ = InpatientEncounter?.Period;
				var ab_ = FHIRHelpers_4_0_001.ToInterval(aa_);

				return context?.Operators.ElementInInterval<CqlDateTime>(z_, ab_, null);
			};
			var af_ = context?.Operators.WhereOrNull<MedicationRequest>(ad_, ae_);
			var ag_ = (MedicationRequest BenzodiazepinesDischarge) => InpatientEncounter;

			return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(af_, ag_);
		};
		var ao_ = context?.Operators.SelectManyOrNull<Encounter, Encounter>(am_, an_);

		return context?.Operators.ListUnion<Encounter>(aj_, ao_);
	}

    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    private IEnumerable<Encounter> Denominator_Exclusion_Value()
	{
		var bd_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		var be_ = (Encounter InpatientEncounter) =>
		{
			var ai_ = this.All_Primary_and_Secondary_Cancer();
			var aj_ = context?.DataRetriever.RetrieveByValueSet<Condition>(ai_, null);
			var ak_ = (Condition Cancer) =>
			{
				var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Cancer);
				var b_ = InpatientEncounter?.Period;
				var c_ = FHIRHelpers_4_0_001.ToInterval(b_);

				return context?.Operators.Overlaps(a_, c_, null);
			};
			var al_ = context?.Operators.WhereOrNull<Condition>(aj_, ak_);
			var am_ = context?.Operators.ExistsInList<Condition>(al_);
			var an_ = this.Palliative_or_Hospice_Care();
			var ao_ = context?.DataRetriever.RetrieveByValueSet<ServiceRequest>(an_, null);
			var ap_ = (ServiceRequest PalliativeOrHospiceCareOrder) =>
			{
				var d_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
				var e_ = FHIRHelpers_4_0_001.ToDateTime(d_);
				var f_ = InpatientEncounter?.Period;
				var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
				var h_ = context?.Operators.ElementInInterval<CqlDateTime>(e_, g_, null);
				var i_ = PalliativeOrHospiceCareOrder?.IntentElement;
				var j_ = (i_ as object);
				var k_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(j_);
				var l_ = (k_ as object);
				var m_ = context?.Operators.Equal(l_, ("order" as object));

				return context?.Operators.And(h_, m_);
			};
			var aq_ = context?.Operators.WhereOrNull<ServiceRequest>(ao_, ap_);
			var ar_ = context?.Operators.ExistsInList<ServiceRequest>(aq_);
			var as_ = context?.Operators.Or(am_, ar_);
			var at_ = this.Palliative_or_Hospice_Care();
			var au_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(at_, null);
			var av_ = (Procedure PalliativeOrHospiceCarePerformed) =>
			{
				var n_ = PalliativeOrHospiceCarePerformed?.Performed;
				var o_ = (n_ as object);
				var p_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(o_);
				var q_ = InpatientEncounter?.Period;
				var r_ = FHIRHelpers_4_0_001.ToInterval(q_);

				return context?.Operators.Overlaps(p_, r_, null);
			};
			var aw_ = context?.Operators.WhereOrNull<Procedure>(au_, av_);
			var ax_ = context?.Operators.ExistsInList<Procedure>(aw_);
			var ay_ = context?.Operators.Or(as_, ax_);
			var az_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
			var ba_ = (Encounter InpatientEncounter) =>
			{
				var s_ = InpatientEncounter?.Hospitalization;
				var t_ = s_?.DischargeDisposition;
				var u_ = FHIRHelpers_4_0_001.ToConcept(t_);
				var v_ = this.Discharge_To_Acute_Care_Facility();
				var w_ = context?.Operators.ConceptInValueSet(u_, v_);
				var x_ = InpatientEncounter?.Hospitalization;
				var y_ = x_?.DischargeDisposition;
				var z_ = FHIRHelpers_4_0_001.ToConcept(y_);
				var aa_ = this.Hospice_Care_Referral_or_Admission();
				var ab_ = context?.Operators.ConceptInValueSet(z_, aa_);
				var ac_ = context?.Operators.Or(w_, ab_);
				var ad_ = InpatientEncounter?.Hospitalization;
				var ae_ = ad_?.DischargeDisposition;
				var af_ = FHIRHelpers_4_0_001.ToConcept(ae_);
				var ag_ = this.Patient_Expired();
				var ah_ = context?.Operators.ConceptInValueSet(af_, ag_);

				return context?.Operators.Or(ac_, ah_);
			};
			var bb_ = context?.Operators.WhereOrNull<Encounter>(az_, ba_);
			var bc_ = context?.Operators.ExistsInList<Encounter>(bb_);

			return context?.Operators.Or(ay_, bc_);
		};
		var bf_ = context?.Operators.WhereOrNull<Encounter>(bd_, be_);
		var bg_ = (Encounter InpatientEncounter) => InpatientEncounter;

		return context?.Operators.SelectOrNull<Encounter, Encounter>(bf_, bg_);
	}

    [CqlDeclaration("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion() => __Denominator_Exclusion.Value;

}