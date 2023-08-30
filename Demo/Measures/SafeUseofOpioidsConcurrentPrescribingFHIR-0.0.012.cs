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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18_Value()
	{
		var a_ = context.Operators;
		var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Inpatient_Encounter();
		bool? c_(Encounter EncounterInpatient)
		{
			var e_ = context.Operators;
			var i_ = e_.TypeConverter;
			var j_ = this.Patient();
			var k_ = j_?.BirthDateElement;
			var l_ = k_?.Value;
			var m_ = i_.Convert<CqlDate>(l_);
			var p_ = EncounterInpatient?.Period;
			var q_ = FHIRHelpers_4_0_001.ToInterval(p_);
			var r_ = e_.Start(q_);
			var s_ = e_.DateFrom(r_);
			var t_ = e_.CalculateAgeAt(m_, s_, "year");
			var u_ = e_.GreaterOrEqual(t_, (int?)18);
			var w_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var x_ = w_.Operators;
			var y_ = x_.TypeConverter;
			var z_ = EncounterInpatient?.StatusElement;
			var aa_ = y_.Convert<string>(z_);
			var ab_ = e_.Equal(aa_, "finished");
			var ac_ = e_.And(u_, ab_);

			return ac_;
		};
		var d_ = a_.WhereOrNull<Encounter>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Inpatient Encounter with Age Greater than or Equal to 18")]
	public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18() => 
		__Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18.Value;

	private IEnumerable<Encounter> Initial_Population_Value()
	{
		var a_ = context.Operators;
		var b_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		IEnumerable<Encounter> c_(Encounter InpatientEncounter)
		{
			var e_ = context.Operators;
			var i_ = context.DataRetriever;
			var j_ = this.Schedule_II_and_III_Opioid_Medications();
			var k_ = i_.RetrieveByValueSet<MedicationRequest>(j_, null);
			var n_ = i_.RetrieveByValueSet<MedicationRequest>(j_, null);
			var o_ = e_.ListUnion<MedicationRequest>(k_, n_);
			var s_ = this.Schedule_IV_Benzodiazepines();
			var t_ = i_.RetrieveByValueSet<MedicationRequest>(s_, null);
			var w_ = i_.RetrieveByValueSet<MedicationRequest>(s_, null);
			var x_ = e_.ListUnion<MedicationRequest>(t_, w_);
			bool? y_(MedicationRequest Medications)
			{
				var af_ = context.Operators;
				var ah_ = Medications?.Category;
				bool? ai_(CodeableConcept C)
				{
					var al_ = context.Operators;
					var am_ = FHIRHelpers_4_0_001.ToConcept(C);
					var ao_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
					var ap_ = al_.ConvertCodeToConcept(ao_);
					var aq_ = al_.Equivalent(am_, ap_);

					return aq_;
				};
				var aj_ = af_.WhereOrNull<CodeableConcept>((ah_ as IEnumerable<CodeableConcept>), ai_);
				var ak_ = af_.ExistsInList<CodeableConcept>(aj_);

				return ak_;
			};
			var z_ = e_.WhereOrNull<MedicationRequest>(x_, y_);
			var aa_ = e_.ListUnion<MedicationRequest>(o_, z_);
			bool? ab_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication)
			{
				var ar_ = context.Operators;
				var au_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
				var av_ = FHIRHelpers_4_0_001.ToDateTime(au_);
				var aw_ = InpatientEncounter?.Period;
				var ax_ = FHIRHelpers_4_0_001.ToInterval(aw_);
				var ay_ = ar_.ElementInInterval<CqlDateTime>(av_, ax_, null);
				var ba_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var bb_ = ba_.Operators;
				var bc_ = bb_.TypeConverter;
				var bd_ = OpioidOrBenzodiazepineDischargeMedication?.StatusElement;
				var be_ = bc_.Convert<string>(bd_);
				var bf_ = ar_.Equal(be_, "active");
				var bg_ = ar_.And(ay_, bf_);
				var bj_ = ba_.Operators;
				var bk_ = bj_.TypeConverter;
				var bl_ = OpioidOrBenzodiazepineDischargeMedication?.IntentElement;
				var bm_ = bk_.Convert<string>(bl_);
				var bn_ = ar_.Equal(bm_, "plan");
				var bo_ = ar_.And(bg_, bn_);

				return bo_;
			};
			var ac_ = e_.WhereOrNull<MedicationRequest>(aa_, ab_);
			Encounter ad_(MedicationRequest OpioidOrBenzodiazepineDischargeMedication) => 
				InpatientEncounter;
			var ae_ = e_.SelectOrNull<MedicationRequest, Encounter>(ac_, ad_);

			return ae_;
		};
		var d_ = a_.SelectManyOrNull<Encounter, Encounter>(b_, c_);

		return d_;
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

	private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElementsFHIR4_2_0_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
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
		var a_ = context.Operators;
		var c_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		bool? d_(Encounter InpatientEncounter)
		{
			var n_ = context.Operators;
			var r_ = context.DataRetriever;
			var s_ = this.Schedule_II_and_III_Opioid_Medications();
			var t_ = r_.RetrieveByValueSet<MedicationRequest>(s_, null);
			bool? u_(MedicationRequest Opioids)
			{
				var aa_ = context.Operators;
				var ab_ = Opioids?.AuthoredOnElement;
				var ac_ = FHIRHelpers_4_0_001.ToDateTime(ab_);
				var ad_ = InpatientEncounter?.Period;
				var ae_ = FHIRHelpers_4_0_001.ToInterval(ad_);
				var af_ = aa_.ElementInInterval<CqlDateTime>(ac_, ae_, null);

				return af_;
			};
			var v_ = n_.WhereOrNull<MedicationRequest>(t_, u_);
			object w_(MedicationRequest Opioids)
			{
				var ag_ = Opioids?.Medication;

				return ag_;
			};
			var x_ = n_.SelectOrNull<MedicationRequest, object>(v_, w_);
			var y_ = n_.CountOrNull<object>(x_);
			var z_ = n_.GreaterOrEqual(y_, (int?)2);

			return z_;
		};
		var e_ = a_.WhereOrNull<Encounter>(c_, d_);
		IEnumerable<Encounter> i_(Encounter InpatientEncounter)
		{
			var ah_ = context.Operators;
			var aj_ = context.DataRetriever;
			var ak_ = this.Schedule_II_and_III_Opioid_Medications();
			var al_ = aj_.RetrieveByValueSet<MedicationRequest>(ak_, null);
			bool? am_(MedicationRequest OpioidsDischarge)
			{
				var aq_ = context.Operators;
				var ar_ = OpioidsDischarge?.AuthoredOnElement;
				var as_ = FHIRHelpers_4_0_001.ToDateTime(ar_);
				var at_ = InpatientEncounter?.Period;
				var au_ = FHIRHelpers_4_0_001.ToInterval(at_);
				var av_ = aq_.ElementInInterval<CqlDateTime>(as_, au_, null);

				return av_;
			};
			var an_ = ah_.WhereOrNull<MedicationRequest>(al_, am_);
			Encounter ao_(MedicationRequest OpioidsDischarge) => 
				InpatientEncounter;
			var ap_ = ah_.SelectOrNull<MedicationRequest, Encounter>(an_, ao_);

			return ap_;
		};
		var j_ = a_.SelectManyOrNull<Encounter, Encounter>(c_, i_);
		IEnumerable<Encounter> k_(Encounter InpatientEncounter)
		{
			var aw_ = context.Operators;
			var ay_ = context.DataRetriever;
			var az_ = this.Schedule_IV_Benzodiazepines();
			var ba_ = ay_.RetrieveByValueSet<MedicationRequest>(az_, null);
			bool? bb_(MedicationRequest BenzodiazepinesDischarge)
			{
				var bf_ = context.Operators;
				var bg_ = BenzodiazepinesDischarge?.AuthoredOnElement;
				var bh_ = FHIRHelpers_4_0_001.ToDateTime(bg_);
				var bi_ = InpatientEncounter?.Period;
				var bj_ = FHIRHelpers_4_0_001.ToInterval(bi_);
				var bk_ = bf_.ElementInInterval<CqlDateTime>(bh_, bj_, null);

				return bk_;
			};
			var bc_ = aw_.WhereOrNull<MedicationRequest>(ba_, bb_);
			Encounter bd_(MedicationRequest BenzodiazepinesDischarge) => 
				InpatientEncounter;
			var be_ = aw_.SelectOrNull<MedicationRequest, Encounter>(bc_, bd_);

			return be_;
		};
		var l_ = a_.SelectManyOrNull<Encounter, Encounter>(j_, k_);
		var m_ = a_.ListUnion<Encounter>(e_, l_);

		return m_;
	}

    [CqlDeclaration("Numerator")]
	public IEnumerable<Encounter> Numerator() => 
		__Numerator.Value;

	private IEnumerable<Encounter> Denominator_Exclusion_Value()
	{
		var a_ = context.Operators;
		var c_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		bool? d_(Encounter InpatientEncounter)
		{
			var h_ = context.Operators;
			var m_ = context.DataRetriever;
			var n_ = this.All_Primary_and_Secondary_Cancer();
			var o_ = m_.RetrieveByValueSet<Condition>(n_, null);
			bool? p_(Condition Cancer)
			{
				var ar_ = context.Operators;
				var as_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Cancer);
				var at_ = InpatientEncounter?.Period;
				var au_ = FHIRHelpers_4_0_001.ToInterval(at_);
				var av_ = ar_.Overlaps(as_, au_, null);

				return av_;
			};
			var q_ = h_.WhereOrNull<Condition>(o_, p_);
			var r_ = h_.ExistsInList<Condition>(q_);
			var v_ = this.Palliative_or_Hospice_Care();
			var w_ = m_.RetrieveByValueSet<ServiceRequest>(v_, null);
			bool? x_(ServiceRequest PalliativeOrHospiceCareOrder)
			{
				var aw_ = context.Operators;
				var ay_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
				var az_ = FHIRHelpers_4_0_001.ToDateTime(ay_);
				var ba_ = InpatientEncounter?.Period;
				var bb_ = FHIRHelpers_4_0_001.ToInterval(ba_);
				var bc_ = aw_.ElementInInterval<CqlDateTime>(az_, bb_, null);
				var be_ = context.Deeper(new CallStackEntry("ToString", null, null));
				var bf_ = be_.Operators;
				var bg_ = bf_.TypeConverter;
				var bh_ = PalliativeOrHospiceCareOrder?.IntentElement;
				var bi_ = bg_.Convert<string>(bh_);
				var bj_ = aw_.Equal(bi_, "order");
				var bk_ = aw_.And(bc_, bj_);

				return bk_;
			};
			var y_ = h_.WhereOrNull<ServiceRequest>(w_, x_);
			var z_ = h_.ExistsInList<ServiceRequest>(y_);
			var aa_ = h_.Or(r_, z_);
			var af_ = m_.RetrieveByValueSet<Procedure>(v_, null);
			bool? ag_(Procedure PalliativeOrHospiceCarePerformed)
			{
				var bl_ = context.Operators;
				var bm_ = PalliativeOrHospiceCarePerformed?.Performed;
				var bn_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(bm_);
				var bo_ = InpatientEncounter?.Period;
				var bp_ = FHIRHelpers_4_0_001.ToInterval(bo_);
				var bq_ = bl_.Overlaps(bn_, bp_, null);

				return bq_;
			};
			var ah_ = h_.WhereOrNull<Procedure>(af_, ag_);
			var ai_ = h_.ExistsInList<Procedure>(ah_);
			var aj_ = h_.Or(aa_, ai_);
			var am_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
			bool? an_(Encounter InpatientEncounter)
			{
				var br_ = context.Operators;
				var bu_ = InpatientEncounter?.Hospitalization;
				var bv_ = bu_?.DischargeDisposition;
				var bw_ = FHIRHelpers_4_0_001.ToConcept(bv_);
				var bx_ = this.Discharge_To_Acute_Care_Facility();
				var by_ = br_.ConceptInValueSet(bw_, bx_);
				var cb_ = bu_?.DischargeDisposition;
				var cc_ = FHIRHelpers_4_0_001.ToConcept(cb_);
				var cd_ = this.Hospice_Care_Referral_or_Admission();
				var ce_ = br_.ConceptInValueSet(cc_, cd_);
				var cf_ = br_.Or(by_, ce_);
				var ci_ = bu_?.DischargeDisposition;
				var cj_ = FHIRHelpers_4_0_001.ToConcept(ci_);
				var ck_ = this.Patient_Expired();
				var cl_ = br_.ConceptInValueSet(cj_, ck_);
				var cm_ = br_.Or(cf_, cl_);

				return cm_;
			};
			var ao_ = h_.WhereOrNull<Encounter>(am_, an_);
			var ap_ = h_.ExistsInList<Encounter>(ao_);
			var aq_ = h_.Or(aj_, ap_);

			return aq_;
		};
		var e_ = a_.WhereOrNull<Encounter>(c_, d_);
		Encounter f_(Encounter InpatientEncounter) => 
			InpatientEncounter;
		var g_ = a_.SelectOrNull<Encounter, Encounter>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public IEnumerable<Encounter> Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

}