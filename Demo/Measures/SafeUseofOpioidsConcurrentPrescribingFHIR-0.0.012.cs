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

    private CqlInterval<CqlDateTime> Measurement_Period_Value() =>
		(CqlInterval<CqlDateTime>)context.ResolveParameter("SafeUseofOpioidsConcurrentPrescribingFHIR-0.0.012", "Measurement Period", null);

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
		var o_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Inpatient_Encounter();
		var p_ = (Encounter EncounterInpatient) =>
		{
			var a_ = (this.Patient()?.BirthDateElement?.Value as object);
			var b_ = context?.Operators?.TypeConverter.Convert<CqlDate>(a_);
			var c_ = EncounterInpatient?.Period;
			var d_ = FHIRHelpers_4_0_001.ToInterval(c_);
			var e_ = context?.Operators.Start(d_);
			var f_ = context?.Operators.DateFrom(e_);
			var g_ = context?.Operators.CalculateAgeAt(b_, f_, "year");
			var h_ = (g_ as object);
			var i_ = ((int?)18 as object);
			var j_ = context?.Operators.GreaterOrEqual(h_, i_);
			var k_ = (EncounterInpatient?.StatusElement as object);
			var l_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(k_);
			var m_ = (l_ as object);
			var n_ = context?.Operators.Equal(m_, ("finished" as object));

			return context?.Operators.And(j_, n_);
		};

		return context?.Operators.WhereOrNull<Encounter>(o_, p_);
	}

    [CqlDeclaration("Inpatient Encounter with Age Greater than or Equal to 18")]
    public IEnumerable<Encounter> Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18() => __Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18.Value;

    private IEnumerable<Encounter> Initial_Population_Value()
	{
		var al_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		var am_ = (Encounter InpatientEncounter) =>
		{
			var v_ = this.Schedule_II_and_III_Opioid_Medications();
			var w_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(v_, null);
			var x_ = this.Schedule_II_and_III_Opioid_Medications();
			var y_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(x_, null);
			var z_ = context?.Operators.ListUnion<MedicationRequest>(w_, y_);
			var aa_ = this.Schedule_IV_Benzodiazepines();
			var ab_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(aa_, null);
			var ac_ = this.Schedule_IV_Benzodiazepines();
			var ad_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(ac_, null);
			var ae_ = context?.Operators.ListUnion<MedicationRequest>(ab_, ad_);
			var af_ = (MedicationRequest Medications) =>
			{
				var e_ = (Medications?.Category as IEnumerable<CodeableConcept>);
				var f_ = (CodeableConcept C) =>
				{
					var a_ = (FHIRHelpers_4_0_001.ToConcept(C) as object);
					var b_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Discharge();
					var c_ = context?.Operators.ConvertCodeToConcept(b_);
					var d_ = (c_ as object);

					return context?.Operators.Equivalent(a_, d_);
				};
				var g_ = context?.Operators.WhereOrNull<CodeableConcept>(e_, f_);

				return context?.Operators.ExistsInList<CodeableConcept>(g_);
			};
			var ag_ = context?.Operators.WhereOrNull<MedicationRequest>(ae_, af_);
			var ah_ = context?.Operators.ListUnion<MedicationRequest>(z_, ag_);
			var ai_ = (MedicationRequest OpioidOrBenzodiazepineDischargeMedication) =>
			{
				var h_ = OpioidOrBenzodiazepineDischargeMedication?.AuthoredOnElement;
				var i_ = FHIRHelpers_4_0_001.ToDateTime(h_);
				var j_ = InpatientEncounter?.Period;
				var k_ = FHIRHelpers_4_0_001.ToInterval(j_);
				var l_ = context?.Operators.ElementInInterval<CqlDateTime>(i_, k_, null);
				var m_ = (OpioidOrBenzodiazepineDischargeMedication?.StatusElement as object);
				var n_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(m_);
				var o_ = (n_ as object);
				var p_ = context?.Operators.Equal(o_, ("active" as object));
				var q_ = context?.Operators.And(l_, p_);
				var r_ = (OpioidOrBenzodiazepineDischargeMedication?.IntentElement as object);
				var s_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(r_);
				var t_ = (s_ as object);
				var u_ = context?.Operators.Equal(t_, ("plan" as object));

				return context?.Operators.And(q_, u_);
			};
			var aj_ = context?.Operators.WhereOrNull<MedicationRequest>(ah_, ai_);
			var ak_ = (MedicationRequest OpioidOrBenzodiazepineDischargeMedication) => InpatientEncounter;

			return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(aj_, ak_);
		};

		return context?.Operators.SelectManyOrNull<Encounter, Encounter>(al_, am_);
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
		var af_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		var ag_ = (Encounter InpatientEncounter) =>
		{
			var e_ = this.Schedule_II_and_III_Opioid_Medications();
			var f_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(e_, null);
			var g_ = (MedicationRequest Opioids) =>
			{
				var a_ = Opioids?.AuthoredOnElement;
				var b_ = FHIRHelpers_4_0_001.ToDateTime(a_);
				var c_ = InpatientEncounter?.Period;
				var d_ = FHIRHelpers_4_0_001.ToInterval(c_);

				return context?.Operators.ElementInInterval<CqlDateTime>(b_, d_, null);
			};
			var h_ = context?.Operators.WhereOrNull<MedicationRequest>(f_, g_);
			var i_ = (MedicationRequest Opioids) => (Opioids?.Medication as object);
			var j_ = context?.Operators.SelectOrNull<MedicationRequest, object>(h_, i_);
			var k_ = context?.Operators.CountOrNull<object>(j_);
			var l_ = (k_ as object);
			var m_ = ((int?)2 as object);

			return context?.Operators.GreaterOrEqual(l_, m_);
		};
		var ah_ = context?.Operators.WhereOrNull<Encounter>(af_, ag_);
		var ai_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		var aj_ = (Encounter InpatientEncounter) =>
		{
			var r_ = this.Schedule_II_and_III_Opioid_Medications();
			var s_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(r_, null);
			var t_ = (MedicationRequest OpioidsDischarge) =>
			{
				var n_ = OpioidsDischarge?.AuthoredOnElement;
				var o_ = FHIRHelpers_4_0_001.ToDateTime(n_);
				var p_ = InpatientEncounter?.Period;
				var q_ = FHIRHelpers_4_0_001.ToInterval(p_);

				return context?.Operators.ElementInInterval<CqlDateTime>(o_, q_, null);
			};
			var u_ = context?.Operators.WhereOrNull<MedicationRequest>(s_, t_);
			var v_ = (MedicationRequest OpioidsDischarge) => InpatientEncounter;

			return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(u_, v_);
		};
		var ak_ = context?.Operators.SelectManyOrNull<Encounter, Encounter>(ai_, aj_);
		var al_ = (Encounter InpatientEncounter) =>
		{
			var aa_ = this.Schedule_IV_Benzodiazepines();
			var ab_ = context?.DataRetriever.RetrieveByValueSet<MedicationRequest>(aa_, null);
			var ac_ = (MedicationRequest BenzodiazepinesDischarge) =>
			{
				var w_ = BenzodiazepinesDischarge?.AuthoredOnElement;
				var x_ = FHIRHelpers_4_0_001.ToDateTime(w_);
				var y_ = InpatientEncounter?.Period;
				var z_ = FHIRHelpers_4_0_001.ToInterval(y_);

				return context?.Operators.ElementInInterval<CqlDateTime>(x_, z_, null);
			};
			var ad_ = context?.Operators.WhereOrNull<MedicationRequest>(ab_, ac_);
			var ae_ = (MedicationRequest BenzodiazepinesDischarge) => InpatientEncounter;

			return context?.Operators.SelectOrNull<MedicationRequest, Encounter>(ad_, ae_);
		};
		var am_ = context?.Operators.SelectManyOrNull<Encounter, Encounter>(ak_, al_);

		return context?.Operators.ListUnion<Encounter>(ah_, am_);
	}

    [CqlDeclaration("Numerator")]
    public IEnumerable<Encounter> Numerator() => __Numerator.Value;

    private IEnumerable<Encounter> Denominator_Exclusion_Value()
	{
		var ay_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
		var az_ = (Encounter InpatientEncounter) =>
		{
			var ad_ = this.All_Primary_and_Secondary_Cancer();
			var ae_ = context?.DataRetriever.RetrieveByValueSet<Condition>(ad_, null);
			var af_ = (Condition Cancer) =>
			{
				var a_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Prevalence_Period(Cancer);
				var b_ = InpatientEncounter?.Period;
				var c_ = FHIRHelpers_4_0_001.ToInterval(b_);

				return context?.Operators.Overlaps(a_, c_, null);
			};
			var ag_ = context?.Operators.WhereOrNull<Condition>(ae_, af_);
			var ah_ = context?.Operators.ExistsInList<Condition>(ag_);
			var ai_ = this.Palliative_or_Hospice_Care();
			var aj_ = context?.DataRetriever.RetrieveByValueSet<ServiceRequest>(ai_, null);
			var ak_ = (ServiceRequest PalliativeOrHospiceCareOrder) =>
			{
				var d_ = PalliativeOrHospiceCareOrder?.AuthoredOnElement;
				var e_ = FHIRHelpers_4_0_001.ToDateTime(d_);
				var f_ = InpatientEncounter?.Period;
				var g_ = FHIRHelpers_4_0_001.ToInterval(f_);
				var h_ = context?.Operators.ElementInInterval<CqlDateTime>(e_, g_, null);
				var i_ = (PalliativeOrHospiceCareOrder?.IntentElement as object);
				var j_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(i_);
				var k_ = (j_ as object);
				var l_ = context?.Operators.Equal(k_, ("order" as object));

				return context?.Operators.And(h_, l_);
			};
			var al_ = context?.Operators.WhereOrNull<ServiceRequest>(aj_, ak_);
			var am_ = context?.Operators.ExistsInList<ServiceRequest>(al_);
			var an_ = context?.Operators.Or(ah_, am_);
			var ao_ = this.Palliative_or_Hospice_Care();
			var ap_ = context?.DataRetriever.RetrieveByValueSet<Procedure>(ao_, null);
			var aq_ = (Procedure PalliativeOrHospiceCarePerformed) =>
			{
				var m_ = (PalliativeOrHospiceCarePerformed?.Performed as object);
				var n_ = MATGlobalCommonFunctionsFHIR4_6_1_000.Normalize_Interval(m_);
				var o_ = InpatientEncounter?.Period;
				var p_ = FHIRHelpers_4_0_001.ToInterval(o_);

				return context?.Operators.Overlaps(n_, p_, null);
			};
			var ar_ = context?.Operators.WhereOrNull<Procedure>(ap_, aq_);
			var as_ = context?.Operators.ExistsInList<Procedure>(ar_);
			var at_ = context?.Operators.Or(an_, as_);
			var au_ = this.Inpatient_Encounter_with_Age_Greater_than_or_Equal_to_18();
			var av_ = (Encounter InpatientEncounter) =>
			{
				var q_ = InpatientEncounter?.Hospitalization?.DischargeDisposition;
				var r_ = FHIRHelpers_4_0_001.ToConcept(q_);
				var s_ = this.Discharge_To_Acute_Care_Facility();
				var t_ = context?.Operators.ConceptInValueSet(r_, s_);
				var u_ = InpatientEncounter?.Hospitalization?.DischargeDisposition;
				var v_ = FHIRHelpers_4_0_001.ToConcept(u_);
				var w_ = this.Hospice_Care_Referral_or_Admission();
				var x_ = context?.Operators.ConceptInValueSet(v_, w_);
				var y_ = context?.Operators.Or(t_, x_);
				var z_ = InpatientEncounter?.Hospitalization?.DischargeDisposition;
				var aa_ = FHIRHelpers_4_0_001.ToConcept(z_);
				var ab_ = this.Patient_Expired();
				var ac_ = context?.Operators.ConceptInValueSet(aa_, ab_);

				return context?.Operators.Or(y_, ac_);
			};
			var aw_ = context?.Operators.WhereOrNull<Encounter>(au_, av_);
			var ax_ = context?.Operators.ExistsInList<Encounter>(aw_);

			return context?.Operators.Or(at_, ax_);
		};
		var ba_ = context?.Operators.WhereOrNull<Encounter>(ay_, az_);
		var bb_ = (Encounter InpatientEncounter) => InpatientEncounter;

		return context?.Operators.SelectOrNull<Encounter, Encounter>(ba_, bb_);
	}

    [CqlDeclaration("Denominator Exclusion")]
    public IEnumerable<Encounter> Denominator_Exclusion() => __Denominator_Exclusion.Value;

}