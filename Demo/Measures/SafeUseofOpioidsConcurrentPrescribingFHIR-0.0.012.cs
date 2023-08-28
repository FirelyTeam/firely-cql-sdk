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

		return (CqlInterval<CqlDateTime>)a_;
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
		bool? b_(Encounter EncounterInpatient)
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
			var t_ = h_.GreaterOrEqual(r_, (int?)18);
			var u_ = EncounterInpatient.StatusElement;
			var v_ = new CallStackEntry("ToString", null, null);
			var w_ = context.Deeper(v_);
			var x_ = w_.Operators;
			var y_ = x_.TypeConverter;
			var z_ = y_.Convert<string>(u_);
			var ab_ = h_.Equal(z_, "finished");
			var ad_ = h_.And(t_, ab_);

			return ad_;
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
		IEnumerable<Encounter> b_(Encounter InpatientEncounter)
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
			bool? u_(MedicationRequest Medications)
			{
				var af_ = Medications.Category;
				bool? ag_(CodeableConcept C)
				{
					var al_ = FHIRHelpers_4_0_001.ToConcept(C);
					var am_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
					var an_ = context.Operators;
					var ao_ = an_.ConvertCodeToConcept(am_);
					var aq_ = an_.Equivalent(al_, ao_);

					return aq_;
				};
				var ah_ = context.Operators;
				var ai_ = ah_.WhereOrNull<CodeableConcept>((af_ as IEnumerable<CodeableConcept>), ag_);
				var ak_ = ah_.ExistsInList<CodeableConcept>(ai_);

				return ak_;
			};
			var w_ = k_.WhereOrNull<MedicationRequest>(t_, u_);
			var y_ = k_.ListUnion<MedicationRequest>(l_, w_);
			bool? z_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication)
			{
				var ar_ = OpioidOrBenzodiazepineDischargeMedication.AuthoredOnElement;
				var as_ = FHIRHelpers_4_0_001.ToDateTime(ar_);
				var at_ = InpatientEncounter.Period;
				var au_ = FHIRHelpers_4_0_001.ToInterval(at_);
				var av_ = context.Operators;
				var aw_ = av_.ElementInInterval<CqlDateTime>(as_, au_, null);
				var ax_ = OpioidOrBenzodiazepineDischargeMedication.StatusElement;
				var ay_ = new CallStackEntry("ToString", null, null);
				var az_ = context.Deeper(ay_);
				var ba_ = az_.Operators;
				var bb_ = ba_.TypeConverter;
				var bc_ = bb_.Convert<string>(ax_);
				var be_ = av_.Equal(bc_, "active");
				var bg_ = av_.And(aw_, be_);
				var bh_ = OpioidOrBenzodiazepineDischargeMedication.IntentElement;
				var bj_ = context.Deeper(ay_);
				var bk_ = bj_.Operators;
				var bl_ = bk_.TypeConverter;
				var bm_ = bl_.Convert<string>(bh_);
				var bo_ = av_.Equal(bm_, "plan");
				var bq_ = av_.And(bg_, bo_);

				return bq_;
			};
			var ab_ = k_.WhereOrNull<MedicationRequest>(y_, z_);
			Encounter ac_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) => InpatientEncounter;
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
		bool? b_(Encounter InpatientEncounter)
		{
			var n_ = this.Schedule_II_and_III_Opioid_Medications();
			var o_ = context.DataRetriever;
			var p_ = o_.RetrieveByValueSet<MedicationRequest>(n_, null);
			bool? q_(MedicationRequest Opioids)
			{
				var aa_ = Opioids.AuthoredOnElement;
				var ab_ = FHIRHelpers_4_0_001.ToDateTime(aa_);
				var ac_ = InpatientEncounter.Period;
				var ad_ = FHIRHelpers_4_0_001.ToInterval(ac_);
				var ae_ = context.Operators;
				var af_ = ae_.ElementInInterval<CqlDateTime>(ab_, ad_, null);

				return af_;
			};
			var r_ = context.Operators;
			var s_ = r_.WhereOrNull<MedicationRequest>(p_, q_);
			object t_(MedicationRequest Opioids)
			{
				var ag_ = Opioids.Medication;

				return ag_;
			};
			var v_ = r_.SelectOrNull<MedicationRequest, object>(s_, t_);
			var x_ = r_.CountOrNull<object>(v_);
			var z_ = r_.GreaterOrEqual(x_, (int?)2);

			return z_;
		};
		var c_ = context.Operators;
		var d_ = c_.WhereOrNull<Encounter>(a_, b_);
		IEnumerable<Encounter> f_(Encounter InpatientEncounter)
		{
			var ah_ = this.Schedule_II_and_III_Opioid_Medications();
			var ai_ = context.DataRetriever;
			var aj_ = ai_.RetrieveByValueSet<MedicationRequest>(ah_, null);
			bool? ak_(MedicationRequest OpioidsDischarge)
			{
				var aq_ = OpioidsDischarge.AuthoredOnElement;
				var ar_ = FHIRHelpers_4_0_001.ToDateTime(aq_);
				var as_ = InpatientEncounter.Period;
				var at_ = FHIRHelpers_4_0_001.ToInterval(as_);
				var au_ = context.Operators;
				var av_ = au_.ElementInInterval<CqlDateTime>(ar_, at_, null);

				return av_;
			};
			var al_ = context.Operators;
			var am_ = al_.WhereOrNull<MedicationRequest>(aj_, ak_);
			Encounter an_(MedicationRequest OpioidsDischarge) => InpatientEncounter;
			var ap_ = al_.SelectOrNull<MedicationRequest, Encounter>(am_, an_);

			return ap_;
		};
		var h_ = c_.SelectManyOrNull<Encounter, Encounter>(a_, f_);
		IEnumerable<Encounter> i_(Encounter InpatientEncounter)
		{
			var aw_ = this.Schedule_IV_Benzodiazepines();
			var ax_ = context.DataRetriever;
			var ay_ = ax_.RetrieveByValueSet<MedicationRequest>(aw_, null);
			bool? az_(MedicationRequest BenzodiazepinesDischarge)
			{
				var bf_ = BenzodiazepinesDischarge.AuthoredOnElement;
				var bg_ = FHIRHelpers_4_0_001.ToDateTime(bf_);
				var bh_ = InpatientEncounter.Period;
				var bi_ = FHIRHelpers_4_0_001.ToInterval(bh_);
				var bj_ = context.Operators;
				var bk_ = bj_.ElementInInterval<CqlDateTime>(bg_, bi_, null);

				return bk_;
			};
			var ba_ = context.Operators;
			var bb_ = ba_.WhereOrNull<MedicationRequest>(ay_, az_);
			Encounter bc_(MedicationRequest BenzodiazepinesDischarge) => InpatientEncounter;
			var be_ = ba_.SelectOrNull<MedicationRequest, Encounter>(bb_, bc_);

			return be_;
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
		bool? b_(Encounter InpatientEncounter)
		{
			var h_ = this.All_Primary_and_Secondary_Cancer();
			var i_ = context.DataRetriever;
			var j_ = i_.RetrieveByValueSet<Condition>(h_, null);
			bool? k_(Condition Cancer)
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
			bool? s_(ServiceRequest PalliativeOrHospiceCareOrder)
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
			bool? ac_(Procedure PalliativeOrHospiceCarePerformed)
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
			bool? ak_(Encounter InpatientEncounter)
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
		Encounter e_(Encounter InpatientEncounter) => InpatientEncounter;
		var g_ = c_.SelectOrNull<Encounter, Encounter>(d_, e_);

		return g_;
	}

    [CqlDeclaration("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion() => __Denominator_Exclusion.Value;

}