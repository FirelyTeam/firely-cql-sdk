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

    private CqlValueSet All_Primary_and_Secondary_Cancer_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161", null);

		return a_;
	}

    [CqlDeclaration("All Primary and Secondary Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.161")]
    public CqlValueSet All_Primary_and_Secondary_Cancer() => __All_Primary_and_Secondary_Cancer.Value;

    private CqlValueSet Discharge_To_Acute_Care_Facility_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87", null);

		return a_;
	}

    [CqlDeclaration("Discharge To Acute Care Facility")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.87")]
    public CqlValueSet Discharge_To_Acute_Care_Facility() => __Discharge_To_Acute_Care_Facility.Value;

    private CqlValueSet Encounter_Inpatient_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307", null);

		return a_;
	}

    [CqlDeclaration("Encounter Inpatient")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307")]
    public CqlValueSet Encounter_Inpatient() => __Encounter_Inpatient.Value;

    private CqlValueSet Hospice_Care_Referral_or_Admission_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365", null);

		return a_;
	}

    [CqlDeclaration("Hospice Care Referral or Admission")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1116.365")]
    public CqlValueSet Hospice_Care_Referral_or_Admission() => __Hospice_Care_Referral_or_Admission.Value;

    private CqlValueSet Palliative_or_Hospice_Care_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579", null);

		return a_;
	}

    [CqlDeclaration("Palliative or Hospice Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1.1579")]
    public CqlValueSet Palliative_or_Hospice_Care() => __Palliative_or_Hospice_Care.Value;

    private CqlValueSet Patient_Expired_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309", null);

		return a_;
	}

    [CqlDeclaration("Patient Expired")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.309")]
    public CqlValueSet Patient_Expired() => __Patient_Expired.Value;

    private CqlValueSet Schedule_II_and_III_Opioid_Medications_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165", null);

		return a_;
	}

    [CqlDeclaration("Schedule II & III Opioid Medications")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1111.165")]
    public CqlValueSet Schedule_II_and_III_Opioid_Medications() => __Schedule_II_and_III_Opioid_Medications.Value;

    private CqlValueSet Schedule_IV_Benzodiazepines_Value()
	{
		var a_ = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1", null);

		return a_;
	}

    [CqlDeclaration("Schedule IV Benzodiazepines")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1125.1")]
    public CqlValueSet Schedule_IV_Benzodiazepines() => __Schedule_IV_Benzodiazepines.Value;

    private CqlCode Birth_date_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);

		return a_;
	}

    [CqlDeclaration("Birth date")]
    public CqlCode Birth_date() => __Birth_date.Value;

    private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode("21112-8", "http://loinc.org", null, null);
		var b_ = new CqlCode[]
		{
			a_,
		};

		return b_;
	}

    [CqlDeclaration("LOINC")]
    public CqlCode[] LOINC() => __LOINC.Value;

    private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", null);
		var b_ = (CqlInterval<CqlDateTime>)a_;

		return b_;
	}

    [CqlDeclaration("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period() => __Measurement_Period.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18_Value()
	{
		var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Inpatient_Encounter();
		var b_ = (Encounter EncounterInpatient) =>
		{
			var e_ = this.Patient();
			var f_ = e_.BirthDateElement;
			var g_ = f_.Value;
			var h_ = context.Operators;
			var i_ = h_.TypeConverter;
			var j_ = i_.Convert<CqlDate>(g_);
			var k_ = EncounterInpatient.Period;
			var l_ = FHIRHelpers_4_0_001.ToInterval(k_);
			var n_ = h_.Start(l_);
			var p_ = h_.DateFrom(n_);
			var r_ = h_.CalculateAgeAt(j_, p_, "year");
			var s_ = r_;
			var t_ = (int?)18;
			var u_ = t_;
			var w_ = h_.GreaterOrEqual(s_, u_);
			var x_ = EncounterInpatient.StatusElement;
			var y_ = new CallStackEntry("ToString", null, null);
			var z_ = context.Deeper(y_);
			var aa_ = z_.Operators;
			var ab_ = aa_.TypeConverter;
			var ac_ = ab_.Convert<string>(x_);
			var ae_ = h_.Equal(ac_, "finished");
			var ag_ = h_.And(w_, ae_);

			return ag_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18() => __Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		var b_ = (Encounter InpatientEncounter) =>
		{
			var e_ = this.Schedule_II_and_III_Opioid_Medications();
			var f_ = context.DataRetriever;
			var g_ = f_.RetrieveByValueSet<MedicationRequest>(e_, null);
			var j_ = f_.RetrieveByValueSet<MedicationRequest>(e_, null);
			var k_ = context.Operators;
			var l_ = k_.ListUnion<MedicationRequest>(g_, j_);
			var m_ = this.Schedule_IV_Benzodiazepines();
			var o_ = f_.RetrieveByValueSet<MedicationRequest>(m_, null);
			var r_ = f_.RetrieveByValueSet<MedicationRequest>(m_, null);
			var t_ = k_.ListUnion<MedicationRequest>(o_, r_);
			var u_ = (MedicationRequest Medications) =>
			{
				var af_ = Medications.Category;
				var ag_ = (af_ as IEnumerable<CodeableConcept>);
				var ah_ = (CodeableConcept C) =>
				{
					var am_ = FHIRHelpers_4_0_001.ToConcept(C);
					var an_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
					var ao_ = context.Operators;
					var ap_ = ao_.ConvertCodeToConcept(an_);
					var ar_ = ao_.Equivalent(am_, ap_);

					return ar_;
				};
				var ai_ = context.Operators;
				var aj_ = ai_.WhereOrNull<CodeableConcept>(ag_, ah_);
				var al_ = ai_.ExistsInList<CodeableConcept>(aj_);

				return al_;
			};
			var w_ = k_.WhereOrNull<MedicationRequest>(t_, u_);
			var y_ = k_.ListUnion<MedicationRequest>(l_, w_);
			var z_ = (MedicationRequest OpioidOrBenzodiazepineDischargeMedication) =>
			{
				var as_ = OpioidOrBenzodiazepineDischargeMedication.AuthoredOnElement;
				var at_ = FHIRHelpers_4_0_001.ToDateTime(as_);
				var au_ = InpatientEncounter.Period;
				var av_ = FHIRHelpers_4_0_001.ToInterval(au_);
				var aw_ = context.Operators;
				var ax_ = aw_.ElementInInterval<CqlDateTime>(at_, av_, null);
				var ay_ = OpioidOrBenzodiazepineDischargeMedication.StatusElement;
				var az_ = new CallStackEntry("ToString", null, null);
				var ba_ = context.Deeper(az_);
				var bb_ = ba_.Operators;
				var bc_ = bb_.TypeConverter;
				var bd_ = bc_.Convert<string>(ay_);
				var bf_ = aw_.Equal(bd_, "active");
				var bh_ = aw_.And(ax_, bf_);
				var bi_ = OpioidOrBenzodiazepineDischargeMedication.IntentElement;
				var bk_ = context.Deeper(az_);
				var bl_ = bk_.Operators;
				var bm_ = bl_.TypeConverter;
				var bn_ = bm_.Convert<string>(bi_);
				var bp_ = aw_.Equal(bn_, "plan");
				var br_ = aw_.And(bh_, bp_);

				return br_;
			};
			var ab_ = k_.WhereOrNull<MedicationRequest>(y_, z_);
			var ac_ = (MedicationRequest OpioidOrBenzodiazepineDischargeMedication) => InpatientEncounter;
			var ae_ = k_.SelectOrNull<MedicationRequest, Encounter>(ab_, ac_);

			return ae_;
		};
		var c_ = context.Operators;
		var d_ = c_.SelectManyOrNull<Encounter, Encounter>(a_, b_);

		return d_;
	}

    [CqlDeclaration("Initial Population")]
    public IEnumerable<Encounter> Initial_Population() => __Initial_Population.Value;

    private IEnumerable<Encounter> Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
    public IEnumerable<Encounter> Denominator() => __Denominator.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

    private IEnumerable<Encounter> Numerator_Value()
	{
		var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		var b_ = (Encounter InpatientEncounter) =>
		{
			var n_ = this.Schedule_II_and_III_Opioid_Medications();
			var o_ = context.DataRetriever;
			var p_ = o_.RetrieveByValueSet<MedicationRequest>(n_, null);
			var q_ = (MedicationRequest Opioids) =>
			{
				var ad_ = Opioids.AuthoredOnElement;
				var ae_ = FHIRHelpers_4_0_001.ToDateTime(ad_);
				var af_ = InpatientEncounter.Period;
				var ag_ = FHIRHelpers_4_0_001.ToInterval(af_);
				var ah_ = context.Operators;
				var ai_ = ah_.ElementInInterval<CqlDateTime>(ae_, ag_, null);

				return ai_;
			};
			var r_ = context.Operators;
			var s_ = r_.WhereOrNull<MedicationRequest>(p_, q_);
			var t_ = (MedicationRequest Opioids) =>
			{
				var aj_ = Opioids.Medication;

				return aj_;
			};
			var v_ = r_.SelectOrNull<MedicationRequest, object>(s_, t_);
			var x_ = r_.CountOrNull<object>(v_);
			var y_ = x_;
			var z_ = (int?)2;
			var aa_ = z_;
			var ac_ = r_.GreaterOrEqual(y_, aa_);

			return ac_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);
		var f_ = (Encounter InpatientEncounter) =>
		{
			var ak_ = this.Schedule_II_and_III_Opioid_Medications();
			var al_ = context.DataRetriever;
			var am_ = al_.RetrieveByValueSet<MedicationRequest>(ak_, null);
			var an_ = (MedicationRequest OpioidsDischarge) =>
			{
				var at_ = OpioidsDischarge.AuthoredOnElement;
				var au_ = FHIRHelpers_4_0_001.ToDateTime(at_);
				var av_ = InpatientEncounter.Period;
				var aw_ = FHIRHelpers_4_0_001.ToInterval(av_);
				var ax_ = context.Operators;
				var ay_ = ax_.ElementInInterval<CqlDateTime>(au_, aw_, null);

				return ay_;
			};
			var ao_ = context.Operators;
			var ap_ = ao_.WhereOrNull<MedicationRequest>(am_, an_);
			var aq_ = (MedicationRequest OpioidsDischarge) => InpatientEncounter;
			var as_ = ao_.SelectOrNull<MedicationRequest, Encounter>(ap_, aq_);

			return as_;
		};
		var h_ = c_.SelectManyOrNull<Encounter, Encounter>(a_, f_);
		var i_ = (Encounter InpatientEncounter) =>
		{
			var az_ = this.Schedule_IV_Benzodiazepines();
			var ba_ = context.DataRetriever;
			var bb_ = ba_.RetrieveByValueSet<MedicationRequest>(az_, null);
			var bc_ = (MedicationRequest BenzodiazepinesDischarge) =>
			{
				var bi_ = BenzodiazepinesDischarge.AuthoredOnElement;
				var bj_ = FHIRHelpers_4_0_001.ToDateTime(bi_);
				var bk_ = InpatientEncounter.Period;
				var bl_ = FHIRHelpers_4_0_001.ToInterval(bk_);
				var bm_ = context.Operators;
				var bn_ = bm_.ElementInInterval<CqlDateTime>(bj_, bl_, null);

				return bn_;
			};
			var bd_ = context.Operators;
			var be_ = bd_.WhereOrNull<MedicationRequest>(bb_, bc_);
			var bf_ = (MedicationRequest BenzodiazepinesDischarge) => InpatientEncounter;
			var bh_ = bd_.SelectOrNull<MedicationRequest, Encounter>(be_, bf_);

			return bh_;
		};
		var k_ = c_.SelectManyOrNull<Encounter, Encounter>(h_, i_);
		var m_ = c_.ListUnion<Encounter>(d_, k_);

		return m_;
	}

    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    private IEnumerable<Encounter> Denominator_Exclusion_Value()
	{
		var a_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		var b_ = (Encounter InpatientEncounter) =>
		{
			var h_ = this.All_Primary_and_Secondary_Cancer();
			var i_ = context.DataRetriever;
			var j_ = i_.RetrieveByValueSet<Condition>(h_, null);
			var k_ = (Condition Cancer) =>
			{
				var ar_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Cancer);
				var as_ = InpatientEncounter.Period;
				var at_ = FHIRHelpers_4_0_001.ToInterval(as_);
				var au_ = context.Operators;
				var av_ = au_.Overlaps(ar_, at_, null);

				return av_;
			};
			var l_ = context.Operators;
			var m_ = l_.WhereOrNull<Condition>(j_, k_);
			var o_ = l_.ExistsInList<Condition>(m_);
			var p_ = this.Palliative_or_Hospice_Care();
			var r_ = i_.RetrieveByValueSet<ServiceRequest>(p_, null);
			var s_ = (ServiceRequest PalliativeOrHospiceCareOrder) =>
			{
				var aw_ = PalliativeOrHospiceCareOrder.AuthoredOnElement;
				var ax_ = FHIRHelpers_4_0_001.ToDateTime(aw_);
				var ay_ = InpatientEncounter.Period;
				var az_ = FHIRHelpers_4_0_001.ToInterval(ay_);
				var ba_ = context.Operators;
				var bb_ = ba_.ElementInInterval<CqlDateTime>(ax_, az_, null);
				var bc_ = PalliativeOrHospiceCareOrder.IntentElement;
				var bd_ = new CallStackEntry("ToString", null, null);
				var be_ = context.Deeper(bd_);
				var bf_ = be_.Operators;
				var bg_ = bf_.TypeConverter;
				var bh_ = bg_.Convert<string>(bc_);
				var bj_ = ba_.Equal(bh_, "order");
				var bl_ = ba_.And(bb_, bj_);

				return bl_;
			};
			var u_ = l_.WhereOrNull<ServiceRequest>(r_, s_);
			var w_ = l_.ExistsInList<ServiceRequest>(u_);
			var y_ = l_.Or(o_, w_);
			var ab_ = i_.RetrieveByValueSet<Procedure>(p_, null);
			var ac_ = (Procedure PalliativeOrHospiceCarePerformed) =>
			{
				var bm_ = PalliativeOrHospiceCarePerformed.Performed;
				var bn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bm_);
				var bo_ = InpatientEncounter.Period;
				var bp_ = FHIRHelpers_4_0_001.ToInterval(bo_);
				var bq_ = context.Operators;
				var br_ = bq_.Overlaps(bn_, bp_, null);

				return br_;
			};
			var ae_ = l_.WhereOrNull<Procedure>(ab_, ac_);
			var ag_ = l_.ExistsInList<Procedure>(ae_);
			var ai_ = l_.Or(y_, ag_);
			var aj_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
			var ak_ = (Encounter InpatientEncounter) =>
			{
				var bs_ = InpatientEncounter.Hospitalization;
				var bt_ = bs_.DischargeDisposition;
				var bu_ = FHIRHelpers_4_0_001.ToConcept(bt_);
				var bv_ = this.Discharge_To_Acute_Care_Facility();
				var bw_ = context.Operators;
				var bx_ = bw_.ConceptInValueSet(bu_, bv_);
				var bz_ = bs_.DischargeDisposition;
				var ca_ = FHIRHelpers_4_0_001.ToConcept(bz_);
				var cb_ = this.Hospice_Care_Referral_or_Admission();
				var cd_ = bw_.ConceptInValueSet(ca_, cb_);
				var cf_ = bw_.Or(bx_, cd_);
				var ch_ = bs_.DischargeDisposition;
				var ci_ = FHIRHelpers_4_0_001.ToConcept(ch_);
				var cj_ = this.Patient_Expired();
				var cl_ = bw_.ConceptInValueSet(ci_, cj_);
				var cn_ = bw_.Or(cf_, cl_);

				return cn_;
			};
			var am_ = l_.WhereOrNull<Encounter>(aj_, ak_);
			var ao_ = l_.ExistsInList<Encounter>(am_);
			var aq_ = l_.Or(ai_, ao_);

			return aq_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);
		var e_ = (Encounter InpatientEncounter) => InpatientEncounter;
		var g_ = c_.SelectOrNull<Encounter, Encounter>(d_, e_);

		return g_;
	}

    [CqlDeclaration("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion() => __Denominator_Exclusion.Value;

}